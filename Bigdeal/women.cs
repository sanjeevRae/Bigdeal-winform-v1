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
    public partial class women : Form
       
    {
        public static women av;
        public static women instance;
        public women()
        {
            InitializeComponent();
            instance = this;
            av = this;

        }

        private void women_Load(object sender, EventArgs e)
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            cart form = new cart();
            form.Show();
            CartItem newItem = new CartItem(
                productId: 1,
                productName: "New neck V long",
                price: 2500,
                quantity: 1);


            cart cartFormInstance = Application.OpenForms.OfType<cart>().FirstOrDefault();

            if (cartFormInstance != null)
            {

                cartFormInstance.AddToCart(newItem);
            }
            else
            {

                cartFormInstance = new cart();
                cartFormInstance.AddToCart(newItem);
                cartFormInstance.Show();
            }

            MessageBox.Show("Item added to cart!");
        }
    }
}
