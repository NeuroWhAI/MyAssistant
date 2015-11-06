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
    public partial class Form_AddSchedule : Form
    {
        public Form_AddSchedule(Form_Calender formCalender)
        {
            InitializeComponent();


            m_formCalender = formCalender;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 멤버 변수 */

        Form_Calender m_formCalender = null;

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /* 일정 */

        private void Button_Add_Click(object sender, EventArgs e)
        {// 일정 추가
            DateTime day = this.MonthCalendar_Cal.SelectionEnd;
            DateTime finalTime = new DateTime(day.Year, day.Month, day.Day, (int)this.NumericUpDown_Hour.Value, (int)this.NumericUpDown_Minute.Value, 0);

            m_formCalender.AddDay(finalTime, this.TextBox_Desc.Text, this.TextBox_Cmd.Text);


            this.Close();
        }


        private void NumericUpDown_Minute_ValueChanged(object sender, EventArgs e)
        {// 분 설정
            if (this.NumericUpDown_Minute.Value >= 60)
            {// 다음 시간 선택
                this.NumericUpDown_Minute.Value = 0;
                this.NumericUpDown_Hour.Value++;
            }
        }


        private void Button_Close_Click(object sender, EventArgs e)
        {// 닫기
            this.Close();
        }
    }
}
