namespace WinFormsApp2
{
    partial class frmyenikayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmyenikayit));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtCinsiyet = new ComboBox();
            txtBolum = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Bold);
            label1.Location = new Point(119, 157);
            label1.Name = "label1";
            label1.Size = new Size(24, 16);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Bold);
            label2.Location = new Point(117, 186);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Bold);
            label3.Location = new Point(117, 215);
            label3.Name = "label3";
            label3.Size = new Size(54, 16);
            label3.TabIndex = 2;
            label3.Text = "Cinsiyet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Bold);
            label4.Location = new Point(119, 241);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 3;
            label4.Text = "Bölüm";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(186, 183);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(178, 23);
            txtSoyad.TabIndex = 5;
            txtSoyad.TextChanged += textBox1_TextChanged;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(186, 154);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(178, 23);
            txtAd.TabIndex = 6;
            txtAd.TextChanged += txtAd_TextChanged;
            // 
            // txtCinsiyet
            // 
            txtCinsiyet.FormattingEnabled = true;
            txtCinsiyet.Items.AddRange(new object[] { "KADIN", "ERKEK" });
            txtCinsiyet.Location = new Point(186, 212);
            txtCinsiyet.Name = "txtCinsiyet";
            txtCinsiyet.Size = new Size(178, 23);
            txtCinsiyet.TabIndex = 7;
            txtCinsiyet.SelectedIndexChanged += txtCinsiyet_SelectedIndexChanged;
            // 
            // txtBolum
            // 
            txtBolum.FormattingEnabled = true;
            txtBolum.Items.AddRange(new object[] { "YÖNETİM BİLİŞİM SİSTEMLERİ", "BİLİŞİM SİSTEMLERİ TEKNOLOJİSİ", "BİLGİSAYAR PROGRAMCILIĞI", "AKADEMİSYEN", "DİĞER..." });
            txtBolum.Location = new Point(186, 241);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(178, 23);
            txtBolum.TabIndex = 8;
            txtBolum.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Bold);
            button1.Location = new Point(92, 335);
            button1.Name = "button1";
            button1.Size = new Size(135, 48);
            button1.TabIndex = 10;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Purple;
            button2.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(335, 336);
            button2.Name = "button2";
            button2.Size = new Size(140, 47);
            button2.TabIndex = 11;
            button2.Text = "ETKİNLİK OLUŞTUR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frmyenikayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(529, 699);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtBolum);
            Controls.Add(txtCinsiyet);
            Controls.Add(txtAd);
            Controls.Add(txtSoyad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmyenikayit";
            Text = "frmyenikayit";
            Load += frmyenikayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private ComboBox txtCinsiyet;
        private ComboBox txtBolum;
        private Button button1;
        private Button button2;
    }
}