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
    public partial class YoneticiIslemleri : Form
    {
        public YoneticiIslemleri()
        {
            InitializeComponent();
        }
        OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabanim.accdb");

        public void BaglantiAc()
        {
            try
            {
                Baglanti.Open();
            }

            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Bağlantı Açma Hata Pencersi");
            }
        }
        public void Kayitlistele()
        {

            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string sorgu = "select * From Yoneticiler";

                string sorguturu = "Select * From Yoneticiler where KullanciAd='" + KullanciGiris.Kullaniciadi + "'";

                if (KullanciGiris.Kturu != "Yönetici")
                {
                    sorgu = sorguturu;
                }
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                da.Fill(ds, "Yoneticiler");
                dataGridView1.DataSource = ds.Tables["Yoneticiler"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "KULLANICI LİSTELEME HATA PENCERESİ");
            }

        }

        public void Kayitlisec()
        {

            try
            {
                txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtKullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cmbKullaniciTuru.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "KAYIT SEÇEME HATA PENCERESİ");
            }

        }
        public void Kullanciekle()
        {

            try
            {
                BaglantiAc();

                string Komutyonetci = "Insert Into Yoneticiler(KullanciAd,Sifre,KullanciTuru)Values(@KullanciAd,@Sifre,@KullanciTuru)";

                OleDbCommand EkleKomut = new OleDbCommand(Komutyonetci, Baglanti);
                EkleKomut.Parameters.AddWithValue("@KullanciAd", txtKullaniciAdi.Text);
                EkleKomut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                EkleKomut.Parameters.AddWithValue("@KullanciTuru", cmbKullaniciTuru.Text);

                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi");

                Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekleme Hata Penceresi");
            }
        }
        public void KayitSil()
        {
            try
            {
                BaglantiAc();
                string Sorgu = "delete from Yoneticiler where YoneticiID=" + txtId.Text;
                OleDbCommand komut = new OleDbCommand(Sorgu, Baglanti);
                if (komut.ExecuteNonQuery() == 1) 
                MessageBox.Show(txtId.Text + "No Kayıt Silindi");

                Baglanti.Close();

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
                BaglantiAc();
                string Sorgu = "Update Yoneticiler Set Sifre=@Sifre where YoneticiID=" + txtId.Text; ;
                OleDbCommand komut = new OleDbCommand(Sorgu, Baglanti);
                komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);

                if (komut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtId.Text + " No Kayıt Şifresi Güncellendi");
                Baglanti.Close();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Şifresi Güncelleme Hata Penceresi");
            }
        }
        public bool BoslukKontrol()
        {
            txtKullaniciAdi.BackColor = Color.White;
            txtSifre.BackColor = Color.White;
            cmbKullaniciTuru.BackColor = Color.White;
            if (txtKullaniciAdi.Text == "")
            {
                txtKullaniciAdi.BackColor = Color.Red;
                txtKullaniciAdi.Focus();
                return false;

            }
            else if (txtSifre.Text == "")
            {
                txtSifre.BackColor = Color.Red;
                txtSifre.Focus();
                return false;

            }
            else if (cmbKullaniciTuru.Text == "")
            {
                cmbKullaniciTuru.BackColor = Color.Red;
                cmbKullaniciTuru.Focus();
                return false;

            }
            else
                return true;
        }

        private void YoneticiIslemleri_Load(object sender, EventArgs e)
        {
            Kayitlistele();
            lblKadi.Text = KullanciGiris.Kullaniciadi;
            lblkaturu.Text = KullanciGiris.Kturu;
            if (KullanciGiris.Kturu != "Yönetici")
            {
                btnKullaniciSil.Enabled = false;
                btnYeniKullanici.Enabled = false;
                cmbKullaniciTuru.Enabled = false;
                txtKullaniciAdi.Enabled = false;
            }
        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            bool sert = true;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == txtKullaniciAdi.Text)
                {
                    sert = false;
                }
            }
            if (sert == true)
            {
                if (BoslukKontrol() == true)
                {
                    Kullanciekle();
                    Kayitlistele();
                }
            }
            else
            {
                MessageBox.Show("girdiğiniz Kullancı adı aynı vardır  ", "hata");
            }
        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(txtKullaniciAdi.Text + "ismli kullanci silinecek \n onaylıyor musunuz?", "Kullancı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                if (txtId.Text == "")
                    MessageBox.Show("lutfen Bir Kayıt Seçin");
                else if (MessageBox.Show(txtId.Text + " Nolu Kayıt silme istiyor musun", "Dikket", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Yönetici")
                {
                    int count = 0;
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "Yönetici")
                        {
                            count++;
                        }
                    }
                    if (count > 1)
                    {
                        KayitSil();
                        Kayitlistele();
                    }
                    else
                        MessageBox.Show(" Bu Yönetici silinmez ", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    KayitSil();
                    Kayitlistele();
                }
            }
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
            {
                KayitGuncelle();
                Kayitlistele();

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Kayitlisec();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Kayitlisec();
        }
    }
     

}
