namespace MyAssistant
{
    partial class Form_Calender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Calender));
            this.ListView_Schedule = new System.Windows.Forms.ListView();
            this.ColumnHeader_Day = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Cmd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenuStrip_Calender = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_AddDay = new System.Windows.Forms.Button();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Timer_Check = new System.Windows.Forms.Timer(this.components);
            this.Label_ElapsedTime = new System.Windows.Forms.Label();
            this.ToolTip_Notify = new System.Windows.Forms.ToolTip(this.components);
            this.Timer_CloseNotify = new System.Windows.Forms.Timer(this.components);
            this.ContextMenuStrip_Calender.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListView_Schedule
            // 
            this.ListView_Schedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader_Day,
            this.ColumnHeader_Content,
            this.ColumnHeader_Cmd});
            this.ListView_Schedule.ContextMenuStrip = this.ContextMenuStrip_Calender;
            this.ListView_Schedule.GridLines = true;
            this.ListView_Schedule.Location = new System.Drawing.Point(12, 24);
            this.ListView_Schedule.Name = "ListView_Schedule";
            this.ListView_Schedule.Size = new System.Drawing.Size(303, 141);
            this.ListView_Schedule.TabIndex = 0;
            this.ListView_Schedule.UseCompatibleStateImageBehavior = false;
            this.ListView_Schedule.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader_Day
            // 
            this.ColumnHeader_Day.Text = "날짜 및 시간";
            this.ColumnHeader_Day.Width = 128;
            // 
            // ColumnHeader_Content
            // 
            this.ColumnHeader_Content.Text = "내용";
            this.ColumnHeader_Content.Width = 89;
            // 
            // ColumnHeader_Cmd
            // 
            this.ColumnHeader_Cmd.Text = "실행 명령어";
            this.ColumnHeader_Cmd.Width = 82;
            // 
            // ContextMenuStrip_Calender
            // 
            this.ContextMenuStrip_Calender.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Delete});
            this.ContextMenuStrip_Calender.Name = "ContextMenuStrip_Calender";
            this.ContextMenuStrip_Calender.Size = new System.Drawing.Size(99, 26);
            // 
            // ToolStripMenuItem_Delete
            // 
            this.ToolStripMenuItem_Delete.Name = "ToolStripMenuItem_Delete";
            this.ToolStripMenuItem_Delete.Size = new System.Drawing.Size(98, 22);
            this.ToolStripMenuItem_Delete.Text = "삭제";
            this.ToolStripMenuItem_Delete.Click += new System.EventHandler(this.ToolStripMenuItem_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "일정 목록";
            // 
            // Button_AddDay
            // 
            this.Button_AddDay.Location = new System.Drawing.Point(12, 171);
            this.Button_AddDay.Name = "Button_AddDay";
            this.Button_AddDay.Size = new System.Drawing.Size(93, 25);
            this.Button_AddDay.TabIndex = 3;
            this.Button_AddDay.Text = "일정 추가";
            this.Button_AddDay.UseVisualStyleBackColor = true;
            this.Button_AddDay.Click += new System.EventHandler(this.Button_AddDay_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.Location = new System.Drawing.Point(222, 171);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(93, 25);
            this.Button_Close.TabIndex = 4;
            this.Button_Close.Text = "닫기";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Timer_Check
            // 
            this.Timer_Check.Interval = 1000;
            this.Timer_Check.Tick += new System.EventHandler(this.Timer_Check_Tick);
            // 
            // Label_ElapsedTime
            // 
            this.Label_ElapsedTime.AutoSize = true;
            this.Label_ElapsedTime.Location = new System.Drawing.Point(135, 9);
            this.Label_ElapsedTime.Name = "Label_ElapsedTime";
            this.Label_ElapsedTime.Size = new System.Drawing.Size(99, 12);
            this.Label_ElapsedTime.TabIndex = 6;
            this.Label_ElapsedTime.Text = "남은 시간 : None";
            // 
            // ToolTip_Notify
            // 
            this.ToolTip_Notify.AutoPopDelay = 1000;
            this.ToolTip_Notify.InitialDelay = 500;
            this.ToolTip_Notify.IsBalloon = true;
            this.ToolTip_Notify.ReshowDelay = 100;
            this.ToolTip_Notify.ToolTipTitle = "일정 알림";
            // 
            // Timer_CloseNotify
            // 
            this.Timer_CloseNotify.Interval = 2000;
            this.Timer_CloseNotify.Tick += new System.EventHandler(this.Timer_CloseNotify_Tick);
            // 
            // Form_Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 208);
            this.Controls.Add(this.Label_ElapsedTime);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.Button_AddDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListView_Schedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Calender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Calender_FormClosing);
            this.Load += new System.EventHandler(this.Form_Calender_Load);
            this.ContextMenuStrip_Calender.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView_Schedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ColumnHeader_Day;
        private System.Windows.Forms.ColumnHeader ColumnHeader_Content;
        private System.Windows.Forms.ColumnHeader ColumnHeader_Cmd;
        private System.Windows.Forms.Button Button_AddDay;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Calender;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Delete;
        private System.Windows.Forms.Timer Timer_Check;
        private System.Windows.Forms.Label Label_ElapsedTime;
        private System.Windows.Forms.ToolTip ToolTip_Notify;
        private System.Windows.Forms.Timer Timer_CloseNotify;
    }
}