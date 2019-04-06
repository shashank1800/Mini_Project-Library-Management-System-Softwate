using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class Form1 : Form
    {
        public static SqlConnection con = null;
        public Form1()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            try
            {
                SqlConnectionStringBuilder ab = new SqlConnectionStringBuilder();
                ab.DataSource = "192.168.43.99,1433";
                ab.UserID = "admin";
                ab.Password = "admin";
                ab.InitialCatalog = "DBMS";
                con = new SqlConnection(ab.ConnectionString);

                if(con== null)
                {
                    MessageBox.Show("Connection failed");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            
      
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String querry = "Select  * from System where Username='" + username.Text + "'and Password='" + password.Text + "';";
                con.Open();
                SqlCommand sc = new SqlCommand(querry, con);
                SqlDataReader result = sc.ExecuteReader();
                int count = 0;
                while (result.Read())
                {
                    count++;
                }
                if (count > 0)
                {
                    AppBody ob = new AppBody(this);
                    this.Visible = false;
                    ob.Show();
                    username.Text = "";
                    password.Text = "";
                }
                else
                {
                    MessageBox.Show("Username or Password is Incorrect!!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
