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
    public partial class KullaniciRaporFormu : Form
    {
        public KullaniciRaporFormu()
        {
            InitializeComponent();
        }

        private void KullaniciRaporFormu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VeritabanimDataSet.Yoneticiler' table. You can move, or remove it, as needed.
            this.YoneticilerTableAdapter.Fill(this.VeritabanimDataSet.Yoneticiler);

            this.reportViewer1.RefreshReport();
        }
    }
}
