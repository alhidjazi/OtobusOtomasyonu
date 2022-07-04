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
    public partial class SeferlerRaporFormu : Form
    {
        public SeferlerRaporFormu()
        {
            InitializeComponent();
        }

        private void SeferlerRaporFormu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VeritabanimDataSet.Seferler' table. You can move, or remove it, as needed.
            this.SeferlerTableAdapter.Fill(this.VeritabanimDataSet.Seferler);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comvarlissehir.Text != "" && txtsurcuad.Text != "")
            {
                SeferlerBindingSource.Filter = "VarisSehir='" + comvarlissehir.Text + " ' and  SurucuID= '" + txtsurcuad.Text + " '"; this.reportViewer1.RefreshReport();
            }
            else if (comvarlissehir.Text == "" && txtsurcuad.Text != "")
            {
                SeferlerBindingSource.Filter = " SurucuID= '" + txtsurcuad.Text + " '"; this.reportViewer1.RefreshReport();
            }
            else if (comvarlissehir.Text != "" && txtsurcuad.Text == "")
            {
                SeferlerBindingSource.Filter = "VarisSehir='" + comvarlissehir.Text + " ' "; this.reportViewer1.RefreshReport();
            }
            else
                this.reportViewer1.RefreshReport();
        }
    }
}
