
namespace check
{
    partial class EmailList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailList));
            this.Title = new System.Windows.Forms.Label();
            this.Email_list = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(92, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(92, 29);
            this.Title.TabIndex = 0;
            this.Title.Text = "Email list";
            // 
            // Email_list
            // 
            this.Email_list.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Email_list.ForeColor = System.Drawing.Color.White;
            this.Email_list.Location = new System.Drawing.Point(2, 31);
            this.Email_list.Name = "Email_list";
            this.Email_list.Size = new System.Drawing.Size(270, 400);
            this.Email_list.TabIndex = 1;
            this.Email_list.Text = "No Email found";
            // 
            // EmailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(284, 440);
            this.Controls.Add(this.Email_list);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmailList";
            this.Text = "EmailList";
            this.Load += new System.EventHandler(this.EmailList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Email_list;
    }
}