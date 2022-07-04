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
    public partial class OtobusRaporFormu : Form
    {
        public OtobusRaporFormu()
        {
            InitializeComponent();
        }

        private void OtobusRaporFormu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VeritabanimDataSet.Otobusler' table. You can move, or remove it, as needed.
            this.OtobuslerTableAdapter.Fill(this.VeritabanimDataSet.Otobusler);

            this.reportViewer1.RefreshReport();
        }
    }
}
