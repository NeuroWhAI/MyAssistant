namespace MyAssistant
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.PictureBox_Char = new System.Windows.Forms.PictureBox();
            this.ContextMenuStrip_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_ShowCmdList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ShowCalender = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Option = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Hide = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyIcon_Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuStrip_Tray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_OpenByTray = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ExitByTray = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Char)).BeginInit();
            this.ContextMenuStrip_Main.SuspendLayout();
            this.ContextMenuStrip_Tray.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox_Char
            // 
            this.PictureBox_Char.ContextMenuStrip = this.ContextMenuStrip_Main;
            this.PictureBox_Char.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.PictureBox_Char.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox_Char.Location = new System.Drawing.Point(0, 0);
            this.PictureBox_Char.Name = "PictureBox_Char";
            this.PictureBox_Char.Size = new System.Drawing.Size(284, 262);
            this.PictureBox_Char.TabIndex = 0;
            this.PictureBox_Char.TabStop = false;
            this.PictureBox_Char.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.PictureBox_Char.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.PictureBox_Char.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.PictureBox_Char.Validated += new System.EventHandler(this.PictureBox_Char_Validated);
            // 
            // ContextMenuStrip_Main
            // 
            this.ContextMenuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ShowCmdList,
            this.ToolStripMenuItem_ShowCalender,
            this.ToolStripMenuItem_Option,
            this.ToolStripMenuItem_Hide,
            this.ToolStripMenuItem_Exit});
            this.ContextMenuStrip_Main.Name = "ContextMenuStrip_Main";
            this.ContextMenuStrip_Main.Size = new System.Drawing.Size(139, 114);
            // 
            // ToolStripMenuItem_ShowCmdList
            // 
            this.ToolStripMenuItem_ShowCmdList.Name = "ToolStripMenuItem_ShowCmdList";
            this.ToolStripMenuItem_ShowCmdList.Size = new System.Drawing.Size(138, 22);
            this.ToolStripMenuItem_ShowCmdList.Text = "명령어 보기";
            this.ToolStripMenuItem_ShowCmdList.Click += new System.EventHandler(this.ToolStripMenuItem_ShowCmdList_Click);
            // 
            // ToolStripMenuItem_ShowCalender
            // 
            this.ToolStripMenuItem_ShowCalender.Name = "ToolStripMenuItem_ShowCalender";
            this.ToolStripMenuItem_ShowCalender.Size = new System.Drawing.Size(138, 22);
            this.ToolStripMenuItem_ShowCalender.Text = "일정 보기";
            this.ToolStripMenuItem_ShowCalender.Click += new System.EventHandler(this.ToolStripMenuItem_ShowCalender_Click);
            // 
            // ToolStripMenuItem_Option
            // 
            this.ToolStripMenuItem_Option.Name = "ToolStripMenuItem_Option";
            this.ToolStripMenuItem_Option.Size = new System.Drawing.Size(138, 22);
            this.ToolStripMenuItem_Option.Text = "옵션";
            // 
            // ToolStripMenuItem_Hide
            // 
            this.ToolStripMenuItem_Hide.Name = "ToolStripMenuItem_Hide";
            this.ToolStripMenuItem_Hide.Size = new System.Drawing.Size(138, 22);
            this.ToolStripMenuItem_Hide.Text = "숨기기";
            this.ToolStripMenuItem_Hide.Click += new System.EventHandler(this.ToolStripMenuItem_Hide_Click);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(138, 22);
            this.ToolStripMenuItem_Exit.Text = "종료";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
            // 
            // NotifyIcon_Tray
            // 
            this.NotifyIcon_Tray.ContextMenuStrip = this.ContextMenuStrip_Tray;
            this.NotifyIcon_Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon_Tray.Icon")));
            this.NotifyIcon_Tray.Text = "Assistant";
            this.NotifyIcon_Tray.Visible = true;
            this.NotifyIcon_Tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_Tray_MouseDoubleClick);
            // 
            // ContextMenuStrip_Tray
            // 
            this.ContextMenuStrip_Tray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_OpenByTray,
            this.ToolStripMenuItem_ExitByTray});
            this.ContextMenuStrip_Tray.Name = "ContextMenuStrip_Tray";
            this.ContextMenuStrip_Tray.Size = new System.Drawing.Size(99, 48);
            // 
            // ToolStripMenuItem_OpenByTray
            // 
            this.ToolStripMenuItem_OpenByTray.Name = "ToolStripMenuItem_OpenByTray";
            this.ToolStripMenuItem_OpenByTray.Size = new System.Drawing.Size(98, 22);
            this.ToolStripMenuItem_OpenByTray.Text = "열기";
            this.ToolStripMenuItem_OpenByTray.Click += new System.EventHandler(this.ToolStripMenuItem_OpenByTray_Click);
            // 
            // ToolStripMenuItem_ExitByTray
            // 
            this.ToolStripMenuItem_ExitByTray.Name = "ToolStripMenuItem_ExitByTray";
            this.ToolStripMenuItem_ExitByTray.Size = new System.Drawing.Size(98, 22);
            this.ToolStripMenuItem_ExitByTray.Text = "종료";
            this.ToolStripMenuItem_ExitByTray.Click += new System.EventHandler(this.ToolStripMenuItem_ExitByTray_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.PictureBox_Char);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Assistant (tlsehdgus321@naver.com)";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Char)).EndInit();
            this.ContextMenuStrip_Main.ResumeLayout(false);
            this.ContextMenuStrip_Tray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Char;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ShowCmdList;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ShowCalender;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Option;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Hide;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.NotifyIcon NotifyIcon_Tray;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Tray;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenByTray;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ExitByTray;
    }
}