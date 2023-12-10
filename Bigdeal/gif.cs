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
    public partial class gif : Form
    {
      
        public gif()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 7000; 
            timer1.Tick += timer1_Tick;
        }

        private void gif_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
    }

