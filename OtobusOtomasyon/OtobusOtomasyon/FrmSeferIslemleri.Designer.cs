namespace OtobusOtomasyon
{
    partial class FrmSeferIslemleri
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comopara = new System.Windows.Forms.ComboBox();
            this.checkopara = new System.Windows.Forms.CheckBox();
            this.checksoforara = new System.Windows.Forms.CheckBox();
            this.comseforara = new System.Windows.Forms.ComboBox();
            this.checkkalisara = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNeredenAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.textseferid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbKalkisSehri = new System.Windows.Forms.ComboBox();
            this.cmbVarisSehri = new System.Windows.Forms.ComboBox();
            this.cmbOtobusPlaka = new System.Windows.Forms.ComboBox();
            this.cmbMuavin = new System.Windows.Forms.ComboBox();
            this.cmbSofor = new System.Windows.Forms.ComboBox();
            this.txtTahminiSure = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskbilettutari = new System.Windows.Forms.MaskedTextBox();
            this.mskvarissaat = new System.Windows.Forms.MaskedTextBox();
            this.mskkalssaat = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(360, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(789, 439);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sefer Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(771, 420);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRaporAl.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnRaporAl.Location = new System.Drawing.Point(620, 15);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(75, 32);
            this.btnRaporAl.TabIndex = 10;
            this.btnRaporAl.Text = "Rapor Al";
            this.btnRaporAl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnRaporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRaporAl.UseVisualStyleBackColor = true;
            // 
            // cmbNereye
            // 
            this.cmbNereye.Enabled = false;
            this.cmbNereye.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "K.maraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.cmbNereye.Location = new System.Drawing.Point(148, 65);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(98, 21);
            this.cmbNereye.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(5, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1144, 112);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sefer Ara :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comopara);
            this.groupBox5.Controls.Add(this.checkopara);
            this.groupBox5.Controls.Add(this.checksoforara);
            this.groupBox5.Controls.Add(this.comseforara);
            this.groupBox5.Controls.Add(this.checkkalisara);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.txtNeredenAd);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.btnRaporAl);
            this.groupBox5.Controls.Add(this.cmbNereye);
            this.groupBox5.ForeColor = System.Drawing.Color.Green;
            this.groupBox5.Location = new System.Drawing.Point(427, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(708, 94);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sefer Bilgi ";
            // 
            // comopara
            // 
            this.comopara.Enabled = false;
            this.comopara.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comopara.FormattingEnabled = true;
            this.comopara.Items.AddRange(new object[] {
            "565448",
            "458766",
            "546879",
            "646318",
            "633355",
            "595385",
            "695999"});
            this.comopara.Location = new System.Drawing.Point(426, 65);
            this.comopara.Name = "comopara";
            this.comopara.Size = new System.Drawing.Size(96, 21);
            this.comopara.TabIndex = 35;
            // 
            // checkopara
            // 
            this.checkopara.AutoSize = true;
            this.checkopara.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkopara.Location = new System.Drawing.Point(429, 34);
            this.checkopara.Name = "checkopara";
            this.checkopara.Size = new System.Drawing.Size(80, 17);
            this.checkopara.TabIndex = 34;
            this.checkopara.Text = "Otobus ID :";
            this.checkopara.UseVisualStyleBackColor = true;
            this.checkopara.CheckedChanged += new System.EventHandler(this.checkopara_CheckedChanged);
            // 
            // checksoforara
            // 
            this.checksoforara.AutoSize = true;
            this.checksoforara.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checksoforara.Location = new System.Drawing.Point(310, 33);
            this.checksoforara.Name = "checksoforara";
            this.checksoforara.Size = new System.Drawing.Size(72, 17);
            this.checksoforara.TabIndex = 33;
            this.checksoforara.Text = "Şoför Adi ";
            this.checksoforara.UseVisualStyleBackColor = true;
            this.checksoforara.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comseforara
            // 
            this.comseforara.Enabled = false;
            this.comseforara.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comseforara.FormattingEnabled = true;
            this.comseforara.Items.AddRange(new object[] {
            "Ahmed",
            "Moaaz",
            "Ali",
            "Samer",
            "Adel",
            "Adbdullrahman",
            "Furkan"});
            this.comseforara.Location = new System.Drawing.Point(292, 65);
            this.comseforara.Name = "comseforara";
            this.comseforara.Size = new System.Drawing.Size(90, 21);
            this.comseforara.TabIndex = 32;
            // 
            // checkkalisara
            // 
            this.checkkalisara.AutoSize = true;
            this.checkkalisara.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkkalisara.Location = new System.Drawing.Point(172, 34);
            this.checkkalisara.Name = "checkkalisara";
            this.checkkalisara.Size = new System.Drawing.Size(60, 17);
            this.checkkalisara.TabIndex = 31;
            this.checkkalisara.Text = "Nereye";
            this.checkkalisara.UseVisualStyleBackColor = true;
            this.checkkalisara.CheckedChanged += new System.EventHandler(this.checkkalisara_CheckedChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Image = global::OtobusOtomasyon.Properties.Resources.Ara;
            this.button1.Location = new System.Drawing.Point(620, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 30;
            this.button1.Text = "Ara";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNeredenAd
            // 
            this.txtNeredenAd.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtNeredenAd.Location = new System.Drawing.Point(22, 68);
            this.txtNeredenAd.Name = "txtNeredenAd";
            this.txtNeredenAd.ReadOnly = true;
            this.txtNeredenAd.Size = new System.Drawing.Size(85, 20);
            this.txtNeredenAd.TabIndex = 27;
            this.txtNeredenAd.Text = "Kastamonu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nereden :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnKapat);
            this.groupBox4.Controls.Add(this.btnYeni);
            this.groupBox4.Controls.Add(this.btnSil);
            this.groupBox4.Controls.Add(this.btnEkle);
            this.groupBox4.Controls.Add(this.btnGuncelle);
            this.groupBox4.ForeColor = System.Drawing.Color.Green;
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(409, 94);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler İnfo :";
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKapat.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnKapat.Image = global::OtobusOtomasyon.Properties.Resources.CikisIcon;
            this.btnKapat.Location = new System.Drawing.Point(327, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 40);
            this.btnKapat.TabIndex = 44;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnKapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYeni.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnYeni.Image = global::OtobusOtomasyon.Properties.Resources.Temizle;
            this.btnYeni.Location = new System.Drawing.Point(3, 23);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 40);
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
            this.btnSil.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSil.Image = global::OtobusOtomasyon.Properties.Resources.sil;
            this.btnSil.Location = new System.Drawing.Point(84, 23);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 40);
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
            this.btnEkle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEkle.Image = global::OtobusOtomasyon.Properties.Resources.Ekle;
            this.btnEkle.Location = new System.Drawing.Point(165, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 40);
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
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnGuncelle.Image = global::OtobusOtomasyon.Properties.Resources.Guncelle;
            this.btnGuncelle.Location = new System.Drawing.Point(246, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 40);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // textseferid
            // 
            this.textseferid.Enabled = false;
            this.textseferid.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textseferid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textseferid.Location = new System.Drawing.Point(154, 25);
            this.textseferid.Name = "textseferid";
            this.textseferid.Size = new System.Drawing.Size(44, 41);
            this.textseferid.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(60, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Sefer ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(45, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Varış Şehri :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(45, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Otobus ID :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(44, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Muavin Adi : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(45, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Şoför Adi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(45, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kalkış Zamani :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(45, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Variş Zamani : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(45, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tahmini Süre :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(45, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Bilet Tutari :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(45, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Kalkış Şehri :";
            // 
            // cmbKalkisSehri
            // 
            this.cmbKalkisSehri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbKalkisSehri.FormattingEnabled = true;
            this.cmbKalkisSehri.Items.AddRange(new object[] {
            "Kastamonu"});
            this.cmbKalkisSehri.Location = new System.Drawing.Point(154, 79);
            this.cmbKalkisSehri.Name = "cmbKalkisSehri";
            this.cmbKalkisSehri.Size = new System.Drawing.Size(147, 28);
            this.cmbKalkisSehri.TabIndex = 1;
            this.cmbKalkisSehri.Text = "Seç";
            // 
            // cmbVarisSehri
            // 
            this.cmbVarisSehri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbVarisSehri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbVarisSehri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbVarisSehri.FormattingEnabled = true;
            this.cmbVarisSehri.Location = new System.Drawing.Point(154, 118);
            this.cmbVarisSehri.Name = "cmbVarisSehri";
            this.cmbVarisSehri.Size = new System.Drawing.Size(147, 28);
            this.cmbVarisSehri.TabIndex = 2;
            this.cmbVarisSehri.Text = "Seç";
            // 
            // cmbOtobusPlaka
            // 
            this.cmbOtobusPlaka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbOtobusPlaka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOtobusPlaka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbOtobusPlaka.FormattingEnabled = true;
            this.cmbOtobusPlaka.Location = new System.Drawing.Point(154, 158);
            this.cmbOtobusPlaka.Name = "cmbOtobusPlaka";
            this.cmbOtobusPlaka.Size = new System.Drawing.Size(147, 28);
            this.cmbOtobusPlaka.TabIndex = 3;
            this.cmbOtobusPlaka.Text = "Seç";
            // 
            // cmbMuavin
            // 
            this.cmbMuavin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMuavin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMuavin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbMuavin.FormattingEnabled = true;
            this.cmbMuavin.Location = new System.Drawing.Point(154, 243);
            this.cmbMuavin.Name = "cmbMuavin";
            this.cmbMuavin.Size = new System.Drawing.Size(147, 28);
            this.cmbMuavin.TabIndex = 5;
            this.cmbMuavin.Text = "Seç";
            this.cmbMuavin.SelectedIndexChanged += new System.EventHandler(this.cmbMuavin_SelectedIndexChanged);
            // 
            // cmbSofor
            // 
            this.cmbSofor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSofor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSofor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbSofor.FormattingEnabled = true;
            this.cmbSofor.Location = new System.Drawing.Point(154, 203);
            this.cmbSofor.Name = "cmbSofor";
            this.cmbSofor.Size = new System.Drawing.Size(147, 28);
            this.cmbSofor.TabIndex = 4;
            this.cmbSofor.Text = "Seç";
            this.cmbSofor.SelectedIndexChanged += new System.EventHandler(this.cmbSofor_SelectedIndexChanged);
            // 
            // txtTahminiSure
            // 
            this.txtTahminiSure.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTahminiSure.Location = new System.Drawing.Point(154, 362);
            this.txtTahminiSure.Name = "txtTahminiSure";
            this.txtTahminiSure.Size = new System.Drawing.Size(147, 26);
            this.txtTahminiSure.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textseferid);
            this.groupBox2.Controls.Add(this.mskbilettutari);
            this.groupBox2.Controls.Add(this.mskvarissaat);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.mskkalssaat);
            this.groupBox2.Controls.Add(this.txtTahminiSure);
            this.groupBox2.Controls.Add(this.cmbSofor);
            this.groupBox2.Controls.Add(this.cmbMuavin);
            this.groupBox2.Controls.Add(this.cmbOtobusPlaka);
            this.groupBox2.Controls.Add(this.cmbVarisSehri);
            this.groupBox2.Controls.Add(this.cmbKalkisSehri);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(5, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 439);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(223, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "TL";
            // 
            // mskbilettutari
            // 
            this.mskbilettutari.Location = new System.Drawing.Point(154, 399);
            this.mskbilettutari.Name = "mskbilettutari";
            this.mskbilettutari.Size = new System.Drawing.Size(62, 26);
            this.mskbilettutari.TabIndex = 9;
            // 
            // mskvarissaat
            // 
            this.mskvarissaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskvarissaat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskvarissaat.Location = new System.Drawing.Point(155, 318);
            this.mskvarissaat.Mask = "00/00/0000 90:00";
            this.mskvarissaat.Name = "mskvarissaat";
            this.mskvarissaat.Size = new System.Drawing.Size(146, 26);
            this.mskvarissaat.TabIndex = 7;
            this.mskvarissaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskkalssaat
            // 
            this.mskkalssaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskkalssaat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mskkalssaat.Location = new System.Drawing.Point(154, 279);
            this.mskkalssaat.Mask = "00/00/0000 90:00";
            this.mskkalssaat.Name = "mskkalssaat";
            this.mskkalssaat.Size = new System.Drawing.Size(147, 26);
            this.mskkalssaat.TabIndex = 6;
            this.mskkalssaat.ValidatingType = typeof(System.DateTime);
            // 
            // FrmSeferIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 579);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSeferIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSeferIslemleri";
            this.Activated += new System.EventHandler(this.FrmSeferIslemleri_Activated);
            this.Load += new System.EventHandler(this.FrmSeferIslemleri_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRaporAl;
        private System.Windows.Forms.ComboBox cmbNereye;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbKalkisSehri;
        private System.Windows.Forms.ComboBox cmbVarisSehri;
        private System.Windows.Forms.ComboBox cmbOtobusPlaka;
        private System.Windows.Forms.ComboBox cmbMuavin;
        private System.Windows.Forms.ComboBox cmbSofor;
        private System.Windows.Forms.TextBox txtTahminiSure;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mskvarissaat;
        private System.Windows.Forms.MaskedTextBox mskkalssaat;
        private System.Windows.Forms.MaskedTextBox mskbilettutari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkkalisara;
        private System.Windows.Forms.TextBox txtNeredenAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textseferid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comopara;
        private System.Windows.Forms.CheckBox checkopara;
        private System.Windows.Forms.CheckBox checksoforara;
        private System.Windows.Forms.ComboBox comseforara;
    }
}