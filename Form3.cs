using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

       

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // FORM1 E ATAMA YAPTIK.
            Form1 yeniform = new Form1();
            this.Hide();
            yeniform.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //YENİ KAYIT FORMUNA ATAMA YAPTIK.
            frmyenikayit fr = new frmyenikayit();
            fr.Show();

        }
    }
}
