namespace staj_degerlendirme;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private MySqlConnection mySqlConnection;

    public Form1()
    {
        InitializeComponent();

        textBoxPassword.PasswordChar = '*';
    }

    private void button1_Click(object sender, EventArgs e)
    {
       
        if (string.IsNullOrWhiteSpace(textBoxUsername.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
        {
            MessageBox.Show("L�tfen kullan�c� ad� ve �ifreyi girin!");
            return;
        }

        string mysqlCon = "server=localhost; user=root; database=giris;";
        string query = "SELECT COUNT(*) FROM giris WHERE adsoyad=@adsoyad AND parola=@parola";

        using (MySqlConnection conn = new MySqlConnection(mysqlCon))
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@adsoyad", textBoxUsername.Text);
                    cmd.Parameters.AddWithValue("@parola", textBoxPassword.Text);

                    int result = Convert.ToInt32(cmd.ExecuteScalar());

                    if (result > 0)
                    {
                        MessageBox.Show("Giri� ba�ar�l�!");
                        Form4 fr2 = new Form4();
                        this.Hide();
                        fr2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullan�c� ad� veya �ifre yanl��!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritaban� ba�lant� hatas�: " + ex.Message);
            }
        }
    }
}
