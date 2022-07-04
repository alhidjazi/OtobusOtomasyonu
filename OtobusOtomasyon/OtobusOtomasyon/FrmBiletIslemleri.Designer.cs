namespace OtobusOtomasyon
{
    partial class FrmBiletIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnSeferGoster = new System.Windows.Forms.Button();
            this.cmbVarisSehri = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsuit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtseferıd = new System.Windows.Forms.TextBox();
            this.txtbosks = new System.Windows.Forms.TextBox();
            this.txtbiletfiyat = new System.Windows.Forms.TextBox();
            this.txttahminisure = new System.Windows.Forms.TextBox();
            this.txtvzaman = new System.Windows.Forms.TextBox();
            this.txtkzaman = new System.Windows.Forms.TextBox();
            this.txtoplaka = new System.Windows.Forms.TextBox();
            this.txtvsehir = new System.Windows.Forms.TextBox();
            this.txtksehir = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBiletAl = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cckvarlis = new System.Windows.Forms.CheckBox();
            this.ckkzaman = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.ckkzaman);
            this.groupBox1.Controls.Add(this.cckvarlis);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.btnSeferGoster);
            this.groupBox1.Controls.Add(this.cmbVarisSehri);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 63);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sefer Ara";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(384, 24);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 15;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // btnSeferGoster
            // 
            this.btnSeferGoster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSeferGoster.Image = global::OtobusOtomasyon.Properties.Resources.Ara;
            this.btnSeferGoster.Location = new System.Drawing.Point(517, 19);
            this.btnSeferGoster.Name = "btnSeferGoster";
            this.btnSeferGoster.Size = new System.Drawing.Size(112, 29);
            this.btnSeferGoster.TabIndex = 12;
            this.btnSeferGoster.Text = "Sefer Göster ";
            this.btnSeferGoster.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSeferGoster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeferGoster.UseVisualStyleBackColor = true;
            this.btnSeferGoster.Click += new System.EventHandler(this.btnSeferGoster_Click);
            // 
            // cmbVarisSehri
            // 
            this.cmbVarisSehri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVarisSehri.Enabled = false;
            this.cmbVarisSehri.FormattingEnabled = true;
            this.cmbVarisSehri.Location = new System.Drawing.Point(123, 27);
            this.cmbVarisSehri.Name = "cmbVarisSehri";
            this.cmbVarisSehri.Size = new System.Drawing.Size(121, 21);
            this.cmbVarisSehri.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nereye  :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(659, 161);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(262, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 36);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sefer Seç";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtsuit);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtseferıd);
            this.groupBox2.Controls.Add(this.txtbosks);
            this.groupBox2.Controls.Add(this.txtbiletfiyat);
            this.groupBox2.Controls.Add(this.txttahminisure);
            this.groupBox2.Controls.Add(this.txtvzaman);
            this.groupBox2.Controls.Add(this.txtkzaman);
            this.groupBox2.Controls.Add(this.txtoplaka);
            this.groupBox2.Controls.Add(this.txtvsehir);
            this.groupBox2.Controls.Add(this.txtksehir);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(12, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 168);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sefer Bilgiler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Bilet Fiyatı";
            // 
            // txtsuit
            // 
            this.txtsuit.Enabled = false;
            this.txtsuit.Location = new System.Drawing.Point(447, 49);
            this.txtsuit.Name = "txtsuit";
            this.txtsuit.Size = new System.Drawing.Size(100, 20);
            this.txtsuit.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(444, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Suit";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(318, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Bos Koltuk Saysı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Sefer No";
            // 
            // txtseferıd
            // 
            this.txtseferıd.Enabled = false;
            this.txtseferıd.Location = new System.Drawing.Point(321, 49);
            this.txtseferıd.Name = "txtseferıd";
            this.txtseferıd.Size = new System.Drawing.Size(100, 20);
            this.txtseferıd.TabIndex = 38;
            // 
            // txtbosks
            // 
            this.txtbosks.Enabled = false;
            this.txtbosks.Location = new System.Drawing.Point(321, 88);
            this.txtbosks.Name = "txtbosks";
            this.txtbosks.Size = new System.Drawing.Size(100, 20);
            this.txtbosks.TabIndex = 37;
            // 
            // txtbiletfiyat
            // 
            this.txtbiletfiyat.Enabled = false;
            this.txtbiletfiyat.Location = new System.Drawing.Point(321, 127);
            this.txtbiletfiyat.Name = "txtbiletfiyat";
            this.txtbiletfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtbiletfiyat.TabIndex = 36;
            // 
            // txttahminisure
            // 
            this.txttahminisure.Enabled = false;
            this.txttahminisure.Location = new System.Drawing.Point(163, 125);
            this.txttahminisure.Name = "txttahminisure";
            this.txttahminisure.Size = new System.Drawing.Size(100, 20);
            this.txttahminisure.TabIndex = 35;
            // 
            // txtvzaman
            // 
            this.txtvzaman.Enabled = false;
            this.txtvzaman.Location = new System.Drawing.Point(163, 88);
            this.txtvzaman.Name = "txtvzaman";
            this.txtvzaman.Size = new System.Drawing.Size(100, 20);
            this.txtvzaman.TabIndex = 34;
            // 
            // txtkzaman
            // 
            this.txtkzaman.Enabled = false;
            this.txtkzaman.Location = new System.Drawing.Point(163, 49);
            this.txtkzaman.Name = "txtkzaman";
            this.txtkzaman.Size = new System.Drawing.Size(100, 20);
            this.txtkzaman.TabIndex = 33;
            // 
            // txtoplaka
            // 
            this.txtoplaka.Enabled = false;
            this.txtoplaka.Location = new System.Drawing.Point(18, 125);
            this.txtoplaka.Name = "txtoplaka";
            this.txtoplaka.Size = new System.Drawing.Size(100, 20);
            this.txtoplaka.TabIndex = 32;
            // 
            // txtvsehir
            // 
            this.txtvsehir.Enabled = false;
            this.txtvsehir.Location = new System.Drawing.Point(18, 88);
            this.txtvsehir.Name = "txtvsehir";
            this.txtvsehir.Size = new System.Drawing.Size(100, 20);
            this.txtvsehir.TabIndex = 31;
            // 
            // txtksehir
            // 
            this.txtksehir.Enabled = false;
            this.txtksehir.Location = new System.Drawing.Point(18, 49);
            this.txtksehir.Name = "txtksehir";
            this.txtksehir.Size = new System.Drawing.Size(100, 20);
            this.txtksehir.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(15, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Kalkış Şehri :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(318, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(160, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tahmini Süre :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(160, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Variş Zamani : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(160, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Kalkış Zamani :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(15, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "OtobusPlaka :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(15, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Varış Şehri :";
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.Location = new System.Drawing.Point(586, 299);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.Size = new System.Drawing.Size(83, 168);
            this.btnBiletAl.TabIndex = 19;
            this.btnBiletAl.Text = "Bilet Al";
            this.btnBiletAl.UseVisualStyleBackColor = true;
            this.btnBiletAl.Click += new System.EventHandler(this.btnBiletAl_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OtobusOtomasyon.Properties.Resources.fft99_mf6761382;
            this.pictureBox2.Location = new System.Drawing.Point(425, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OtobusOtomasyon.Properties.Resources._133858;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // cckvarlis
            // 
            this.cckvarlis.AutoSize = true;
            this.cckvarlis.Location = new System.Drawing.Point(37, 31);
            this.cckvarlis.Name = "cckvarlis";
            this.cckvarlis.Size = new System.Drawing.Size(15, 14);
            this.cckvarlis.TabIndex = 16;
            this.cckvarlis.UseVisualStyleBackColor = true;
            this.cckvarlis.CheckedChanged += new System.EventHandler(this.cckvarlis_CheckedChanged);
            // 
            // ckkzaman
            // 
            this.ckkzaman.AutoSize = true;
            this.ckkzaman.Location = new System.Drawing.Point(303, 30);
            this.ckkzaman.Name = "ckkzaman";
            this.ckkzaman.Size = new System.Drawing.Size(15, 14);
            this.ckkzaman.TabIndex = 17;
            this.ckkzaman.UseVisualStyleBackColor = true;
            this.ckkzaman.CheckedChanged += new System.EventHandler(this.ckkzaman_CheckedChanged);
            // 
            // FrmBiletIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 479);
            this.Controls.Add(this.btnBiletAl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBiletIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmBiletIslemleri";
            this.Activated += new System.EventHandler(this.FrmBiletIslemleri_Activated);
            this.Load += new System.EventHandler(this.FrmBiletIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeferGoster;
        private System.Windows.Forms.ComboBox cmbVarisSehri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBiletAl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtsuit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtseferıd;
        private System.Windows.Forms.TextBox txtbosks;
        private System.Windows.Forms.TextBox txtbiletfiyat;
        private System.Windows.Forms.TextBox txttahminisure;
        private System.Windows.Forms.TextBox txtvzaman;
        private System.Windows.Forms.TextBox txtkzaman;
        private System.Windows.Forms.TextBox txtoplaka;
        private System.Windows.Forms.TextBox txtvsehir;
        private System.Windows.Forms.TextBox txtksehir;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckkzaman;
        private System.Windows.Forms.CheckBox cckvarlis;

    }
}