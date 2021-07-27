using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace check
{
    public partial class Form1 : Form
    {
        int perm = 0;
        public string name;
        DataTable dt = new DataTable();
        SQLFuncs sqlfuncs = new SQLFuncs();
        public string tablest = "Products";
        List<Label> labelperm3 = new List<Label>();
        LogoImageHandler logoHand = new LogoImageHandler();


        public Form1(string name, int perm)
        {
            InitializeComponent();
            setGUI();
            this.name = name;
            LabelUserName.Text = name;
            this.perm = 1;
            this.perm = perm;
            TableLabel.Text = tablest + " Table";
            tableMaker();

        }


        void setGUI() //SETUP THE GUI
        {
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            LogoutButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            AddButton.ForeColor = ColorTranslator.FromHtml("#2B2D42"); 
            ColumnRemoveButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            TableFunctionAddButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            TableFunctionRemoveButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            //TableOptionsButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            RowFunctinsAddButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            RowFunctitonsRemoveButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            ExcelCheckButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            PDFCheckButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            ExcelToMailButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            PDFToMailButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            AddProductsButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            SellProductButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = logoHand.ChangeLogoImage();

        }
        public void tableMaker() //main function making table
        {
            TableLabel.Text = tablest + " Table";
            dataGridView1.Columns.Clear();
            dt = new DataTable();
            SetTableComboBox();
            dt = sqlfuncs.GetTable("SELECT * FROM " + tablest);
            dataGridView1.DataSource = dt;
            dataGridView1.BackgroundColor = ColorTranslator.FromHtml("#2B2D42");
            SetColumnComboBox();
            if(tablest == "Products")
            {
                ProductsLabel.Visible = true;
                AddProductsButton.Visible = true;
                SellProductButton.Visible = true;
                if(dataGridView1.RowCount > 0)
                {
                    AddProductsButton.Enabled = true;
                    SellProductButton.Enabled = true;
                }
            }
            else
            {
                ProductsLabel.Visible = false;
                AddProductsButton.Visible = false;
                SellProductButton.Visible = false ;
            }
        }


        public void SetTableComboBox() // setting the combobox with table names
        {
            TableComboBox.Items.Clear();
            TableComboBox.ResetText();
            RemoveTableComboBox.Items.Clear();
            RemoveTableComboBox.ResetText();
            DataTable tables = sqlfuncs.GetTablesName();
            foreach (DataRow row in tables.Rows)
            {
                TableComboBox.Items.Add(row[2]);
                RemoveTableComboBox.Items.Add(row[2]);
            }

            //after fixing the logs  remove the comment
            TableComboBox.Items.Remove("LoginTable");
            TableComboBox.Items.Remove("PermissionTable");
            TableComboBox.Items.Remove("LOGColumns");
            TableComboBox.Items.Remove("LOGTables");
            TableComboBox.Items.Remove("LOGUnits");
            TableComboBox.Items.Remove("EmailLogin");
            TableComboBox.Items.Remove("Settings");
            TableComboBox.Items.Remove("LOGUnits");
            RemoveTableComboBox.Items.Remove("CustomersTable");
            RemoveTableComboBox.Items.Remove("LOGColumns");
            RemoveTableComboBox.Items.Remove("LOGTables");
            RemoveTableComboBox.Items.Remove("LOGUnits");
            RemoveTableComboBox.Items.Remove("LoginTable");
            RemoveTableComboBox.Items.Remove("PermissionTable");
            RemoveTableComboBox.Items.Remove("EmailLogin");
            RemoveTableComboBox.Items.Remove("Settings");
            RemoveTableComboBox.Items.Remove("Products");
            TableComboBox.Items.Remove("Sells");
            RemoveTableComboBox.Items.Remove("Sells");
            TableComboBox.Items.Remove("Buys");
            RemoveTableComboBox.Items.Remove("Buys");
        }



        public void SetColumnComboBox() //ADDING ALL THE NAME OF COLUMN TO THE COMBOBOX
        {
            ColumnsComboBox.Items.Clear();
            ColumnsComboBox.ResetText();
            for(int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                ColumnsComboBox.Items.Add(dataGridView1.Columns[i].Name);
            }
            ColumnsComboBox.Items.Remove("ID"); 
            ColumnsComboBox.Items.Remove("Email");
            if(tablest == "Products")
            {
                ColumnsComboBox.Items.Remove("ProductName");
                ColumnsComboBox.Items.Remove("Price");
                ColumnsComboBox.Items.Remove("Amount");
            }
        }



        private void LogoutButton_MouseClick(object sender, MouseEventArgs e) //going back to login screen
        {
            this.Close();
        }


        private void AddButton_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void RowFunctitonsRemoveButton_MouseClick(object sender, MouseEventArgs e) //REMOVE ROW FROM TABLE
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user from the system  ? ", "Question Box", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                string st = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

                sqlfuncs.AddRemoveChange("DELETE  FROM " + tablest + " WHERE " + dataGridView1.Columns[0].Name + " = '" + st + "'");
                dataGridView1.Rows.RemoveAt(rowIndex);
                //add to LOG
                string sql = "INSERT INTO `LOGUnits`(`TableName`, `Action`, `ColumnChanged` , `UniqueField`, `From`, `To`, `User` , `When`) VALUES('" + tablest + "','DELETE Unit','NONE','" + st + "','NONE','NONE','" + name + "',NOW());";
                sqlfuncs.AddRemoveChange(sql);
            }
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void ColumnRemoveButton_MouseClick(object sender, MouseEventArgs e)//REMOVE COLUMN FROM TABLE
        {
            string pkcolname = dataGridView1.Columns[0].Name;
            if (dataGridView1.Columns.Count > 2 && ColumnsComboBox.Text != pkcolname)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this column from the system  ? ", "Question Box", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sqlfuncs.AddRemoveChange("ALTER TABLE " + tablest + " DROP COLUMN " + ColumnsComboBox.Text + ";");
                    string sql = "INSERT INTO `LOGColumns`(`TableName`, `Column`, `Action` , `User`, `When`) VALUES('" + tablest + "', 'NEW','Delete Column','" + name + "',NOW());";
                    sqlfuncs.AddRemoveChange(sql);
                    MessageBox.Show("Column Removed Successfuly");
                    tableMaker();
                }
            }

            if(ColumnsComboBox.Text == "ID" || ColumnsComboBox.Text == "Email")
            {
                MessageBox.Show("Unique Fields Cannot Be Deleted");
            }

            else
            {
                MessageBox.Show("The program cannot remove Unique Field or Have less then 2 columns.");
            }

        }

        private void AddButton_MouseClick_1(object sender, MouseEventArgs e) //ADD COLUMN TO TABLE
        {
            if(ColumnsComboBox.Items.Count > 9)
            {
                MessageBox.Show("Max column for this version is 10. please delete other column to add a new 1.");
            }
            else
            {
                AddColumn f2 = new AddColumn(tablest,dataGridView1,this);
                f2.ShowDialog();
            }
        }

        private void RowFunctinsAddButton_MouseClick(object sender, MouseEventArgs e) //ADD ROW TO TABLE
        {
            AddUnit f2 = new AddUnit(tablest,dataGridView1,this);
            f2.ShowDialog();
        }

        private void TableFunctionAddButton_MouseClick(object sender, MouseEventArgs e)//CREATE NEW TABLE
        {
            AddTable f2 = new AddTable(this,name);
            f2.ShowDialog();
        }

        private void TableFunctionRemoveButton_MouseClick(object sender, MouseEventArgs e) //REMOVE TABLE
        {
            if(RemoveTableComboBox.Text != "")
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this table from the system  ? ", "Question Box", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlfuncs.AddRemoveChange("DROP TABLE " + RemoveTableComboBox.Text + ";");    
                        string sql = "INSERT INTO `LOGTables`(`TableName`, `Action`, `User`, `When`) VALUES('" + RemoveTableComboBox.Text + "', 'Delete Table','" + name + "', NOW());";
                        sqlfuncs.AddRemoveChange(sql);           
                        if(RemoveTableComboBox.Text == tablest)
                        {
                            tablest = "Products";
                        }
                        tableMaker();
                        MessageBox.Show(RemoveTableComboBox.Text + " Haven been removed successfuly!!!");
                    }
                }
                catch
                {
                    MessageBox.Show("Removing Table Failed. Try again!!!.");
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //EDIT CELL IN TABLE
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            string keyvalue = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            string colname = dataGridView1.Columns[dataGridView1.CurrentCell.ColumnIndex].Name;
            string pkcolname = dataGridView1.Columns[0].Name;
            string oldvalue = dataGridView1.CurrentCell.Value.ToString();
            if (tablest != "Products")
            {
                EditRow f2 = new EditRow(tablest, keyvalue, pkcolname, colname, this, oldvalue); //keyvalue + 
                f2.ShowDialog();

            }
            if(tablest == "Products" && perm == 3 && colname != "Amount")
            {
                EditRow f2 = new EditRow(tablest, keyvalue, pkcolname, colname, this, oldvalue); //keyvalue + 
                f2.ShowDialog();
            }
        }

        private void TableComboBox_SelectionChangeCommitted(object sender, EventArgs e) //IF TABLE CHANGED IN COMBOBOX REFRESHING THE PAGE WITH NEW TABLE
        {
            TableLabel.Text = TableComboBox.Text;
            tablest = TableComboBox.SelectedItem.ToString();
            tableMaker();
        }

        private void ExcelCheckButton_MouseClick(object sender, MouseEventArgs e) //EXPORT EXCEL
        {
            exportExcel();
            MessageBox.Show("The Excel Exported Succesfully!!!");
        }

        private void PDFCheckButton_MouseClick(object sender, MouseEventArgs e) //EXPORT PDF
        {
            exportPDF();
            MessageBox.Show("The PDF Exported Succesfully!!!");
        }

        private void TitleLabel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e) //EXPOSE ADMIN SETTINGS
        {
            if(TableOptionsButton.Text == "Expose")
            {
                TableOptionsButton.Text = "Dispose";
                if (perm == 3)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    ExcelToMailButton.Visible = true;
                    PDFToMailButton.Visible = true;
                    ExcelCheckButton.Visible = true;
                    PDFCheckButton.Visible = true;
                    FunctionsLabel.Visible = true;
                    AddButton.Visible = true;
                    ColumnsComboBox.Visible = true;
                    ColumnRemoveButton.Visible = true;
                    TableFunctionsLabel.Visible = true;
                    TableFunctionAddButton.Visible = true;
                    RemoveTableComboBox.Visible = true;
                    TableFunctionRemoveButton.Visible = true;
                }
                else if (perm == 2)
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    ExcelCheckButton.Visible = true;
                    PDFCheckButton.Visible = true;
                    FunctionsLabel.Visible = true;
                    AddButton.Visible = true;
                    ColumnsComboBox.Visible = true;
                    ColumnRemoveButton.Visible = true;
                }
            }

            else
            {
                TableOptionsButton.Text = "Expose";
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                ExcelToMailButton.Visible = false;
                PDFToMailButton.Visible = false;
                ExcelCheckButton.Visible = false;
                PDFCheckButton.Visible = false;
                FunctionsLabel.Visible = false;
                AddButton.Visible = false;
                ColumnsComboBox.Visible = false;
                ColumnRemoveButton.Visible = false;
                TableFunctionsLabel.Visible = false;
                TableFunctionAddButton.Visible = false;
                RemoveTableComboBox.Visible = false;
                TableFunctionRemoveButton.Visible = false;
            }

        }

        private void SellProductButton_MouseClick(object sender, MouseEventArgs e)//SELL PRODUCT
        {
            SellProducts f2 = new SellProducts(dt,this);
            f2.ShowDialog();
        }

        private void AddProductsButton_MouseClick(object sender, MouseEventArgs e) //BUY PRODUCT
        {
            AddProducts f2 = new AddProducts(dt, this);
            f2.ShowDialog();
        }


        string exportPDF() //CREATE PDF 
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        pdfTable.AddCell(cell.Value.ToString());
            //    }
            //}
            int row = dataGridView1.Rows.Count;
            int cell2 = dataGridView1.Rows[1].Cells.Count;
            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < cell2; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        //return directly
                        //return;
                        //or set a value for the empty data
                        dataGridView1.Rows[i].Cells[j].Value = "null";
                    }
                    pdfTable.AddCell(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
            }

            //Exporting to PDF
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT bin directory (ie ../bin/)
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            // This will get the current PROJECT directory
            projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            string folderPath = projectDirectory + "\\PdfExports\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            DateTime dateTime = DateTime.UtcNow.Date;
            string filename = tablest + "_" + dateTime.ToString("M - d - yyyy") + ".pdf";
            using (FileStream stream = new FileStream(folderPath + filename, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            return folderPath + filename;
        }

        string exportExcel() //create excel
        {
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT bin directory (ie ../bin/)
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            // This will get the current PROJECT directory
            projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            DateTime dateTime = DateTime.UtcNow.Date;
            // save the application  
            projectDirectory = projectDirectory + "\\ExcelExports\\" + tablest + "_" + dateTime.ToString("M - d - yyyy") + ".xlsx";
            workbook.SaveAs(projectDirectory, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  

            app.Quit();
            return projectDirectory;
        }

        private void PDFToMailButton_MouseClick(object sender, MouseEventArgs e) //SENDING PDF TO MAIL
        {
            smtpHandler smtp = new smtpHandler();
            DateTime dateTime = DateTime.UtcNow.Date;
            string filetoupload = exportPDF();
            string st = "PDF Export" + dateTime.ToString("M - d - yyyy");
            smtp.BackupSender(st, st, filetoupload);
        }

        private void button1_MouseClick_1(object sender, MouseEventArgs e) //SENDING EXCEL TO MAIL
        {
            smtpHandler smtp = new smtpHandler();
            DateTime dateTime = DateTime.UtcNow.Date;
            string filetoupload = exportExcel();
            string st = "Excel Export " + dateTime.ToString("M - d - yyyy");
            smtp.BackupSender(st, st, filetoupload);
        }

        private void ColumnRemoveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
