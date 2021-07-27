namespace List
{
    partial class Form1
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
            this.CircleButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.ColorButton = new System.Windows.Forms.Button();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.HexaButton = new System.Windows.Forms.Button();
            this.UndoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FillCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CircleButton
            // 
            this.CircleButton.Location = new System.Drawing.Point(1254, 0);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(100, 100);
            this.CircleButton.TabIndex = 0;
            this.CircleButton.Text = "Circle";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(1254, 98);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(100, 100);
            this.RectangleButton.TabIndex = 1;
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(1254, 509);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(100, 100);
            this.ColorButton.TabIndex = 2;
            this.ColorButton.Text = "Color";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // TriangleButton
            // 
            this.TriangleButton.Location = new System.Drawing.Point(1254, 192);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(100, 100);
            this.TriangleButton.TabIndex = 3;
            this.TriangleButton.Text = "Triangle";
            this.TriangleButton.UseVisualStyleBackColor = true;
            this.TriangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(1254, 282);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(100, 100);
            this.LineButton.TabIndex = 4;
            this.LineButton.Text = "Line";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // HexaButton
            // 
            this.HexaButton.Location = new System.Drawing.Point(1254, 378);
            this.HexaButton.Name = "HexaButton";
            this.HexaButton.Size = new System.Drawing.Size(100, 100);
            this.HexaButton.TabIndex = 5;
            this.HexaButton.Text = "Hexagon";
            this.HexaButton.UseVisualStyleBackColor = true;
            this.HexaButton.Click += new System.EventHandler(this.HexaButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Location = new System.Drawing.Point(1158, 509);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(100, 100);
            this.UndoButton.TabIndex = 6;
            this.UndoButton.Text = "Undo";
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(1273, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Color";
            // 
            // FillCheckBox
            // 
            this.FillCheckBox.AutoSize = true;
            this.FillCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FillCheckBox.Location = new System.Drawing.Point(1171, 474);
            this.FillCheckBox.Name = "FillCheckBox";
            this.FillCheckBox.Size = new System.Drawing.Size(59, 29);
            this.FillCheckBox.TabIndex = 8;
            this.FillCheckBox.Text = "Fill";
            this.FillCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1357, 610);
            this.Controls.Add(this.FillCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UndoButton);
            this.Controls.Add(this.HexaButton);
            this.Controls.Add(this.LineButton);
            this.Controls.Add(this.TriangleButton);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.RectangleButton);
            this.Controls.Add(this.CircleButton);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button TriangleButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Button HexaButton;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox FillCheckBox;
    }
}