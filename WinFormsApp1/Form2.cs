using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Google Crome")
                {
                    string google = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default\History";
                    SQLiteConnection cn = new SQLiteConnection("Data Source=" + google + ";Version=3;New=False;Compress=True;");
                    cn.Open();
                    SQLiteDataAdapter sd = new SQLiteDataAdapter("select url,title,visit_count,last_visit_time from urls order by last_visit_time desc", cn);
                    DataSet ds = new DataSet();
                    sd.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    cn.Close();
                }
                else if (comboBox1.Text == "Mozilla Firefox")
                {
                    string mozilla = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Mozilla\Firefox\Profiles\2omnu1dg.default\places.sqlite";
                    SQLiteConnection cn = new SQLiteConnection("Data Source=" + mozilla + ";Version=3;New=False;Compress=True;");
                    cn.Open();
                    SQLiteDataAdapter sd = new SQLiteDataAdapter("select url,title,visit_count,last_visit_date from moz_places order by last_visit_date desc", cn);
                    DataSet ds = new DataSet();
                    sd.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    cn.Close();
                }
                else if (comboBox1.Text == "Apple Safari")
                {
                    string apple = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Apple Computer\Safari\WebpageIcons.db";
                    SQLiteConnection cn = new SQLiteConnection("Data Source=" + apple + ";Version=3;New=False;Compress=True;");
                    cn.Open();
                    SQLiteDataAdapter sd = new SQLiteDataAdapter("* from PageURL", cn);
                    DataSet ds = new DataSet();
                    sd.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    cn.Close();
                }
                else if (comboBox1.Text == "Opera")
                {
                    string opera = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Opera Software\Opera Stable\History";
                    SQLiteConnection cn = new SQLiteConnection("Data Source=" + opera + ";Version=3;New=False;Compress=True;");
                    cn.Open();
                    SQLiteDataAdapter sd = new SQLiteDataAdapter("select * from URLS", cn);
                    DataSet ds = new DataSet();
                    sd.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Tarayıcı Seçimi Yapınız.");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Geçmiş bulunamadı.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
