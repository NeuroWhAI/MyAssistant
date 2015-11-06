using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAssistant
{
    public partial class Form_AddCmd : Form
    {
        public Form_AddCmd()
        {
            InitializeComponent();


            m_ButtonCmdTypeList[this.RadioButton_RunAssistant] = CMD_TYPE.Run_Assistant;
            m_ButtonCmdTypeList[this.RadioButton_StopAssistant] = CMD_TYPE.Stop_Assistant;
            m_ButtonCmdTypeList[this.RadioButton_RunProgram] = CMD_TYPE.Run_Program;
            m_ButtonCmdTypeList[this.RadioButton_ExitProgram] = CMD_TYPE.Exit_Program;
            m_ButtonCmdTypeList[this.RadioButton_ExitTopProgram] = CMD_TYPE.Exit_Top_Program;
            m_ButtonCmdTypeList[this.RadioButton_Mini_Top] = CMD_TYPE.Mini_Top_Program;
            m_ButtonCmdTypeList[this.RadioButton_Max_PrevMini] = CMD_TYPE.Max_PrevMini_Program;
            m_ButtonCmdTypeList[this.RadioButton_Hide_Top] = CMD_TYPE.Hide_Top_Program;
            m_ButtonCmdTypeList[this.RadioButton_ShowAll] = CMD_TYPE.Show_All_Hide_Program;
            m_ButtonCmdTypeList[this.RadioButton_Say] = CMD_TYPE.Say_Sentence;
            m_ButtonCmdTypeList[this.RadioButton_KeyboardInput] = CMD_TYPE.Keyboard_Input;
            m_ButtonCmdTypeList[this.RadioButton_Typing] = CMD_TYPE.Typing_Str;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 멤버 변수 */

        Form_CmdList m_MainForm = null;

        Dictionary<RadioButton, CMD_TYPE> m_ButtonCmdTypeList = new Dictionary<RadioButton, CMD_TYPE>();

        Keys m_keyData = Keys.None;

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 외부 통신 */

        public void SetMainForm(Form_CmdList MainForm)
        {
            m_MainForm = MainForm;
        }


        private void Button_Add_Click(object sender, EventArgs e)
        {
            // 오류검사
            if(this.TextBox_CmdName.Text.Length <= 0)
            {
                MessageBox.Show("명령어를 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // 선택된 작업 알아옴
            CMD_TYPE WorkType = CMD_TYPE.None;
            foreach (var ButtonCmdType in m_ButtonCmdTypeList)
            {
                if (ButtonCmdType.Key.Checked)
                {
                    WorkType = m_ButtonCmdTypeList[ButtonCmdType.Key];
                    break;
                }
            }


            // 필요하면 작업 세부정보를 알아옴
            object Info = "";

            switch (WorkType)
            {
                case CMD_TYPE.Run_Program:
                    Info = this.TextBox_RunProgramPath.Text + '\t' + this.TextBox_ProgramArg.Text;

                    break;


                case CMD_TYPE.Exit_Program:
                    Info = this.TextBox_ExitProgram.Text;

                    break;


                case CMD_TYPE.Say_Sentence:
                    Info = this.TextBox_SaySentence.Text;

                    break;


                case CMD_TYPE.Keyboard_Input:
                    if(m_keyData == Keys.None)
                    {
                        MessageBox.Show("키를 설정해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    
                    string tempStr = m_keyData.ToString() + '#' + ((int)m_keyData).ToString() + '#';

                    tempStr += (this.CheckBox_Key_Ctrl.Checked ? 'o' : 'x');
                    tempStr += (this.CheckBox_Key_Shift.Checked ? 'o' : 'x');
                    tempStr += (this.CheckBox_Key_Alt.Checked ? 'o' : 'x');


                    Info = tempStr;

                    break;


                case CMD_TYPE.Typing_Str:
                    Info = this.TextBox_TypingStr.Text;

                    break;
            }


            m_MainForm.AddCmdList(this.TextBox_CmdName.Text, WorkType, Info);


            this.Close();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Button_Exit_Click(object sender, EventArgs e)
        {// 창 닫기
            this.Close();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 세부 갱신 */

        private void RadioButton_RunProgram_CheckedChanged(object sender, EventArgs e)
        {
            this.TextBox_RunProgramPath.Enabled = this.RadioButton_RunProgram.Checked;
            this.TextBox_ProgramArg.Enabled = this.RadioButton_RunProgram.Checked;

            if (this.RadioButton_RunProgram.Checked)
            {
                this.TextBox_RunProgramPath.Text = "";
                this.TextBox_ProgramArg.Text = "";
            }
        }


        private void RadioButton_Say_CheckedChanged(object sender, EventArgs e)
        {
            this.TextBox_SaySentence.Enabled = this.RadioButton_Say.Checked;

            if (this.RadioButton_Say.Checked)
            {
                this.TextBox_SaySentence.Text = "";
            }
        }


        private void RadioButton_ExitProgram_CheckedChanged(object sender, EventArgs e)
        {
            this.TextBox_ExitProgram.Enabled = this.RadioButton_ExitProgram.Checked;

            if (this.RadioButton_ExitProgram.Checked)
            {
                this.TextBox_ExitProgram.Text = "";
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (this.Label_Key.Enabled)
            {
                m_keyData = keyData;
                this.Label_Key.Text = keyData.ToString();


                this.Label_Key.Enabled = false;


                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }


        private void RadioButton_KeyboardInput_CheckedChanged(object sender, EventArgs e)
        {
            this.Label_Key.Enabled = this.RadioButton_KeyboardInput.Checked;
            this.CheckBox_Key_Ctrl.Enabled = this.RadioButton_KeyboardInput.Checked;
            this.CheckBox_Key_Shift.Enabled = this.RadioButton_KeyboardInput.Checked;
            this.CheckBox_Key_Alt.Enabled = this.RadioButton_KeyboardInput.Checked;

            if (this.RadioButton_KeyboardInput.Checked)
            {
                this.Label_Key.Text = "(키를 누르세요)";
                m_keyData = Keys.None;
            }
        }


        private void Label_Key_Click(object sender, EventArgs e)
        {
            if (this.RadioButton_KeyboardInput.Checked)
            {
                this.Label_Key.Enabled = true;
            }
        }


        private void RadioButton_Typing_CheckedChanged(object sender, EventArgs e)
        {
            this.TextBox_TypingStr.Enabled = this.RadioButton_Typing.Checked;

            if (this.RadioButton_Typing.Checked)
            {
                this.TextBox_TypingStr.Text = "";
            }
        }
    }
}
