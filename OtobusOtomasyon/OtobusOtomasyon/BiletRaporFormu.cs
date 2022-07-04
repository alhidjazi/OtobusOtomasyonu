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
    public partial class BiletRaporFormu : Form
    {
        public BiletRaporFormu()
        {
            InitializeComponent();
        }

        private void BiletRaporFormu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VeritabanimDataSet.Biletler' table. You can move, or remove it, as needed.
            this.BiletlerTableAdapter.Fill(this.VeritabanimDataSet.Biletler);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BiletlerBindingSource.Filter = "SeferID='" + txtseferidara.Text + "'"; this.reportViewer1.RefreshReport();

        }
    }
}
