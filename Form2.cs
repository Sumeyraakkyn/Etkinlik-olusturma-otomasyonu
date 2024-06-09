using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
      

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             // SQL BAĞLANTISI KURULDU.

            SqlConnection connection = new SqlConnection("Data Source=Sümeyra\\SUMEYRA09;Initial Catalog=sumeyraybs;Integrated Security=True;MultipleActiveResultSets=True");
            connection.Open();


            string etkinlikAd = textBox2.Text;
            string etkinlikTur = comboBox1.Text;
            string olusturan = textBox1.Text;
            



            SqlCommand command = new SqlCommand("INSERT INTO dbo.Etkinlikler (EtkinlikAdi,EtkinlikTuru,Olusturan) VALUES (@EtkinlikAdi,@EtkinlikTuru,@Olusturan)", connection);

            command.Parameters.AddWithValue("@EtkinlikAdi", etkinlikAd);
            command.Parameters.AddWithValue("@EtkinlikTuru", etkinlikTur);
            command.Parameters.AddWithValue("@Olusturan", olusturan);
           

            command.ExecuteNonQuery();



            MessageBox.Show($"{etkinlikAd} etkinliği ekleme başarılı.");


            connection.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // OLUŞTURULAN ETKİNLİKLERİMİZİ FORM4 UYGULAMASINDA GÖRMEK İÇİN ATAMA YAPTIK.

            MailAddressCollection frm4 = new MailAddressCollection();
            frm4.Show();
            this.Hide();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

