using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staj_degerlendirme
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string mysqlCon = "server=localhost; user=root; database=odev;";
            string query = "SELECT * FROM ogrbilgileri";

            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string mysqlCon = "server=localhost; user=root; database=sorular;";
            string query = @"INSERT INTO sorular (isim, soyisim, ders_kodu, isyeri_degerlendirmesi, sekil_bicim, soru_1, soru_2, soru_3, soru_4, soru_5, soru_6, soru_7, soru_8, soru_9, soru_10, soru_11, soru_12, soru_13, soru_14, soru_15, soru_16, soru_17, soru_18, soru_19) 
                             VALUES (@isim, @soyisim, @ders_kodu, @isyeri_degerlendirmesi, @sekil_bicim, @soru_1, @soru_2, @soru_3, @soru_4, @soru_5, @soru_6, @soru_7, @soru_8, @soru_9, @soru_10, @soru_11, @soru_12, @soru_13, @soru_14, @soru_15, @soru_16, @soru_17, @soru_18, @soru_19)";

            using (MySqlConnection conn = new MySqlConnection(mysqlCon))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@isim", txtIsim.Text);
                        cmd.Parameters.AddWithValue("@soyisim", txtSoyisim.Text);
                        cmd.Parameters.AddWithValue("@ders_kodu", txtDersKodu.Text);
                        cmd.Parameters.AddWithValue("@isyeri_degerlendirmesi", txtIsyeriDegerlendirmesi.Text);
                        cmd.Parameters.AddWithValue("@sekil_bicim", txtSekilBicim.Text);
                        cmd.Parameters.AddWithValue("@soru_1", txtSoru1.Text);
                        cmd.Parameters.AddWithValue("@soru_2", txtSoru2.Text);
                        cmd.Parameters.AddWithValue("@soru_3", txtSoru3.Text);
                        cmd.Parameters.AddWithValue("@soru_4", txtSoru4.Text);
                        cmd.Parameters.AddWithValue("@soru_5", txtSoru5.Text);
                        cmd.Parameters.AddWithValue("@soru_6", txtSoru6.Text);
                        cmd.Parameters.AddWithValue("@soru_7", txtSoru7.Text);
                        cmd.Parameters.AddWithValue("@soru_8", txtSoru8.Text);
                        cmd.Parameters.AddWithValue("@soru_9", txtSoru9.Text);
                        cmd.Parameters.AddWithValue("@soru_10", txtSoru10.Text);
                        cmd.Parameters.AddWithValue("@soru_11", txtSoru11.Text);
                        cmd.Parameters.AddWithValue("@soru_12", txtSoru12.Text);
                        cmd.Parameters.AddWithValue("@soru_13", txtSoru13.Text);
                        cmd.Parameters.AddWithValue("@soru_14", txtSoru14.Text);
                        cmd.Parameters.AddWithValue("@soru_15", txtSoru15.Text);
                        cmd.Parameters.AddWithValue("@soru_16", txtSoru16.Text);
                        cmd.Parameters.AddWithValue("@soru_17", txtSoru17.Text);
                        cmd.Parameters.AddWithValue("@soru_18", txtSoru18.Text);
                        cmd.Parameters.AddWithValue("@soru_19", txtSoru19.Text);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Bilgiler başarıyla kaydedildi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {

                    ((TextBox)control).Text = string.Empty;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
