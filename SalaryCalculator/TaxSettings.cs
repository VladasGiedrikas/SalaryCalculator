using System;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class TaxSettings : Form
    {
        
        public static double npd = 310; //  primarry values
        public double Npd => (npd);     // get changed values and send to main form

        public static double pnpd = 100;
        public double Pnpd => pnpd;

        public static double incomeTax = 0.15;
        public double IncomeTax => (incomeTax);

        public static double healthInsuranceTax = 0.06;
        public double HealthInsuranceTax => (healthInsuranceTax);

        public static double socialInsuranceTax = 0.03;
        public double SocialInsuranceTax => (socialInsuranceTax);

        private static double authorIncomeTax = 0.24;
        public  double AuthorIncomeTax => (authorIncomeTax);

        public static double sodraTax = 0.3118;
        public double SodraTax => (sodraTax);

        public static double sodraTaxAuthor = 0.3048;
        public double SodraTaxAuthor => (sodraTaxAuthor);

        public static double minimumWage = 380;
        public double MinimumWage => (minimumWage);

        public TaxSettings()
        {
            InitializeComponent();
        }

        // getting tax values from user
        // checking if the input is only numbers(double) and percentages are 0-100
        // and divide by 100 for better counting in main form

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBoxNpdTax.Text, out npd))
            {
                MessageBox.Show("Prašome įvesti tik tik skaičius!");
                return;
            }
            
            if (!double.TryParse(textBoxPnpdTax.Text, out pnpd))
            {
                MessageBox.Show("Prašome įvesti tik skaičius!");
                return;
            }
            if (!double.TryParse(textBoxIncomeTax.Text, out incomeTax)||incomeTax>100)
            {
                MessageBox.Show("Prašome įvesti tik skaičius!\n Procentai nuo 0 iki 100");
                return;
            }
            incomeTax = incomeTax / 100;
            if (!double.TryParse(textBoxHelthInsuranceTax.Text, out healthInsuranceTax)||healthInsuranceTax>100)
            {
                MessageBox.Show("Prašome įvesti tik skaičius!\n Procentai nuo 0 iki 100");
                return;
            }
            healthInsuranceTax = healthInsuranceTax / 100;
            if (!double.TryParse(textBoxSocoialInsuranceTax.Text, out socialInsuranceTax)||socialInsuranceTax>100)
            {
                MessageBox.Show("Prašome įvesti tik skaičius!\n Procentai nuo 0 iki 100");
                return;
            }
            socialInsuranceTax = socialInsuranceTax / 100;
            if (!double.TryParse(textBoxAuthorIncomeTax.Text, out authorIncomeTax)||authorIncomeTax>100)
            {
                MessageBox.Show("Prašome įvesti tik skaičius!\n Procentai nuo 0 iki 100");
                return;
            }
            authorIncomeTax = authorIncomeTax / 100;
            if (!double.TryParse(textBoxSodraTax.Text, out sodraTax)||sodraTax>100)
            {
                MessageBox.Show("Prašome įvesti tik skaičius!\n Procentai nuo 0 iki 100");
                return;
            }
            sodraTax = sodraTax / 100;
            if (!double.TryParse(textBoxMinimumWage.Text, out minimumWage))
            {
                MessageBox.Show("Prašome įvesti tik skaičius!");
                    return;
            }
            
            if (!double.TryParse(textBoxSodraTaxAuthor.Text, out sodraTaxAuthor))
            {
                MessageBox.Show("Prašome įvesti tik skaičius!\n Procentai nuo 0 iki 100");
                return;
            }
            sodraTaxAuthor = sodraTaxAuthor / 100;

            Close();
        }

        private void buttonCancelSettings_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
