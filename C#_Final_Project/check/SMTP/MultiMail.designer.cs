
namespace check
{
    partial class MultiMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiMail));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.bodyText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.addAttechment = new System.Windows.Forms.Button();
            this.attechmentTextBox = new System.Windows.Forms.TextBox();
            this.removeComboBox = new System.Windows.Forms.ComboBox();
            this.removeAttechment = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mass Email sender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Body:";
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(60, 76);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(187, 20);
            this.TitleText.TabIndex = 3;
            // 
            // bodyText
            // 
            this.bodyText.ForeColor = System.Drawing.Color.Red;
            this.bodyText.Location = new System.Drawing.Point(16, 122);
            this.bodyText.Multiline = true;
            this.bodyText.Name = "bodyText";
            this.bodyText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bodyText.Size = new System.Drawing.Size(381, 207);
            this.bodyText.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::check.Properties.Resources.Mail_Send;
            this.button1.Location = new System.Drawing.Point(298, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 54);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = global::check.Properties.Resources.Mail_BackButton;
            this.backButton.Location = new System.Drawing.Point(3, 1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(105, 54);
            this.backButton.TabIndex = 6;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addAttechment
            // 
            this.addAttechment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAttechment.Image = global::check.Properties.Resources.Empty;
            this.addAttechment.Location = new System.Drawing.Point(475, 99);
            this.addAttechment.Name = "addAttechment";
            this.addAttechment.Size = new System.Drawing.Size(82, 31);
            this.addAttechment.TabIndex = 14;
            this.addAttechment.Text = "Browse";
            this.addAttechment.UseVisualStyleBackColor = true;
            this.addAttechment.Click += new System.EventHandler(this.addAttechment_Click);
            // 
            // attechmentTextBox
            // 
            this.attechmentTextBox.ForeColor = System.Drawing.Color.Red;
            this.attechmentTextBox.Location = new System.Drawing.Point(430, 203);
            this.attechmentTextBox.Multiline = true;
            this.attechmentTextBox.Name = "attechmentTextBox";
            this.attechmentTextBox.ReadOnly = true;
            this.attechmentTextBox.Size = new System.Drawing.Size(296, 126);
            this.attechmentTextBox.TabIndex = 16;
            // 
            // removeComboBox
            // 
            this.removeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.removeComboBox.FormattingEnabled = true;
            this.removeComboBox.Location = new System.Drawing.Point(505, 141);
            this.removeComboBox.Name = "removeComboBox";
            this.removeComboBox.Size = new System.Drawing.Size(114, 21);
            this.removeComboBox.TabIndex = 18;
            this.removeComboBox.SelectedIndexChanged += new System.EventHandler(this.removeComboBox_SelectedIndexChanged);
            // 
            // removeAttechment
            // 
            this.removeAttechment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAttechment.Image = global::check.Properties.Resources.Empty;
            this.removeAttechment.Location = new System.Drawing.Point(625, 139);
            this.removeAttechment.Name = "removeAttechment";
            this.removeAttechment.Size = new System.Drawing.Size(82, 34);
            this.removeAttechment.TabIndex = 17;
            this.removeAttechment.Text = "Remove";
            this.removeAttechment.UseVisualStyleBackColor = true;
            this.removeAttechment.Click += new System.EventHandler(this.removeAttechment_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(427, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Attachment Functions:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(427, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Add:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(427, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Remove:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(427, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Attachment List:";
            // 
            // MultiMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(745, 402);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeComboBox);
            this.Controls.Add(this.removeAttechment);
            this.Controls.Add(this.attechmentTextBox);
            this.Controls.Add(this.addAttechment);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bodyText);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultiMail";
            this.Text = "MultiMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.TextBox bodyText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button addAttechment;
        private System.Windows.Forms.TextBox attechmentTextBox;
        private System.Windows.Forms.ComboBox removeComboBox;
        private System.Windows.Forms.Button removeAttechment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}