
namespace check
{
    partial class ChangingPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangingPasswordForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.newPassword = new System.Windows.Forms.Label();
            this.renewPassword = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.reenterTextBox = new System.Windows.Forms.TextBox();
            this.subbmitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::check.Properties.Resources.Empty;
            this.button1.Location = new System.Drawing.Point(2, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back to login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newPassword
            // 
            this.newPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newPassword.ForeColor = System.Drawing.Color.White;
            this.newPassword.Location = new System.Drawing.Point(8, 73);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(105, 23);
            this.newPassword.TabIndex = 2;
            this.newPassword.Text = "password:";
            // 
            // renewPassword
            // 
            this.renewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.renewPassword.ForeColor = System.Drawing.Color.White;
            this.renewPassword.Location = new System.Drawing.Point(8, 114);
            this.renewPassword.Name = "renewPassword";
            this.renewPassword.Size = new System.Drawing.Size(182, 23);
            this.renewPassword.TabIndex = 3;
            this.renewPassword.Text = "Re-enter password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.passwordTextBox.Location = new System.Drawing.Point(194, 70);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(164, 26);
            this.passwordTextBox.TabIndex = 4;
            // 
            // reenterTextBox
            // 
            this.reenterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.reenterTextBox.Location = new System.Drawing.Point(194, 111);
            this.reenterTextBox.Name = "reenterTextBox";
            this.reenterTextBox.PasswordChar = '*';
            this.reenterTextBox.Size = new System.Drawing.Size(164, 26);
            this.reenterTextBox.TabIndex = 5;
            // 
            // subbmitButton
            // 
            this.subbmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subbmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.subbmitButton.Image = global::check.Properties.Resources.Basic_Submit;
            this.subbmitButton.Location = new System.Drawing.Point(364, 79);
            this.subbmitButton.Name = "subbmitButton";
            this.subbmitButton.Size = new System.Drawing.Size(120, 58);
            this.subbmitButton.TabIndex = 6;
            this.subbmitButton.UseVisualStyleBackColor = true;
            this.subbmitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "please fill both boxes";
            // 
            // ChangingPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(504, 183);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subbmitButton);
            this.Controls.Add(this.reenterTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.renewPassword);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangingPasswordForm";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label newPassword;
        private System.Windows.Forms.Label renewPassword;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox reenterTextBox;
        private System.Windows.Forms.Button subbmitButton;
        private System.Windows.Forms.Label label2;
    }
}