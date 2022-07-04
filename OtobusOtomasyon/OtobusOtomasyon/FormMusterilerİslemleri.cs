using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OtobusOtomasyon
{
    public partial class FormMusterilerİslemleri : Form
    {
        public FormMusterilerİslemleri()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabanim.accdb");

        public void baglantiAc()
        {
            try
            {
                baglanti.Open();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "wrong");
            }
        }
        public void ekle()
        {
            try
            {
                baglantiAc();
                string Komut = "Insert Into Musteriler(AD,Soyad,TcNo,Adres,Telefon,Email,Cinsiyat)Values(@AD,@Soyad,@TcNo,@Adres,@Telefon,@Email,@Cinsiyat)";
                OleDbCommand EkleKomut = new OleDbCommand(Komut, baglanti);
                EkleKomut.Parameters.AddWithValue("@AD", txtad.Text);
                EkleKomut.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                EkleKomut.Parameters.AddWithValue("@TcNo", txttcno.Text);
                EkleKomut.Parameters.AddWithValue("@Adres", txtadres.Text);
                EkleKomut.Parameters.AddWithValue("@Telefon", tel.Text);
                EkleKomut.Parameters.AddWithValue("@Email", textEmail.Text);
                if (radioer.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", "Erkek");
                else if (radiokadin.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", "Kadın");
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("kayıt Eklendi");
                baglanti.Close();
            }

            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hatalı");
            }
        }


        public void kayitleste()
        {
            try
            {
                baglantiAc();
                DataSet ds = new DataSet();
                string sorgu = "select * from Musteriler";
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
                da.Fill(ds, "Musteriler");
                dataGridView1.DataSource = ds.Tables["Musteriler"];
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "failed");
            }

        }
        public void kayitsilme()
        {
            try
            {
                baglantiAc();
                string Sorgu = "delete from Musteriler where MusteriID =" + id.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(id.Text + " Nolu Kayıt Silindi");

                baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Silme Hata Penceresi");
            }
        }
        public void KayitGuncelle()
        {
            try
            {

                baglantiAc();
                string Sorgu = "update Musteriler set Ad=@Ad,Soyad=@Soyad,TcNo=@TcNo,Email=@Email,Telefon=@Telefon,Adres=@Adres,Cinsiyat=@Cinsiyat where MusteriID=" + id.Text;
                OleDbCommand Guncellekomut = new OleDbCommand(Sorgu, baglanti);
                Guncellekomut.Parameters.AddWithValue("@Ad", txtad.Text);
                Guncellekomut.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                Guncellekomut.Parameters.AddWithValue("@TcNo", txttcno.Text);
                Guncellekomut.Parameters.AddWithValue("@Email", textEmail.Text);
                Guncellekomut.Parameters.AddWithValue("@Telefon", tel.Text);
                Guncellekomut.Parameters.AddWithValue("@Adres", txtadres.Text);
                if (radioer.Checked == true)
                    Guncellekomut.Parameters.AddWithValue("@Cinsiyet", "Erkek");
                else if (radiokadin.Checked == true)
                    Guncellekomut.Parameters.AddWithValue("@Cinsiyet", "Kadın");

                if (Guncellekomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Güncellendi");

                baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Güncelleme Hata Penceres");
            }

        }
        public void KayitAra()
        {
            try
            {
                baglantiAc();
                DataSet ds = new DataSet();
                string sorgu = "select * from Musteriler";
                string SorguAd = "select * from Musteriler where Ad='" + textadara.Text + "'";
                string SorguSoyad = "select * from Musteriler where Soyad='" + textsoyadara.Text + "'";
                
                string cinsiyat;
                if (radioerara.Checked == true)
                    cinsiyat = "Erkek";
                else
                    cinsiyat = "Kadın";
                string Sorgucinsiyat = "select * from Musteriler where Cinsiyat='" + cinsiyat + "'";

                string SorguAdSoyad = "select * from Musteriler where Ad ='" + textadara.Text + "'and soyad='" + textsoyadara.Text + "'";
                string SorguAdcinsiyat = "select * from Musteriler where Ad='" + textadara.Text + "' and Cinsiyat='" + cinsiyat + "'";
                string SorguSoyadcinsiyat = "select * from Musteriler where Soyad='" + textsoyadara.Text + "'and Cinsiyat='" + cinsiyat + "'";

                string SorguAdSoyadcinsiyat = "select * from Musteriler where Ad='" + textadara.Text + "'and Soyad='" + textsoyadara.Text + "'and Cinsiyat='" + cinsiyat + "'";

                if (chkad.Checked == true && chksoyad.Checked == true && checcinsiyetara.Checked == true)
                    sorgu = SorguAdSoyadcinsiyat;
                else if (chkad.Checked == true && chksoyad.Checked == true)
                    sorgu = SorguAdSoyad;
                else if (chkad.Checked == true && checcinsiyetara.Checked == true)
                    sorgu = SorguAdcinsiyat;
                else if (chksoyad.Checked == true && checcinsiyetara.Checked == true)
                    sorgu = SorguSoyadcinsiyat;
                else if (chkad.Checked == true)
                    sorgu = SorguAd;
                else if (chksoyad.Checked == true)
                    sorgu = SorguSoyad;
                else if (checcinsiyetara.Checked == true)
                    sorgu = Sorgucinsiyat;



                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
                da.Fill(ds, "Musteriler");// DATASETİ DOLDUR
                dataGridView1.DataSource = ds.Tables["Musteriler"];//TABLOYU FORMDA GÖSTEr
                baglanti.Close();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceres");

            }
        }
        public void KayitAraBenzer()
        {
            try
            {
                baglantiAc();
                DataSet ds = new DataSet();
                string sorgu = "select * from Musteriler";

                string Sorguicertc = "select * from Musteriler where TcNo like'%" + textara.Text + "%'";
                string Sorgubaslayantc = "select * from Musteriler where TcNo like'" + textara.Text + "%'";
                string Sorgubitentc = "select * from Musteriler where TcNo like'%" + textara.Text + "'";

                string Sorguicertel = "select * from Musteriler where Telefon like'%" + textara.Text + "%'";
                string Sorgubaslayantel = "select * from Musteriler where Telefon like'(" + textara.Text + "%'";
                string Sorgubitentel = "select * from Musteriler where  Telefon like'%" + textara.Text + "'";


                if (comaramaturu.Text == "İçeren")
                {
                    if (radiotcnoara.Checked == true)
                        sorgu = Sorguicertc;
                    else if (radiotelara.Checked == true)
                        sorgu = Sorguicertel;
                }
                else if (comaramaturu.Text == "İle Başlayan")
                {
                    if (radiotcnoara.Checked == true)
                        sorgu = Sorgubaslayantc;
                    else if (radiotelara.Checked == true)
                        sorgu = Sorgubaslayantel;
                }
                else if (comaramaturu.Text == "İle Biten")
                {
                    if (radiotcnoara.Checked == true)
                        sorgu = Sorgubitentc;

                    else if (radiotelara.Checked == true)
                        sorgu = Sorgubitentel;

                }

                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglanti);
                da.Fill(ds, "Musteriler");
                dataGridView1.DataSource = ds.Tables["Musteriler"];
                baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Benzer Hata Penceresi");

            }
        }
        public bool BoslukKontrol()
        {
            txtad.BackColor = Color.White;
            txtsoyad.BackColor = Color.White;
            txttcno.BackColor = Color.White;
            txtadres.BackColor = Color.White;
            tel.BackColor = Color.White;
            textEmail.BackColor = Color.White;
              if (txttcno.Text == "")
            {
                txttcno.BackColor = Color.Red;
                txttcno.Focus();
                return false;
            }
              else if (txtad.Text == "")
            {
                txtad.BackColor = Color.Red;
                txtad.Focus();
                return false;
            }
            else if (txtsoyad.Text == "")
            {
                txtsoyad.BackColor = Color.Red;
                txtsoyad.Focus();
                return false;
            }
            else if (txtadres.Text == "")
            {
                txtadres.BackColor = Color.Red;
                txtadres.Focus();
                return false;
            }
            else if (tel.Text == "(    )    -")
            {
                tel.BackColor = Color.Red;
                tel.Focus();
                return false;
            }
            else if (textEmail.Text == "")
            {
                textEmail.BackColor = Color.Red;
                textEmail.Focus();
                return false;
            }
            else if (radioer.Checked == false && radiokadin.Checked == false)
              {
                  MessageBox.Show("Cinsiyet Seçiniz");
                  return false;
              }
              else
              {
                  return true;
              }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(BoslukKontrol() ==true)
            ekle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                KayitGuncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
                MessageBox.Show("lutfen Bir Kayıt Seçin");
            else if (MessageBox.Show(id.Text + " Nolu Kayıt silme istiyor musun", "Dikket", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            kayitsilme();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            id.Clear();
            txtad.Clear();
            txtadres.Clear();
            txtsoyad.Clear();
            txttcno.Clear();
            textEmail.Clear();
            tel.Clear();
            radioer.Checked = false;
            radiokadin.Checked = false;
        }

        private void FormMusterilerİslemleri_Activated(object sender, EventArgs e)
        {
            baglanti.Close();
            kayitleste();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void textara_TextChanged(object sender, EventArgs e)
        {
            KayitAraBenzer();
        }

        private void chkad_CheckedChanged(object sender, EventArgs e)
        {
            if (chkad.Checked == true)
            {
                textadara.Enabled = true;
                textadara.Focus();
            }
            else
            {
                textadara.Enabled = false;
                textadara.Text = "";
            }
        }

        private void chksoyad_CheckedChanged(object sender, EventArgs e)
        {
            if (chksoyad.Checked == true)
            {
                textsoyadara.Enabled = true;
                textsoyadara.Focus();
            }
            else
            {
                textsoyadara.Enabled = false;
                textsoyadara.Text = "";
            }
        }

        private void checcinsiyetara_CheckedChanged(object sender, EventArgs e)
        {
            if (checcinsiyetara.Checked == true)
            {
                panel1.Enabled = true;

            }
            else
            {
                panel1.Enabled = false;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txttcno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Erkek")
            {
                radioer.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == "Kadın")
            {
                radiokadin.Checked = true;
            }
        }
    }
}
