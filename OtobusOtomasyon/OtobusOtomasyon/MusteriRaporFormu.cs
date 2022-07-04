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
    public partial class MusteriRaporFormu : Form
    {
        public MusteriRaporFormu()
        {
            InitializeComponent();
        }

        private void MusteriRaporFormu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VeritabanimDataSet.Musteriler' table. You can move, or remove it, as needed.
            this.MusterilerTableAdapter.Fill(this.VeritabanimDataSet.Musteriler);

            this.reportViewer1.RefreshReport();
        }
    }
}
