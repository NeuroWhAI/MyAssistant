using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Threading;

using Microsoft.Speech.Recognition;
using Microsoft.Speech.Synthesis;

namespace MyAssistant
{
    public partial class Form_CmdList : Form
    {
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        [DllImport("user32.dll")]
        static extern IntPtr GetDesktopWindow();

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public Form_CmdList(PictureBox mainCharBox, Form_Main mainForm)
        {
            InitializeComponent();


            m_mainCharBox = mainCharBox;
            m_mainForm = mainForm;


            InitRS();
            InitTTS();
        }


        public void Destroy()
        {
            if (m_speakThread != null)
            {
                lock (m_bThreadLock)
                {
                    m_bThreadEnd = true;
                }
                m_speakThread.Join();


                m_speakThread = null;
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 멤버 변수 (음성인식 및 작업) */

        SpeechSynthesizer m_TsKo = null, m_TsEn = null;
        SpeechRecognitionEngine m_SreKo = null, m_SreEn = null;

        List<IntPtr> m_WindowList = new List<IntPtr>();
        List<IntPtr> m_MiniWindowList = new List<IntPtr>();

        PictureBox m_mainCharBox = null;
        Form_Main m_mainForm = null;

        object m_bThreadLock = new object();
        object m_bThreadLock2 = new object();
        bool m_bThreadEnd = false;
        string m_strToSpeak = "";
        Thread m_speakThread = null;

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 멤버 변수 (명령 관리) */

        bool m_bOnRun = true;

        List<string> m_CmdList = new List<string>();
        List<CMD_TYPE> m_CmdTypeList = new List<CMD_TYPE>();
        List<object> m_CmdInfo = new List<object>();

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 초기화 / 정리 */

        private void Form_Main_Load(object sender, EventArgs e)
        {// 초기화
            try
            {
                using (StreamReader sr = new StreamReader(new FileStream("CmdList.txt", FileMode.Open)))
                {
                    this.ListView_Command.BeginUpdate();


                    while (!sr.EndOfStream)
                    {
                        int Index = m_CmdList.Count;

                        m_CmdList.Add(sr.ReadLine());
                        m_CmdTypeList.Add((CMD_TYPE)Enum.Parse(typeof(CMD_TYPE), sr.ReadLine()));
                        m_CmdInfo.Add(sr.ReadLine());


                        ListViewItem Item = new ListViewItem(m_CmdList[Index]);
                        Item.SubItems.Add(StringEnum.GetStringValue(m_CmdTypeList[Index]));
                        Item.SubItems.Add(m_CmdInfo[Index].ToString());


                        this.ListView_Command.Items.Add(Item);
                    }


                    this.ListView_Command.EndUpdate();


                    sr.Close();
                }
            }
            catch (FileNotFoundException NoFileEcp)
            {

            }


            m_speakThread = new Thread(new ThreadStart(ThreadFunc_Speak));
            m_speakThread.Start();
        }


        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {// 종료전 정리
            ShowAllWindow();


            UpdateCmdList(); // xml 저장


            SaveCmdList();


            e.Cancel = true;
            this.Hide();
        }


        private void SaveCmdList()
        {
            using (StreamWriter sw = new StreamWriter(new FileStream("CmdList.txt", FileMode.Create)))
            {
                for (int i = 0; i < m_CmdList.Count; i++)
                {
                    sw.WriteLine(m_CmdList[i]);
                    sw.WriteLine(m_CmdTypeList[i].ToString());
                    sw.WriteLine(m_CmdInfo[i].ToString());
                }


                sw.Close();
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////

        public void AddCmdList(string Cmd, CMD_TYPE Work, object Info)
        {// 명령어 목록에 추가
            // 중복검사
            for (int i = 0; i < m_CmdList.Count; i++)
            {
                if (m_CmdList[i] == Cmd)
                {
                    MessageBox.Show("중복된 명령어 입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            // 내부 목록에 추가
            m_CmdList.Add(Cmd);
            m_CmdTypeList.Add(Work);
            m_CmdInfo.Add(Info);


            // 보이는 목록에 추가
            this.ListView_Command.BeginUpdate();


            ListViewItem Item = new ListViewItem(Cmd);
            Item.SubItems.Add(StringEnum.GetStringValue(Work));
            Item.SubItems.Add(Info.ToString());


            this.ListView_Command.Items.Add(Item);


            this.ListView_Command.EndUpdate();


            // 명령어 목록 갱신 및 적용
            UpdateCmdList();


            // 명령어 목록 저장
            SaveCmdList();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 메인 버튼 */

        private void Button_RunStop_Click(object sender, EventArgs e)
        {// 음성인식 시작/중지
            if (m_bOnRun)
            {
                this.Button_RunStop.Text = "실행";
            }
            else
            {
                this.Button_RunStop.Text = "정지";
            }

            m_bOnRun = !m_bOnRun;
        }


        private void Button_AddCmd_Click(object sender, EventArgs e)
        {// 명령어 실행
            Form_AddCmd AddCmdForm = new Form_AddCmd();
            AddCmdForm.SetMainForm(this);
            AddCmdForm.ShowDialog();

            this.ListView_Command.Focus(); // 목록에 다시 포커스를 잡아줘야 선택이 보임
        }


        private void Button_Exit_Click(object sender, EventArgs e)
        {// 프로그램 종료
            this.Hide();
        }


        private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {// 명령어 제거
            var Item = this.ListView_Command.SelectedItems;

            if (Item != null && Item.Count > 0)
            {
                int Idx = this.ListView_Command.Items.IndexOf(Item[0]);
                this.ListView_Command.Items.RemoveAt(Idx);

                m_CmdList.RemoveAt(Idx);
                m_CmdTypeList.RemoveAt(Idx);
                m_CmdInfo.RemoveAt(Idx);


                UpdateCmdList();
                SaveCmdList();
            }
        }


        private void ToolStripMenuItem_EditCmd_Click(object sender, EventArgs e)
        {// 명령어 수정
            var Item = this.ListView_Command.SelectedItems;

            if (Item != null && Item.Count > 0)
            {
                string prevCmd = Item[0].SubItems[0].Text;

                Form_EditCmd formEditCmd = new Form_EditCmd(Item[0].SubItems[0]);
                formEditCmd.ShowDialog();


                if (prevCmd != Item[0].SubItems[0].Text)
                {
                    int Idx = this.ListView_Command.Items.IndexOf(Item[0]);

                    m_CmdList[Idx] = Item[0].SubItems[0].Text;


                    UpdateCmdList();
                    SaveCmdList();
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 음성인식 */

        private int InitRS()
        {
            try
            {
                // Grammer 파일이 없으면 샘플로 하나를 만듬
                if (File.Exists("CmdList_Ko.xml") == false)
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream("CmdList_Ko.xml", FileMode.Create)))
                    {
                        sw.Write("<grammar version=\"1.0\" sapi:alphabet=\"x-microsoft-ups\" xml:lang=\"ko-KR\" root=\"Command\"\n" + 
                            "tag-format=\"semantics-ms/1.0\" xmlns=\"http://www.w3.org/2001/06/grammar\"\n" + 
                            "xmlns:sapi=\"http://schemas.microsoft.com/Speech/2002/06/SRGSExtensions\">\n" + 
                            "<rule id=\"Command\" scope=\"public\">\n" + 
                            "<one-of>\n" + 
                            "<item>None</item>\n" + 
                            "</one-of>\n" + 
                            "</rule>" + 
                            "</grammar>");


                        sw.Close();
                    }
                }

                if (File.Exists("CmdList_En.xml") == false)
                {
                    using (StreamWriter sw = new StreamWriter(new FileStream("CmdList_En.xml", FileMode.Create)))
                    {
                        sw.Write("<grammar version=\"1.0\" sapi:alphabet=\"x-microsoft-ups\" xml:lang=\"en-US\" root=\"Command\"\n" +
                            "tag-format=\"semantics-ms/1.0\" xmlns=\"http://www.w3.org/2001/06/grammar\"\n" +
                            "xmlns:sapi=\"http://schemas.microsoft.com/Speech/2002/06/SRGSExtensions\">\n" +
                            "<rule id=\"Command\" scope=\"public\">\n" +
                            "<one-of>\n" +
                            "<item>None</item>\n" +
                            "</one-of>\n" +
                            "</rule>" +
                            "</grammar>");


                        sw.Close();
                    }
                }


                if (m_SreKo != null)
                {
                    m_SreKo.SpeechRecognized -= new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
                    m_SreKo.Dispose();
                }

                if (m_SreEn != null)
                {
                    m_SreEn.SpeechRecognized -= new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
                    m_SreEn.Dispose();
                }


                m_SreKo = new SpeechRecognitionEngine(new CultureInfo("ko-KR"));

                Grammar g = new Grammar("CmdList_Ko.xml");
                m_SreKo.LoadGrammar(g);

                m_SreKo.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
                m_SreKo.SetInputToDefaultAudioDevice();
                m_SreKo.RecognizeAsync(RecognizeMode.Multiple);


                m_SreEn = new SpeechRecognitionEngine(new CultureInfo("en-US"));

                g = new Grammar("CmdList_En.xml");
                m_SreEn.LoadGrammar(g);

                m_SreEn.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
                m_SreEn.SetInputToDefaultAudioDevice();
                m_SreEn.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            return 0;
        }


        private int InitTTS()
        {
            try
            {
                m_TsKo = new SpeechSynthesizer();
                m_TsKo.SelectVoice("Microsoft Server Speech Text to Speech Voice (ko-KR, Heami)");
                m_TsKo.SetOutputToDefaultAudioDevice();
                m_TsKo.Volume = 100;

                m_TsEn = new SpeechSynthesizer();
                m_TsEn.SelectVoice("Microsoft Server Speech Text to Speech Voice (en-US, Helen)");
                m_TsEn.SetOutputToDefaultAudioDevice();
                m_TsEn.Volume = 100;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            return 0;
        }


        // 프로세스 실행
        private static void RunProgram(string filename, string arg = "")
        {
            ProcessStartInfo psi;
            if (arg.Length != 0)
                psi = new ProcessStartInfo(filename, arg);
            else
                psi = new ProcessStartInfo(filename);
            Process.Start(psi);
        }


        // 프로세스 종료
        private static void CloseProcess(string filename)
        {
            Process[] myProcesses;
            // Returns array containing all instances of process.
            myProcesses = Process.GetProcessesByName(filename);
            foreach (Process myProcess in myProcesses)
            {
                myProcess.CloseMainWindow();
            }
        }


        // 숨긴 프로그램 다 보임
        private void ShowAllWindow()
        {
            foreach (IntPtr WinHead in m_WindowList)
            {
                if (WinHead.ToInt32() == m_mainForm.Handle.ToInt32())
                {
                    m_mainForm.ShowForm();
                }
                else if (WinHead != IntPtr.Zero)
                {
                    ShowWindow(WinHead, 3/*MAX*/);
                    SetWindowPos(WinHead.ToInt32(), 0, 0, 0, 0, 0, 64 | 32 | 2 | 1);
                }
            }

            m_WindowList.Clear();
        }


        // 말하기
        public void SpeakSentence(string cmdName, string Msg, bool bManualSay = true)
        {
            if (bManualSay  &&  this.CheckBox_ResponseVoice.Checked)
            {
                string customSndPath = "Voice/" + cmdName + ".wav";

                if (File.Exists(customSndPath))
                {// 커스텀 보이스가 있음
                    try
                    {
                        System.Media.SoundPlayer sndPlayer = new System.Media.SoundPlayer(customSndPath);

                        sndPlayer.Play();
                    }
                    catch (FileNotFoundException noFileEcp)
                    {
                        MessageBox.Show(noFileEcp.Message);
                    }
                }
                else
                {
                    lock (m_bThreadLock2)
                    {
                        m_strToSpeak = Msg;
                    }
                }
            }
        }


        // 말하기 스레드 함수
        private void ThreadFunc_Speak()
        {
            try
            {
                while (true)
                {
                    lock (m_bThreadLock)
                    {
                        if (m_bThreadEnd) break;
                    }


                    lock (m_bThreadLock2)
                    {
                        if (m_strToSpeak != "")
                        {
                            if (IsEnglish(m_strToSpeak))
                            {
                                m_TsEn.Speak(m_strToSpeak);
                            }
                            else
                            {
                                m_TsKo.Speak(m_strToSpeak);
                            }

                            m_strToSpeak = "";
                        }
                    }


                    Thread.Sleep(50);
                }
            }
            catch (ThreadInterruptedException InterruptEcp)
            {
                return;
            }
        }


        // 명령어 갱신
        private void UpdateCmdList()
        {
            List<string> cmdEn = new List<string>();
            List<string> cmdKo = new List<string>();

            for (int i = 0; i < m_CmdList.Count; i++)
            {
                if (!IsEnglish(m_CmdList[i])) continue;

                cmdEn.Add(m_CmdList[i]);
            }

            for (int i = 0; i < m_CmdList.Count; i++)
            {
                if (IsEnglish(m_CmdList[i])) continue;

                cmdKo.Add(m_CmdList[i]);
            }


            if (cmdKo.Count > 0)
            {
                using (StreamWriter sw = new StreamWriter(new FileStream("CmdList_Ko.xml", FileMode.Create)))
                {
                    sw.Write("<grammar version=\"1.0\" sapi:alphabet=\"x-microsoft-ups\" xml:lang=\"ko-KR\" root=\"Command\"\n" +
                        "tag-format=\"semantics-ms/1.0\" xmlns=\"http://www.w3.org/2001/06/grammar\"\n" +
                        "xmlns:sapi=\"http://schemas.microsoft.com/Speech/2002/06/SRGSExtensions\">\n" +
                        "<rule id=\"Command\" scope=\"public\">\n" +
                        "<one-of>\n");


                    for (int i = 0; i < cmdKo.Count; i++)
                    {
                        sw.Write("<item>");

                        sw.Write(cmdKo[i]);

                        sw.Write("</item>\n");
                    }


                    sw.Write("</one-of>\n" +
                        "</rule>" +
                        "</grammar>");


                    sw.Close();
                }
            }
            else
            {
                File.Delete("CmdList_Ko.xml");
            }

            if (cmdEn.Count > 0)
            {
                using (StreamWriter sw = new StreamWriter(new FileStream("CmdList_En.xml", FileMode.Create)))
                {
                    sw.Write("<grammar version=\"1.0\" sapi:alphabet=\"x-microsoft-ups\" xml:lang=\"en-US\" root=\"Command\"\n" +
                        "tag-format=\"semantics-ms/1.0\" xmlns=\"http://www.w3.org/2001/06/grammar\"\n" +
                        "xmlns:sapi=\"http://schemas.microsoft.com/Speech/2002/06/SRGSExtensions\">\n" +
                        "<rule id=\"Command\" scope=\"public\">\n" +
                        "<one-of>\n");


                    for (int i = 0; i < cmdEn.Count; i++)
                    {
                        sw.Write("<item>");

                        sw.Write(cmdEn[i]);

                        sw.Write("</item>\n");
                    }


                    sw.Write("</one-of>\n" +
                        "</rule>" +
                        "</grammar>");


                    sw.Close();
                }
            }
            else
            {
                File.Delete("CmdList_En.xml");
            }


            try
            {
                InitRS();
            }
            catch (Exception Ecp)
            {
                MessageBox.Show(Ecp.Message);
            }
        }


        // 영어? 한국어?
        bool IsEnglish(string str)
        {
            if (str.Length <= 0) return false;


            return (str[0] >= 'a' && str[0] <= 'z') || (str[0] >= 'A' && str[0] <= 'Z');
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // 인식된 명령 처리
        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence < 0.85f) return; // 정확도


            ProcessCmd(e.Result.Text);
        }


        public void ProcessCmd(string cmd, bool bSay = true)
        {
            // 목록에서 명령어 Highlight
            for (int i = 0; i < this.ListView_Command.Items.Count; i++)
            {
                if (this.ListView_Command.Items[i].SubItems[0].Text == cmd)
                {
                    this.ListView_Command.Items[i].Selected = true;
                    this.ListView_Command.Items[i].Focused = true;
                    this.ListView_Command.Items[i].EnsureVisible();

                    break;
                }
            }


            // 작업, 정보 알아옴
            int CmdIdx = m_CmdList.IndexOf(cmd);
            if (CmdIdx < 0) return;

            CMD_TYPE CmdType = m_CmdTypeList[CmdIdx];
            object CmdInfo = m_CmdInfo[CmdIdx];


            // 정지모드 중 실행 명령이 아닌것들은 무시함
            if (m_bOnRun == false)
            {
                if (CmdType != CMD_TYPE.Run_Assistant)
                    return;
            }


            // 팝업 띄우기 및 캐릭터 애니메이션
            if (bSay)
            {
                // 캐릭터 애니메이션
                if (ProgramCore.CharacterAction.CheckPictureExists(cmd))
                {
                    ProgramCore.CharacterAction.SetAction(cmd);
                }
                else
                {
                    ProgramCore.CharacterAction.SetAction("RunCmd");
                }

                // 팝업
                m_mainCharBox.Parent.BringToFront();
                m_mainCharBox.BringToFront();
                this.ToolTip_Notify.Show(StringEnum.GetStringValue(CmdType), m_mainCharBox, 0, -64);
                this.Timer_CloseTip.Enabled = true;
            }


            // 작업
            IntPtr hWnd;

            switch (CmdType)
            {
                case CMD_TYPE.Run_Assistant:
                    m_bOnRun = true;
                    this.Button_RunStop.Text = "정지";

                    SpeakSentence(cmd, "비서를 실행합니다.", bSay);

                    break;

                case CMD_TYPE.Stop_Assistant:
                    m_bOnRun = false;
                    this.Button_RunStop.Text = "실행";

                    SpeakSentence(cmd, "비서를 정지합니다.", bSay);

                    break;

                case CMD_TYPE.Run_Program:
                    string[] ProgramInfo = ((string)CmdInfo).Split('\t');

                    if (ProgramInfo.Length >= 2)
                        RunProgram(ProgramInfo[0], ProgramInfo[1]);
                    else
                        RunProgram(ProgramInfo[0]);

                    SpeakSentence(cmd, "프로그램을 실행합니다.", bSay);

                    break;

                case CMD_TYPE.Exit_Program:
                    CloseProcess((string)CmdInfo);

                    SpeakSentence(cmd, "프로그램을 종료합니다.", bSay);

                    break;

                case CMD_TYPE.Exit_Top_Program:
                    hWnd = GetForegroundWindow();

                    if (hWnd.ToInt32() == this.Handle.ToInt32())
                    {// 이 프로그램을 종료하려고 함
                        MessageBox.Show("종료버튼으로 종료해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (hWnd.ToInt32() == m_mainForm.Handle.ToInt32())
                    {// 이 프로그램을 종료하려고 함
                        MessageBox.Show("정상적으로 종료해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (hWnd != IntPtr.Zero)
                    {
                        SendMessage(hWnd, 0x0010/*WM_CLOSE*/, 0, 0);
                        SpeakSentence(cmd, "프로그램을 종료합니다.", bSay);
                    }

                    break;

                case CMD_TYPE.Mini_Top_Program:
                    hWnd = GetForegroundWindow();

                    if (hWnd != IntPtr.Zero)
                    {
                        m_MiniWindowList.Add(hWnd);
                        ShowWindow(hWnd, 2/*SW_SHOWMINIMIZED*/);
                        SpeakSentence(cmd, "프로그램을 내립니다.", bSay);
                    }

                    break;

                case CMD_TYPE.Max_PrevMini_Program:
                    if (m_MiniWindowList.Count > 0)
                    {
                        hWnd = m_MiniWindowList[m_MiniWindowList.Count - 1];

                        if (hWnd.ToInt32() == m_mainForm.Handle.ToInt32())
                        {
                            m_mainForm.BringToFront();
                            m_mainForm.Show();
                            m_mainForm.Activate();
                        }
                        else if (hWnd != IntPtr.Zero)
                        {
                            ShowWindow(hWnd, 3/*SW_SHOWMAXIMIZED*/);
                        }

                        m_MiniWindowList.RemoveAt(m_MiniWindowList.Count - 1);
                        SpeakSentence(cmd, "프로그램을 올립니다.", bSay);
                    }

                    break;

                case CMD_TYPE.Hide_Top_Program:
                    hWnd = GetForegroundWindow();

                    if (hWnd.ToInt32() == m_mainForm.Handle.ToInt32())
                    {
                        m_WindowList.Add(hWnd);

                        m_mainForm.HideForm();

                        SpeakSentence(cmd, "프로그램을 숨깁니다.", bSay);
                    }
                    else if (hWnd != IntPtr.Zero)
                    {
                        m_WindowList.Add(hWnd);

                        // Alt + Tab
                        keybd_event(0x12/*VK_MENU*/, 0, 0, 0);
                        keybd_event(0x09/*VK_TAB*/, 0, 0, 0);
                        keybd_event(0x09/*VK_TAB*/, 0, 0x0002/*KEYEVENTF_KEYUP*/, 0);
                        keybd_event(0x12/*VK_MENU*/, 0, 0x0002/*KEYEVENTF_KEYUP*/, 0);

                        Thread.Sleep(10);

                        ShowWindow(hWnd, 0);
                        SetWindowPos(hWnd.ToInt32(), 1, 0, 0, 0, 0, 128 | 2 | 1);
                        SpeakSentence(cmd, "프로그램을 숨깁니다.", bSay);
                    }

                    break;

                case CMD_TYPE.Show_All_Hide_Program:
                    ShowAllWindow();
                    SpeakSentence(cmd, "숨긴 프로그램을 엽니다.", bSay);

                    break;

                case CMD_TYPE.Say_Sentence:
                    SpeakSentence(cmd, (string)CmdInfo, true);

                    break;

                case CMD_TYPE.Keyboard_Input:
                    ProgramInfo = ((string)CmdInfo).Split('#');

                    if (ProgramInfo.Length >= 3)
                    {
                        Keys key = (Keys)int.Parse(ProgramInfo[1]); // 0번은 보여주기위한 것일뿐이므로 안씀


                        // 키 누름
                        if (ProgramInfo[2].Length >= 3)
                        {
                            if (ProgramInfo[2][0/*Ctrl*/] == 'o') keybd_event((byte)Keys.ControlKey, 0, 0, 0);
                            if (ProgramInfo[2][1/*Shift*/] == 'o') keybd_event((byte)Keys.ShiftKey, 0, 0, 0);
                            if (ProgramInfo[2][2/*Alt*/] == 'o') keybd_event((byte)Keys.Menu, 0, 0, 0);
                        }

                        keybd_event((byte)key, 0, 0, 0);


                        // 키 땜
                        keybd_event((byte)key, 0, 0x0002/*KEYEVENTF_KEYUP*/, 0);

                        if (ProgramInfo[2].Length >= 3)
                        {
                            if (ProgramInfo[2][0/*Ctrl*/] == 'o') keybd_event((byte)Keys.ControlKey, 0, 0x0002/*KEYEVENTF_KEYUP*/, 0);
                            if (ProgramInfo[2][1/*Shift*/] == 'o') keybd_event((byte)Keys.ShiftKey, 0, 0x0002/*KEYEVENTF_KEYUP*/, 0);
                            if (ProgramInfo[2][2/*Alt*/] == 'o') keybd_event((byte)Keys.Menu, 0, 0x0002/*KEYEVENTF_KEYUP*/, 0);
                        }


                        SpeakSentence(cmd, "키보드를 누릅니다.", bSay);
                    }

                    break;

                case CMD_TYPE.Typing_Str:
                    // 클립보드 백업
                    if (CmdInfo != null)
                    {
                        string backupClipboard = Clipboard.GetText();
                        if (backupClipboard == null) backupClipboard = "";

                        // 클립보드에 텍스트 설정
                        Clipboard.SetText((string)CmdInfo);


                        // Ctrl + V
                        keybd_event(0x11/*VK_CONTROL*/, 0, 0, 0);
                        keybd_event((byte)'V', 0, 0, 0);
                        keybd_event(0x11/*VK_CONTROL*/, 0, 0x0002/*KEYEVENTF_KEYUP*/, 0);
                        keybd_event((byte)'V', 0, 0x0002/*KEYEVENTF_KEYUP*/, 0);


                        SpeakSentence(cmd, "타이핑합니다.", bSay);


                        Thread.Sleep(50);


                        // 클립보드 복구
                        if (backupClipboard != null)
                        {
                            Clipboard.SetText(backupClipboard);
                        }
                    }

                    break;
            } // switch (CmdType)
        }


        private void Timer_CloseTip_Tick(object sender, EventArgs e)
        {// 팝업 닫기 및 캐릭터 애니메이션 초기화
            this.ToolTip_Notify.Hide(m_mainCharBox);
            ProgramCore.CharacterAction.SetAction("Nothing");


            this.Timer_CloseTip.Enabled = false;
        }
    }
}
