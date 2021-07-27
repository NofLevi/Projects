namespace check
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserLabel = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TableLabel = new System.Windows.Forms.Label();
            this.TablesLabel = new System.Windows.Forms.Label();
            this.FunctionsLabel = new System.Windows.Forms.Label();
            this.TableComboBox = new System.Windows.Forms.ComboBox();
            this.RowFunctionsLabel = new System.Windows.Forms.Label();
            this.ColumnsComboBox = new System.Windows.Forms.ComboBox();
            this.TableFunctionsLabel = new System.Windows.Forms.Label();
            this.RemoveTableComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TableOptionsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ExcelToMailButton = new System.Windows.Forms.Button();
            this.PDFToMailButton = new System.Windows.Forms.Button();
            this.AddProductsButton = new System.Windows.Forms.Button();
            this.SellProductButton = new System.Windows.Forms.Button();
            this.TableOptionsButton = new System.Windows.Forms.Button();
            this.PDFCheckButton = new System.Windows.Forms.Button();
            this.ExcelCheckButton = new System.Windows.Forms.Button();
            this.TableFunctionRemoveButton = new System.Windows.Forms.Button();
            this.TableFunctionAddButton = new System.Windows.Forms.Button();
            this.RowFunctitonsRemoveButton = new System.Windows.Forms.Button();
            this.RowFunctinsAddButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ColumnRemoveButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1096, 419);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(0, 51);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(52, 19);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "User:";
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.LabelUserName.ForeColor = System.Drawing.Color.White;
            this.LabelUserName.Location = new System.Drawing.Point(58, 51);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(59, 19);
            this.LabelUserName.TabIndex = 2;
            this.LabelUserName.Text = "label1";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleLabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(475, 7);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(172, 25);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Tables Window";
            this.TitleLabel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TitleLabel_MouseDoubleClick);
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.TableLabel.ForeColor = System.Drawing.Color.White;
            this.TableLabel.Location = new System.Drawing.Point(-1, 248);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(117, 23);
            this.TableLabel.TabIndex = 4;
            this.TableLabel.Text = "Parts Table";
            // 
            // TablesLabel
            // 
            this.TablesLabel.AutoSize = true;
            this.TablesLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TablesLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.TablesLabel.ForeColor = System.Drawing.Color.White;
            this.TablesLabel.Location = new System.Drawing.Point(0, 77);
            this.TablesLabel.Name = "TablesLabel";
            this.TablesLabel.Size = new System.Drawing.Size(172, 23);
            this.TablesLabel.TabIndex = 8;
            this.TablesLabel.Text = "Avaliable Tables:";
            // 
            // FunctionsLabel
            // 
            this.FunctionsLabel.AutoSize = true;
            this.FunctionsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FunctionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctionsLabel.ForeColor = System.Drawing.Color.White;
            this.FunctionsLabel.Location = new System.Drawing.Point(629, 51);
            this.FunctionsLabel.Name = "FunctionsLabel";
            this.FunctionsLabel.Size = new System.Drawing.Size(196, 24);
            this.FunctionsLabel.TabIndex = 11;
            this.FunctionsLabel.Text = "Columns Functions:";
            this.FunctionsLabel.Visible = false;
            // 
            // TableComboBox
            // 
            this.TableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableComboBox.FormattingEnabled = true;
            this.TableComboBox.Location = new System.Drawing.Point(4, 103);
            this.TableComboBox.Name = "TableComboBox";
            this.TableComboBox.Size = new System.Drawing.Size(121, 21);
            this.TableComboBox.TabIndex = 12;
            this.TableComboBox.SelectionChangeCommitted += new System.EventHandler(this.TableComboBox_SelectionChangeCommitted);
            // 
            // RowFunctionsLabel
            // 
            this.RowFunctionsLabel.AutoSize = true;
            this.RowFunctionsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RowFunctionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowFunctionsLabel.ForeColor = System.Drawing.Color.White;
            this.RowFunctionsLabel.Location = new System.Drawing.Point(917, 51);
            this.RowFunctionsLabel.Name = "RowFunctionsLabel";
            this.RowFunctionsLabel.Size = new System.Drawing.Size(155, 24);
            this.RowFunctionsLabel.TabIndex = 15;
            this.RowFunctionsLabel.Text = "Row Functions:";
            // 
            // ColumnsComboBox
            // 
            this.ColumnsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnsComboBox.FormattingEnabled = true;
            this.ColumnsComboBox.Location = new System.Drawing.Point(633, 118);
            this.ColumnsComboBox.Name = "ColumnsComboBox";
            this.ColumnsComboBox.Size = new System.Drawing.Size(121, 21);
            this.ColumnsComboBox.TabIndex = 19;
            this.ColumnsComboBox.Visible = false;
            // 
            // TableFunctionsLabel
            // 
            this.TableFunctionsLabel.AutoSize = true;
            this.TableFunctionsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableFunctionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableFunctionsLabel.ForeColor = System.Drawing.Color.White;
            this.TableFunctionsLabel.Location = new System.Drawing.Point(629, 156);
            this.TableFunctionsLabel.Name = "TableFunctionsLabel";
            this.TableFunctionsLabel.Size = new System.Drawing.Size(167, 24);
            this.TableFunctionsLabel.TabIndex = 20;
            this.TableFunctionsLabel.Text = "Table Functions:";
            this.TableFunctionsLabel.Visible = false;
            // 
            // RemoveTableComboBox
            // 
            this.RemoveTableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RemoveTableComboBox.FormattingEnabled = true;
            this.RemoveTableComboBox.Location = new System.Drawing.Point(633, 231);
            this.RemoveTableComboBox.Name = "RemoveTableComboBox";
            this.RemoveTableComboBox.Size = new System.Drawing.Size(121, 21);
            this.RemoveTableComboBox.TabIndex = 23;
            this.RemoveTableComboBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(917, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Export Table";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(913, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Excel:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1027, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "PDF:";
            this.label3.Visible = false;
            // 
            // TableOptionsLabel
            // 
            this.TableOptionsLabel.AutoSize = true;
            this.TableOptionsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableOptionsLabel.ForeColor = System.Drawing.Color.White;
            this.TableOptionsLabel.Location = new System.Drawing.Point(863, 9);
            this.TableOptionsLabel.Name = "TableOptionsLabel";
            this.TableOptionsLabel.Size = new System.Drawing.Size(147, 24);
            this.TableOptionsLabel.TabIndex = 29;
            this.TableOptionsLabel.Text = "Table Options:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 747);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Table Functions:";
            this.label4.Visible = false;
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLabel.ForeColor = System.Drawing.Color.White;
            this.ProductsLabel.Location = new System.Drawing.Point(-5, 696);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(196, 24);
            this.ProductsLabel.TabIndex = 32;
            this.ProductsLabel.Text = "Products Functions:";
            this.ProductsLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(862, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "File:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(858, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Mail:";
            this.label6.Visible = false;
            // 
            // ExcelToMailButton
            // 
            this.ExcelToMailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcelToMailButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcelToMailButton.Image")));
            this.ExcelToMailButton.Location = new System.Drawing.Point(903, 231);
            this.ExcelToMailButton.Name = "ExcelToMailButton";
            this.ExcelToMailButton.Size = new System.Drawing.Size(86, 37);
            this.ExcelToMailButton.TabIndex = 36;
            this.ExcelToMailButton.UseVisualStyleBackColor = true;
            this.ExcelToMailButton.Visible = false;
            this.ExcelToMailButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick_1);
            // 
            // PDFToMailButton
            // 
            this.PDFToMailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PDFToMailButton.Image = ((System.Drawing.Image)(resources.GetObject("PDFToMailButton.Image")));
            this.PDFToMailButton.Location = new System.Drawing.Point(1007, 231);
            this.PDFToMailButton.Name = "PDFToMailButton";
            this.PDFToMailButton.Size = new System.Drawing.Size(80, 37);
            this.PDFToMailButton.TabIndex = 35;
            this.PDFToMailButton.UseVisualStyleBackColor = true;
            this.PDFToMailButton.Visible = false;
            this.PDFToMailButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PDFToMailButton_MouseClick);
            // 
            // AddProductsButton
            // 
            this.AddProductsButton.Enabled = false;
            this.AddProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductsButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddProductsButton.Image = global::check.Properties.Resources.button_buy__1_;
            this.AddProductsButton.Location = new System.Drawing.Point(197, 693);
            this.AddProductsButton.Name = "AddProductsButton";
            this.AddProductsButton.Size = new System.Drawing.Size(89, 34);
            this.AddProductsButton.TabIndex = 34;
            this.AddProductsButton.UseVisualStyleBackColor = true;
            this.AddProductsButton.Visible = false;
            this.AddProductsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddProductsButton_MouseClick);
            // 
            // SellProductButton
            // 
            this.SellProductButton.Enabled = false;
            this.SellProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SellProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellProductButton.ForeColor = System.Drawing.Color.Transparent;
            this.SellProductButton.Image = global::check.Properties.Resources.button_sell;
            this.SellProductButton.Location = new System.Drawing.Point(292, 693);
            this.SellProductButton.Name = "SellProductButton";
            this.SellProductButton.Size = new System.Drawing.Size(89, 36);
            this.SellProductButton.TabIndex = 33;
            this.SellProductButton.UseVisualStyleBackColor = true;
            this.SellProductButton.Visible = false;
            this.SellProductButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SellProductButton_MouseClick);
            // 
            // TableOptionsButton
            // 
            this.TableOptionsButton.BackColor = System.Drawing.Color.Transparent;
            this.TableOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableOptionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableOptionsButton.ForeColor = System.Drawing.Color.White;
            this.TableOptionsButton.Image = global::check.Properties.Resources.Empty;
            this.TableOptionsButton.Location = new System.Drawing.Point(1010, 12);
            this.TableOptionsButton.Name = "TableOptionsButton";
            this.TableOptionsButton.Size = new System.Drawing.Size(77, 30);
            this.TableOptionsButton.TabIndex = 30;
            this.TableOptionsButton.Text = "Expose";
            this.TableOptionsButton.UseVisualStyleBackColor = false;
            this.TableOptionsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // PDFCheckButton
            // 
            this.PDFCheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PDFCheckButton.Image = ((System.Drawing.Image)(resources.GetObject("PDFCheckButton.Image")));
            this.PDFCheckButton.Location = new System.Drawing.Point(1007, 187);
            this.PDFCheckButton.Name = "PDFCheckButton";
            this.PDFCheckButton.Size = new System.Drawing.Size(80, 34);
            this.PDFCheckButton.TabIndex = 25;
            this.PDFCheckButton.UseVisualStyleBackColor = true;
            this.PDFCheckButton.Visible = false;
            this.PDFCheckButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PDFCheckButton_MouseClick);
            // 
            // ExcelCheckButton
            // 
            this.ExcelCheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcelCheckButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcelCheckButton.Image")));
            this.ExcelCheckButton.Location = new System.Drawing.Point(903, 189);
            this.ExcelCheckButton.Name = "ExcelCheckButton";
            this.ExcelCheckButton.Size = new System.Drawing.Size(86, 31);
            this.ExcelCheckButton.TabIndex = 24;
            this.ExcelCheckButton.UseVisualStyleBackColor = true;
            this.ExcelCheckButton.Visible = false;
            this.ExcelCheckButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExcelCheckButton_MouseClick);
            // 
            // TableFunctionRemoveButton
            // 
            this.TableFunctionRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableFunctionRemoveButton.Image = global::check.Properties.Resources.Table_RemoveButton;
            this.TableFunctionRemoveButton.Location = new System.Drawing.Point(760, 223);
            this.TableFunctionRemoveButton.Name = "TableFunctionRemoveButton";
            this.TableFunctionRemoveButton.Size = new System.Drawing.Size(86, 34);
            this.TableFunctionRemoveButton.TabIndex = 22;
            this.TableFunctionRemoveButton.UseVisualStyleBackColor = true;
            this.TableFunctionRemoveButton.Visible = false;
            this.TableFunctionRemoveButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TableFunctionRemoveButton_MouseClick);
            // 
            // TableFunctionAddButton
            // 
            this.TableFunctionAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TableFunctionAddButton.Image = global::check.Properties.Resources.Table_AddButton;
            this.TableFunctionAddButton.Location = new System.Drawing.Point(633, 183);
            this.TableFunctionAddButton.Name = "TableFunctionAddButton";
            this.TableFunctionAddButton.Size = new System.Drawing.Size(92, 33);
            this.TableFunctionAddButton.TabIndex = 21;
            this.TableFunctionAddButton.UseVisualStyleBackColor = true;
            this.TableFunctionAddButton.Visible = false;
            this.TableFunctionAddButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TableFunctionAddButton_MouseClick);
            // 
            // RowFunctitonsRemoveButton
            // 
            this.RowFunctitonsRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RowFunctitonsRemoveButton.Image = global::check.Properties.Resources.Table_RemoveButton;
            this.RowFunctitonsRemoveButton.Location = new System.Drawing.Point(999, 84);
            this.RowFunctitonsRemoveButton.Name = "RowFunctitonsRemoveButton";
            this.RowFunctitonsRemoveButton.Size = new System.Drawing.Size(85, 34);
            this.RowFunctitonsRemoveButton.TabIndex = 17;
            this.RowFunctitonsRemoveButton.UseVisualStyleBackColor = true;
            this.RowFunctitonsRemoveButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RowFunctitonsRemoveButton_MouseClick);
            // 
            // RowFunctinsAddButton
            // 
            this.RowFunctinsAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RowFunctinsAddButton.Image = global::check.Properties.Resources.Table_AddButton;
            this.RowFunctinsAddButton.Location = new System.Drawing.Point(888, 84);
            this.RowFunctinsAddButton.Name = "RowFunctinsAddButton";
            this.RowFunctinsAddButton.Size = new System.Drawing.Size(90, 34);
            this.RowFunctinsAddButton.TabIndex = 16;
            this.RowFunctinsAddButton.UseVisualStyleBackColor = true;
            this.RowFunctinsAddButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RowFunctinsAddButton_MouseClick);
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(633, 78);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(83, 34);
            this.AddButton.TabIndex = 14;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseClick_1);
            // 
            // ColumnRemoveButton
            // 
            this.ColumnRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnRemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("ColumnRemoveButton.Image")));
            this.ColumnRemoveButton.Location = new System.Drawing.Point(760, 109);
            this.ColumnRemoveButton.Name = "ColumnRemoveButton";
            this.ColumnRemoveButton.Size = new System.Drawing.Size(86, 36);
            this.ColumnRemoveButton.TabIndex = 13;
            this.ColumnRemoveButton.UseVisualStyleBackColor = true;
            this.ColumnRemoveButton.Visible = false;
            this.ColumnRemoveButton.Click += new System.EventHandler(this.ColumnRemoveButton_Click);
            this.ColumnRemoveButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ColumnRemoveButton_MouseClick);
            // 
            // LogoutButton
            // 
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Image = global::check.Properties.Resources.Basic_MainMenu;
            this.LogoutButton.Location = new System.Drawing.Point(-1, -1);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(93, 49);
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogoutButton_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(183, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 202);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1097, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ExcelToMailButton);
            this.Controls.Add(this.PDFToMailButton);
            this.Controls.Add(this.AddProductsButton);
            this.Controls.Add(this.SellProductButton);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TableOptionsButton);
            this.Controls.Add(this.TableOptionsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PDFCheckButton);
            this.Controls.Add(this.ExcelCheckButton);
            this.Controls.Add(this.RemoveTableComboBox);
            this.Controls.Add(this.TableFunctionRemoveButton);
            this.Controls.Add(this.TableFunctionAddButton);
            this.Controls.Add(this.TableFunctionsLabel);
            this.Controls.Add(this.ColumnsComboBox);
            this.Controls.Add(this.RowFunctitonsRemoveButton);
            this.Controls.Add(this.RowFunctinsAddButton);
            this.Controls.Add(this.RowFunctionsLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ColumnRemoveButton);
            this.Controls.Add(this.TableComboBox);
            this.Controls.Add(this.FunctionsLabel);
            this.Controls.Add(this.TablesLabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tables";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label TablesLabel;
        private System.Windows.Forms.Label FunctionsLabel;
        private System.Windows.Forms.ComboBox TableComboBox;
        private System.Windows.Forms.Button ColumnRemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label RowFunctionsLabel;
        private System.Windows.Forms.Button RowFunctinsAddButton;
        private System.Windows.Forms.Button RowFunctitonsRemoveButton;
        private System.Windows.Forms.ComboBox ColumnsComboBox;
        private System.Windows.Forms.Label TableFunctionsLabel;
        private System.Windows.Forms.Button TableFunctionAddButton;
        private System.Windows.Forms.Button TableFunctionRemoveButton;
        private System.Windows.Forms.ComboBox RemoveTableComboBox;
        private System.Windows.Forms.Button ExcelCheckButton;
        private System.Windows.Forms.Button PDFCheckButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TableOptionsLabel;
        private System.Windows.Forms.Button TableOptionsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Button SellProductButton;
        private System.Windows.Forms.Button AddProductsButton;
        private System.Windows.Forms.Button ExcelToMailButton;
        private System.Windows.Forms.Button PDFToMailButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

