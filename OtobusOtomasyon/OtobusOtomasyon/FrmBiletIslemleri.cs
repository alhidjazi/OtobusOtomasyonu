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
    public partial class FrmBiletIslemleri : Form
    {
        public FrmBiletIslemleri()
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
        public void Sec()
        {
            txtksehir.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtvsehir.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtoplaka.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtkzaman.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtvzaman.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txttahminisure.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtseferıd.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtbosks.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtbiletfiyat.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtsuit.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }
        public static string seferid, fiyat, otoplaka, kalkiszaman;
        public static int BosKoltuksayi;
        public void KayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string sorgu = "Select * from Seferler";
               
                string sorguvarsehir = "Select * from Seferler where VarisSehir= '" + cmbVarisSehri.Text + " ' ";
                string sorguKalkisZamani = "Select * from Seferler where KalkisZamani like '" + maskedTextBox1.Text + "%' ";

                string Sorgusoforop = "select * from Seferler where VarisSehir= '" + cmbVarisSehri.Text + " 'and KalkisZamani like '" + maskedTextBox1.Text + "%' ";

                if (cckvarlis.Checked == true && ckkzaman.Checked == true)
                    sorgu = Sorgusoforop;
                else if (cckvarlis.Checked == true)
                    sorgu = sorguvarsehir;
                else if (ckkzaman.Checked == true)
                    sorgu = sorguKalkisZamani;

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
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            seferid = txtseferıd.Text;
            fiyat = txtbiletfiyat.Text;
            otoplaka = txtoplaka.Text;
            kalkiszaman = txtkzaman.Text;
            BosKoltuksayi = Convert.ToInt32(txtbosks.Text);
            if (txtsuit.Text == "Suit")
            {
                BiletAl2 bal2 = new BiletAl2();
                bal2.ShowDialog();
            }
            else
            {
                BiletAl bal = new BiletAl();
                bal.ShowDialog();
            }
        }

        private void btnSeferGoster_Click(object sender, EventArgs e)
        {
            KayitAra();
        }

        private void FrmBiletIslemleri_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter da1 = new OleDbDataAdapter("select * from Sehirler", Baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cmbVarisSehri.DataSource = dt1;
            cmbVarisSehri.DisplayMember = "SehirAd";
            cmbVarisSehri.ValueMember = "SehirID";
        }

        private void cckvarlis_CheckedChanged(object sender, EventArgs e)
        {
            if (cckvarlis.Checked == true)
                cmbVarisSehri.Enabled = true;
            else
                cmbVarisSehri.Enabled = false;
        }

        private void ckkzaman_CheckedChanged(object sender, EventArgs e)
        {
            if (ckkzaman.Checked == true)
                maskedTextBox1.Enabled = true;
            else
                maskedTextBox1.Enabled = false;
        }

        private void FrmBiletIslemleri_Activated(object sender, EventArgs e)
        {
            Baglanti.Close();
            Kayitlistele();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Sec();
        }
    }
}
