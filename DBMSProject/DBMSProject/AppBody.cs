using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSProject
{
    public partial class AppBody : Form
    {
        public Form1 ob;
        public AppBody(Form1 x)
        {
            ob = x;
            InitializeComponent();
            
        }

        private void Appbody_Load(object sender, EventArgs e)
        {
            Transaction_button_Click(sender,e);
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            ob.Visible = true;
            this.Close();
            Form1.con.Close();
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Transaction_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ContentPanel.Controls.Contains(Transaction_UserControl.Instance))
                {
                    ContentPanel.Controls.Add(Transaction_UserControl.Instance);
                    Transaction_UserControl.Instance.Dock = DockStyle.Fill;
                    Transaction_UserControl.Instance.BringToFront();
                    
                }
                else
                {
                    Transaction_UserControl.Instance.BringToFront();
                }
            }catch(Exception ex)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ContentPanel.Controls.Contains(Books_UserControl.Instance))
                {
                    ContentPanel.Controls.Add(Books_UserControl.Instance);
                    Books_UserControl.Instance.Dock = DockStyle.Fill;
                    Books_UserControl.Instance.BringToFront();
                }
                else
                {
                    Books_UserControl.Instance.BringToFront();
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ContentPanel.Controls.Contains(Borrowers_UserControl.Instance))
                {
                    ContentPanel.Controls.Add(Borrowers_UserControl.Instance);
                    Borrowers_UserControl.Instance.Dock = DockStyle.Fill;
                    Borrowers_UserControl.Instance.BringToFront();
                }
                else
                {
                    Borrowers_UserControl.Instance.BringToFront();
                }
            }catch(Exception ex)
            {

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Transaction_button_Click(sender,e);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ContentPanel.Controls.Contains(About_UserControl.Instance))
                {
                    ContentPanel.Controls.Add(About_UserControl.Instance);
                    About_UserControl.Instance.Dock = DockStyle.Fill;
                    About_UserControl.Instance.BringToFront();
                }
                else
                {
                    About_UserControl.Instance.BringToFront();
                }
            }catch(Exception ex)
            {
                

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ContentPanel.Controls.Contains(AddUser_UserControl.Instance))
                {
                    ContentPanel.Controls.Add(AddUser_UserControl.Instance);
                    AddUser_UserControl.Instance.Dock = DockStyle.Fill;
                    AddUser_UserControl.Instance.BringToFront();
                }
                else
                {
                    AddUser_UserControl.Instance.BringToFront();
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            button1_Click_1(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            button2_Click_1(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            button3_Click_1(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            button4_Click_1(sender, e);
        }
    }
}
