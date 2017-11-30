using System;
using System.Globalization;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            
            InitializeComponent();
            // making texbox for author income invisible
            textBoxAuthorIncome.Visible = (checkBoxAuthorIncome.CheckState == CheckState.Checked);
            textBoxAuthorIncome2.Visible = (CheckBoxAuthorIncome2.CheckState == CheckState.Checked);
        }

        private void buttonCountOnHands_Click(object sender, EventArgs e)
        {
            // counting for tab1 salary on paper
            // getting values from user
            if (!Int32.TryParse(textBoxNmbOfChildrens.Text, out int numberOfChildrens))
            {
                MessageBox.Show("Prašome įvesti tik sveikus skaičius!");
                return;
            }
            
            if (!double.TryParse(textBoxSalaryOnPapper.Text, out double salaryOnPaper))
            {
                MessageBox.Show("Prašome įvesti tik skaičius!");
                return;
            }
            if (!double.TryParse(textBoxAuthorIncome.Text, out double authorIncome))
            {
                MessageBox.Show("Prašome įvesti tik skaičius!");
                return;
            }

            
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("lt-LT"); // for currency string formatting 
            TaxSettings tax = new TaxSettings(); //  values from settings
            
            double npd=0;
            double incomeTax = 0;
            var pnpd = tax.Pnpd * numberOfChildrens;
            if (radioButtonAlone.Checked)
            {
                pnpd = pnpd * 2;
            }
            // income tax  npd is different relating to salary
            if (salaryOnPaper <= tax.MinimumWage)
            {
                npd =tax.Npd;
                labelIncomeTax.Text = incomeTax.ToString("C", cultureInfo);
                if (salaryOnPaper>tax.Npd&&salaryOnPaper<=tax.MinimumWage)
                {
                    npd = tax.Npd ;
                    labelIncomeTax.Text = ((salaryOnPaper-npd) * tax.IncomeTax).ToString("C",cultureInfo);
                    if (numberOfChildrens>0)
                    {
                        labelIncomeTax.Text = ((salaryOnPaper - tax.Npd - pnpd) * tax.IncomeTax).ToString("C", cultureInfo);
                    }
                }
            }
             if (salaryOnPaper > tax.MinimumWage)
            {
                npd = tax.Npd - (0.5 * (salaryOnPaper - tax.MinimumWage));
                labelIncomeTax.Text = ((salaryOnPaper-npd) * tax.IncomeTax).ToString("C", cultureInfo);
                if (numberOfChildrens > 0)
                {
                    labelIncomeTax.Text = ((salaryOnPaper - npd - pnpd) * tax.IncomeTax).ToString("C", cultureInfo);
                }
                if (npd<0)
                {
                    npd = 0;
                    labelIncomeTax.Text = ((salaryOnPaper - npd -pnpd) * tax.IncomeTax).ToString("C", cultureInfo);
                }
            }
            // counting and show results to labels on tab1

            labelNpd.Text = npd.ToString("C",cultureInfo);

            labelPnpd.Text = pnpd.ToString("C", cultureInfo);

            labelHealthInsurance.Text =(salaryOnPaper *tax.HealthInsuranceTax).ToString("C", cultureInfo);

            labelSocialInsurance.Text = (salaryOnPaper*tax.SocialInsuranceTax).ToString("C", cultureInfo);

            labelAuthorTax.Text =(authorIncome-(authorIncome*tax.AuthorIncomeTax)).ToString("C", cultureInfo);

            labelSodraTax.Text = (salaryOnPaper *tax.SodraTax).ToString("C", cultureInfo);

            labelOnPaperSalary.Text = salaryOnPaper.ToString("C", cultureInfo);

            labelWorkPlacePrice.Text = (salaryOnPaper + (salaryOnPaper * tax.SodraTax)).ToString("C", cultureInfo);

            labelOnHandSalary.Text = ((salaryOnPaper - ((salaryOnPaper - pnpd-npd) * tax.IncomeTax)) -
                                     (salaryOnPaper * tax.HealthInsuranceTax) -
                                     (salaryOnPaper * tax.SocialInsuranceTax)).ToString("C", cultureInfo);
                if (pnpd>salaryOnPaper - npd)
                {
                    labelIncomeTax.Text = incomeTax.ToString("C", cultureInfo);
                    labelOnHandSalary.Text = (salaryOnPaper - (salaryOnPaper * tax.HealthInsuranceTax)- 
                                             (salaryOnPaper * tax.SocialInsuranceTax)).ToString("C", cultureInfo);
                }
        }

        private void buttonCountOnPapper_Click(object sender, EventArgs e)
        {
           
            // getting values from user on tab2
            if (!Int32.TryParse(textBoxNmbOfChildrens2.Text, out int numberOfChildrens2))
            {
                MessageBox.Show("Prašome įvesti tik  sveikus skaičius!");
                return;
            }
            if (!double.TryParse(textBoxSalaryOnHands.Text, out double salaryOnHands2))
            {
                MessageBox.Show("Prašome įvesti tik  skaičius!");
                return;
            }
            if (!double.TryParse(textBoxAuthorIncome2.Text, out double authorIncome2))
            {
                MessageBox.Show("Prašome įvesti tik  skaičius!");
                return;
            }

            
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("lt-LT"); // for currency string formatting 

            TaxSettings tax = new TaxSettings();
            // counting for tab2 salary on hands
            double npd2 = 0;
            double salaryOnPaper2 = 0;
            var pnpd2 = tax.Pnpd * numberOfChildrens2;
            if (radioButtonAlone2.Checked)
            {
                pnpd2 = pnpd2 * 2;
            }
            //on paper if not using npd
            // with all taxes 
            double taxesShort = (1 - (tax.IncomeTax + tax.HealthInsuranceTax + tax.SocialInsuranceTax));
            if (salaryOnHands2>760)
            {
                salaryOnPaper2 = salaryOnHands2 / taxesShort;
                labelIncomeTax2.Text = ((salaryOnPaper2 - npd2 - pnpd2) * tax.IncomeTax).ToString("C", cultureInfo);

                if (numberOfChildrens2 > 0)
                {
                    double incomePnpd = (salaryOnPaper2 - pnpd2) * tax.IncomeTax;
                    salaryOnPaper2 = (salaryOnHands2 / (1 - (tax.HealthInsuranceTax + tax.SocialInsuranceTax))) + incomePnpd;
                    labelIncomeTax2.Text = ((salaryOnPaper2 - pnpd2) * tax.IncomeTax).ToString("C", cultureInfo);
                    if (salaryOnPaper2 - pnpd2 < 0)
                    {
                        salaryOnPaper2 = (salaryOnHands2 / (1 - (tax.HealthInsuranceTax + tax.SocialInsuranceTax)));
                        labelIncomeTax2.Text = 0.ToString("C", cultureInfo);
                    }
                }
            }
            //if on hands <760 and >282.10 then using npd
            if (salaryOnHands2<760 && salaryOnHands2> 282.10)
            {
                salaryOnPaper2 = (salaryOnHands2 - tax.IncomeTax * (tax.Npd + (0.5 * tax.MinimumWage) + pnpd2)) /
                    (1 - tax.HealthInsuranceTax - tax.SocialInsuranceTax - (1.5 * tax.IncomeTax));

                npd2 = tax.Npd - (0.5 * (salaryOnPaper2 - tax.MinimumWage));

                labelIncomeTax2.Text = ((salaryOnPaper2 - npd2-pnpd2) * tax.IncomeTax).ToString("C", cultureInfo);
                if (pnpd2+npd2>salaryOnPaper2)
                {
                    labelIncomeTax2.Text = 0.ToString("C", cultureInfo);
                    salaryOnPaper2 = (salaryOnHands2 / (1 - (tax.HealthInsuranceTax + tax.SocialInsuranceTax)));
                }
            }
           
            // if on hands < 282.10 then no income tax
            if (salaryOnHands2 < 282.10)
            {
                labelIncomeTax2.Text = 0.ToString("C", cultureInfo);
                salaryOnPaper2 = (salaryOnHands2 / (1 - (tax.HealthInsuranceTax + tax.SocialInsuranceTax)));
                npd2 = tax.Npd;
            }

            //show results to labels on tab2
            labelNpd2.Text = npd2.ToString("C", cultureInfo);

            labelPnpd2.Text = pnpd2.ToString("C", cultureInfo);

            labelHealthInsurance2.Text = (salaryOnPaper2 * tax.HealthInsuranceTax).ToString("C", cultureInfo);

            labelSocialInsurance2.Text = (salaryOnPaper2 * tax.SocialInsuranceTax).ToString("C", cultureInfo);

            labelAuthorTax2.Text = (authorIncome2/ (1-tax.AuthorIncomeTax)).ToString("C", cultureInfo);

            labelSodraTax2.Text = (salaryOnPaper2 * tax.SodraTax).ToString("C", cultureInfo);

            labelOnPaperSalary2.Text = salaryOnPaper2.ToString("C", cultureInfo);

            labelWorkPlacePrice2.Text = (salaryOnPaper2 + (salaryOnPaper2 * tax.SodraTax)).ToString("C", cultureInfo);

            labelOnHandSalary2.Text = salaryOnHands2.ToString("C", cultureInfo);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            var settings = new TaxSettings();
            settings.ShowDialog();
        }

        private void checkBoxAuthorIncome_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAuthorIncome.Visible = (checkBoxAuthorIncome.CheckState == CheckState.Checked);
        }

        private void CheckBoxAuthorIncome2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAuthorIncome2.Visible = (CheckBoxAuthorIncome2.CheckState == CheckState.Checked);
        }
    }
}
