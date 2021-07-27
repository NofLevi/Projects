
namespace check
{
    partial class SMTPSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMTPSetup));
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.VerificationCodeLabel = new System.Windows.Forms.Label();
            this.ConfirmSMTPTextBox = new System.Windows.Forms.TextBox();
            this.SMTPVerificationButton = new System.Windows.Forms.Button();
            this.EmailPassword = new System.Windows.Forms.TextBox();
            this.EmailIDTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SkipButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(271, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "@";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gmail.com",
            "Yahoo.com",
            "Hotmail.com"});
            this.comboBox1.Location = new System.Drawing.Point(295, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // VerificationCodeLabel
            // 
            this.VerificationCodeLabel.AutoSize = true;
            this.VerificationCodeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerificationCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificationCodeLabel.ForeColor = System.Drawing.Color.White;
            this.VerificationCodeLabel.Location = new System.Drawing.Point(10, 154);
            this.VerificationCodeLabel.Name = "VerificationCodeLabel";
            this.VerificationCodeLabel.Size = new System.Drawing.Size(98, 16);
            this.VerificationCodeLabel.TabIndex = 33;
            this.VerificationCodeLabel.Text = "SMTP Verify:";
            this.VerificationCodeLabel.Visible = false;
            // 
            // ConfirmSMTPTextBox
            // 
            this.ConfirmSMTPTextBox.Location = new System.Drawing.Point(164, 154);
            this.ConfirmSMTPTextBox.Name = "ConfirmSMTPTextBox";
            this.ConfirmSMTPTextBox.Size = new System.Drawing.Size(100, 20);
            this.ConfirmSMTPTextBox.TabIndex = 32;
            this.ConfirmSMTPTextBox.Visible = false;
            // 
            // SMTPVerificationButton
            // 
            this.SMTPVerificationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SMTPVerificationButton.Image = global::check.Properties.Resources.SMTPSetupManager_SendMail;
            this.SMTPVerificationButton.Location = new System.Drawing.Point(295, 120);
            this.SMTPVerificationButton.Name = "SMTPVerificationButton";
            this.SMTPVerificationButton.Size = new System.Drawing.Size(85, 33);
            this.SMTPVerificationButton.TabIndex = 30;
            this.SMTPVerificationButton.UseVisualStyleBackColor = true;
            this.SMTPVerificationButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EmailVerificationButton_MouseClick);
            // 
            // EmailPassword
            // 
            this.EmailPassword.Location = new System.Drawing.Point(164, 120);
            this.EmailPassword.Name = "EmailPassword";
            this.EmailPassword.Size = new System.Drawing.Size(100, 20);
            this.EmailPassword.TabIndex = 29;
            // 
            // EmailIDTextBox
            // 
            this.EmailIDTextBox.Location = new System.Drawing.Point(164, 88);
            this.EmailIDTextBox.Name = "EmailIDTextBox";
            this.EmailIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmailIDTextBox.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Secure password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Email Settings:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Email ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 36;
            this.label1.Text = "SMTP Setup Manager:";
            // 
            // SkipButton
            // 
            this.SkipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkipButton.Image = global::check.Properties.Resources.SMTPSetupManager_SkipSMTP;
            this.SkipButton.Location = new System.Drawing.Point(295, 220);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(137, 29);
            this.SkipButton.TabIndex = 37;
            this.SkipButton.UseVisualStyleBackColor = true;
            this.SkipButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SkipButton_MouseClick);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Image = global::check.Properties.Resources.SMTPSetupManager_Confirm;
            this.ConfirmButton.Location = new System.Drawing.Point(12, 184);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(127, 69);
            this.ConfirmButton.TabIndex = 38;
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConfirmButton_MouseClick);
            // 
            // SMTPSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(444, 261);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.SkipButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.VerificationCodeLabel);
            this.Controls.Add(this.ConfirmSMTPTextBox);
            this.Controls.Add(this.SMTPVerificationButton);
            this.Controls.Add(this.EmailPassword);
            this.Controls.Add(this.EmailIDTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SMTPSetup";
            this.Text = "SMTP Setup Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label VerificationCodeLabel;
        private System.Windows.Forms.TextBox ConfirmSMTPTextBox;
        private System.Windows.Forms.Button SMTPVerificationButton;
        private System.Windows.Forms.TextBox EmailPassword;
        private System.Windows.Forms.TextBox EmailIDTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SkipButton;
        private System.Windows.Forms.Button ConfirmButton;
    }
}