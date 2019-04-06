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
    public partial class Books_UserControl : UserControl
    {
        private static Books_UserControl _instance;
        public static Books_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Books_UserControl();

                }
                return _instance;
            }
        }
        public Books_UserControl()
        {
            InitializeComponent();
        }

        private void Books_UserControl_Load(object sender, EventArgs e)
        {
            addBookToolStripMenuItem_Click(sender, e);
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resettheposition();
            clearthetexbox();

            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            Department_ComboBox.Visible = true;
            label7.Visible = true;
            label6.Visible = true;

            Accno_textBox.Visible = true;
            Name_textBox.Visible = true;
            Publisher_textBox.Visible = true;
            Isbn_textBox.Visible = true;
            Department_TextBox.Visible = true;
            Author_textBox.Visible = true;
            addBook.Visible = true;

        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resettheposition();
            clearthetexbox();

            Accno_textBox.Location = new Point(332, 162);
            label2.Location = new Point(220, 159);

            label2.Visible = true;
            Delete.Visible = true;
            Accno_textBox.Visible = true;

        }


        private void updateBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resettheposition();
            clearthetexbox();

            Accno_textBox.Location = new Point(332, 70);
            label2.Location = new Point(220, 70);

            label2.Visible = true;
            Accno_textBox.Visible = true;
            button2.Visible = true;
        }
        
        public void clearthetexbox()
        {
            Accno_textBox.Text = "";
            Isbn_textBox.Text = "";
            Name_textBox.Text = "";
            Author_textBox.Text = "";
            Publisher_textBox.Text = "";
            Department_TextBox.Text = "";
        }
        public void resettheposition()
        {
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            Department_ComboBox.Visible = false;
            label7.Visible = false;
            label6.Visible = false;
            button3.Visible = false;

            Accno_textBox.Visible = false;
            Name_textBox.Visible = false;
            Publisher_textBox.Visible = false;
            Isbn_textBox.Visible = false;
            Department_TextBox.Visible = false;
            Author_textBox.Visible = false;

            addBook.Visible = false;
            Delete.Visible = false;
            Update.Visible = false;
            button2.Visible = false;

            Accno_textBox.Location = new Point(509, 150);
            label2.Location = new Point(395, 150);

            Name_textBox.Location = new Point(142, 155);
            label4.Location = new Point(40, 151);

            
            label4.Location = new Point(47, 159);
            Name_textBox.Location = new Point(142, 155);

            dataGridView.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (Accno_textBox.Text == "")
            {
                MessageBox.Show("Enter the Accession No");
            }
            else
            {
                label4.Visible = true;
                label5.Visible = true;
                Department_ComboBox.Visible = true;
                label7.Visible = true;
                label6.Visible = true;

                Name_textBox.Visible = true;
                Publisher_textBox.Visible = true;
                Isbn_textBox.Visible = true;
                Department_TextBox.Visible = true;
                Author_textBox.Visible = true;

                Name_textBox.Location = new Point(332, 180);
                label4.Location = new Point(220, 180);

                Update.Visible = true;
            }
        }

        private void Delete_Click_2(object sender, EventArgs e)
        {
            if (label2.Text == "" || Accno_textBox.Text == "")
            {
                MessageBox.Show("Enter the Accession no of the Book To delete");
            }
            else
            {
                try
                {
                    Form1.con.Open();
                    String q = "delete from BOOKS where AccNo='" + Accno_textBox.Text + "';";
                    SqlCommand sc = new SqlCommand(q, Form1.con);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Book deleted Successfully");
                    clearthetexbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Form1.con.Close();
                }
            }
        }

        private void addBook_Click_2(object sender, EventArgs e)
        {
            if (Accno_textBox.Text == "" ||
                Name_textBox.Text == "" ||
                Publisher_textBox.Text == "" ||
                Isbn_textBox.Text == "" ||
                Department_TextBox.Text == "" ||
                Author_textBox.Text == "")
            {
                MessageBox.Show("Enter all fields");
            }
            else
            {
                try
                {
                    Form1.con.Open();
                    String q = "INSERT INTO BOOKS VALUES('" + Accno_textBox.Text + "','" + Isbn_textBox.Text + "','" + Name_textBox.Text + "','" + Author_textBox.Text + "','" + Publisher_textBox.Text + "',0," + Department_TextBox.Text + ");";
                    SqlCommand sc = new SqlCommand(q, Form1.con);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Book added Successfully");
                    clearthetexbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Book with Accession No already exist");
                }
                finally
                {
                    Form1.con.Close();
                }
            }
        }

        private void Update_Click_2(object sender, EventArgs e)
        {
            if (Accno_textBox.Text == "" || Name_textBox.Text == "" ||
            Publisher_textBox.Text == "" ||
            Isbn_textBox.Text == "" ||
            Department_TextBox.Text == "" ||
            Author_textBox.Text == "")
            {
                MessageBox.Show("Enter all fields");
            }
            else
            {
                try
                {
                    Form1.con.Open();
                    String q = "Update books set ISBN ='" + Isbn_textBox.Text + "', Book_Name = '" + Name_textBox.Text + "', Author_Name = '" + Author_textBox.Text + "', Publisher = '" + Publisher_textBox.Text + "', Dep_Id ='" + Department_TextBox.Text + "' where AccNo = '" + Accno_textBox.Text + "'; ";
                    SqlCommand sc = new SqlCommand(q, Form1.con);
                    sc.ExecuteNonQuery();
                    MessageBox.Show("Updation Successful");
                    clearthetexbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Form1.con.Close();
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clearthetexbox();
            resettheposition();

            label4.Visible = true;
            Name_textBox.Visible = true;
            button3.Visible = true;

            label4.Location = new Point(47, 50);
            Name_textBox.Location = new Point(142, 50);

            dataGridView.Visible = true;
            String q = "SELECT * FROM BOOKS";
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

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Name_textBox.Text == "")
            {
                MessageBox.Show("Enter Book Name");
            }
            else
            {
                String q = "select * from Books where Book_Name like '%"+Name_textBox.Text+"%';";
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
        }
    }
}
