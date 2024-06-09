using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Net.Security;

namespace WinFormsApp2
    
{  
    public partial class frmyenikayit : Form
    {
        private string connectionString;

        public frmyenikayit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmyenikayit_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQL DE OLUŞTURDUĞUMUZ DOSYA İLE BAĞLANTI KURDUK. VERİLERİ OKUTTUK.


            SqlConnection connection = new SqlConnection("Data Source=Sümeyra\\SUMEYRA09;Initial Catalog=sumeyraybs;Integrated Security=True;MultipleActiveResultSets=True");
            connection.Open();


            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string gender = txtCinsiyet.Text;
            string section = txtBolum.Text;

           

            SqlCommand command = new SqlCommand("INSERT INTO dbo.Ogrenciler (Name,Surname,Section,Gender) VALUES (@Name,@Surname,@Section,@Gender)",connection);

            command.Parameters.AddWithValue("@Name", ad);
            command.Parameters.AddWithValue("@Surname", soyad);
            command.Parameters.AddWithValue("@Gender", gender);
            command.Parameters.AddWithValue("@Section", section);

            command.ExecuteNonQuery();

            MessageBox.Show("Kayıt ekleme başarılı.");


            connection.Close();


        }
        private void txtCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtEposta_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 yeniform = new Form2();
            this.Hide();
            yeniform.Show();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
