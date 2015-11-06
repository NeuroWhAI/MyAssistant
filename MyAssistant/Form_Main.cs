using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyAssistant
{
    public partial class Form_Main : Form
    {
        public struct POINTAPI
        {
            public int x;
            public int y;
        }

        [DllImport("user32.dll")]
        public static extern int GetCursorPos(ref POINTAPI lpPoint);

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public Form_Main()
        {
            InitializeComponent();


            ProgramCore.CharacterAction = new CharacterAction(this.PictureBox_Char, this);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 멤버 변수 (기능) */

        Form_CmdList m_formCmdList = null;
        Form_Calender m_formCalender = null;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 멤버 변수 (인터페이스) */

        bool m_bOnMove = false;
        POINTAPI m_pathPos = new POINTAPI();

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 인터페이스 */

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {// 드래그 시작
            m_bOnMove = true;

            GetCursorPos(ref m_pathPos);

            m_pathPos.x -= this.Location.X;
            m_pathPos.y -= this.Location.Y;
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {// 드래그
            if (m_bOnMove)
            {
                POINTAPI cursorPos = new POINTAPI();
                GetCursorPos(ref cursorPos);

                this.Location = new Point(cursorPos.x - m_pathPos.x, cursorPos.y - m_pathPos.y);
            }
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {// 드래그 완료
            m_bOnMove = false;
        }


        private void PictureBox_Char_Validated(object sender, EventArgs e)
        {// 알림 보여줌
            this.Show();
            this.BringToFront();
            this.PictureBox_Char.BringToFront();
        }


        public void HideForm()
        {// 트레이로 숨김
            this.Visible = false;
            this.NotifyIcon_Tray.Visible = true;
        }


        public void ShowForm()
        {// 보임
            this.Visible = true;
            this.NotifyIcon_Tray.Visible = false;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 메인 메뉴 */

        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {// 종료
            m_formCmdList.Destroy();
            m_formCmdList.Dispose();
            m_formCalender.Dispose();
            Application.Exit();
        }


        private void ToolStripMenuItem_Hide_Click(object sender, EventArgs e)
        {// 트레이 아이콘으로 숨김
            HideForm();
        }


        private void NotifyIcon_Tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {// 보이기
            ShowForm();
        }


        private void ToolStripMenuItem_OpenByTray_Click(object sender, EventArgs e)
        {// 보이기
            ShowForm();
        }


        private void ToolStripMenuItem_ExitByTray_Click(object sender, EventArgs e)
        {// 종료
            m_formCmdList.Destroy();
            m_formCmdList.Dispose();
            m_formCalender.Dispose();
            Application.Exit();
        }


        private void ToolStripMenuItem_ShowCmdList_Click(object sender, EventArgs e)
        {// 명령어 목록 보기
            if (m_formCmdList.IsDisposed)
            {
                m_formCmdList = new Form_CmdList(this.PictureBox_Char, this);
            }

            m_formCmdList.Show();
        }


        private void ToolStripMenuItem_ShowCalender_Click(object sender, EventArgs e)
        {// 일정 보기
            if (m_formCalender.IsDisposed)
            {
                m_formCalender = new Form_Calender(this.PictureBox_Char, this, m_formCmdList);
            }

            m_formCalender.Show();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 초기화 및 종료처리 */

        private void Form_Main_Load(object sender, EventArgs e)
        {
            ProgramCore.CharacterAction.SetAction("Nothing");


            m_formCmdList = new Form_CmdList(this.PictureBox_Char, this);
            m_formCalender = new Form_Calender(this.PictureBox_Char, this, m_formCmdList);

            m_formCmdList.Show();
            m_formCalender.Show();

            m_formCmdList.Hide();
            m_formCalender.Hide();
        }


        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_formCmdList != null && m_formCmdList.IsDisposed == false)
            {
                m_formCmdList.Destroy();
                m_formCmdList.Dispose();

                m_formCmdList = null;
            }

            if (m_formCalender != null && m_formCalender.IsDisposed == false)
            {
                m_formCalender.Dispose();

                m_formCalender = null;
            }
        }
    }
}
