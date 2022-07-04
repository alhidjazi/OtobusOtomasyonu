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
    public partial class FrmSehir : Form
    {
        public FrmSehir()
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
                string sorgu = "select * From Sehirler";
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                da.Fill(ds, "Sehirler");
                dataGridView1.DataSource = ds.Tables["Sehirler"];
                Baglanti.Close();
            }

            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Bağlantı Açma Hata Pencersi");
            }

        }

        public void SehirlerEkle()
        {
            try
            {
                BaglantiAc();
                string Komut = "Insert Into Sehirler(SehirAd)Values(@SehirAd)";
                OleDbCommand EkleKomut = new OleDbCommand(Komut, Baglanti);
                EkleKomut.Parameters.AddWithValue("@SehirAd", txtSehirAdi.Text);

                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("kayıt Eklendi");
                Baglanti.Close();
            }

            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hatalı");
            }
        }
        public bool BoslukKontrol()
        {
            txtSehirAdi.BackColor = Color.White;

            if (txtSehirAdi.Text == "")
            {
                txtSehirAdi.BackColor = Color.Red;
                txtSehirAdi.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        public void KayitSil()
        {
            try
            {
                BaglantiAc();
                string Sorgu = "delete from Sehirler where SehirID=" + txtSehirID.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtSehirID.Text + " Nolu Kayıt Silindi");

                Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Silme Hata Penceresi");
            }
        }
        public void KayitAraBenzer()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string sorgu = "select * from Sehirler where TcNo like'%" + txtAranacak.Text + "%'";
                    
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                da.Fill(ds, "Sehirler");
                dataGridView1.DataSource = ds.Tables["Sehirler"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Benzer Hata Penceresi");

            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            /*DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Sehirler where SehirID=" + cmbSehir.Text, Baglanti);
            da.Fill(ds, "Sehirler");
            DataTable dt = ds.Tables["Sehirler"];
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Seçtiğiniz Şehir Mevcuttur");

            }
            else*/ if (BoslukKontrol() == true)
            {         
                        SehirlerEkle();
                        Kayitlistele();     
            }
            else
               MessageBox.Show("Boş alanları doldurunuz");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (txtSehirID.Text == "")
                    MessageBox.Show("lutfen Bir Kayıt Seçin");
            else if (MessageBox.Show(txtSehirID.Text + " Nolu Kayıt silme istiyor musun", "Dikket", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                KayitSil();
                Kayitlistele();
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtSehirAdi.Clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtSehirID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtSehirAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void FrmSehir_Activated(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                    count++;

            }
            txtSehirSayisi.Text = count.ToString() ;
        }

        private void FrmSehir_Load(object sender, EventArgs e)
        {
            Kayitlistele();
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSehirAdi.Text = cmbSehir.Text;
        }
    }
     
}
