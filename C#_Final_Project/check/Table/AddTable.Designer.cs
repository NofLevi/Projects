
namespace check
{
    partial class AddTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTable));
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.AddColumnButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.UniqueFieldLabel = new System.Windows.Forms.Label();
            this.uniquefieldcombobox = new System.Windows.Forms.ComboBox();
            this.nametextbox1 = new System.Windows.Forms.TextBox();
            this.DeleteColumnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TableNameTextBox = new System.Windows.Forms.TextBox();
            this.namelabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Image = global::check.Properties.Resources.Basic_ConfirmButton;
            this.ConfirmButton.Location = new System.Drawing.Point(93, 142);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(84, 39);
            this.ConfirmButton.TabIndex = 0;
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConfirmButton_MouseClick);
            // 
            // AddColumnButton
            // 
            this.AddColumnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddColumnButton.Image = global::check.Properties.Resources.AddTable_AddColumnButton;
            this.AddColumnButton.Location = new System.Drawing.Point(-1, 144);
            this.AddColumnButton.Name = "AddColumnButton";
            this.AddColumnButton.Size = new System.Drawing.Size(88, 35);
            this.AddColumnButton.TabIndex = 1;
            this.AddColumnButton.UseVisualStyleBackColor = true;
            this.AddColumnButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddColumnButton_MouseClick);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(83, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(95, 20);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Add Table:";
            // 
            // UniqueFieldLabel
            // 
            this.UniqueFieldLabel.AutoSize = true;
            this.UniqueFieldLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UniqueFieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniqueFieldLabel.ForeColor = System.Drawing.Color.White;
            this.UniqueFieldLabel.Location = new System.Drawing.Point(12, 83);
            this.UniqueFieldLabel.Name = "UniqueFieldLabel";
            this.UniqueFieldLabel.Size = new System.Drawing.Size(104, 16);
            this.UniqueFieldLabel.TabIndex = 3;
            this.UniqueFieldLabel.Text = "Unique Field: ";
            // 
            // uniquefieldcombobox
            // 
            this.uniquefieldcombobox.FormattingEnabled = true;
            this.uniquefieldcombobox.Items.AddRange(new object[] {
            "ID",
            "Email"});
            this.uniquefieldcombobox.Location = new System.Drawing.Point(122, 78);
            this.uniquefieldcombobox.Name = "uniquefieldcombobox";
            this.uniquefieldcombobox.Size = new System.Drawing.Size(121, 21);
            this.uniquefieldcombobox.TabIndex = 4;
            // 
            // nametextbox1
            // 
            this.nametextbox1.Location = new System.Drawing.Point(122, 112);
            this.nametextbox1.Name = "nametextbox1";
            this.nametextbox1.Size = new System.Drawing.Size(100, 20);
            this.nametextbox1.TabIndex = 7;
            // 
            // DeleteColumnButton
            // 
            this.DeleteColumnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteColumnButton.Image = global::check.Properties.Resources.AddTable_DeleteColumn;
            this.DeleteColumnButton.Location = new System.Drawing.Point(184, 144);
            this.DeleteColumnButton.Name = "DeleteColumnButton";
            this.DeleteColumnButton.Size = new System.Drawing.Size(93, 35);
            this.DeleteColumnButton.TabIndex = 11;
            this.DeleteColumnButton.UseVisualStyleBackColor = true;
            this.DeleteColumnButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DeleteColumnButton_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Table Name:";
            // 
            // TableNameTextBox
            // 
            this.TableNameTextBox.Location = new System.Drawing.Point(122, 38);
            this.TableNameTextBox.Name = "TableNameTextBox";
            this.TableNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.TableNameTextBox.TabIndex = 13;
            // 
            // namelabel1
            // 
            this.namelabel1.AutoSize = true;
            this.namelabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namelabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel1.ForeColor = System.Drawing.Color.White;
            this.namelabel1.Location = new System.Drawing.Point(12, 116);
            this.namelabel1.Name = "namelabel1";
            this.namelabel1.Size = new System.Drawing.Size(67, 16);
            this.namelabel1.TabIndex = 14;
            this.namelabel1.Text = "C.Name:";
            // 
            // AddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(284, 189);
            this.Controls.Add(this.namelabel1);
            this.Controls.Add(this.TableNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteColumnButton);
            this.Controls.Add(this.nametextbox1);
            this.Controls.Add(this.uniquefieldcombobox);
            this.Controls.Add(this.UniqueFieldLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AddColumnButton);
            this.Controls.Add(this.ConfirmButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTable";
            this.Text = "Add Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button AddColumnButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label UniqueFieldLabel;
        private System.Windows.Forms.ComboBox uniquefieldcombobox;
        private System.Windows.Forms.TextBox nametextbox1;
        private System.Windows.Forms.Button DeleteColumnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TableNameTextBox;
        private System.Windows.Forms.Label namelabel1;
    }
}