namespace MyAssistant
{
    partial class Form_EditCmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditCmd));
            this.TextBox_CmdName = new System.Windows.Forms.TextBox();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_CmdName
            // 
            this.TextBox_CmdName.Location = new System.Drawing.Point(12, 12);
            this.TextBox_CmdName.Name = "TextBox_CmdName";
            this.TextBox_CmdName.Size = new System.Drawing.Size(207, 21);
            this.TextBox_CmdName.TabIndex = 0;
            // 
            // Button_Edit
            // 
            this.Button_Edit.Location = new System.Drawing.Point(230, 10);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(82, 23);
            this.Button_Edit.TabIndex = 1;
            this.Button_Edit.Text = "수정";
            this.Button_Edit.UseVisualStyleBackColor = true;
            this.Button_Edit.Click += new System.EventHandler(this.Button_Edit_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(318, 10);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(82, 23);
            this.Button_Cancel.TabIndex = 2;
            this.Button_Cancel.Text = "취소";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Form_EditCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 45);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.TextBox_CmdName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_EditCmd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Command";
            this.Load += new System.EventHandler(this.Form_EditCmd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_CmdName;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.Button Button_Cancel;
    }
}