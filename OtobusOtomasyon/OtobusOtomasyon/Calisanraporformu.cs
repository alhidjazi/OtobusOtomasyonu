using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusOtomasyon
{
    public partial class Calisanraporformu : Form
    {
        public Calisanraporformu()
        {
            InitializeComponent();
        }

        private void Calisanraporformu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VeritabanimDataSet.Calisan' table. You can move, or remove it, as needed.
            this.CalisanTableAdapter.Fill(this.VeritabanimDataSet.Calisan);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cinsyat = "";
            if (radioer.Checked == true)
                cinsyat = "Erkek";
            else if (radiokadin.Checked == true)
                cinsyat = "kadın";

            if (txtAd.Text != "" && comclbolum.Text != "" && cinsyat != "")
            {
                CalisanBindingSource.Filter = " Ad= '" + txtAd.Text + " ' and  CalisBolm= '" + comclbolum.Text + " ' and Cinsiyat = '" + cinsyat + " '"; this.reportViewer1.RefreshReport();
            }
            else if (txtAd.Text != "" && comclbolum.Text != "")
            {
                CalisanBindingSource.Filter = " Ad= '" + txtAd.Text + " ' and  CalisBolm= '" + comclbolum.Text + " '"; this.reportViewer1.RefreshReport();
            }
            else if (txtAd.Text != "" && cinsyat != "")
            {
                CalisanBindingSource.Filter = " Ad= '" + txtAd.Text + " '  and Cinsiyat = '" + cinsyat + " '"; this.reportViewer1.RefreshReport();
            }
            else if (comclbolum.Text != "" && cinsyat != "")
            {
                CalisanBindingSource.Filter = " CalisBolm= '" + comclbolum.Text + " ' and Cinsiyat = '" + cinsyat + " '"; this.reportViewer1.RefreshReport();
            }
            else if (txtAd.Text != "")
            {
                CalisanBindingSource.Filter = " Ad= '" + txtAd.Text + " ' "; this.reportViewer1.RefreshReport();
            }
            else if (comclbolum.Text != "")
            {
                CalisanBindingSource.Filter = "   CalisBolm= '" + comclbolum.Text + " ' "; this.reportViewer1.RefreshReport();
            }
            else if (cinsyat != "")
            {
                CalisanBindingSource.Filter = " Cinsiyat = '" + cinsyat + " '"; this.reportViewer1.RefreshReport();
            }
        }
    }
}
