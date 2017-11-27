using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class TaxSettings : Form
    {
        public static double npd = 310;
        public double Npd => (npd);

        public static double pnpd = 100;
        public double Pnpd => (pnpd);

        public static double incomeTax = 0.15;
        public double IncomeTax => (incomeTax);

        public static double healthInsuranceTax = 0.06;
        public double HealthInsuranceTax => (healthInsuranceTax);

        public static double socialInsuranceTax = 0.03;
        public double SocialInsuranceTax => (socialInsuranceTax);

        private static double authorIncomeTax = 0.15;
        public  double AuthorIncomeTax => (authorIncomeTax);

        public static double sodraTax = 0.3118;
        public double SodraTax => (sodraTax);
        public TaxSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                npd = Convert.ToDouble(textBoxNpdTax.Text);
                pnpd = Convert.ToDouble(textBoxPnpdTax.Text);
                incomeTax = Convert.ToDouble(textBoxIncomeTax.Text) / 100;
                healthInsuranceTax = Convert.ToDouble(textBoxHelthInsuranceTax.Text) / 100;
                socialInsuranceTax = Convert.ToDouble(textBoxSocoialInsuranceTax.Text) / 100;
                authorIncomeTax = Convert.ToDouble(textBoxAuthorIncomeTax.Text) / 100;
                sodraTax = Convert.ToDouble(textBoxSodraTax.Text) / 100;
            this.Close();
        }

        private void buttonCancelSettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
