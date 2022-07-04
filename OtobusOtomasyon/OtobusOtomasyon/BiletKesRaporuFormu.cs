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
    public partial class BiletKesRaporuFormu : Form
    {
        public BiletKesRaporuFormu()
        {
            InitializeComponent();
        }

        private void BiletKesRaporuFormu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VeritabanimDataSet.Biletler' table. You can move, or remove it, as needed.
            this.BiletlerTableAdapter.Fill(this.VeritabanimDataSet.Biletler);

            BiletlerBindingSource.Filter = "SeferID='"+FrmBiletIslemleri.seferid+"' and KoltukNo='"+BiletAl.koltukno+"'";
            this.reportViewer1.RefreshReport();
        }
    }
}
