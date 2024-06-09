using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp2
{
    public partial class MailAddressCollection : Form
    {
        public MailAddressCollection()
        {
            InitializeComponent();
        }

        void MailGonder()
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Sümeyra\\SUMEYRA09;Initial Catalog=sumeyraybs;Integrated Security=True;MultipleActiveResultSets=True");
            connection.Open();

            // SQL BAĞLANTISI KURULDU VERİLERİ OKUTTUK. OLUŞTURULAN ETKİNLİKLERİ GÖRMEK İÇİN SQL BAĞLANTIMIZDAN VERİLERİ ÇEKTİK.


            SqlCommand command = new SqlCommand("(Select * from Etkinlikler)", connection);



            DataTable dt = new DataTable();

            SqlDataReader reader = command.ExecuteReader();

            dt.Load(reader);

            dataGridView1.DataSource = dt;


            reader.Close();

            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
