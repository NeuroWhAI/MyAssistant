namespace MyAssistant
{
    partial class Form_CmdList
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CmdList));
            this.label1 = new System.Windows.Forms.Label();
            this.ListView_Command = new System.Windows.Forms.ListView();
            this.ColumnHeader_Command = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Work = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader_Info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextMenuStrip_CmdList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_RunStop = new System.Windows.Forms.Button();
            this.Button_AddCmd = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.CheckBox_ResponseVoice = new System.Windows.Forms.CheckBox();
            this.ToolTip_Notify = new System.Windows.Forms.ToolTip(this.components);
            this.Timer_CloseTip = new System.Windows.Forms.Timer(this.components);
            this.ToolStripMenuItem_EditCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip_CmdList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "명령어 목록";
            // 
            // ListView_Command
            // 
            this.ListView_Command.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader_Command,
            this.ColumnHeader_Work,
            this.ColumnHeader_Info});
            this.ListView_Command.ContextMenuStrip = this.ContextMenuStrip_CmdList;
            this.ListView_Command.GridLines = true;
            this.ListView_Command.Location = new System.Drawing.Point(12, 24);
            this.ListView_Command.MultiSelect = false;
            this.ListView_Command.Name = "ListView_Command";
            this.ListView_Command.Size = new System.Drawing.Size(319, 152);
            this.ListView_Command.TabIndex = 1;
            this.ListView_Command.UseCompatibleStateImageBehavior = false;
            this.ListView_Command.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader_Command
            // 
            this.ColumnHeader_Command.Text = "명령어";
            this.ColumnHeader_Command.Width = 102;
            // 
            // ColumnHeader_Work
            // 
            this.ColumnHeader_Work.Text = "작업";
            this.ColumnHeader_Work.Width = 121;
            // 
            // ColumnHeader_Info
            // 
            this.ColumnHeader_Info.Text = "정보";
            this.ColumnHeader_Info.Width = 92;
            // 
            // ContextMenuStrip_CmdList
            // 
            this.ContextMenuStrip_CmdList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_EditCmd,
            this.ToolStripMenuItem_Delete});
            this.ContextMenuStrip_CmdList.Name = "ContextMenuStrip_CmdList";
            this.ContextMenuStrip_CmdList.Size = new System.Drawing.Size(153, 70);
            // 
            // ToolStripMenuItem_Delete
            // 
            this.ToolStripMenuItem_Delete.Name = "ToolStripMenuItem_Delete";
            this.ToolStripMenuItem_Delete.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Delete.Text = "삭제";
            this.ToolStripMenuItem_Delete.Click += new System.EventHandler(this.ToolStripMenuItem_Delete_Click);
            // 
            // Button_RunStop
            // 
            this.Button_RunStop.Location = new System.Drawing.Point(12, 182);
            this.Button_RunStop.Name = "Button_RunStop";
            this.Button_RunStop.Size = new System.Drawing.Size(93, 25);
            this.Button_RunStop.TabIndex = 2;
            this.Button_RunStop.Text = "정지";
            this.Button_RunStop.UseVisualStyleBackColor = true;
            this.Button_RunStop.Click += new System.EventHandler(this.Button_RunStop_Click);
            // 
            // Button_AddCmd
            // 
            this.Button_AddCmd.Location = new System.Drawing.Point(111, 182);
            this.Button_AddCmd.Name = "Button_AddCmd";
            this.Button_AddCmd.Size = new System.Drawing.Size(93, 25);
            this.Button_AddCmd.TabIndex = 3;
            this.Button_AddCmd.Text = "명령어 추가";
            this.Button_AddCmd.UseVisualStyleBackColor = true;
            this.Button_AddCmd.Click += new System.EventHandler(this.Button_AddCmd_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Location = new System.Drawing.Point(238, 182);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(93, 25);
            this.Button_Exit.TabIndex = 4;
            this.Button_Exit.Text = "닫기";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // CheckBox_ResponseVoice
            // 
            this.CheckBox_ResponseVoice.AutoSize = true;
            this.CheckBox_ResponseVoice.Checked = true;
            this.CheckBox_ResponseVoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_ResponseVoice.Location = new System.Drawing.Point(215, 8);
            this.CheckBox_ResponseVoice.Name = "CheckBox_ResponseVoice";
            this.CheckBox_ResponseVoice.Size = new System.Drawing.Size(116, 16);
            this.CheckBox_ResponseVoice.TabIndex = 5;
            this.CheckBox_ResponseVoice.Text = "응답 목소리 출력";
            this.CheckBox_ResponseVoice.UseVisualStyleBackColor = true;
            // 
            // ToolTip_Notify
            // 
            this.ToolTip_Notify.AutoPopDelay = 500;
            this.ToolTip_Notify.InitialDelay = 500;
            this.ToolTip_Notify.IsBalloon = true;
            this.ToolTip_Notify.ReshowDelay = 100;
            this.ToolTip_Notify.ToolTipTitle = "명령을 실행합니다";
            // 
            // Timer_CloseTip
            // 
            this.Timer_CloseTip.Interval = 2000;
            this.Timer_CloseTip.Tick += new System.EventHandler(this.Timer_CloseTip_Tick);
            // 
            // ToolStripMenuItem_EditCmd
            // 
            this.ToolStripMenuItem_EditCmd.Name = "ToolStripMenuItem_EditCmd";
            this.ToolStripMenuItem_EditCmd.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_EditCmd.Text = "수정";
            this.ToolStripMenuItem_EditCmd.Click += new System.EventHandler(this.ToolStripMenuItem_EditCmd_Click);
            // 
            // Form_CmdList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 218);
            this.Controls.Add(this.CheckBox_ResponseVoice);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_AddCmd);
            this.Controls.Add(this.Button_RunStop);
            this.Controls.Add(this.ListView_Command);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_CmdList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ContextMenuStrip_CmdList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView ListView_Command;
        private System.Windows.Forms.ColumnHeader ColumnHeader_Command;
        private System.Windows.Forms.ColumnHeader ColumnHeader_Work;
        private System.Windows.Forms.ColumnHeader ColumnHeader_Info;
        private System.Windows.Forms.Button Button_RunStop;
        private System.Windows.Forms.Button Button_AddCmd;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.CheckBox CheckBox_ResponseVoice;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_CmdList;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Delete;
        private System.Windows.Forms.ToolTip ToolTip_Notify;
        private System.Windows.Forms.Timer Timer_CloseTip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_EditCmd;
    }
}

