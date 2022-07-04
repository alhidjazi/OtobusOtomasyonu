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
    public partial class CalisanIslemlrei : Form
    {
        public CalisanIslemlrei()
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
                string sorgu = "select * From Calisan";
                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                da.Fill(ds, "Calisan");
                dataGridView1.DataSource = ds.Tables["Calisan"];
                Baglanti.Close();
            }

            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Bağlantı Açma Hata Pencersi");
            }

        }
        
        public void CalisanEkle()
        {
            try
            {
                BaglantiAc();
                string Komut = "Insert Into Calisan(TcNo,Ad,Soyad,DogumTarih,Tel,EvAdresi,Cinsiyat,CalisBolm)Values(@TcNo,@Ad,@Soyad,@DogumTarih,@Tel,@EvAdresi,@Cinsiyat,@CalisBolm)";
                OleDbCommand EkleKomut = new OleDbCommand(Komut, Baglanti);
                EkleKomut.Parameters.AddWithValue("@TcNo", texttc.Text);
                EkleKomut.Parameters.AddWithValue("@Ad", textad.Text);
                EkleKomut.Parameters.AddWithValue("@soyad", textsoyad.Text);
                EkleKomut.Parameters.AddWithValue("@DogumTarih", textdtarih.Text);
                EkleKomut.Parameters.AddWithValue("@tel", texttel.Text);
                EkleKomut.Parameters.AddWithValue("@EvAdresi", textevadresi.Text);
                if (radioer.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@cinsiyet", "Erkek");
                else if (radiokadin.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@cinsiyet", "Kadın");
                
                if (radiosurucu.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@CalisBolm", "Sürücü");
                else if (radiocalisan.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@CalisBolm", "Çalışan");

                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("kayıt Eklendi");
                Baglanti.Close();
            }

            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Ekle Hatalı");
            }
        }
        public void KayitGuncelle()
        {
            try
            {

                BaglantiAc();
                string Sorgu = "update Calisan set TcNo=@TcNo,Ad=@Ad,Soyad=@Soyad,DogumTarih=@DogumTarih,Tel=@Tel,EvAdresi=@EvAdresi,Cinsiyat=@Cinsiyat,CalisBolm=@CalisBolm where CalisanID=" + textid.Text;
                OleDbCommand Guncellekomut = new OleDbCommand(Sorgu, Baglanti);
                Guncellekomut.Parameters.AddWithValue("@TcNo", texttc.Text);
                Guncellekomut.Parameters.AddWithValue("@Ad", textad.Text);
                Guncellekomut.Parameters.AddWithValue("@soyad", textsoyad.Text);
                Guncellekomut.Parameters.AddWithValue("@DogumTarih", textdtarih.Text);
                Guncellekomut.Parameters.AddWithValue("@tel", texttel.Text);
                Guncellekomut.Parameters.AddWithValue("@EvAdresi", textevadresi.Text);
                if (radioer.Checked == true)
                    Guncellekomut.Parameters.AddWithValue("@cinsiyet", "Erkek");
                else if (radiokadin.Checked == true)
                    Guncellekomut.Parameters.AddWithValue("@cinsiyet", "Kadın");
               
                if (radiosurucu.Checked == true)
                    Guncellekomut.Parameters.AddWithValue("@CalisBolm", "Sürücü");
                else if (radiocalisan.Checked == true)
                    Guncellekomut.Parameters.AddWithValue("@CalisBolm", "Çalışan");


                if (Guncellekomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(textid.Text + " Numaralı Kayıt Güncellendi");
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Güncelleme Hata Penceresi");
            }
        }
        public bool BoslukKontrol()
        {
            texttc.BackColor = Color.White;
            textad.BackColor = Color.White;
            textsoyad.BackColor = Color.White;
            textdtarih.BackColor = Color.White;
            texttel.BackColor = Color.White;
            textevadresi.BackColor = Color.White;
            if (texttc.Text == "")
            {
                texttc.BackColor = Color.Red;
                texttc.Focus();
                return false;
            }
            else if (textad.Text == "")
            {
                textad.BackColor = Color.Red;
                textad.Focus();
                return false;
            }
            else if (textsoyad.Text == "")
            {
                textsoyad.BackColor = Color.Red;
                textsoyad.Focus();
                return false;
            }
            else if (textdtarih.Text == "  .  .")
            {
                textdtarih.BackColor = Color.Red;
                textdtarih.Focus();
                return false;
            }
            else if (texttel.Text == "(    )    -")
            {
                texttel.BackColor = Color.Red;
                texttel.Focus();
                return false;
            }
            else if (textevadresi.Text == "")
            {
                textevadresi.BackColor = Color.Red;
                textevadresi.Focus();
                return false;
            }
            else if (radioer.Checked == false && radiokadin.Checked == false)
            {
                MessageBox.Show("Cinsiyet Seçiniz");
                return false;
            }
            else if ( radiosurucu.Checked == false && radiocalisan.Checked == false)
            {
                MessageBox.Show("Çalışan Bölüm Seçiniz");
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
                string Sorgu = "delete from Calisan where CalisanID=" + textid.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(textid.Text + " Nolu Kayıt Silindi");

                Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Silme Hata Penceresi");
            }
        }
        public void KayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string sorgu = "Select * from Calisan";
                string sorguad = "Select * from Calisan where Ad= '" + textCAara.Text + " ' ";
                string SorguSoyad = "select * from Calisan where Soyad='" + textsoyadara.Text + "'";
                string sorgubolm = "Select * from Calisan where CalisBolm= '" + comCBara.Text + " ' ";
                
                string sorguadbolm = "Select * from Calisan where Ad='" + textCAara.Text + " ' and  CalisBolm= '" + comCBara.Text + " ' ";
                string SorguAdSoyad = "select * from Calisan where Ad ='" + textCAara.Text + "'and Soyad='" + textsoyadara.Text + "'";
                string SorguSoyadbolm = "select * from Calisan where Soyad='" + textsoyadara.Text + "'and CalisBolm='" + comCBara.Text + "'";

                string SorguAdSoyadbolm = "select * from Calisan where Ad='" + textCAara.Text + "'and Soyad='" + textsoyadara.Text + "'and CalisBolm='" + comCBara.Text + "'";
                if (checcalisanadara.Checked == true && checkCBara.Checked == true && checkcalisansoyad.Checked == true)
                    sorgu = SorguAdSoyadbolm;
                else if (checcalisanadara.Checked == true && checkcalisansoyad.Checked == true)
                    sorgu = SorguAdSoyad;
                else if (checkcalisansoyad.Checked == true && checkCBara.Checked == true)
                    sorgu = SorguSoyadbolm;            
                else if (checcalisanadara.Checked == true && checkCBara.Checked == true)
                    sorgu = sorguadbolm;
                else if (checcalisanadara.Checked == true)
                    sorgu = sorguad;
                else if (checkCBara.Checked == true)
                    sorgu = sorgubolm;
                else if (checkcalisansoyad.Checked == true)
                    sorgu = SorguSoyad;

                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                da.Fill(ds, "Calisan");
                dataGridView1.DataSource = ds.Tables["Calisan"];
                Baglanti.Close();

            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Listeleme Hata Penceresi");

            }
        }
        public void KayitAraBenzer()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string sorgu = "select * from Calisan";

                string Sorguicertc = "select * from Calisan where TcNo like'%" + textara.Text + "%'";
                string Sorgubaslayantc = "select * from Calisan where TcNo like'" + textara.Text + "%'";
                string Sorgubitentc = "select * from Calisan where TcNo like'%" + textara.Text + "'";

                string Sorguicertel = "select * from Calisan where Tel like'%" + textara.Text + "%'";
                string Sorgubaslayantel = "select * from Calisan where Tel like'(" + textara.Text + "%'";
                string Sorgubitentel = "select * from Calisan where  Tel like'%" + textara.Text + "'";

                string sorguciniceren = "select * from Calisan where Cinsiyat like'%" + textara.Text + "%'";
                string sorgucinilebaslayan = "select * from Calisan where Cinsiyat like '" + textara.Text + "%'";
                string sorgucinilebiten = "select * from Calisan where Cinsiyat like'%" + textara.Text + "'";

                string sorgudoiceren = "select * from Calisan where DogumTarih like'%" + textara.Text + "%'";
                string sorgudoilebaslayan = "select * from Calisan where DogumTarih like '" + textara.Text + "%'";
                string sorgudoilebiten = "select * from Calisan where DogumTarih like'%" + textara.Text + "'";

                string sorgudevaiceren = "select * from Calisan where EvAdresi like'%" + textara.Text + "%'";
                string sorguevailebaslayan = "select * from Calisan where EvAdresi like '" + textara.Text + "%'";
                string sorguevailebiten = "select * from Calisan where EvAdresi like'%" + textara.Text + "'";

                if (comaramaturu.Text == "İçeren")
                {
                    if (radiotcnoara.Checked == true)
                        sorgu = Sorguicertc;
                    else if (radiotelara.Checked == true)
                        sorgu = Sorguicertel;
                    else if (radcin.Checked == true)
                        sorgu = sorguciniceren;
                    else if (raddo.Checked == true)
                        sorgu = sorgudoiceren;
                    else if (radioevara.Checked == true)
                        sorgu = sorgudevaiceren;
                }
                else if (comaramaturu.Text == "İle Başlayan")
                {
                    if (radiotcnoara.Checked == true)
                        sorgu = Sorgubaslayantc;
                    else if (radiotelara.Checked == true)
                        sorgu = Sorgubaslayantel;
                    else if (radcin.Checked == true)
                        sorgu = sorgucinilebaslayan;
                    else if (raddo.Checked == true)
                        sorgu = sorgudoilebaslayan;
                    else if (radioevara.Checked == true)
                        sorgu = sorguevailebaslayan;
                }
                else if (comaramaturu.Text == "İle Biten")
                {
                    if (radiotcnoara.Checked == true)
                        sorgu = Sorgubitentc;
                    else if (radiotelara.Checked == true)
                        sorgu = Sorgubitentel;
                    else if (radcin.Checked == true)
                        sorgu = sorgucinilebiten;
                    else if (raddo.Checked == true)
                        sorgu = sorgudoilebiten;
                    else if (radioevara.Checked == true)
                        sorgu = sorguevailebiten;

                }

                OleDbDataAdapter da = new OleDbDataAdapter(sorgu, Baglanti);
                da.Fill(ds, "Calisan");
                dataGridView1.DataSource = ds.Tables["Calisan"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kayıt Arama Benzer Hata Penceresi");

            }
        }
        
                
        private void button3_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                CalisanEkle();
            else
                MessageBox.Show("Boş alanları doldurunuz");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textid.Text == "")
                MessageBox.Show("lutfen Bir Kayıt Seçin");
            else
            {
                if (BoslukKontrol() == true)
                    KayitGuncelle();
                else
                    MessageBox.Show("Boş alanları doldurunuz");
            }
        }
     
        private void button5_Click_1(object sender, EventArgs e)
        {
            Kayitlistele();
        }

        private void btnYonListe_Click(object sender, EventArgs e)
        {
        }

        private void btnKayitSeç_Click(object sender, EventArgs e)
        {
            textid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            texttc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textsoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textdtarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            texttel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textevadresi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Erkek")
            {
                radioer.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Kadın")
            {
                radiokadin.Checked = true;
            }
            
            if (dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Sürücü")
            {
                radiosurucu.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Çalışan")
            {
                radiocalisan.Checked = true;
            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (textid.Text == "")
                MessageBox.Show("lutfen Bir Kayıt Seçin");
            else if (MessageBox.Show(textid.Text + " Nolu Kayıt silme istiyor musun", "Dikket", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
               KayitSil();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textid.Clear();
            texttc.Clear();
            textad.Clear();
            textsoyad.Clear();
            textdtarih.Clear();
            texttel.Clear();
            textevadresi.Clear();
            radioer.Checked = false;
            radiokadin.Checked = false;
            radiosurucu.Checked = false;
            radiocalisan.Checked = false;

        }

        private void checcalisanadara_CheckedChanged(object sender, EventArgs e)
        {
            if (checcalisanadara.Checked == true)
            {
                textCAara.Enabled = true;
                textCAara.Focus();
            }
            else
            {
                textCAara.Enabled = false;
                textCAara.Clear();

            }
        }

        private void checkCBara_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCBara.Checked == true)
            {
                comCBara.Enabled = true;
                comCBara.Focus();
            }
            else
            {
                comCBara.Enabled = false;
                comCBara.Text = "";
            }
        }

        private void btnCalisanAra_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void CalisanIslemlrei_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void CalisanIslemlrei_Activated(object sender, EventArgs e)
        {
            Baglanti.Close();
            Kayitlistele();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void checkcalisansoyad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkcalisansoyad.Checked == true)
            {
                textsoyadara.Enabled = true;
                textsoyadara.Focus();
            }
            else
            {
                textsoyadara.Enabled = false;
                textsoyadara.Clear();

            }
        }

        private void radiotcnoara_CheckedChanged(object sender, EventArgs e)
        {
            if (radiotcnoara.Checked == true)
            {

                labelsecara.Text = "Aranack Tcno";
                textara.Clear();
                textara.Focus();
            }
        }

        private void radiotelara_CheckedChanged(object sender, EventArgs e)
        {
             if (radiotelara.Checked == true)
                {
                    labelsecara.Text = "Aranack Telefon";
                    textara.Clear();
                    textara.Focus();
                 
                }
        }

        private void textara_TextChanged(object sender, EventArgs e)
        {
            if (radiotcnoara.Text == "Seçiniz")
            {
                MessageBox.Show("Arama benzer turu Seçiniz");
            }
            else
            KayitAraBenzer();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void radcin_CheckedChanged(object sender, EventArgs e)
        {
            labelsecara.Text = "Aranack Cinsyat";
            textara.Clear();
            textara.Focus();
        }

        private void raddo_CheckedChanged(object sender, EventArgs e)
        {
            labelsecara.Text = "Aranack Duğum Tarihi";
            textara.Clear();
            textara.Focus();
        }

        private void radioevara_CheckedChanged(object sender, EventArgs e)
        {
            labelsecara.Text = "Aranack Ev Adresi";
            textara.Clear();
            textara.Focus();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            texttc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textsoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textdtarih.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            texttel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textevadresi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Erkek")
            {
                radioer.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Kadın")
            {
                radiokadin.Checked = true;
            }

            if (dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Sürücü")
            {
                radiosurucu.Checked = true;
            }
            else if (dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Çalışan")
            {
                radiocalisan.Checked = true;
            }
        }

        private void textara_TextChanged_1(object sender, EventArgs e)
        {
            KayitAraBenzer();
        }
    }
}

