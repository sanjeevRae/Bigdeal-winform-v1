﻿using System;
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
    public partial class Boys : Form
    {
        public static Boys kta;
        public Boys()
        {
            InitializeComponent();
            kta = this;
        }

        private void Boys_Load(object sender, EventArgs e)
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Visible == true)
            {
                pictureBox11.Visible = true;
                pictureBox12.Visible = false;
                pictureBox3.Visible = false;
            }

            else if (pictureBox11.Visible == true)
            {
                pictureBox12.Visible = true;
                pictureBox11.Visible = false;
                pictureBox3.Visible = false;

            }

            else if (pictureBox12.Visible == true)
            {
                pictureBox3.Visible = true;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Visible == true)
            {
                pictureBox11.Visible = false;
                pictureBox12.Visible = true;
                pictureBox3.Visible = false;
            }

            else if (pictureBox11.Visible == true)
            {
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox3.Visible = true;

            }

            else if (pictureBox12.Visible == true)
            {
                pictureBox11.Visible = true;
                pictureBox3.Visible = false;
                pictureBox12.Visible = false;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            CartItem newItem = new CartItem(
                productId: 1,
                productName: "Hoodie set",
                price: 4500,
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
