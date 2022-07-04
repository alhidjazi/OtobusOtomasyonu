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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void hatKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalisanIslemlrei calis = new CalisanIslemlrei();
            calis.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void AnaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void araçKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeferIslemleri frmsefer = new FrmSeferIslemleri();
            frmsefer.ShowDialog();
        }

        private void biletSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBiletIslemleri fembilislem = new FrmBiletIslemleri();
            fembilislem.ShowDialog();
        }

        private void muşterilerİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMusterilerİslemleri f = new FormMusterilerİslemleri();
            f.ShowDialog();
        }

        private void otobüsİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtobusIslemleri Ot = new OtobusIslemleri();
            Ot.ShowDialog();
        }

        private void şehirlerİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSehir Sehir = new FrmSehir();
            Sehir.ShowDialog();
        }

        private void kullancilerİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiIslemleri yo = new YoneticiIslemleri();
            yo.ShowDialog();
        }

        private void kullanıcıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult cevap;

            cevap = MessageBox.Show("Program Kapatılsın mı?", "Kapat", MessageBoxButtons.YesNo);

            if (cevap == DialogResult.Yes)
            {
                MessageBox.Show("program sonlandırılıyor");
                Application.Exit();
            }

            else if (cevap == DialogResult.No)
            {
                MessageBox.Show("program iptal ediliyor");
            }
        }

        private void çalışanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bolumeGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calisanraporformu cr = new Calisanraporformu();
            cr.ShowDialog();
        }

        private void kkullaniciTuruGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciRaporFormu krf = new KullaniciRaporFormu();
            krf.ShowDialog();
        }

        private void seferlerListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeferlerRaporFormu srf = new SeferlerRaporFormu();
            srf.ShowDialog();
        }

        private void ötöpüslerListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OtobusRaporFormu orf = new OtobusRaporFormu();
            orf.ShowDialog();
        }

        private void muşterilerListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriRaporFormu mrf = new MusteriRaporFormu();
            mrf.ShowDialog();
        }

        private void biletlerListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BiletRaporFormu brf = new BiletRaporFormu();
            brf.ShowDialog();
        }
    }
}
