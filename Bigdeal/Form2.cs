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
    public partial class Form2 : Form
     
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';


            }
            else
            {
                txtpassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }




            private void button1_Click(object sender, EventArgs e)
            {
                if (txtUsername.Text == "" && txtpassword.Text == "" && txtComPassword.Text == "")
                {
                    MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtpassword.Text == txtComPassword.Text)
                {
                    con.Open();
                    string register = "INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "','" + txtpassword.Text + "')";
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                txtUsername.Text = "";
                txtpassword.Text = "";
                txtComPassword.Text = "";

                    MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Passwords do not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Text = "";
                    txtComPassword.Text = "";
                    txtpassword.Focus();
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';


            }
            else
            {
                txtpassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtpassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtpassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtpassword.Text == txtComPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "','" + txtpassword.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtpassword.Text = "";
                txtComPassword.Text = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords do not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtpassword.Text = "";
                txtComPassword.Text = "";
                txtpassword.Focus();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtComPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }
