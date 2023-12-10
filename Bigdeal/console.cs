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
    public partial class console : Form
    {
        public static console ecc;
        public console()
        {
            InitializeComponent();
            ecc = this;
        }

        private void console_Load(object sender, EventArgs e)
        {

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            CartItem newItem = new CartItem(
                productId: 1,
                productName: "Super console",
                price: 15300,
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
