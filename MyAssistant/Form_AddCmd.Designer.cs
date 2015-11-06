namespace MyAssistant
{
    partial class Form_AddCmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddCmd));
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_CmdName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox_ExitProgram = new System.Windows.Forms.TextBox();
            this.RadioButton_ExitProgram = new System.Windows.Forms.RadioButton();
            this.TextBox_SaySentence = new System.Windows.Forms.TextBox();
            this.RadioButton_Say = new System.Windows.Forms.RadioButton();
            this.TextBox_ProgramArg = new System.Windows.Forms.TextBox();
            this.RadioButton_ShowAll = new System.Windows.Forms.RadioButton();
            this.RadioButton_Hide_Top = new System.Windows.Forms.RadioButton();
            this.RadioButton_Max_PrevMini = new System.Windows.Forms.RadioButton();
            this.RadioButton_Mini_Top = new System.Windows.Forms.RadioButton();
            this.RadioButton_ExitTopProgram = new System.Windows.Forms.RadioButton();
            this.TextBox_RunProgramPath = new System.Windows.Forms.TextBox();
            this.RadioButton_RunProgram = new System.Windows.Forms.RadioButton();
            this.RadioButton_StopAssistant = new System.Windows.Forms.RadioButton();
            this.RadioButton_RunAssistant = new System.Windows.Forms.RadioButton();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.RadioButton_KeyboardInput = new System.Windows.Forms.RadioButton();
            this.CheckBox_Key_Ctrl = new System.Windows.Forms.CheckBox();
            this.Label_Key = new System.Windows.Forms.Label();
            this.CheckBox_Key_Shift = new System.Windows.Forms.CheckBox();
            this.CheckBox_Key_Alt = new System.Windows.Forms.CheckBox();
            this.RadioButton_Typing = new System.Windows.Forms.RadioButton();
            this.TextBox_TypingStr = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "명령어 :";
            // 
            // TextBox_CmdName
            // 
            this.TextBox_CmdName.Location = new System.Drawing.Point(67, 6);
            this.TextBox_CmdName.Name = "TextBox_CmdName";
            this.TextBox_CmdName.Size = new System.Drawing.Size(205, 21);
            this.TextBox_CmdName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBox_TypingStr);
            this.groupBox1.Controls.Add(this.RadioButton_Typing);
            this.groupBox1.Controls.Add(this.CheckBox_Key_Alt);
            this.groupBox1.Controls.Add(this.CheckBox_Key_Shift);
            this.groupBox1.Controls.Add(this.Label_Key);
            this.groupBox1.Controls.Add(this.CheckBox_Key_Ctrl);
            this.groupBox1.Controls.Add(this.RadioButton_KeyboardInput);
            this.groupBox1.Controls.Add(this.TextBox_ExitProgram);
            this.groupBox1.Controls.Add(this.RadioButton_ExitProgram);
            this.groupBox1.Controls.Add(this.TextBox_SaySentence);
            this.groupBox1.Controls.Add(this.RadioButton_Say);
            this.groupBox1.Controls.Add(this.TextBox_ProgramArg);
            this.groupBox1.Controls.Add(this.RadioButton_ShowAll);
            this.groupBox1.Controls.Add(this.RadioButton_Hide_Top);
            this.groupBox1.Controls.Add(this.RadioButton_Max_PrevMini);
            this.groupBox1.Controls.Add(this.RadioButton_Mini_Top);
            this.groupBox1.Controls.Add(this.RadioButton_ExitTopProgram);
            this.groupBox1.Controls.Add(this.TextBox_RunProgramPath);
            this.groupBox1.Controls.Add(this.RadioButton_RunProgram);
            this.groupBox1.Controls.Add(this.RadioButton_StopAssistant);
            this.groupBox1.Controls.Add(this.RadioButton_RunAssistant);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 356);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "작업";
            // 
            // TextBox_ExitProgram
            // 
            this.TextBox_ExitProgram.Enabled = false;
            this.TextBox_ExitProgram.Location = new System.Drawing.Point(111, 116);
            this.TextBox_ExitProgram.Name = "TextBox_ExitProgram";
            this.TextBox_ExitProgram.Size = new System.Drawing.Size(143, 21);
            this.TextBox_ExitProgram.TabIndex = 6;
            this.TextBox_ExitProgram.Text = "프로세스 이름";
            // 
            // RadioButton_ExitProgram
            // 
            this.RadioButton_ExitProgram.AutoSize = true;
            this.RadioButton_ExitProgram.Location = new System.Drawing.Point(6, 117);
            this.RadioButton_ExitProgram.Name = "RadioButton_ExitProgram";
            this.RadioButton_ExitProgram.Size = new System.Drawing.Size(99, 16);
            this.RadioButton_ExitProgram.TabIndex = 5;
            this.RadioButton_ExitProgram.TabStop = true;
            this.RadioButton_ExitProgram.Text = "프로그램 종료";
            this.RadioButton_ExitProgram.UseVisualStyleBackColor = true;
            this.RadioButton_ExitProgram.CheckedChanged += new System.EventHandler(this.RadioButton_ExitProgram_CheckedChanged);
            // 
            // TextBox_SaySentence
            // 
            this.TextBox_SaySentence.Enabled = false;
            this.TextBox_SaySentence.Location = new System.Drawing.Point(71, 252);
            this.TextBox_SaySentence.Name = "TextBox_SaySentence";
            this.TextBox_SaySentence.Size = new System.Drawing.Size(183, 21);
            this.TextBox_SaySentence.TabIndex = 13;
            this.TextBox_SaySentence.Text = "문장";
            // 
            // RadioButton_Say
            // 
            this.RadioButton_Say.AutoSize = true;
            this.RadioButton_Say.Location = new System.Drawing.Point(6, 253);
            this.RadioButton_Say.Name = "RadioButton_Say";
            this.RadioButton_Say.Size = new System.Drawing.Size(59, 16);
            this.RadioButton_Say.TabIndex = 12;
            this.RadioButton_Say.TabStop = true;
            this.RadioButton_Say.Text = "말하기";
            this.RadioButton_Say.UseVisualStyleBackColor = true;
            this.RadioButton_Say.CheckedChanged += new System.EventHandler(this.RadioButton_Say_CheckedChanged);
            // 
            // TextBox_ProgramArg
            // 
            this.TextBox_ProgramArg.Enabled = false;
            this.TextBox_ProgramArg.Location = new System.Drawing.Point(111, 90);
            this.TextBox_ProgramArg.Name = "TextBox_ProgramArg";
            this.TextBox_ProgramArg.Size = new System.Drawing.Size(143, 21);
            this.TextBox_ProgramArg.TabIndex = 4;
            this.TextBox_ProgramArg.Text = "입력정보";
            // 
            // RadioButton_ShowAll
            // 
            this.RadioButton_ShowAll.AutoSize = true;
            this.RadioButton_ShowAll.Location = new System.Drawing.Point(6, 231);
            this.RadioButton_ShowAll.Name = "RadioButton_ShowAll";
            this.RadioButton_ShowAll.Size = new System.Drawing.Size(131, 16);
            this.RadioButton_ShowAll.TabIndex = 11;
            this.RadioButton_ShowAll.TabStop = true;
            this.RadioButton_ShowAll.Text = "숨겼던 창 모두 열기";
            this.RadioButton_ShowAll.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Hide_Top
            // 
            this.RadioButton_Hide_Top.AutoSize = true;
            this.RadioButton_Hide_Top.Location = new System.Drawing.Point(6, 209);
            this.RadioButton_Hide_Top.Name = "RadioButton_Hide_Top";
            this.RadioButton_Hide_Top.Size = new System.Drawing.Size(115, 16);
            this.RadioButton_Hide_Top.TabIndex = 10;
            this.RadioButton_Hide_Top.TabStop = true;
            this.RadioButton_Hide_Top.Text = "최상위 창 숨기기";
            this.RadioButton_Hide_Top.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Max_PrevMini
            // 
            this.RadioButton_Max_PrevMini.AutoSize = true;
            this.RadioButton_Max_PrevMini.Location = new System.Drawing.Point(6, 187);
            this.RadioButton_Max_PrevMini.Name = "RadioButton_Max_PrevMini";
            this.RadioButton_Max_PrevMini.Size = new System.Drawing.Size(115, 16);
            this.RadioButton_Max_PrevMini.TabIndex = 9;
            this.RadioButton_Max_PrevMini.TabStop = true;
            this.RadioButton_Max_PrevMini.Text = "내렸던 창 최대화";
            this.RadioButton_Max_PrevMini.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Mini_Top
            // 
            this.RadioButton_Mini_Top.AutoSize = true;
            this.RadioButton_Mini_Top.Location = new System.Drawing.Point(6, 165);
            this.RadioButton_Mini_Top.Name = "RadioButton_Mini_Top";
            this.RadioButton_Mini_Top.Size = new System.Drawing.Size(115, 16);
            this.RadioButton_Mini_Top.TabIndex = 8;
            this.RadioButton_Mini_Top.TabStop = true;
            this.RadioButton_Mini_Top.Text = "최상위 창 최소화";
            this.RadioButton_Mini_Top.UseVisualStyleBackColor = true;
            // 
            // RadioButton_ExitTopProgram
            // 
            this.RadioButton_ExitTopProgram.AutoSize = true;
            this.RadioButton_ExitTopProgram.Location = new System.Drawing.Point(6, 143);
            this.RadioButton_ExitTopProgram.Name = "RadioButton_ExitTopProgram";
            this.RadioButton_ExitTopProgram.Size = new System.Drawing.Size(103, 16);
            this.RadioButton_ExitTopProgram.TabIndex = 7;
            this.RadioButton_ExitTopProgram.TabStop = true;
            this.RadioButton_ExitTopProgram.Text = "최상위 창 종료";
            this.RadioButton_ExitTopProgram.UseVisualStyleBackColor = true;
            // 
            // TextBox_RunProgramPath
            // 
            this.TextBox_RunProgramPath.Enabled = false;
            this.TextBox_RunProgramPath.Location = new System.Drawing.Point(111, 63);
            this.TextBox_RunProgramPath.Name = "TextBox_RunProgramPath";
            this.TextBox_RunProgramPath.Size = new System.Drawing.Size(143, 21);
            this.TextBox_RunProgramPath.TabIndex = 3;
            this.TextBox_RunProgramPath.Text = "경로";
            // 
            // RadioButton_RunProgram
            // 
            this.RadioButton_RunProgram.AutoSize = true;
            this.RadioButton_RunProgram.Location = new System.Drawing.Point(6, 64);
            this.RadioButton_RunProgram.Name = "RadioButton_RunProgram";
            this.RadioButton_RunProgram.Size = new System.Drawing.Size(99, 16);
            this.RadioButton_RunProgram.TabIndex = 2;
            this.RadioButton_RunProgram.TabStop = true;
            this.RadioButton_RunProgram.Text = "프로그램 실행";
            this.RadioButton_RunProgram.UseVisualStyleBackColor = true;
            this.RadioButton_RunProgram.CheckedChanged += new System.EventHandler(this.RadioButton_RunProgram_CheckedChanged);
            // 
            // RadioButton_StopAssistant
            // 
            this.RadioButton_StopAssistant.AutoSize = true;
            this.RadioButton_StopAssistant.Location = new System.Drawing.Point(6, 42);
            this.RadioButton_StopAssistant.Name = "RadioButton_StopAssistant";
            this.RadioButton_StopAssistant.Size = new System.Drawing.Size(75, 16);
            this.RadioButton_StopAssistant.TabIndex = 1;
            this.RadioButton_StopAssistant.TabStop = true;
            this.RadioButton_StopAssistant.Text = "비서 정지";
            this.RadioButton_StopAssistant.UseVisualStyleBackColor = true;
            // 
            // RadioButton_RunAssistant
            // 
            this.RadioButton_RunAssistant.AutoSize = true;
            this.RadioButton_RunAssistant.Location = new System.Drawing.Point(6, 20);
            this.RadioButton_RunAssistant.Name = "RadioButton_RunAssistant";
            this.RadioButton_RunAssistant.Size = new System.Drawing.Size(75, 16);
            this.RadioButton_RunAssistant.TabIndex = 0;
            this.RadioButton_RunAssistant.TabStop = true;
            this.RadioButton_RunAssistant.Text = "비서 실행";
            this.RadioButton_RunAssistant.UseVisualStyleBackColor = true;
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(12, 409);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(106, 25);
            this.Button_Add.TabIndex = 3;
            this.Button_Add.Text = "추가";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Location = new System.Drawing.Point(166, 409);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(106, 25);
            this.Button_Exit.TabIndex = 4;
            this.Button_Exit.Text = "닫기";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // RadioButton_KeyboardInput
            // 
            this.RadioButton_KeyboardInput.AutoSize = true;
            this.RadioButton_KeyboardInput.Location = new System.Drawing.Point(6, 279);
            this.RadioButton_KeyboardInput.Name = "RadioButton_KeyboardInput";
            this.RadioButton_KeyboardInput.Size = new System.Drawing.Size(87, 16);
            this.RadioButton_KeyboardInput.TabIndex = 14;
            this.RadioButton_KeyboardInput.TabStop = true;
            this.RadioButton_KeyboardInput.Text = "키보드 입력";
            this.RadioButton_KeyboardInput.UseVisualStyleBackColor = true;
            this.RadioButton_KeyboardInput.CheckedChanged += new System.EventHandler(this.RadioButton_KeyboardInput_CheckedChanged);
            // 
            // CheckBox_Key_Ctrl
            // 
            this.CheckBox_Key_Ctrl.AutoSize = true;
            this.CheckBox_Key_Ctrl.Enabled = false;
            this.CheckBox_Key_Ctrl.Location = new System.Drawing.Point(83, 301);
            this.CheckBox_Key_Ctrl.Name = "CheckBox_Key_Ctrl";
            this.CheckBox_Key_Ctrl.Size = new System.Drawing.Size(53, 16);
            this.CheckBox_Key_Ctrl.TabIndex = 15;
            this.CheckBox_Key_Ctrl.Text = "+ Ctrl";
            this.CheckBox_Key_Ctrl.UseVisualStyleBackColor = true;
            // 
            // Label_Key
            // 
            this.Label_Key.AutoSize = true;
            this.Label_Key.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Label_Key.Enabled = false;
            this.Label_Key.Location = new System.Drawing.Point(94, 281);
            this.Label_Key.Name = "Label_Key";
            this.Label_Key.Size = new System.Drawing.Size(91, 12);
            this.Label_Key.TabIndex = 16;
            this.Label_Key.Text = "(키를 누르세요)";
            this.Label_Key.Click += new System.EventHandler(this.Label_Key_Click);
            // 
            // CheckBox_Key_Shift
            // 
            this.CheckBox_Key_Shift.AutoSize = true;
            this.CheckBox_Key_Shift.Enabled = false;
            this.CheckBox_Key_Shift.Location = new System.Drawing.Point(142, 301);
            this.CheckBox_Key_Shift.Name = "CheckBox_Key_Shift";
            this.CheckBox_Key_Shift.Size = new System.Drawing.Size(58, 16);
            this.CheckBox_Key_Shift.TabIndex = 17;
            this.CheckBox_Key_Shift.Text = "+ Shift";
            this.CheckBox_Key_Shift.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Key_Alt
            // 
            this.CheckBox_Key_Alt.AutoSize = true;
            this.CheckBox_Key_Alt.Enabled = false;
            this.CheckBox_Key_Alt.Location = new System.Drawing.Point(206, 301);
            this.CheckBox_Key_Alt.Name = "CheckBox_Key_Alt";
            this.CheckBox_Key_Alt.Size = new System.Drawing.Size(48, 16);
            this.CheckBox_Key_Alt.TabIndex = 18;
            this.CheckBox_Key_Alt.Text = "+ Alt";
            this.CheckBox_Key_Alt.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Typing
            // 
            this.RadioButton_Typing.AutoSize = true;
            this.RadioButton_Typing.Location = new System.Drawing.Point(6, 323);
            this.RadioButton_Typing.Name = "RadioButton_Typing";
            this.RadioButton_Typing.Size = new System.Drawing.Size(99, 16);
            this.RadioButton_Typing.TabIndex = 19;
            this.RadioButton_Typing.TabStop = true;
            this.RadioButton_Typing.Text = "키보드 타이핑";
            this.RadioButton_Typing.UseVisualStyleBackColor = true;
            this.RadioButton_Typing.CheckedChanged += new System.EventHandler(this.RadioButton_Typing_CheckedChanged);
            // 
            // TextBox_TypingStr
            // 
            this.TextBox_TypingStr.Enabled = false;
            this.TextBox_TypingStr.Location = new System.Drawing.Point(111, 322);
            this.TextBox_TypingStr.Name = "TextBox_TypingStr";
            this.TextBox_TypingStr.Size = new System.Drawing.Size(143, 21);
            this.TextBox_TypingStr.TabIndex = 20;
            this.TextBox_TypingStr.Text = "문장";
            // 
            // Form_AddCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 446);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TextBox_CmdName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_AddCmd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Command";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_CmdName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.RadioButton RadioButton_RunAssistant;
        private System.Windows.Forms.RadioButton RadioButton_StopAssistant;
        private System.Windows.Forms.TextBox TextBox_RunProgramPath;
        private System.Windows.Forms.RadioButton RadioButton_RunProgram;
        private System.Windows.Forms.RadioButton RadioButton_ExitTopProgram;
        private System.Windows.Forms.RadioButton RadioButton_Mini_Top;
        private System.Windows.Forms.RadioButton RadioButton_Max_PrevMini;
        private System.Windows.Forms.RadioButton RadioButton_ShowAll;
        private System.Windows.Forms.RadioButton RadioButton_Hide_Top;
        private System.Windows.Forms.TextBox TextBox_ProgramArg;
        private System.Windows.Forms.RadioButton RadioButton_Say;
        private System.Windows.Forms.TextBox TextBox_SaySentence;
        private System.Windows.Forms.TextBox TextBox_ExitProgram;
        private System.Windows.Forms.RadioButton RadioButton_ExitProgram;
        private System.Windows.Forms.RadioButton RadioButton_KeyboardInput;
        private System.Windows.Forms.CheckBox CheckBox_Key_Alt;
        private System.Windows.Forms.CheckBox CheckBox_Key_Shift;
        private System.Windows.Forms.Label Label_Key;
        private System.Windows.Forms.CheckBox CheckBox_Key_Ctrl;
        private System.Windows.Forms.TextBox TextBox_TypingStr;
        private System.Windows.Forms.RadioButton RadioButton_Typing;
    }
}