namespace MyAssistant
{
    partial class Form_AddSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddSchedule));
            this.NumericUpDown_Hour = new System.Windows.Forms.NumericUpDown();
            this.MonthCalendar_Cal = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumericUpDown_Minute = new System.Windows.Forms.NumericUpDown();
            this.Button_Add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Desc = new System.Windows.Forms.TextBox();
            this.TextBox_Cmd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Minute)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumericUpDown_Hour
            // 
            this.NumericUpDown_Hour.Location = new System.Drawing.Point(12, 200);
            this.NumericUpDown_Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NumericUpDown_Hour.Name = "NumericUpDown_Hour";
            this.NumericUpDown_Hour.Size = new System.Drawing.Size(43, 21);
            this.NumericUpDown_Hour.TabIndex = 1;
            // 
            // MonthCalendar_Cal
            // 
            this.MonthCalendar_Cal.Location = new System.Drawing.Point(12, 26);
            this.MonthCalendar_Cal.MaxSelectionCount = 1;
            this.MonthCalendar_Cal.Name = "MonthCalendar_Cal";
            this.MonthCalendar_Cal.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "시";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "분";
            // 
            // NumericUpDown_Minute
            // 
            this.NumericUpDown_Minute.Location = new System.Drawing.Point(84, 200);
            this.NumericUpDown_Minute.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.NumericUpDown_Minute.Name = "NumericUpDown_Minute";
            this.NumericUpDown_Minute.Size = new System.Drawing.Size(41, 21);
            this.NumericUpDown_Minute.TabIndex = 2;
            this.NumericUpDown_Minute.ValueChanged += new System.EventHandler(this.NumericUpDown_Minute_ValueChanged);
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(12, 365);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(88, 24);
            this.Button_Add.TabIndex = 3;
            this.Button_Add.Text = "추가";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MonthCalendar_Cal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NumericUpDown_Hour);
            this.groupBox1.Controls.Add(this.NumericUpDown_Minute);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 240);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "날짜 및 시간";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBox_Cmd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TextBox_Desc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 87);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "내용";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "설명 :";
            // 
            // TextBox_Desc
            // 
            this.TextBox_Desc.Location = new System.Drawing.Point(49, 23);
            this.TextBox_Desc.Name = "TextBox_Desc";
            this.TextBox_Desc.Size = new System.Drawing.Size(183, 21);
            this.TextBox_Desc.TabIndex = 1;
            // 
            // TextBox_Cmd
            // 
            this.TextBox_Cmd.Location = new System.Drawing.Point(101, 50);
            this.TextBox_Cmd.Name = "TextBox_Cmd";
            this.TextBox_Cmd.Size = new System.Drawing.Size(131, 21);
            this.TextBox_Cmd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "실행할 명령어 :";
            // 
            // Button_Close
            // 
            this.Button_Close.Location = new System.Drawing.Point(169, 365);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(88, 23);
            this.Button_Close.TabIndex = 9;
            this.Button_Close.Text = "닫기";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Form_AddSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 401);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_AddSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Minute)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericUpDown_Hour;
        private System.Windows.Forms.MonthCalendar MonthCalendar_Cal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Minute;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextBox_Desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Cmd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Close;
    }
}