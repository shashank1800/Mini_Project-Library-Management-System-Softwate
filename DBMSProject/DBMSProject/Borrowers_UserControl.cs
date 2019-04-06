using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DBMSProject
{
    public partial class Borrowers_UserControl : UserControl
    {
        private static Borrowers_UserControl _instance;
        public static Borrowers_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Borrowers_UserControl();

                }
                return _instance;
            }
        }
        public Borrowers_UserControl()
        {
            InitializeComponent();
        }

        private void Borrowers_UserControl_Load(object sender, EventArgs e)
        {
            searchBorrowersToolStripMenuItem_Click(sender, e);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addborrowertoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clearthetext();
            makeinvisible();

            borrower_name_tb.Visible = false;
            phoneno_tb.Visible = false;
            book1_tb.Visible = false;
            book2_tb.Visible = false;
            book3_tb.Visible = false;

            borrowers_id.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;

            ABTextfield.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible =true;

            AddB.Visible = true;
            
        }
       

        

        private void searchBorrowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearthetext();
            makeinvisible();

            borrowers_id.Visible = true;
            ABTextfield.Visible = true;
            SearchBorrow.Visible = true;
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (ABTextfield.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Enter all fields");
            }
            else if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Password do not matches!");

            }
            else {
                try
                {
                    Form1.con.Open();
                    String q = "INSERT INTO BORROWER VALUES('"+ ABTextfield.Text+"','"+textBox1.Text+"','"+textBox3.Text+"','"+textBox2.Text+"',NULL,NULL,NULL);";
                    SqlCommand sc = new SqlCommand(q, Form1.con);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Borrower added Successfully");
                    clearthetext();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("");
                }
                finally
                {
                    Form1.con.Close();
                }
            }
        }

        private void SearchBorrow_Click(object sender, EventArgs e)
        {
            if(ABTextfield.Text =="")
            {
                MessageBox.Show("Enter Borrower ID");
            }
            else
            {
                try
                {
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    book2_tb.Visible = true;
                    book3_tb.Visible = true;
                    book1_tb.Visible = true;
                    borrower_name_tb.Visible = true;
                    phoneno_tb.Visible = true;

                    SqlDataAdapter asdf = new SqlDataAdapter("Select name,Phone_no,Book1,Book2,Book3 from Borrower where Br_Id='" + ABTextfield.Text + "' ", Form1.con);
                    DataTable ss = new DataTable();
                    asdf.Fill(ss);
                    borrower_name_tb.Text = ss.Rows[0][0].ToString();
                    phoneno_tb.Text = ss.Rows[0][1].ToString();

                    if (ss.Rows[0][2].ToString() == "")
                        book1_tb.Text = "Not Issued";
                    else
                    {
                        try
                        {
                            Form1.con.Open();
                            String q = "Select Book_Name from BOOKS where AccNo='" + ss.Rows[0][2].ToString() + "';";
                            SqlCommand sc = new SqlCommand(q, Form1.con);
                            SqlDataReader result = sc.ExecuteReader();
                            while (result.Read())
                            {
                                book1_tb.Text = (string)result["Book_Name"];
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error");
                        }
                        finally
                        {
                            Form1.con.Close();
                        }
                    }

                    if (ss.Rows[0][3].ToString() == "")
                        book2_tb.Text = "Not Issued";
                    else
                    {
                        try
                        {
                            Form1.con.Open();
                            String q = "Select Book_Name from BOOKS where AccNo='" + ss.Rows[0][3].ToString() + "';";
                            SqlCommand sc = new SqlCommand(q, Form1.con);
                            SqlDataReader result = sc.ExecuteReader();
                            while (result.Read())
                            {
                                book2_tb.Text = (string)result["Book_Name"];
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("");
                        }
                        finally
                        {
                            Form1.con.Close();
                        }
                    }

                    if (ss.Rows[0][4].ToString() == "")
                        book3_tb.Text = "Not Issued";
                    else
                    {
                        try
                        {
                            Form1.con.Open();
                            String q = "Select Book_Name from BOOKS where AccNo='" + ss.Rows[0][4].ToString() + "';";
                            SqlCommand sc = new SqlCommand(q, Form1.con);
                            SqlDataReader result = sc.ExecuteReader();
                            while (result.Read())
                            {
                                book3_tb.Text = (string)result["Book_Name"];
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("");
                        }
                        finally
                        {
                            Form1.con.Close();
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Invalid Input");
                }
            }
        }

       

        private void borrower_name_tb_Click(object sender, EventArgs e)
        {

        }
        public void clearthetext()
        {
            ABTextfield.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            borrower_name_tb.Text = "";
            phoneno_tb.Text = "";
            book1_tb.Text = "";
            book2_tb.Text = "";
            book3_tb.Text = "";
        }
        public void makeinvisible()
        {
            borrowers_id.Visible = false;
            ABTextfield.Visible = false;
            SearchBorrow.Visible = false;
            AccessionLabel.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;

            ABTextfield.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;

            AddB.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ABTextfield.Text == "")
            {
                MessageBox.Show("Enter Accession No");
            }
            else
            {

            }
        }
    }
}
