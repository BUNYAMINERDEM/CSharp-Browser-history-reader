using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "" & textBox7.Text != "" & textBox8.Text != "" & textBox9.Text != "")
                {
                    if (textBox1.Text != textBox2.Text & textBox2.Text != textBox3.Text)
                    {
                        if (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) == 15 && Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) == 15 && Convert.ToInt32(textBox7.Text) + Convert.ToInt32(textBox8.Text) + Convert.ToInt32(textBox9.Text) == 15)
                        {
                            if (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox7.Text) == 15 && Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox8.Text) == 15 && Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox9.Text) == 15)
                            {
                                if (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox9.Text) == 15 && Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox7.Text) == 15)
                                {
                                    Form2 yeni = new Form2();
                                    yeni.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Anahtar Hatalı");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Anahtar Hatalı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Anahtar Hatalı");
                    }
                }
                else
                {
                    MessageBox.Show("Anahtarı Tam giriniz.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}