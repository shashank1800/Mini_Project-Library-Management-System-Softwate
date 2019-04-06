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
    public partial class Transaction_UserControl : UserControl
    {

        private static Transaction_UserControl _instance;
        public static Transaction_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Transaction_UserControl();

                }
                return _instance;
            }
        }
        public Transaction_UserControl()
        {
            InitializeComponent();
        }

        private void Transaction_UserControl_Load(object sender, EventArgs e)
        {
            pLACEORDERToolStripMenuItem_Click(sender,e);
        }

        

        private void pLACEORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearthebox();
            Borrower_id.Visible = true;
            Borrower_textbox.Visible = true;

            label1.Visible = true;
            Accno_textbox.Visible = true;
            button1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String res = "";
            if (Borrower_textbox.Text =="" || Accno_textbox.Text =="")
            {
                MessageBox.Show("Enter all feilds");
            }
            
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select isIssued from BOOKS where AccNo ='" + Accno_textbox.Text + "';", Form1.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                res = dt.Rows[0][0].ToString();
                if (res.Equals("True"))
                {
                    MessageBox.Show("Error:Book is already issued");
                }
                else
                {
                    try
                    {
                        SqlDataAdapter sda1 = new SqlDataAdapter("Select Book1,Book2,Book3 from BORROWER where Br_Id = '" + Borrower_textbox.Text + "'", Form1.con);
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);

                        if (dt1.Rows[0][0].ToString() == "")
                            issue_fun("Book1");
                        else if (dt1.Rows[0][1].ToString() == "")
                            issue_fun("Book2");
                        else if (dt1.Rows[0][2].ToString() == "")
                            issue_fun("Book3");
                        else
                            MessageBox.Show("Book Not Issued!!\nBorrower took maximum no of Books");
                        clearthetext();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                
            }
        }

        public void issue_fun(String book)
        {
            
            String q = "";
            try
            {
                Form1.con.Open();
                
                q = "Update BORROWER set " + book + " = '" + Accno_textbox.Text + "' where Br_Id= '" + Borrower_textbox.Text + "';";
                SqlCommand sc = new SqlCommand(q, Form1.con);
                sc.ExecuteNonQuery();

                q = "Update BOOKS set isIssued = 1 where AccNo = '" + Accno_textbox.Text + "';";
                SqlCommand sc2 = new SqlCommand(q, Form1.con);
                sc2.ExecuteNonQuery();

                q = "insert into TRANSACTIONS(Date,Br_Id,BookNo,Return_Date,Has_returned) Values(GETDATE(),'"+Borrower_textbox.Text+"','"+Accno_textbox.Text+"',GETDATE()+30,0);";
                SqlCommand sc3 = new SqlCommand(q, Form1.con);
                sc3.ExecuteNonQuery();

                /*
                SqlCommand sc3 = new SqlCommand("transaction_update", Form1.con);
                sc3.CommandType = CommandType.StoredProcedure;
                sc3.Parameters.Add("@AccNo",SqlDbType.VarChar).Value = Accno_textbox.Text;
                sc3.Parameters.Add("@Br_id", SqlDbType.VarChar).Value = Borrower_textbox.Text;
                sc3.ExecuteNonQuery();*/

                MessageBox.Show("Book issued!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Form1.con.Close();
            }
        }

        private void Accno_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void clearthebox()
        {
            Borrower_id.Visible = false;
            Borrower_textbox.Visible = false;
            label1.Visible = false;
            Accno_textbox.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            dataGridView.Visible =false;
            comboBox1.Visible = false;
        }

        public void clearthetext()
        {
            Borrower_textbox.Text = "";
            Accno_textbox.Text = "";
        }

        private void rETURNBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearthebox();

            Borrower_id.Visible = true;
            Borrower_textbox.Visible = true;
            label1.Visible = true;
            Accno_textbox.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Borrower_textbox.Text == "" || Accno_textbox.Text == "")
            {
                MessageBox.Show("Enter all feilds");
            }
            else
            {
                try
                {
                    Form1.con.Open();
                    String q = "Update BOOKS set isIssued = 0 where AccNo = '" + Accno_textbox.Text + "';";
                    SqlCommand sc = new SqlCommand(q, Form1.con);
                    sc.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    Form1.con.Close();
                }
                try
                {

                    SqlDataAdapter sda = new SqlDataAdapter("Select Book1,Book2,Book3 from BORROWER where Br_Id = '" + Borrower_textbox.Text + "'", Form1.con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == Accno_textbox.Text)
                        return_fun("Book1");
                    else if (dt.Rows[0][1].ToString() == Accno_textbox.Text)
                        return_fun("Book2");
                    else if (dt.Rows[0][2].ToString() == Accno_textbox.Text)
                        return_fun("Book3");
                    else
                        MessageBox.Show("Invalid Input!\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        public void return_fun(String book)
        {
            try
            {
                Form1.con.Open();

                String q = "Update BORROWER set " + book + " = NULL where Br_Id= '" + Borrower_textbox.Text + "';";
                SqlCommand sc = new SqlCommand(q, Form1.con);
                sc.ExecuteNonQuery();

                q = "Update TRANSACTIONS set Has_returned=1 where Br_Id='"+Borrower_textbox.Text+"' and BookNo='"+Accno_textbox.Text+"';";
                SqlCommand sc5 = new SqlCommand(q, Form1.con);
                sc5.ExecuteNonQuery();

                MessageBox.Show("Book Returned");
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clearthebox();
            clearthetext();

            dataGridView.Visible = true;
            comboBox1.Visible = true;

            String q = "select * from Transactions";
            Form1.con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(q, Form1.con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridView.ReadOnly = true;
            dataGridView.DataSource = table;

            Form1.con.Close();

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            String q = "";


            /* int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
                            "Index: " + selectedIndex.ToString());*/

            switch (selectedIndex.ToString()) {
                case "0":
                    q= "select * from Transactions";
                    Form1.con.Open();
                    dataAdapter1(q);
                    Form1.con.Close();
                    break;

                case "1":
                    q = "select * from Transactions where date between (GETDATE()-1) and GETDATE();";
                    Form1.con.Open();
                    dataAdapter1(q);
                    Form1.con.Close();
                    break;
                case "2":
                    q = "select * from Transactions where date between (GETDATE()-8) and GETDATE();";
                    Form1.con.Open();
                    dataAdapter1(q);
                    Form1.con.Close();
                    break;

                case "3":
                    q = "select * from Transactions where date between (GETDATE()-30) and GETDATE();";
                    Form1.con.Open();
                    dataAdapter1(q);
                    Form1.con.Close();
                    break;
                case "4":
                    q = "select * from Transactions where date between (GETDATE()-182) and GETDATE();";
                    Form1.con.Open();
                    dataAdapter1(q);
                    Form1.con.Close();
                    break;
            }

        }

        public void dataAdapter1(String q)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(q, Form1.con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridView.ReadOnly = true;
            dataGridView.DataSource = table;
        }
    }
}
