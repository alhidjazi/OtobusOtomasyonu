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
    public partial class OtobusIslemleri : Form
    {
        public OtobusIslemleri()
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
                MessageBox.Show(Hata.Message, "wrong");
            }
        }

        public void ekle()
        {
            try
            {
                BaglantiAc();
                string Komut = "Insert Into Otobusler(Plaka,KoltukSayisi,Marka)Values(@Plaka,@KoltukSayisi,@Marka)";
                OleDbCommand EkleKomut = new OleDbCommand(Komut, Baglanti);
                string plakano = txtpilkno.Text + txtporth.Text + txtplakason.Text;
                EkleKomut.Parameters.AddWithValue("@Plaka", plakano);
                EkleKomut.Parameters.AddWithValue("@KoltukSayisi", txtKoltukSayisi.Text);
                EkleKomut.Parameters.AddWithValue("@Marka", comoturu.Text);

                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("kayıt Eklendi");
                Baglanti.Close();
            }



            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hatalı");
            }
        }
        public void KayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string sorgu = "select * from Otobusler";

                string Sorgutxtoksayisi = "select * from Otobusler where KoltukSayisi='" + txtoksayisi.Text + "'";
                string SorguMarka = "select * from Otobusler where Marka='" + comoturuara.Text + "'";

                string Sorguksmarka = "select * from Otobusler where KoltukSayisi='" + txtoksayisi.Text + "' and Marka='" + comoturuara.Text + "'";

                if (checkoksara.Checked == true && checkoturuara.Checked == true)
                    sorgu = Sorguksmarka;
                else if (checkoksara.Checked == true)
                    sorgu = Sorgutxtoksayisi;
                else if (checkoturuara.Checked == true)
                    sorgu = SorguMarka;

                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                da.Fill(ds, "Otobusler");
                dataGridView1.DataSource = ds.Tables["Otobusler"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");

            }
        }
        public void KayitAraBenzer()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string sorgu = "select * from Otobusler";

                string Sorguopbas = "select * from Otobusler where Plaka like'" + textharamaoplak.Text + "%'";
                string Sorguopiciren = "select * from Otobusler where Plaka like'%" + textharamaoplak.Text + "%'";
                string Sorguopbiten = "select * from Otobusler where Plaka like'%" + textharamaoplak.Text + "'";

                if (comaramaturu.Text == "İçeren")
                {
                    sorgu = Sorguopiciren;
                }
                else if (comaramaturu.Text == "İle Başlayan")
                {
                    sorgu = Sorguopbas;
                }
                else if (comaramaturu.Text == "İle Biten")
                {
                    sorgu = Sorguopbiten;
                }
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                da.Fill(ds, "Otobusler");
                dataGridView1.DataSource = ds.Tables["Otobusler"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Benzer Hata Penceresi");

            }
        }
        public void kayitleste()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string sorgu = "select * from Otobusler";
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                da.Fill(ds, "Otobusler");
                dataGridView1.DataSource = ds.Tables["Otobusler"];
                Baglanti.Close();
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
                BaglantiAc();
                string Sorgu = "delete from Otobusler where OtobusID =" + txtid.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtid.Text + " Nolu Kayıt Silindi");

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
                string Sorgu = "update Otobusler set Plaka=@Plaka,KoltukSayisi=@KoltukSayisi,Marka=@Marka where OtobusID=" + txtid.Text;
                OleDbCommand Guncellekomut = new OleDbCommand(Sorgu, Baglanti);
                string plakano = txtpilkno.Text + txtporth.Text + txtplakason.Text;
                Guncellekomut.Parameters.AddWithValue("@Plaka", plakano);
                Guncellekomut.Parameters.AddWithValue("@KoltukSayisi", txtKoltukSayisi.Text);
                Guncellekomut.Parameters.AddWithValue("@Marka", comoturu.Text);

                if (Guncellekomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Güncellendi");

                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Güncelleme Hata Penceresi");
            }

        }
        public bool BoslukKontrol()
        {

            txtKoltukSayisi.BackColor = Color.White;
            comoturu.BackColor = Color.White;
            txtpilkno.BackColor = Color.White;
            txtporth.BackColor = Color.White;
            txtplakason.BackColor = Color.White;
            
            if (txtpilkno.Text == "")
            {
                txtpilkno.BackColor = Color.Red;
                txtpilkno.Focus();
                return false;
            }
            else if (txtporth.Text == "")
            {
                txtporth.BackColor = Color.Red;
                txtporth.Focus();
                return false;
            }
            else if (txtplakason.Text == "")
            {
                txtplakason.BackColor = Color.Red;
                txtplakason.Focus();
                return false;
            }
            else if (txtKoltukSayisi.Text == "")
            {
                txtKoltukSayisi.BackColor = Color.Red;
                txtKoltukSayisi.Focus();
                return false;
            }
            else if (comoturu.Text == "")
            {
                comoturu.BackColor = Color.Red;
                comoturu.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void kayitsil()
        {
            try
            {
                BaglantiAc();
                string Sorgu = "delete from Otobusler where OtobusID =" + txtid.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtid.Text + " Nolu Kayıt Silindi");

                Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Silme Hata Penceresi");
            }
        }

        private void checkoksara_CheckedChanged(object sender, EventArgs e)
        {
            if (checkoksara.Checked == true)
            {
                txtoksayisi.Enabled = true;
                txtoksayisi.Focus();
            }
            else
            {
                txtoksayisi.Enabled = false;
                txtoksayisi.Clear();

            }
        }

        private void checkoturuara_CheckedChanged(object sender, EventArgs e)
        {
            if (checkoturuara.Checked == true)
            {
                comoturuara.Enabled = true;
                comoturuara.Focus();
            }
            else
            {
                comoturuara.Enabled = false;
                comoturuara.Text = "";

            }
        }

        private void textharamaoplak_TextChanged(object sender, EventArgs e)
        {
            KayitAraBenzer();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
            KayitGuncelle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
            ekle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            kayitsil();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtKoltukSayisi.Clear();
            txtpilkno.Clear();
            txtplakason.Clear();
            txtporth.Clear();
            comoturu.Text = "";
            txtid.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OtobusIslemleri_Activated(object sender, EventArgs e)
        {
            Baglanti.Close();
            kayitleste();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtpilkno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Substring(0, 2);
            txtporth.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Substring(2, 2);
            txtplakason.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString().Substring(4, 4);
            txtKoltukSayisi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comoturu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void OtobusIslemleri_Load(object sender, EventArgs e)
        {
        }
    }
}
