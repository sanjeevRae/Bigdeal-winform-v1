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
    public partial class Home : Form
    {
        public static Home life;
        public Home()
        {
            InitializeComponent();
            life = this;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form5 form5Instance = Application.OpenForms.OfType<Form5>().FirstOrDefault();

            if (form5Instance == null)
            {

                Form5 form = new Form5();
                form.Show();
            }
            else
            {

                form5Instance.BringToFront();
            }

            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form5 form5Instance = Application.OpenForms.OfType<Form5>().FirstOrDefault();

            if (form5Instance == null)
            {

                Form5 form = new Form5();
                form.Show();
            }
            else
            {

                form5Instance.BringToFront();
            }

            this.Close();
        }
    }
}
