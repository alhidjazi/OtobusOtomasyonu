namespace OtobusOtomasyon
{
    partial class OtobusIslemleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtoksayisi = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comaramaturu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textharamaoplak = new System.Windows.Forms.TextBox();
            this.checkoksara = new System.Windows.Forms.CheckBox();
            this.checkoturuara = new System.Windows.Forms.CheckBox();
            this.comoturuara = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comoturu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtplakason = new System.Windows.Forms.MaskedTextBox();
            this.txtporth = new System.Windows.Forms.MaskedTextBox();
            this.txtpilkno = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKoltukSayisi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtoksayisi);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.checkoksara);
            this.groupBox1.Controls.Add(this.checkoturuara);
            this.groupBox1.Controls.Add(this.comoturuara);
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 82);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otobüs Arama İşlemleri";
            // 
            // txtoksayisi
            // 
            this.txtoksayisi.Enabled = false;
            this.txtoksayisi.Location = new System.Drawing.Point(165, 32);
            this.txtoksayisi.Name = "txtoksayisi";
            this.txtoksayisi.Size = new System.Drawing.Size(87, 20);
            this.txtoksayisi.TabIndex = 40;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comaramaturu);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textharamaoplak);
            this.groupBox3.Location = new System.Drawing.Point(549, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 64);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HızlıArama";
            // 
            // comaramaturu
            // 
            this.comaramaturu.FormattingEnabled = true;
            this.comaramaturu.Items.AddRange(new object[] {
            "İçeren",
            "İle Başlayan",
            "İle Biten"});
            this.comaramaturu.Location = new System.Drawing.Point(89, 26);
            this.comaramaturu.Name = "comaramaturu";
            this.comaramaturu.Size = new System.Drawing.Size(92, 21);
            this.comaramaturu.TabIndex = 6;
            this.comaramaturu.Text = "Seçiniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Arama Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "OtobusPlaka";
            // 
            // textharamaoplak
            // 
            this.textharamaoplak.Location = new System.Drawing.Point(261, 28);
            this.textharamaoplak.Name = "textharamaoplak";
            this.textharamaoplak.Size = new System.Drawing.Size(100, 20);
            this.textharamaoplak.TabIndex = 0;
            this.textharamaoplak.TextChanged += new System.EventHandler(this.textharamaoplak_TextChanged);
            // 
            // checkoksara
            // 
            this.checkoksara.AutoSize = true;
            this.checkoksara.Location = new System.Drawing.Point(13, 37);
            this.checkoksara.Name = "checkoksara";
            this.checkoksara.Size = new System.Drawing.Size(132, 17);
            this.checkoksara.TabIndex = 38;
            this.checkoksara.Text = "Otobus Kotluk Sayısı : ";
            this.checkoksara.UseVisualStyleBackColor = true;
            this.checkoksara.CheckedChanged += new System.EventHandler(this.checkoksara_CheckedChanged);
            // 
            // checkoturuara
            // 
            this.checkoturuara.AutoSize = true;
            this.checkoturuara.Location = new System.Drawing.Point(262, 35);
            this.checkoturuara.Name = "checkoturuara";
            this.checkoturuara.Size = new System.Drawing.Size(84, 17);
            this.checkoturuara.TabIndex = 37;
            this.checkoturuara.Text = "OyobusTuru";
            this.checkoturuara.UseVisualStyleBackColor = true;
            this.checkoturuara.CheckedChanged += new System.EventHandler(this.checkoturuara_CheckedChanged);
            // 
            // comoturuara
            // 
            this.comoturuara.Enabled = false;
            this.comoturuara.FormattingEnabled = true;
            this.comoturuara.Items.AddRange(new object[] {
            "Suit",
            "Classik"});
            this.comoturuara.Location = new System.Drawing.Point(352, 30);
            this.comoturuara.Name = "comoturuara";
            this.comoturuara.Size = new System.Drawing.Size(121, 21);
            this.comoturuara.TabIndex = 36;
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAra.Image = global::OtobusOtomasyon.Properties.Resources.Ara;
            this.btnAra.Location = new System.Drawing.Point(479, 26);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(64, 28);
            this.btnAra.TabIndex = 34;
            this.btnAra.Text = "Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(7, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 287);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mevcut Otobüs Listesi İşlemleri";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comoturu);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtid);
            this.groupBox6.Controls.Add(this.txtplakason);
            this.groupBox6.Controls.Add(this.txtporth);
            this.groupBox6.Controls.Add(this.txtpilkno);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txtKoltukSayisi);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox6.Location = new System.Drawing.Point(21, 31);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(298, 250);
            this.groupBox6.TabIndex = 67;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Otobüs Ekleme Düzenleme Silme İşlemleri";
            // 
            // comoturu
            // 
            this.comoturu.FormattingEnabled = true;
            this.comoturu.Items.AddRange(new object[] {
            "Suit",
            "Classik"});
            this.comoturu.Location = new System.Drawing.Point(137, 180);
            this.comoturu.Name = "comoturu";
            this.comoturu.Size = new System.Drawing.Size(108, 21);
            this.comoturu.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "OtobusID";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(137, 46);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(33, 20);
            this.txtid.TabIndex = 71;
            // 
            // txtplakason
            // 
            this.txtplakason.Location = new System.Drawing.Point(212, 99);
            this.txtplakason.Name = "txtplakason";
            this.txtplakason.Size = new System.Drawing.Size(33, 20);
            this.txtplakason.TabIndex = 69;
            // 
            // txtporth
            // 
            this.txtporth.Location = new System.Drawing.Point(173, 99);
            this.txtporth.Name = "txtporth";
            this.txtporth.Size = new System.Drawing.Size(33, 20);
            this.txtporth.TabIndex = 68;
            // 
            // txtpilkno
            // 
            this.txtpilkno.Location = new System.Drawing.Point(137, 99);
            this.txtpilkno.Name = "txtpilkno";
            this.txtpilkno.Size = new System.Drawing.Size(33, 20);
            this.txtpilkno.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Plaka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Koltuk Sayısı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "OyobusTuru";
            // 
            // txtKoltukSayisi
            // 
            this.txtKoltukSayisi.Location = new System.Drawing.Point(137, 137);
            this.txtKoltukSayisi.Name = "txtKoltukSayisi";
            this.txtKoltukSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKoltukSayisi.TabIndex = 57;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(565, 360);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.btnYeni);
            this.groupBox4.Controls.Add(this.btnSil);
            this.groupBox4.Controls.Add(this.btnEkle);
            this.groupBox4.Controls.Add(this.btnGuncelle);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(7, 381);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 67);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler İnfo :";
            // 
            // btnYeni
            // 
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYeni.ForeColor = System.Drawing.Color.Green;
            this.btnYeni.Image = global::OtobusOtomasyon.Properties.Resources.if_edit_clear_118917;
            this.btnYeni.Location = new System.Drawing.Point(7, 29);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 32);
            this.btnYeni.TabIndex = 16;
            this.btnYeni.Text = "Temizle";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnYeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSil.ForeColor = System.Drawing.Color.Green;
            this.btnSil.Image = global::OtobusOtomasyon.Properties.Resources.CikisIcon;
            this.btnSil.Location = new System.Drawing.Point(88, 29);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 32);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEkle.ForeColor = System.Drawing.Color.Green;
            this.btnEkle.Image = global::OtobusOtomasyon.Properties.Resources.Ekle;
            this.btnEkle.Location = new System.Drawing.Point(169, 29);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 32);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuncelle.ForeColor = System.Drawing.Color.Green;
            this.btnGuncelle.Image = global::OtobusOtomasyon.Properties.Resources.Guncelle;
            this.btnGuncelle.Location = new System.Drawing.Point(250, 29);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 32);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // OtobusIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 458);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "OtobusIslemleri";
            this.Text = "Otobüs İşlemleri";
            this.Activated += new System.EventHandler(this.OtobusIslemleri_Activated);
            this.Load += new System.EventHandler(this.OtobusIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textharamaoplak;
        private System.Windows.Forms.CheckBox checkoksara;
        private System.Windows.Forms.CheckBox checkoturuara;
        private System.Windows.Forms.ComboBox comoturuara;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.MaskedTextBox txtplakason;
        private System.Windows.Forms.MaskedTextBox txtporth;
        private System.Windows.Forms.MaskedTextBox txtpilkno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKoltukSayisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox comaramaturu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comoturu;
        private System.Windows.Forms.MaskedTextBox txtoksayisi;

    }
}