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
    public partial class Form_EditCmd : Form
    {
        public Form_EditCmd(ListViewItem.ListViewSubItem listViewSubItem)
        {
            InitializeComponent();


            m_listViewSubItem = listViewSubItem;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private ListViewItem.ListViewSubItem m_listViewSubItem;

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Form_EditCmd_Load(object sender, EventArgs e)
        {
            this.TextBox_CmdName.Text = m_listViewSubItem.Text;
        }


        private void Button_Edit_Click(object sender, EventArgs e)
        {
            if (this.TextBox_CmdName.Text.Length <= 0)
            {
                MessageBox.Show("명령어를 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            m_listViewSubItem.Text = this.TextBox_CmdName.Text;


            this.Close();
        }


        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
