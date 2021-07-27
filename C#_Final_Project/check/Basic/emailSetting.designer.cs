
namespace check
{
    partial class emailSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emailSetting));
            this.curr_email_id = new System.Windows.Forms.Label();
            this.Curr_securePassword = new System.Windows.Forms.Label();
            this.Email_id_label = new System.Windows.Forms.Label();
            this.Email_textbox = new System.Windows.Forms.TextBox();
            this.SecurePassword_label = new System.Windows.Forms.Label();
            this.SecurePw_textbox = new System.Windows.Forms.TextBox();
            this.EmailType_comboBox = new System.Windows.Forms.ComboBox();
            this.Submit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // curr_email_id
            // 
            this.curr_email_id.AutoSize = true;
            this.curr_email_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curr_email_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.curr_email_id.ForeColor = System.Drawing.Color.White;
            this.curr_email_id.Location = new System.Drawing.Point(15, 50);
            this.curr_email_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.curr_email_id.Name = "curr_email_id";
            this.curr_email_id.Size = new System.Drawing.Size(132, 20);
            this.curr_email_id.TabIndex = 0;
            this.curr_email_id.Text = "Email in use : N/A";
            // 
            // Curr_securePassword
            // 
            this.Curr_securePassword.AutoSize = true;
            this.Curr_securePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Curr_securePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Curr_securePassword.ForeColor = System.Drawing.Color.White;
            this.Curr_securePassword.Location = new System.Drawing.Point(15, 80);
            this.Curr_securePassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Curr_securePassword.Name = "Curr_securePassword";
            this.Curr_securePassword.Size = new System.Drawing.Size(216, 20);
            this.Curr_securePassword.TabIndex = 1;
            this.Curr_securePassword.Text = "Secure password in use : N/A";
            // 
            // Email_id_label
            // 
            this.Email_id_label.AutoSize = true;
            this.Email_id_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Email_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Email_id_label.ForeColor = System.Drawing.Color.White;
            this.Email_id_label.Location = new System.Drawing.Point(15, 120);
            this.Email_id_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Email_id_label.Name = "Email_id_label";
            this.Email_id_label.Size = new System.Drawing.Size(52, 20);
            this.Email_id_label.TabIndex = 2;
            this.Email_id_label.Text = "Email:";
            // 
            // Email_textbox
            // 
            this.Email_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Email_textbox.Location = new System.Drawing.Point(157, 114);
            this.Email_textbox.Margin = new System.Windows.Forms.Padding(6);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(214, 29);
            this.Email_textbox.TabIndex = 3;
            this.Email_textbox.TextChanged += new System.EventHandler(this.Email_textbox_TextChanged);
            // 
            // SecurePassword_label
            // 
            this.SecurePassword_label.AutoSize = true;
            this.SecurePassword_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecurePassword_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SecurePassword_label.ForeColor = System.Drawing.Color.White;
            this.SecurePassword_label.Location = new System.Drawing.Point(15, 163);
            this.SecurePassword_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SecurePassword_label.Name = "SecurePassword_label";
            this.SecurePassword_label.Size = new System.Drawing.Size(137, 20);
            this.SecurePassword_label.TabIndex = 4;
            this.SecurePassword_label.Text = "Secure Password:";
            // 
            // SecurePw_textbox
            // 
            this.SecurePw_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SecurePw_textbox.Location = new System.Drawing.Point(157, 157);
            this.SecurePw_textbox.Margin = new System.Windows.Forms.Padding(6);
            this.SecurePw_textbox.Name = "SecurePw_textbox";
            this.SecurePw_textbox.PasswordChar = '*';
            this.SecurePw_textbox.Size = new System.Drawing.Size(214, 29);
            this.SecurePw_textbox.TabIndex = 5;
            this.SecurePw_textbox.TextChanged += new System.EventHandler(this.SecurePw_textbox_TextChanged);
            // 
            // EmailType_comboBox
            // 
            this.EmailType_comboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "@Gmail.com",
            "@Yahoo.com"});
            this.EmailType_comboBox.DisplayMember = "-1";
            this.EmailType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmailType_comboBox.FormattingEnabled = true;
            this.EmailType_comboBox.Items.AddRange(new object[] {
            "@Gmail.com",
            "@Yahoo.com"});
            this.EmailType_comboBox.Location = new System.Drawing.Point(383, 114);
            this.EmailType_comboBox.Margin = new System.Windows.Forms.Padding(6);
            this.EmailType_comboBox.Name = "EmailType_comboBox";
            this.EmailType_comboBox.Size = new System.Drawing.Size(161, 32);
            this.EmailType_comboBox.TabIndex = 6;
            // 
            // Submit_button
            // 
            this.Submit_button.Enabled = false;
            this.Submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_button.Image = global::check.Properties.Resources.Basic_Submit;
            this.Submit_button.Location = new System.Drawing.Point(2, 195);
            this.Submit_button.Name = "Submit_button";
            this.Submit_button.Size = new System.Drawing.Size(134, 56);
            this.Submit_button.TabIndex = 7;
            this.Submit_button.UseVisualStyleBackColor = true;
            this.Submit_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email Settings:";
            // 
            // emailSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(557, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit_button);
            this.Controls.Add(this.EmailType_comboBox);
            this.Controls.Add(this.SecurePw_textbox);
            this.Controls.Add(this.SecurePassword_label);
            this.Controls.Add(this.Email_textbox);
            this.Controls.Add(this.Email_id_label);
            this.Controls.Add(this.Curr_securePassword);
            this.Controls.Add(this.curr_email_id);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "emailSetting";
            this.Text = "emailSetting";
            this.Load += new System.EventHandler(this.emailSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label curr_email_id;
        private System.Windows.Forms.Label Curr_securePassword;
        private System.Windows.Forms.Label Email_id_label;
        private System.Windows.Forms.TextBox Email_textbox;
        private System.Windows.Forms.Label SecurePassword_label;
        private System.Windows.Forms.TextBox SecurePw_textbox;
        private System.Windows.Forms.ComboBox EmailType_comboBox;
        private System.Windows.Forms.Button Submit_button;
        private System.Windows.Forms.Label label1;
    }
}