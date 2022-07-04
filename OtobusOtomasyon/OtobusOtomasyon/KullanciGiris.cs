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
    public partial class KullanciGiris : Form
    {
        public KullanciGiris()
        {
            InitializeComponent();
        }
        OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabanim.accdb ;Persist Security Info = False");

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
        public static string Kullaniciadi;
        public static string Kturu;

        public void KullaniciAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string sorguad = "Select * from Yoneticiler where KullanciAd='" + textkulanciadi.Text + "' and Sifre= '" + textkulancisifre.Text + "'";
               
                OleDbDataAdapter da = new OleDbDataAdapter(sorguad, Baglanti);
                da.Fill(ds, "Yoneticiler");
                dataGridView1.DataSource = ds.Tables["Yoneticiler"];
                Baglanti.Close();

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    Kturu = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    Kullaniciadi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    MessageBox.Show("Girilen Bilgiler Doğru. Hoşgeldiniz.", "Kullanıcı Girişi");
                    AnaForm frm = new AnaForm();
                    this.Hide();
                    frm.Show();
                }
                else
                    MessageBox.Show("Girilen Bİlgiler Hatalı", "Kullanıcı Giriş");
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Kullanıcı Arama Hata Penceresi");

            }


        }
        private void btngiris_Click(object sender, EventArgs e)
        {
            KullaniciAra();
        }
        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KullanciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void KullanciGiris_Load(object sender, EventArgs e)
        {

        }

        private void btngiris_Click_1(object sender, EventArgs e)
        {
            KullaniciAra();
        }

        private void btncikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
