using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bigdeal
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Hide(); 
            Form4 form = new Form4();

           
            form.FormClosed += (s, args) => 
            {
              
                this.Show();
            };

            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Form4 form = new Form4();


            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();


            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();


            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
