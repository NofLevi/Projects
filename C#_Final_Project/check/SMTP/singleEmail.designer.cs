
namespace check
{
    partial class singleEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(singleEmail));
            this.label2 = new System.Windows.Forms.Label();
            this.Email_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titlebox = new System.Windows.Forms.TextBox();
            this.bodybox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.attechmentsLabel = new System.Windows.Forms.Label();
            this.attechmentTextBox = new System.Windows.Forms.TextBox();
            this.addAttechment = new System.Windows.Forms.Button();
            this.removeAttechment = new System.Windows.Forms.Button();
            this.removeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = " Email:";
            // 
            // Email_textbox
            // 
            this.Email_textbox.Location = new System.Drawing.Point(71, 69);
            this.Email_textbox.Name = "Email_textbox";
            this.Email_textbox.Size = new System.Drawing.Size(198, 20);
            this.Email_textbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Body: ";
            // 
            // titlebox
            // 
            this.titlebox.Location = new System.Drawing.Point(71, 110);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(301, 20);
            this.titlebox.TabIndex = 6;
            // 
            // bodybox
            // 
            this.bodybox.ForeColor = System.Drawing.Color.Red;
            this.bodybox.Location = new System.Drawing.Point(3, 163);
            this.bodybox.Multiline = true;
            this.bodybox.Name = "bodybox";
            this.bodybox.Size = new System.Drawing.Size(493, 244);
            this.bodybox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::check.Properties.Resources.Mail_Send;
            this.button1.Location = new System.Drawing.Point(371, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 55);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(367, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Single Mail ";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::check.Properties.Resources.Mail_BackButton;
            this.button2.Location = new System.Drawing.Point(3, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 62);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // attechmentsLabel
            // 
            this.attechmentsLabel.AutoSize = true;
            this.attechmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.attechmentsLabel.ForeColor = System.Drawing.Color.White;
            this.attechmentsLabel.Location = new System.Drawing.Point(520, 163);
            this.attechmentsLabel.Name = "attechmentsLabel";
            this.attechmentsLabel.Size = new System.Drawing.Size(137, 24);
            this.attechmentsLabel.TabIndex = 11;
            this.attechmentsLabel.Text = "attechments list";
            // 
            // attechmentTextBox
            // 
            this.attechmentTextBox.ForeColor = System.Drawing.Color.Red;
            this.attechmentTextBox.Location = new System.Drawing.Point(524, 190);
            this.attechmentTextBox.Multiline = true;
            this.attechmentTextBox.Name = "attechmentTextBox";
            this.attechmentTextBox.ReadOnly = true;
            this.attechmentTextBox.Size = new System.Drawing.Size(362, 217);
            this.attechmentTextBox.TabIndex = 12;
            // 
            // addAttechment
            // 
            this.addAttechment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAttechment.Image = global::check.Properties.Resources.Empty;
            this.addAttechment.Location = new System.Drawing.Point(568, 87);
            this.addAttechment.Name = "addAttechment";
            this.addAttechment.Size = new System.Drawing.Size(89, 28);
            this.addAttechment.TabIndex = 13;
            this.addAttechment.Text = "Browse";
            this.addAttechment.UseVisualStyleBackColor = true;
            this.addAttechment.Click += new System.EventHandler(this.addAttechment_Click);
            // 
            // removeAttechment
            // 
            this.removeAttechment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAttechment.Image = global::check.Properties.Resources.Empty;
            this.removeAttechment.Location = new System.Drawing.Point(725, 122);
            this.removeAttechment.Name = "removeAttechment";
            this.removeAttechment.Size = new System.Drawing.Size(81, 33);
            this.removeAttechment.TabIndex = 14;
            this.removeAttechment.Text = "Remove";
            this.removeAttechment.UseVisualStyleBackColor = true;
            this.removeAttechment.Click += new System.EventHandler(this.removeAttechment_Click);
            // 
            // removeComboBox
            // 
            this.removeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.removeComboBox.FormattingEnabled = true;
            this.removeComboBox.Location = new System.Drawing.Point(598, 131);
            this.removeComboBox.Name = "removeComboBox";
            this.removeComboBox.Size = new System.Drawing.Size(114, 21);
            this.removeComboBox.TabIndex = 15;
            this.removeComboBox.SelectedIndexChanged += new System.EventHandler(this.removeComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(520, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Attachment Functions:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(520, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Add:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(520, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Remove:";
            // 
            // singleEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(898, 477);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.removeComboBox);
            this.Controls.Add(this.removeAttechment);
            this.Controls.Add(this.addAttechment);
            this.Controls.Add(this.attechmentTextBox);
            this.Controls.Add(this.attechmentsLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bodybox);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email_textbox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "singleEmail";
            this.Text = "singleEmail";
            this.Load += new System.EventHandler(this.singleEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.TextBox bodybox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label attechmentsLabel;
        private System.Windows.Forms.TextBox attechmentTextBox;
        private System.Windows.Forms.Button addAttechment;
        private System.Windows.Forms.Button removeAttechment;
        private System.Windows.Forms.ComboBox removeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}