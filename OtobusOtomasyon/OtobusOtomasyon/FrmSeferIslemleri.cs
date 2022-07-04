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
    public partial class FrmSeferIslemleri : Form
    {
        public FrmSeferIslemleri()
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
                string sorgu = "select * From Seferler";
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                da.Fill(ds, "Seferler");
                dataGridView1.DataSource = ds.Tables["Seferler"];
                Baglanti.Close();
            }

            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Bağlantı Açma Hata Pencersi");
            }

        }
        public void SeferEkle()
        {
            try
            {
                BaglantiAc();
                string Komut = "Insert Into Seferler(KalkisSehir,VarisSehir,OtobusID,SurucuID,Muavin,KalkisZamani,VarisZamani,TahminSure,BiletTutari,BosKoltukSaysi,OtobusTuru)Values(@KalkisSehir,@VarisSehir,@OtobusID,@SurucuID,@Muavin,@KalkisZamani,@VarisZamani,@TahminSure,@BiletTutari,@BosKoltukSaysi,@OtobusTuru)";
                OleDbCommand EkleKomut = new OleDbCommand(Komut, Baglanti);
                EkleKomut.Parameters.AddWithValue("@KalkisSehir", cmbKalkisSehri.Text);
                EkleKomut.Parameters.AddWithValue("@VarisSehir", cmbVarisSehri.Text);
                EkleKomut.Parameters.AddWithValue("@OtobusID", cmbOtobusPlaka.Text);
                EkleKomut.Parameters.AddWithValue("@SurucuID", cmbSofor.Text);
                EkleKomut.Parameters.AddWithValue("@Muavin", cmbMuavin.Text);
                EkleKomut.Parameters.AddWithValue("@KalkisZamani", mskkalssaat.Text);
                EkleKomut.Parameters.AddWithValue("@VarisZamani", mskvarissaat.Text);
                EkleKomut.Parameters.AddWithValue("@TahminSure", txtTahminiSure.Text);
                EkleKomut.Parameters.AddWithValue("@BiletTutari", mskbilettutari.Text);
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Otobusler where OtobusID=" + cmbOtobusPlaka.Text , Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                 EkleKomut.Parameters.AddWithValue("@BosKoltukSaysi", dt.Rows[0][2]);
                 EkleKomut.Parameters.AddWithValue("@OtobusTuru", dt.Rows[0][3]);


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
            cmbKalkisSehri.BackColor = Color.White;
            cmbVarisSehri.BackColor = Color.White;
            cmbOtobusPlaka.BackColor = Color.White;
            cmbSofor.BackColor = Color.White;
            cmbMuavin.BackColor = Color.White;
            mskkalssaat.BackColor = Color.White;
            mskvarissaat.BackColor = Color.White;
            txtTahminiSure.BackColor = Color.White;
            mskbilettutari.BackColor = Color.White;
            if (cmbKalkisSehri.Text == "Seç" || cmbKalkisSehri.Text == "")
            {
                cmbKalkisSehri.BackColor = Color.Red;
                cmbKalkisSehri.Focus();
                return false;
            }
            else if (cmbVarisSehri.Text == "Seç" || cmbVarisSehri.Text == "")
            {
                cmbVarisSehri.BackColor = Color.Red;
                cmbVarisSehri.Focus();
                return false;
            }
            else if (cmbOtobusPlaka.Text == "Seç" || cmbOtobusPlaka.Text == "")
            {
                cmbOtobusPlaka.BackColor = Color.Red;
                cmbOtobusPlaka.Focus();
                return false;
            }
            else if (cmbSofor.Text == "Seç" || cmbSofor.Text == "")
            {
                cmbSofor.BackColor = Color.Red;
                cmbSofor.Focus();
                return false;
            }
            else if (cmbMuavin.Text == "Seç" || cmbMuavin.Text == "")
            {
                cmbMuavin.BackColor = Color.Red;
                cmbMuavin.Focus();
                return false;
            }
            else if (mskkalssaat.Text == "  .  .       :")
            {
                mskkalssaat.BackColor = Color.Red;
                return false;
            }
            else if (mskvarissaat.Text == "  .  .       :")
            {
                mskvarissaat.BackColor = Color.Red;
                return false;
            }
            else if (txtTahminiSure.Text == "")
            {
                txtTahminiSure.BackColor = Color.Red;
                txtTahminiSure.Focus();
                return false;
            }
            else if (cmbMuavin.Text == "")
            {
                mskbilettutari.BackColor = Color.Red;
                mskbilettutari.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        public void KayitGuncelle()
        {
            try
            {

                BaglantiAc();
                string Sorgu = "update Seferler set KalkisSehir=@KalkisSehir,VarisSehir=@VarisSehir,OtobusID=@OtobusID,SurucuID=@SurucuID,Muavin=@Muavin,KalkisZamani=@KalkisZamani,VarisZamani=@VarisZamaniTahminSure=@TahminSure,BiletTutari=@BiletTutari,BosKoltukSaysi=@BosKoltukSaysi,OtobusTuru=@OtobusTuru where SeferID=" + textseferid.Text;
                OleDbCommand Guncellekomut = new OleDbCommand(Sorgu,Baglanti);
                Guncellekomut.Parameters.AddWithValue("@KalkisSehir", cmbKalkisSehri.Text);
                Guncellekomut.Parameters.AddWithValue("@VarisSehir", cmbVarisSehri.Text);
                Guncellekomut.Parameters.AddWithValue("@OtobusID", cmbOtobusPlaka.Text);
                Guncellekomut.Parameters.AddWithValue("@SurucuID", cmbSofor.Text);
                Guncellekomut.Parameters.AddWithValue("@Muavin", cmbMuavin.Text);
                Guncellekomut.Parameters.AddWithValue("@KalkisZamani", mskkalssaat.Text);
                Guncellekomut.Parameters.AddWithValue("@VarisZamani", mskvarissaat.Text);
                Guncellekomut.Parameters.AddWithValue("@TahminSure", txtTahminiSure.Text);
                Guncellekomut.Parameters.AddWithValue("@BiletTutari", mskbilettutari.Text);
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Otobusler where OtobusID=" + cmbOtobusPlaka.Text, Baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Guncellekomut.Parameters.AddWithValue("@BosKoltukSaysi", dt.Rows[0][2]);
                Guncellekomut.Parameters.AddWithValue("@OtobusTuru", dt.Rows[0][3]);

                if (Guncellekomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Güncellendi");

                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Güncelleme Hata Penceresi");
            }

        }
        public void KayitSil()
        {
            try
            {
                BaglantiAc();
                string Sorgu = "delete from Seferler where SeferID=" + textseferid.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(textseferid.Text + " Nolu Kayıt Silindi");

                Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Silme Hata Penceresi");
            }
        }
        private void btnAnaListeyeGeriDon_Click(object sender, EventArgs e)
        {
            Kayitlistele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                SeferEkle();
            else
                MessageBox.Show("Boş alanları doldurunuz");
        }
        public void KayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string sorgu = "Select * from Seferler";
                string sorguvarsehir = "Select * from Seferler where VarisSehir= '" + cmbNereye.Text + " ' ";
                string sorgusofor = "Select * from Seferler where SurucuID= '" + comseforara.Text + " ' ";
                string sorguop = "Select * from Seferler where OtobusID= '" + comopara.Text + " ' ";

                string sorguvssofor = "Select * from Seferler where VarisSehir='" + cmbNereye.Text + " ' and  SurucuID= '" + comseforara.Text + " ' ";
                string Sorguvsop = "select * from Seferler where VarisSehir ='" + cmbNereye.Text + "'and OtobusID='" + comopara.Text + "'";
                string Sorgusoforop = "select * from Seferler where SurucuID='" + comseforara.Text + "'and OtobusID='" + comopara.Text + "'";

                string Sorguvssoforop = "select * from Seferler where VarisSehir='" + cmbNereye.Text + "'and SurucuID='" + comseforara.Text + "'and OtobusID='" + comopara.Text + "'";
                if (checkkalisara.Checked == true && checksoforara.Checked == true && checkopara.Checked == true)
                    sorgu = Sorguvssoforop;
                else if (checksoforara.Checked == true && checkopara.Checked == true)
                    sorgu = Sorgusoforop;
                else if (checkkalisara.Checked == true && checkopara.Checked == true)
                    sorgu = Sorguvsop;
               else if (checkkalisara.Checked == true && checksoforara.Checked == true)
                    sorgu = sorguvssofor;
                else if (checkopara.Checked == true)
                    sorgu = sorguop;
                else if (checksoforara.Checked == true)
                    sorgu = sorgusofor;
                else if (checkkalisara.Checked == true)
                    sorgu = sorguvarsehir;
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                da.Fill(ds, "Seferler");
                dataGridView1.DataSource = ds.Tables["Seferler"];
                Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listeleme Hata Penceresi");

            }
        }

        private void FrmSeferIslemleri_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Otobusler", Baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbOtobusPlaka.DataSource = dt;
            cmbOtobusPlaka.DisplayMember = "OtobusID";
            cmbOtobusPlaka.ValueMember = "OtobusID";
            cmbOtobusPlaka.Text = "Seç";

            OleDbDataAdapter da1 = new OleDbDataAdapter("select * from Sehirler", Baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cmbVarisSehri.DataSource = dt1;
            cmbVarisSehri.DisplayMember = "SehirAd";
            cmbVarisSehri.ValueMember = "SehirID";
            cmbVarisSehri.Text = "Seç";

            OleDbDataAdapter da2 = new OleDbDataAdapter("select * from Calisan where CalisBolm ='Sürücü' ", Baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbSofor.DataSource = dt2;
            cmbSofor.DisplayMember = "Ad";
            cmbSofor.ValueMember = "CalisanID";
            cmbSofor.Text = "Seç";

            OleDbDataAdapter da3 = new OleDbDataAdapter("select * from Calisan where CalisBolm ='Çalışan' ", Baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            cmbSofor.DataSource = dt3;
            cmbSofor.DisplayMember = "Ad";
            cmbSofor.ValueMember = "CalisanID";
            cmbSofor.Text = "Seç";


            

        }

        private void btnSeferListe_Click(object sender, EventArgs e)
        {
            Kayitlistele();
        }

        private void btnKayitSeç_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (textseferid.Text == "")
                MessageBox.Show("lutfen Bir Kayıt Seçin");
            else
            {
                if (BoslukKontrol() == true)
                    KayitGuncelle();
                else
                    MessageBox.Show("Boş alanları doldurunuz");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (textseferid.Text == "")
                MessageBox.Show("lutfen Bir Kayıt Seçin");
            else if (MessageBox.Show(textseferid.Text + " Nolu Kayıt silme istiyor musun", "Dikket", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                KayitSil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            textseferid.Clear();
            cmbKalkisSehri.Text = "Seç";
            cmbVarisSehri.Text = "Seç";
            cmbOtobusPlaka.Text = "Seç";
            cmbSofor.Text = "Seç";
            cmbMuavin.Text = "Seç";
            mskkalssaat.Clear();
            mskvarissaat.Clear();
            txtTahminiSure.Clear();
            mskbilettutari.Clear();
        }

        private void cmbSofor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void checkkalisara_CheckedChanged(object sender, EventArgs e)
        {
            if (checkkalisara.Checked == true)
            {
                cmbNereye.Enabled = true;
                cmbNereye.Focus();
            }
            else
            {
                cmbNereye.Enabled = false;
                cmbNereye.Text = "";
            }
        }

        private void FrmSeferIslemleri_Activated(object sender, EventArgs e)
        {
            Baglanti.Close();
            Kayitlistele();

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textseferid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmbKalkisSehri.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cmbVarisSehri.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cmbOtobusPlaka.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbSofor.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cmbMuavin.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            mskkalssaat.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            mskvarissaat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtTahminiSure.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            mskbilettutari.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checksoforara.Checked == true)
            {
                comseforara.Enabled = true;
                comseforara.Focus();
            }
            else
            {
                comseforara.Enabled = false;
                comseforara.Text = "";
            }
        }

        private void checkopara_CheckedChanged(object sender, EventArgs e)
        {
            if (checkopara.Checked == true)
            {
                comopara.Enabled = true;
                comopara.Focus();
            }
            else
            {
                comopara.Enabled = false;
                comopara.Text = "";
            }
        }

        private void cmbMuavin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

    }
}
