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

namespace MyAssistant
{
    public partial class Form_Calender : Form
    {
        public Form_Calender(PictureBox mainCharBox, Form_Main mainForm, Form_CmdList cmdForm)
        {
            InitializeComponent();


            m_mainChar = mainCharBox;
            m_mainForm = mainForm;
            m_cmdForm = cmdForm;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 멤버 변수 */

        List<DateTime> m_TimeList = new List<DateTime>();

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 멤버 변수 */

        PictureBox m_mainChar = null;
        Form_Main m_mainForm = null;
        Form_CmdList m_cmdForm = null;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 초기화 및 종료 처리 */

        private void Form_Calender_Load(object sender, EventArgs e)
        {// 초기화
            try
            {
                using (StreamReader sr = new StreamReader(new FileStream("Calender.txt", FileMode.Open)))
                {
                    while (!sr.EndOfStream)
                    {
                        string dayTime = sr.ReadLine();
                        string desc = sr.ReadLine();
                        string cmd = sr.ReadLine();

                        m_TimeList.Add(DateTime.Parse(dayTime));


                        this.ListView_Schedule.BeginUpdate();


                        ListViewItem Item = new ListViewItem(dayTime);
                        Item.SubItems.Add(desc);
                        Item.SubItems.Add(cmd);


                        this.ListView_Schedule.Items.Add(Item);


                        this.ListView_Schedule.EndUpdate();
                    }


                    sr.Close();
                }
            }
            catch (FileNotFoundException NoFileEcp)
            {
                // empty
            }


            // 일정 확인 타이머 작동
            this.Timer_Check.Enabled = true;
        }


        private void Form_Calender_FormClosing(object sender, FormClosingEventArgs e)
        {// 닫기 처리
            // 일정 저장
            SaveCalenderData();


            // 숨기기
            e.Cancel = true;
            this.Hide();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 인터페이스 */

        private void Button_Close_Click(object sender, EventArgs e)
        {// 닫기
            this.Hide();
        }


        private void Button_AddDay_Click(object sender, EventArgs e)
        {// 일정 추가
            Form_AddSchedule formAddSchedule = new Form_AddSchedule(this);
            formAddSchedule.ShowDialog();
        }


        private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {// 일정 삭제
            var Item = this.ListView_Schedule.SelectedItems;

            if (Item != null && Item.Count > 0)
            {
                int Idx = this.ListView_Schedule.Items.IndexOf(Item[0]);
                this.ListView_Schedule.Items.RemoveAt(Idx);

                m_TimeList.RemoveAt(Idx);


                SaveCalenderData();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 외부 통신 */

        public int AddDay(DateTime time, string Desc, string Cmd = "")
        {
            // 내부 목록에 추가
            m_TimeList.Add(time);


            // 외부 목록에 추가
            this.ListView_Schedule.BeginUpdate();


            ListViewItem Item = new ListViewItem(time.ToString());
            Item.SubItems.Add(Desc);
            Item.SubItems.Add(Cmd);


            this.ListView_Schedule.Items.Add(Item);


            // 외부 목록 시간순으로 정렬
            for (int i = 0; i < m_TimeList.Count; i++)
            {
                for (int j = i+1; j < m_TimeList.Count; j++)
                {
                    if (m_TimeList[i] > m_TimeList[j])
                    {
                        DateTime temp = m_TimeList[i];
                        m_TimeList[i] = m_TimeList[j];
                        m_TimeList[j] = temp;


                        var temp2 = this.ListView_Schedule.Items[i];
                        this.ListView_Schedule.Items[i] = this.ListView_Schedule.Items[j];
                        this.ListView_Schedule.Items[j] = temp2;
                    }
                }
            }


            this.ListView_Schedule.EndUpdate();


            // 변경사항 저장
            SaveCalenderData();


            return 0;
        }


        private int SaveCalenderData()
        {
            if (m_TimeList.Count <= 0)
            {
                this.Label_ElapsedTime.Text = "남은 시간 : None";
            }


            using (StreamWriter sw = new StreamWriter(new FileStream("Calender.txt", FileMode.Create)))
            {
                for (int i = 0; i < this.ListView_Schedule.Items.Count; i++)
                {
                    sw.WriteLine(m_TimeList[i].ToString());
                    sw.WriteLine(this.ListView_Schedule.Items[i].SubItems[1].Text);
                    sw.WriteLine(this.ListView_Schedule.Items[i].SubItems[2].Text);
                }


                sw.Close();
            }


            return 0;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 일정 확인 및 작동 */

        private void Timer_Check_Tick(object sender, EventArgs e)
        {// 지속적인 확인
            while (m_TimeList.Count > 0)
            {
                if (DateTime.Now >= m_TimeList[0])
                {// 일정 지남
                    // 캐릭터 애니메이션
                    ProgramCore.CharacterAction.SetAction("Calender");
                    
                    // 알림
                    m_mainChar.Parent.BringToFront();
                    m_mainChar.BringToFront();
                    this.ToolTip_Notify.Show(this.ListView_Schedule.Items[0].SubItems[1].Text, m_mainChar, 0, -64);
                    this.Timer_CloseNotify.Enabled = true; // 알림 닫기 타이머 작동

                    // 음성으로 알림
                    m_cmdForm.SpeakSentence(this.ListView_Schedule.Items[0].SubItems[1].Text, this.ListView_Schedule.Items[0].SubItems[1].Text);

                    // 실행할 명령이 있으면 실행
                    if (this.ListView_Schedule.Items[0].SubItems[2].Text.Length > 0)
                    {
                        m_cmdForm.ProcessCmd(this.ListView_Schedule.Items[0].SubItems[2].Text, bSay:false/* 명령 응답은 안함 */);
                    }


                    // 지움
                    m_TimeList.RemoveAt(0);
                    this.ListView_Schedule.Items.RemoveAt(0);

                    SaveCalenderData();
                }
                else
                {
                    TimeSpan timeSpan = m_TimeList[0] - DateTime.Now;
                    this.Label_ElapsedTime.Text = "남은 시간 : "
                        + string.Format("{0}일 {1}시간 {2}분 {3}초", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);


                    break;
                }
            }
        }


        private void Timer_CloseNotify_Tick(object sender, EventArgs e)
        {// 알림 닫기
            this.ToolTip_Notify.Hide(m_mainChar);
            ProgramCore.CharacterAction.SetAction("Nothing");


            this.Timer_CloseNotify.Enabled = false;
        }
    }
}
