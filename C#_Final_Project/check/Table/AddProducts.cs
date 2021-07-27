using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check
{
    public partial class AddProducts : Form
    {
        List<TextBox> amounttextboxlist = new List<TextBox>();
        List<Label> namelabellist = new List<Label>();
        List<TextBox> pricetextboxlist = new List<TextBox>();
        List<Label> amountlabellist = new List<Label>();
        List<Button> incbuttonlist = new List<Button>();
        List<Button> decbuttonlist = new List<Button>();
        SQLFuncs sqlfuncs = new SQLFuncs();
        DataTable dt;
        Form1 Table;
        int flag = 0;
        public AddProducts(DataTable dt, Form1 Table)
        {
            InitializeComponent();

            this.dt = dt;
            this.Table = Table;
            setForm();
            GUI();
        }

        void GUI() //SETUP GUI DESIGN
        {
            this.BackColor = ColorTranslator.FromHtml("#2B2D42");
            button1.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            button2.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            ConfirmButton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        void setForm() //MODULARE FORM ADDING THE AMOUNT OF PRODUCTS ON THE TABLE
        {
            foreach (DataRow row in dt.Rows)
            {
                int listsize = namelabellist.Count;
                if (flag == 0)
                {
                    StockLabel.BringToFront();
                    label1.Text = row["ProductName"].ToString();
                    StockLabel.Text = row["Amount"].ToString();
                    textBox1.Text = "0";
                    namelabellist.Add(label1);
                    pricetextboxlist.Add(PriceTextBox);
                    amountlabellist.Add(StockLabel);
                    amounttextboxlist.Add(textBox1);
                    incbuttonlist.Add(button1);
                    decbuttonlist.Add(button2);
                    flag = 1;
                }
                else
                {
 



                    //add controls
                        //namelabels
                        Label tempnamelabel = new Label();
                        tempnamelabel.Text = row["ProductName"].ToString();
                        tempnamelabel.Font = label1.Font;
                        tempnamelabel.FlatStyle = label1.FlatStyle;
                        tempnamelabel.ForeColor = label1.ForeColor;
                        tempnamelabel.Location = new Point(namelabellist[listsize - 1].Location.X, namelabellist[listsize - 1].Location.Y + 30);
                        tempnamelabel.Visible = true;
                        namelabellist.Add(tempnamelabel);

                        //amountlabels
                        tempnamelabel = new Label();
                        tempnamelabel.Text = row["Amount"].ToString();
                        tempnamelabel.Font = label1.Font;
                        tempnamelabel.ForeColor = label1.ForeColor;
                        tempnamelabel.FlatStyle = label1.FlatStyle;
                        tempnamelabel.Location = new Point(amountlabellist[listsize - 1].Location.X, amountlabellist[listsize - 1].Location.Y + 30);
                        tempnamelabel.Visible = true;
                        amountlabellist.Add(tempnamelabel);

                        //price text box
                        TextBox temptextbox = new TextBox();
                        temptextbox.Size = PriceTextBox.Size;
                        temptextbox.Location = new Point(pricetextboxlist[listsize - 1].Location.X, pricetextboxlist[listsize - 1].Location.Y + 30);
                        temptextbox.Visible = true;
                        temptextbox.TextChanged += new EventHandler(this.textBox1_TextChanged);
                        pricetextboxlist.Add(temptextbox);

                        //amount 
                        temptextbox = new TextBox();
                        temptextbox.Size = textBox1.Size;
                        temptextbox.Location = new Point(amounttextboxlist[listsize - 1].Location.X, amounttextboxlist[listsize - 1].Location.Y + 30);
                        temptextbox.Visible = true;
                        temptextbox.Text = "0";
                        temptextbox.TextChanged += new EventHandler(this.textBox1_TextChanged);
                        temptextbox.Enabled = false;
                        amounttextboxlist.Add(temptextbox);

                        //both inc and dec buttons
                        //inc
                        Button tempbutton = new Button();
                        tempbutton.Location = new Point(incbuttonlist[listsize - 1].Location.X, incbuttonlist[listsize - 1].Location.Y + 30);
                        tempbutton.Visible = true;
                        tempbutton.FlatStyle = button1.FlatStyle;
                        tempbutton.Size = button1.Size;
                        tempbutton.Image = button1.Image;
                        tempbutton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
                        tempbutton.Click += new EventHandler(this.button1_Click);
                        incbuttonlist.Add(tempbutton);

                        //dec
                        tempbutton = new Button();
                        tempbutton.FlatStyle = button1.FlatStyle;
                        tempbutton.Image = button2.Image;
                        tempbutton.Location = new Point(decbuttonlist[listsize - 1].Location.X, decbuttonlist[listsize - 1].Location.Y + 30);
                        tempbutton.Visible = true;
                        tempbutton.Size = button1.Size;
                        tempbutton.ForeColor = ColorTranslator.FromHtml("#2B2D42");
                        tempbutton.Click += new EventHandler(this.button2_Click);

                        decbuttonlist.Add(tempbutton);
                        this.Controls.Add(namelabellist[listsize]);
                        this.Controls.Add(pricetextboxlist[listsize]);
                        this.Controls.Add(amountlabellist[listsize]);
                        this.Controls.Add(amounttextboxlist[listsize]);
                        this.Controls.Add(incbuttonlist[listsize]);
                        this.Controls.Add(decbuttonlist[listsize]);

                        ConfirmButton.Location = new Point(ConfirmButton.Location.X, ConfirmButton.Location.Y + 30);
                        SumLabel1.Location = new Point(SumLabel1.Location.X, SumLabel1.Location.Y + 30);
                        SumLabel2.Location = new Point(SumLabel2.Location.X, SumLabel2.Location.Y + 30);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //INCREASE 1 PRODUCTS TO THE AMOUNT
        {
            int i = 0;
            foreach (Button button in incbuttonlist)
            {
                if (sender == button)
                {
                    break;
                }
                i++;
            }
            int temp = int.Parse(amounttextboxlist[i].Text) + 1;
            amounttextboxlist[i].Text = temp.ToString();
        }

        private void button2_Click(object sender, EventArgs e) // DECREASE 1 PRODUCT FROM THE AMOUNT
        {
            int i = 0;
            foreach (Button button in decbuttonlist)
            {
                if (sender == button)
                {
                    break;
                }
                i++;
            }
            if (int.Parse(amounttextboxlist[i].Text) > 0)
            {
                int temp = int.Parse(amounttextboxlist[i].Text) - 1;
                amounttextboxlist[i].Text = temp.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //checking if the user didnt put chars
        {
            int sum = 0;
            TextBox tb = (TextBox)sender;
            if (tb.Text.All(char.IsDigit) == true)
            {
                for(int i = 0; i < amountlabellist.Count; i++)
                {
                    if (amounttextboxlist[i].Text != "0" && pricetextboxlist[i].Text != "")
                    {
                        sum += int.Parse(amounttextboxlist[i].Text) * int.Parse(pricetextboxlist[i].Text);
                    }
                }
                SumLabel2.Text = sum.ToString();
            }

            else
            {
                MessageBox.Show("Do not enter characters because they will count as 0!!!");
            }
        }



        private void ConfirmButton_MouseClick(object sender, MouseEventArgs e) //CHECK ALL THE FIELDS WHO ARE DIFF FROM 0 OR CHAR AND ADDING THEM TO THE PRODUCTS SQL
        {
            try
            {
                for (int i = 0; i < namelabellist.Count; i++)
                {
                    if (amounttextboxlist[i].Text != "0" && amounttextboxlist[i].Text.All(char.IsDigit) == true && pricetextboxlist[i].Text.All(char.IsDigit) == true && pricetextboxlist[i].Text != "")
                    {
                        int temp = int.Parse(amountlabellist[i].Text) + int.Parse(amounttextboxlist[i].Text);
                        string sql = "UPDATE Products SET[Amount] = '" + temp.ToString() + "' WHERE [ProductName] = '" + namelabellist[i].Text + "'; ";
                        sqlfuncs.AddRemoveChange(sql);
                        sql = "INSERT INTO `Buys`(`ProductName`, `Price`, `Amount`, `WorkerName`, `BuyDate`) VALUES('" + namelabellist[i].Text + "','" + pricetextboxlist[i].Text + "','" + amounttextboxlist[i].Text + "','" + Table.name + "', NOW())";
                        sqlfuncs.AddRemoveChange(sql);
                    }
                }
                Table.tableMaker();
                MessageBox.Show("Order Confirmed!!!");
                this.Close();
            }

            catch
            {
                MessageBox.Show("Error 404!!!");
            }

        }
    }
}
