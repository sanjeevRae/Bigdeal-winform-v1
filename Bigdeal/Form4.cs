using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bigdeal
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text + "' and password= '" + txtpassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new Form5().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtpassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();
        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtpassword.PasswordChar = '\0';
                


            }
            else
            {
                txtpassword.PasswordChar = '*';
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkbxShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtpassword.PasswordChar = '\0';



            }
            else
            {
                txtpassword.PasswordChar = '*';

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text + "' and password= '" + txtpassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new Form5().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtpassword.Text = "";
                txtUsername.Focus();
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            txtUsername.Text = "";
            txtpassword.Text = "";
            txtUsername.Focus();


        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
