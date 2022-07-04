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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timergizle_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.01;
            if (this.Opacity == 0)
            {
                KullanciGiris kg = new KullanciGiris();
                kg.Show();
                this.Hide();
                timergizle.Enabled = false;
            }
        }

        private void timergoster_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.01;
            if (progressBar1.Value < 100)
                progressBar1.Value+=100;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnsistmegiris_Click(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                timergizle.Enabled = true;
                timergoster.Enabled = false;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
