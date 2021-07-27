namespace check
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTextField = new System.Windows.Forms.TextBox();
            this.PasswordTextField = new System.Windows.Forms.TextBox();
            this.forgotPasswordLabel = new System.Windows.Forms.Label();
            this.forgotId = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Image = global::check.Properties.Resources.Login_LoginButton;
            this.LoginButton.Location = new System.Drawing.Point(90, 106);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(85, 34);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginButton_MouseClick);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.White;
            this.IDLabel.Location = new System.Drawing.Point(12, 23);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(30, 20);
            this.IDLabel.TabIndex = 1;
            this.IDLabel.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // IDTextField
            // 
            this.IDTextField.Location = new System.Drawing.Point(100, 25);
            this.IDTextField.Name = "IDTextField";
            this.IDTextField.Size = new System.Drawing.Size(146, 20);
            this.IDTextField.TabIndex = 3;
            // 
            // PasswordTextField
            // 
            this.PasswordTextField.Location = new System.Drawing.Point(100, 70);
            this.PasswordTextField.Name = "PasswordTextField";
            this.PasswordTextField.PasswordChar = '*';
            this.PasswordTextField.Size = new System.Drawing.Size(142, 20);
            this.PasswordTextField.TabIndex = 4;
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.forgotPasswordLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.forgotPasswordLabel.Location = new System.Drawing.Point(12, 187);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(129, 20);
            this.forgotPasswordLabel.TabIndex = 5;
            this.forgotPasswordLabel.Text = "Forgot Password";
            this.forgotPasswordLabel.Click += new System.EventHandler(this.forgotPasswordLabel_Click);
            this.forgotPasswordLabel.MouseLeave += new System.EventHandler(this.forgotPasswordLabel_MouseLeave);
            this.forgotPasswordLabel.MouseHover += new System.EventHandler(this.forgotPasswordLabel_MouseHover);
            // 
            // forgotId
            // 
            this.forgotId.AutoSize = true;
            this.forgotId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.forgotId.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.forgotId.Location = new System.Drawing.Point(12, 228);
            this.forgotId.Name = "forgotId";
            this.forgotId.Size = new System.Drawing.Size(77, 20);
            this.forgotId.TabIndex = 6;
            this.forgotId.Text = "Forgot ID";
            this.forgotId.Click += new System.EventHandler(this.forgotId_Click);
            this.forgotId.MouseLeave += new System.EventHandler(this.forGotId_MouseLeave);
            this.forgotId.MouseHover += new System.EventHandler(this.forGotId_MouseHover);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Logo.Location = new System.Drawing.Point(347, 25);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(250, 100);
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "*set-up smtp before using the recovering functions*";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(609, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.forgotId);
            this.Controls.Add(this.forgotPasswordLabel);
            this.Controls.Add(this.PasswordTextField);
            this.Controls.Add(this.IDTextField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.LoginButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDTextField;
        private System.Windows.Forms.TextBox PasswordTextField;
        private System.Windows.Forms.Label forgotPasswordLabel;
        private System.Windows.Forms.Label forgotId;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
    }
}