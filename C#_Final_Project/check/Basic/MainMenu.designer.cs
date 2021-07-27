
namespace check
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.UserNameLable = new System.Windows.Forms.Label();
            this.Permissionlevel = new System.Windows.Forms.Label();
            this.EmailFormOpener = new System.Windows.Forms.Button();
            this.TableButton = new System.Windows.Forms.Button();
            this.AdminSettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameLable
            // 
            this.UserNameLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UserNameLable.ForeColor = System.Drawing.Color.White;
            this.UserNameLable.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.UserNameLable.Location = new System.Drawing.Point(4, 32);
            this.UserNameLable.Name = "UserNameLable";
            this.UserNameLable.Size = new System.Drawing.Size(512, 67);
            this.UserNameLable.TabIndex = 0;
            this.UserNameLable.Text = "Welcome ERROR";
            this.UserNameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Permissionlevel
            // 
            this.Permissionlevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Permissionlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Permissionlevel.ForeColor = System.Drawing.Color.White;
            this.Permissionlevel.Location = new System.Drawing.Point(0, 9);
            this.Permissionlevel.Name = "Permissionlevel";
            this.Permissionlevel.Size = new System.Drawing.Size(167, 23);
            this.Permissionlevel.TabIndex = 1;
            this.Permissionlevel.Text = "Permission-level:";
            // 
            // EmailFormOpener
            // 
            this.EmailFormOpener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmailFormOpener.Image = global::check.Properties.Resources.MainMenu_EmailsButton;
            this.EmailFormOpener.Location = new System.Drawing.Point(129, 190);
            this.EmailFormOpener.Name = "EmailFormOpener";
            this.EmailFormOpener.Size = new System.Drawing.Size(246, 86);
            this.EmailFormOpener.TabIndex = 2;
            this.EmailFormOpener.UseVisualStyleBackColor = true;
            this.EmailFormOpener.Click += new System.EventHandler(this.EmailFormOpener_Click);
            // 
            // TableButton
            // 
            this.TableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableButton.Image = global::check.Properties.Resources.MainMenu_TableButton;
            this.TableButton.Location = new System.Drawing.Point(129, 102);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(246, 82);
            this.TableButton.TabIndex = 3;
            this.TableButton.UseVisualStyleBackColor = true;
            this.TableButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TableButton_MouseClick);
            // 
            // AdminSettingsButton
            // 
            this.AdminSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminSettingsButton.Image = global::check.Properties.Resources.MainMenu_AdminSettings;
            this.AdminSettingsButton.Location = new System.Drawing.Point(129, 282);
            this.AdminSettingsButton.Name = "AdminSettingsButton";
            this.AdminSettingsButton.Size = new System.Drawing.Size(246, 87);
            this.AdminSettingsButton.TabIndex = 4;
            this.AdminSettingsButton.UseVisualStyleBackColor = true;
            this.AdminSettingsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AdminSettingsButton_MouseClick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(523, 367);
            this.Controls.Add(this.AdminSettingsButton);
            this.Controls.Add(this.TableButton);
            this.Controls.Add(this.EmailFormOpener);
            this.Controls.Add(this.Permissionlevel);
            this.Controls.Add(this.UserNameLable);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.RightToLeftLayout = true;
            this.Text = "MainMenu";
            this.TextChanged += new System.EventHandler(this.MainMenu_TextChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UserNameLable;
        private System.Windows.Forms.Label Permissionlevel;
        private System.Windows.Forms.Button EmailFormOpener;
        private System.Windows.Forms.Button TableButton;
        private System.Windows.Forms.Button AdminSettingsButton;
    }
}