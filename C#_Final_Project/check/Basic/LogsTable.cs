using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    public partial class LogsTable : Form
    {
        DataTable dt = new DataTable();
        string connString;
        OleDbConnection con;
        string tablest;
        smtpHandler smtp = new smtpHandler();
        public LogsTable()
        {
            InitializeComponent();
            tablest = "LOGUnits";
            SetSQLConnection();
            tableMaker();
            GUI();
        }

        void GUI() //SETUP GUI
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            ExcelCheckButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            PDFCheckButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            button1.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            button2.ForeColor = ColorTranslator.FromHtml("#2B2D42");
        }

        void SetSQLConnection() //set sql connection
        {
            connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            con = new OleDbConnection(connString);
        }

        public void tableMaker() //main function making table
        {
            TabelLabel.Text = tablest;
            dataGridView1.Columns.Clear();
            dt = new DataTable();
            OleDbCommand cmd;

            con.Open();
            SetTableComboBox();
            cmd = new OleDbCommand("SELECT * FROM " + tablest, con);

            OleDbDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            //TableComboBox.SelectedIndex = 0;
            con.Close();
        }


        public void SetTableComboBox() // setting the combobox with table names
        {
            TableComboBox.Items.Clear();
            TableComboBox.ResetText();
            DataTable tables = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            foreach (DataRow row in tables.Rows)
            {
                if (row[2].ToString() == "LOGUnits" || row[2].ToString() == "LOGColumns" || row[2].ToString() == "LOGTables" || row[2].ToString() == "Sells" || row[2].ToString() == "Buys")
                {
                    TableComboBox.Items.Add(row[2]);
                }
            }
        }

        private void TableComboBox_SelectionChangeCommitted(object sender, EventArgs e) //WHEN TABLE CHANGED IN COMBO BOX REFRESHING TO THE CURRECT TABLE
        {
            TabelLabel.Text = TableComboBox.Text;
            tablest = TableComboBox.SelectedItem.ToString();
            tableMaker();
        }

        private void PDFCheckButton_MouseClick(object sender, MouseEventArgs e) //EXPORTING PDF TO THE SOFTWARE FOLDER
        {
            exportPDF();
            MessageBox.Show(tablest + "Have Exported to pdf Sucesessfuly !!!");
        }

        private void ExcelCheckButton_MouseClick(object sender, MouseEventArgs e) //EXPORTING EXCEL TO THE SOFTWARE FOLDER
        {
            exportExcel();
            MessageBox.Show(tablest + " Exported Succsesfully!!!");
        }

        private void button2_MouseClick(object sender, MouseEventArgs e) //SENDING EXCEL TO MAIL
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string filetoupload = exportExcel();
            string st = "Excel Export " + dateTime.ToString("M - d - yyyy");
            smtp.BackupSender(st, st, filetoupload);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e) //SENDING PDF TO MAIL
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string filetoupload = exportPDF();
            string st = "PDF Export" + dateTime.ToString("M - d - yyyy");
            smtp.BackupSender(st, st, filetoupload);
        }


        string exportPDF() //MAKING PDF FILE
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

        string exportExcel() //MAKING EXCEL FILE
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


    }
}
