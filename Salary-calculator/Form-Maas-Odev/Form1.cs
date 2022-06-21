using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Maas_Odev
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal maas = Convert.ToDecimal(txtMaas.Text);
            

            if (rdBekar.Checked)
            {
                maas = maas * 1.02m;
                if (chbAlmanca.Checked)
                    maas = maas * 1.02m;
                if (chbIngilizce.Checked)
                    maas = maas * 1.02m;
                if (chbFransızca.Checked)
                    maas = maas * 1.02m;
                if (chbItalyanca.Checked)
                    maas = maas * 1.02m;
                if (chbYunanca.Checked)
                    maas = maas * 1.02m;
                if (chbArapca.Checked)
                    maas = maas * 1.02m;

                lblSonMaas.Text = "Son maaşınız : " + maas + "₺ idir.";
            }
            else
            {
                maas = maas * 1.03m;
                if (rdSıfır.Checked)
                    maas = maas * 1m;
                if (rdBir.Checked)
                    maas = maas * 1.01m;
                if (rdİki.Checked)
                    maas = maas * 1.02m;
                if (rdUc.Checked)
                    maas = maas * 1.03m;
                if (chbAlmanca.Checked)
                    maas = maas * 1.02m;
                if (chbIngilizce.Checked)
                    maas = maas * 1.02m;
                if (chbFransızca.Checked)
                    maas = maas * 1.02m;
                if (chbItalyanca.Checked)
                    maas = maas * 1.02m;
                if (chbYunanca.Checked)
                    maas = maas * 1.02m;
                if (chbArapca.Checked)
                    maas = maas * 1.02m;
                
                lblSonMaas.Text = "Son maaşınız : " + maas + "₺ idir.";
            }
        }
        private void rdEvli_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEvli.Checked == true)
                grpCocuk.Visible = true;
        }

        private void rdBekar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBekar.Checked == true)
                grpCocuk.Visible = false;
        }

    }
}
