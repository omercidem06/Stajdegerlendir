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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                string mysqlCon = "server=localhost; user=root; database=odev;";
                string query = @"INSERT INTO ogrbilgileri (kayitNo, tcKimlikNo, ad, soyad, ogrenciNo, sinif, cepTelNo, eposta, stajKodu, stajYeri, stajbaslangic, stajbitis, stajEvraklari, zorunluStajYazisi, end300400Yazisi, basvuruDilekçesi, kabulYazisi, müstehaklıkBelgesi, kimlikFotokopisi, stajDegerlendirmeFormu, stajrapor) 
                             VALUES (@kayitNo ,@tcKimlikNo, @ad, @soyad, @ogrenciNo, @sinif, @cepTelNo, @eposta, @stajKodu, @stajYeri, @stajbaslangic, @stajbitis, @stajEvraklari, @zorunluStajYazisi, @end300400Yazisi, @basvuruDilekçesi, @kabulYazisi, @müstehaklıkBelgesi, @kimlikFotokopisi, @stajDegerlendirmeFormu, @stajrapor)";

                using (MySqlConnection conn = new MySqlConnection(mysqlCon))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {

                            cmd.Parameters.AddWithValue("@kayitNo", textBoxkayıtno.Text);
                            cmd.Parameters.AddWithValue("@tcKimlikNo", textBoxTcKimlikNo.Text);
                            cmd.Parameters.AddWithValue("@ad", textBoxAd.Text);
                            cmd.Parameters.AddWithValue("@soyad", textBoxSoyad.Text);
                            cmd.Parameters.AddWithValue("@ogrenciNo", textBoxOgrenciNo.Text);
                            cmd.Parameters.AddWithValue("@sinif", textBoxSinif.Text);
                            cmd.Parameters.AddWithValue("@cepTelNo", textBoxCepTelNo.Text);
                            cmd.Parameters.AddWithValue("@eposta", textBoxEposta.Text);
                            cmd.Parameters.AddWithValue("@stajKodu", textBoxStajKodu.Text);
                            cmd.Parameters.AddWithValue("@stajYeri", textBoxStajYeri.Text);
                            cmd.Parameters.AddWithValue("@stajbaslangic", textStajBaslangic.Text);
                            cmd.Parameters.AddWithValue("@stajbitis", textStajBitis.Text);
                            cmd.Parameters.AddWithValue("@stajEvraklari", textBoxStajEvraklari.Text);
                            cmd.Parameters.AddWithValue("@zorunluStajYazisi", textBoxZorunluStajYazisi.Text);
                            cmd.Parameters.AddWithValue("@end300400Yazisi", textBoxEnd300400Yazisi.Text);
                            cmd.Parameters.AddWithValue("@basvuruDilekçesi", textBoxBasvuruDilekcesi.Text);
                            cmd.Parameters.AddWithValue("@kabulYazisi", textBoxKabulYazisi.Text);
                            cmd.Parameters.AddWithValue("@müstehaklıkBelgesi", textBoxMustehaklikBelgesi.Text);
                            cmd.Parameters.AddWithValue("@kimlikFotokopisi", textBoxKimlikFotokopisi.Text);
                            cmd.Parameters.AddWithValue("@stajDegerlendirmeFormu", textBoxStajDegerlendirmeFormu.Text);
                            cmd.Parameters.AddWithValue("@stajrapor", textBoxStajrapor.Text);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Bilgiler başarıyla kaydedildi.");
                            Form5 form5 = new Form5();
                            form5.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message);
                    }
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
          
            Form5 form5 = new Form5();
            form5.Show();

        }
    }
}



