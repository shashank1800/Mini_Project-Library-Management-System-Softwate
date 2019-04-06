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
    public partial class AddUser_UserControl : UserControl
    {
        private static AddUser_UserControl _instance;
        public static AddUser_UserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AddUser_UserControl();

                }
                return _instance;
            }
        }
        public AddUser_UserControl()
        {
            InitializeComponent();
        }

        private void AddUser_UserControl_Load(object sender, EventArgs e)
        {
            
        }

        public void clearthetext()
        {
            username.Text = "";
            password.Text = "";
            confirmpassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (username.Text == ""|| password.Text == "" || confirmpassword.Text == "")
            {
                MessageBox.Show("Enter all fields");
            }
            
            else
            {
                if (password.Text != confirmpassword.Text)
                {
                    MessageBox.Show("Password do not match");
                }
                else
                {
                    try
                    {
                        Form1.con.Open();
                        String q = "select * from System where Username='" + username.Text + "' and Password='" + password.Text + "';";
                        SqlCommand sc = new SqlCommand(q, Form1.con);
                        SqlDataReader ab = sc.ExecuteReader();
                        
                        while (ab.Read())
                        {
                            count++;
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Form1.con.Close();
                    }
                    try{ 
                        if (count == 0) {
                            Form1.con.Open();
                            String q = "insert into System values('" + username.Text + "','" + password.Text + "');";
                            SqlCommand sc = new SqlCommand(q, Form1.con);
                            sc.ExecuteNonQuery();
                            MessageBox.Show("SignUp Successful");
                            clearthetext();
                        }else
                        {
                            MessageBox.Show("User Already Exist");
                        }
                       
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Form1.con.Close();
                    }
                }

            }
        }
    }
}
