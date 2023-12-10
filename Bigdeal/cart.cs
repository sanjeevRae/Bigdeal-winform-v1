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
    
    public partial class cart : Form
    {
        private DataGridView dataGridViewCart;
        private Label labelGrandTotal; 
        private decimal grandTotal; 
        public static cart xcart;

        public cart()
        {
            InitializeComponent();
            xcart = this;

            dataGridViewCart = new DataGridView();
            dataGridViewCart.Location = new System.Drawing.Point(12, 12); 
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.Size = new System.Drawing.Size(557, 300);
            dataGridViewCart.TabIndex = 0;

            dataGridViewCart.Columns.Add("ProductName", "Product Name");
            dataGridViewCart.Columns.Add("Price", "Price");
            dataGridViewCart.Columns.Add("Quantity", "Quantity");
            dataGridViewCart.Columns.Add("Total", "Total");

            dataGridViewCart.Columns["ProductName"].Width = 150;
            dataGridViewCart.Columns["Price"].Width = 75;
            dataGridViewCart.Columns["Quantity"].Width = 75;
            dataGridViewCart.Columns["Total"].Width = 100;

            dataGridViewCart.Location = new Point(pictureBox1.Left, pictureBox1.Bottom + 10);

            Controls.Add(dataGridViewCart);

           
            labelGrandTotal = new Label();
            labelGrandTotal.Text = "Grand Total: Rs0.00"; 
            labelGrandTotal.Location = new Point(dataGridViewCart.Left, dataGridViewCart.Bottom + 10);
            Controls.Add(labelGrandTotal);
        }

        private void cart_Load(object sender, EventArgs e)
        {
            
        }


        public void AddToCart(CartItem newItem)
        {

            decimal total = newItem.Price * newItem.Quantity;

            dataGridViewCart.Rows.Add(newItem.ProductName, newItem.Price, newItem.Quantity, total);

            grandTotal += total;
            labelGrandTotal.Text = $"Grand Total: Rs{grandTotal:F2}";



        }

       
        private System.Windows.Forms.ListBox listBoxCart;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
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