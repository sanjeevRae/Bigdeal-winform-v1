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
    public partial class Form5 : Form
    {

        public static  Form5 instance;
        public static Form5 heal;
        public static Form5 kta;
        public static Form5 clock;
        public static Form5 ecc;
        public static Form5 VT;
        public static Form5 SS;
        public static Form5 Dog;
        public static Form5 Toy;
        public static Form5 Ball;
        public static Form5 life;
        public static Form5 DIY;
        public static Form5 av;
        public static Form5 sh;
        public static Form5 us;
        public static Form5 buy;
        public static Form5 xcart;
        
        public Form5()
        {
            InitializeComponent();
            instance = this;
            heal = this;
            kta = this;
            clock = this;
            ecc = this;
            VT = this;
            SS = this;
            Dog = this;
            Toy = this;
            Ball = this;
            life = this;
            DIY = this;
            av = this;
            sh = this;
            us = this;
            buy = this;
            xcart = this;
        }

        

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
           
        }

        private void flowLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Visible==true)
            {
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox3.Visible = false;
            }

            else if (pictureBox4.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox4.Visible = false;
            }

            else if (pictureBox5.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox4.Visible = false;
            }

            else if (pictureBox6.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
                pictureBox4.Visible = false;
            }

            else if (pictureBox7.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
                pictureBox4.Visible = false;
            }

            else if (pictureBox8.Visible == true)
            {
                pictureBox3.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox4.Visible = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
                pictureBox3.Visible = false;
            }

            else if (pictureBox4.Visible == true)
            {
                pictureBox3.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox4.Visible = false;
            }

            else if (pictureBox5.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox4.Visible = true;
            }

            else if (pictureBox6.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox4.Visible = false;
            }

            else if (pictureBox7.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox4.Visible = false;
            }

            else if (pictureBox8.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
                pictureBox4.Visible = false;
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            


        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            women form = new women();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            health form = new health ();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            


            this.Hide();
           watches form = new watches();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();







        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {
            this.Hide();
            women form = new women();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide();
            women form = new women();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            health form = new health();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            health form = new health();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Hide();
            health form = new health();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Boys form = new Boys();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Boys form = new Boys();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Boys form = new Boys();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            watches form = new watches();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.Hide();
            watches form = new watches();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            watches form = new watches();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Boys form = new Boys();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Boys form = new Boys();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            console form = new console();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
            console form = new console();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label36_Click(object sender, EventArgs e)
        {
            this.Hide();
            console form = new console();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
            access form = new access();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            this.Hide();
            access form = new access();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Boys form = new Boys();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            this.Hide();
            Boys form = new Boys();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

            this.Hide();
            TV form = new TV();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label20_Click(object sender, EventArgs e)
        {

            this.Hide();
            TV form = new TV();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pet form = new Pet();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pet form = new Pet();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Hide();
            Baby form = new Baby();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label41_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Baby form = new Baby();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sport form = new Sport();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label46_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sport form = new Sport();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label44_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            motor form = new motor();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label35_Click(object sender, EventArgs e)
        {
            this.Hide();
            motor form = new motor();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TV form = new TV ();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Boys form = new Boys();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TV form = new TV();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sport form = new Sport();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Hide();
            motor form = new motor();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Baby form = new Baby();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pet form = new Pet();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            access form = new access();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            TV form = new TV();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            shoes form = new shoes();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            this.Hide();
            shoes form = new shoes();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {
            this.Hide();
            shoes form = new shoes();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void searchbox_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_Click_1(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text.Contains("Console"))
            {
                pictureBox17.Visible = true;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox13.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
            }
            else if (searchBox.Text.Contains("Shoes"))
            {

                pictureBox17.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = true;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox13.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
            }

            else if (searchBox.Text.Contains("Hoodie"))
            {

                pictureBox17.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = true;
                pictureBox16.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox10.Visible = true;
                pictureBox9.Visible = true;
                pictureBox13.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
            }

            else if (searchBox.Text.Contains("xbox"))
            {

                pictureBox17.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = true;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox13.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
            }


            else if (searchBox.Text.Contains("one piece"))
            {

                pictureBox17.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox18.Visible = true;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox13.Visible = false;
                pictureBox19.Visible = false;
            }

            else if (searchBox.Text.Contains("cream"))
            {

                pictureBox17.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox18.Visible = true;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox13.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
            }

            else if (searchBox.Text.Contains("dress"))
            {

                pictureBox17.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = true;
                pictureBox16.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox10.Visible = true;
                pictureBox9.Visible = true;
                pictureBox13.Visible = false;
                pictureBox18.Visible = true;
                pictureBox19.Visible = false;
            }

            else if (searchBox.Text.Contains("watch"))
            {

                pictureBox17.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox24.Visible = true;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox18.Visible = false;
                pictureBox23.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox13.Visible = false;
                pictureBox18.Visible = false;
                pictureBox19.Visible = false;
            }

            else if (searchBox.Text.Contains("cream"))
            {

                pictureBox17.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox18.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox24.Visible = true;
                pictureBox23.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox13.Visible = false;
                pictureBox19.Visible = false;

            }

            else if (searchBox.Text.Contains("drools"))
            {

                pictureBox17.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox18.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = true;
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox13.Visible = false;
                pictureBox19.Visible = false;

            }

            else if (searchBox.Text.Contains("bottle"))
            {

                pictureBox17.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox18.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox13.Visible = false;
                pictureBox19.Visible = true;

            }

            else if (searchBox.Text.Contains("football"))
            {

                pictureBox17.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox18.Visible = false;
                pictureBox20.Visible = true;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox13.Visible = false;
                pictureBox19.Visible = false;

            }

            else if (searchBox.Text.Contains("knife"))
            {

                pictureBox17.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox18.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = true;
                pictureBox22.Visible = false;
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox13.Visible = false;
                pictureBox19.Visible = false;

            }

            else if (searchBox.Text.Contains("multimeter"))
            {

                pictureBox17.Visible = false;
                pictureBox11.Visible = true;
                pictureBox12.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox18.Visible = false;
                pictureBox20.Visible = false;
                pictureBox21.Visible = false;
                pictureBox22.Visible = false;
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox13.Visible = false;
                pictureBox19.Visible = false;

            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            About form = new About();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            About_us form = new About_us ();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            this.Hide();
            cart form = new cart();
            form.FormClosed += (s, args) =>
            {

                this.Show();
            };

            form.Show();
        }
    }
 }
