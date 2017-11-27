using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            textBoxAuthorIncome2.Visible = (checkBoxAuthorIncome2.CheckState == CheckState.Checked);
        }

        private void buttonCountOnHands_Click(object sender, EventArgs e)
        {
            // getting values from textboxs
            var numberOfChildrens = Convert.ToInt32(textBoxNmbOfChildrens.Text);
            var salaryOnPaper = Convert.ToDouble(textBoxSalaryOnPapper.Text);
            var authorIncome = Convert.ToDouble(textBoxAuthorIncome.Text);
           
            // counting and show results to labels on tab1
            TaxSettings tax = new TaxSettings();
            
            var npd1 = 310 - (0.5 * (salaryOnPaper - 380));
            // npd is 0 if salary on paper is >1000
            labelNpd.Text = 0.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelPnpd.Text = (tax.Pnpd * numberOfChildrens).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelIncomeTax.Text = ((salaryOnPaper-(tax.Pnpd*numberOfChildrens))*tax.IncomeTax).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelHealthInsurance.Text =(salaryOnPaper *tax.HealthInsuranceTax).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelSocialInsurance.Text = (salaryOnPaper*tax.SocialInsuranceTax).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelAuthorTax.Text =(authorIncome-(authorIncome*tax.AuthorIncomeTax)).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelSodraTax.Text = (salaryOnPaper *tax.SodraTax).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelOnPaperSalary.Text = salaryOnPaper.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelOnHandSalary.Text = ((salaryOnPaper - ((salaryOnPaper - (tax.Pnpd * numberOfChildrens)) * tax.IncomeTax)) - (salaryOnPaper * tax.HealthInsuranceTax) - (salaryOnPaper * tax.SocialInsuranceTax)).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelWorkPlacePrice.Text = (salaryOnPaper + (salaryOnPaper * tax.SodraTax)).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));

            // because income tax depends on npd and pnpd need to count seperately
            if (salaryOnPaper<=310)
            {
                labelNpd.Text = tax.Npd.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                labelIncomeTax.Text = 0.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
               
                // if Pnpd more than salary on paper than income tax is 0.00
                if (tax.Pnpd*numberOfChildrens>salaryOnPaper- tax.Npd)
                {
                    labelIncomeTax.Text = 0.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                    labelOnHandSalary.Text = (salaryOnPaper - (salaryOnPaper * tax.HealthInsuranceTax) - (salaryOnPaper * tax.SocialInsuranceTax)).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                }
            }
            // if salary on paper is >310 and <1000
            if (salaryOnPaper>310&&salaryOnPaper<1000)
            {
                labelNpd.Text =npd1.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                var pnpd1 = tax.Pnpd * numberOfChildrens;
                labelIncomeTax.Text = ((salaryOnPaper - tax.Pnpd*numberOfChildrens - npd1) * tax.IncomeTax).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                labelOnHandSalary.Text = ((salaryOnPaper-((salaryOnPaper - npd1 - pnpd1) * tax.IncomeTax)) - (salaryOnPaper * tax.HealthInsuranceTax) - (salaryOnPaper * tax.SocialInsuranceTax)).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));

                // check if pnpd is more than salary on paper
                if (tax.Pnpd * numberOfChildrens > salaryOnPaper - tax.Npd)
                {
                    labelIncomeTax.Text = "0.00";
                }
            }
        }

        private void buttonCountOnPapper_Click(object sender, EventArgs e)
        {
            //getting values from textboxs
            var numberOfChildrens2 = Convert.ToInt32(textBoxNmbOfChildrens2.Text);
            var salaryOnHands = Convert.ToInt32(textBoxSalaryOnHands.Text);
            var authorIncome2 = Convert.ToInt32(textBoxAuthorIncome2.Text);
           
            TaxSettings tax = new TaxSettings();
            var salaryOnPapper2 = salaryOnHands / (1 - (tax.IncomeTax + tax.HealthInsuranceTax + tax.SocialInsuranceTax));
            var npd2 = 310 - (0.5 * (salaryOnPapper2 - 380));
            //counting and show results to labels on tab2
            labelNpd.Text = 0.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelPnpd2.Text = (tax.Pnpd * numberOfChildrens2).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelIncomeTax2.Text = ((salaryOnPapper2 - (tax.Pnpd * numberOfChildrens2)) * tax.IncomeTax).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelHealthInsurance2.Text = (salaryOnPapper2* tax.HealthInsuranceTax).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelSocialInsurance2.Text = (salaryOnPapper2 * tax.SocialInsuranceTax).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelAuthorTax2.Text = (authorIncome2 - (authorIncome2 * tax.AuthorIncomeTax)).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelSodraTax2.Text = (salaryOnPapper2 * tax.SodraTax).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelOnPaperSalary2.Text = salaryOnPapper2.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelOnHandSalary2.Text = salaryOnHands.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
            labelWorkPlacePrice2.Text = (salaryOnPapper2 + (salaryOnPapper2 * tax.SodraTax)).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
           
            // because income tax depends on npd and pnpd need to count seperately
            if (salaryOnPapper2 <= 310)
            {
                labelNpd2.Text = tax.Npd.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                labelIncomeTax2.Text = 0.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                // if Pnpd more than salary on paper than income tax is 0.00
                if (tax.Pnpd * numberOfChildrens2 > salaryOnPapper2 - tax.Npd)
                {
                    labelIncomeTax.Text = 0.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                    labelOnHandSalary2.Text = (salaryOnPapper2 - (salaryOnPapper2 * tax.HealthInsuranceTax) - (salaryOnPapper2 * tax.SocialInsuranceTax)).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                }
            }
            // if salary on paper is >310 and <1000
            if (salaryOnPapper2> 310 && salaryOnPapper2< 1000)
            {
                labelNpd2.Text = npd2.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                labelIncomeTax2.Text = ((salaryOnPapper2 - tax.Pnpd * numberOfChildrens2 - npd2) * tax.IncomeTax).ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                // check if pnpd is more than salary on paper
                if (tax.Pnpd * numberOfChildrens2 > salaryOnPapper2 - tax.Npd)
                {
                    labelIncomeTax.Text = 0.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                }
            }

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            var settings = new TaxSettings();
            settings.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var settings = new TaxSettings();
            settings.ShowDialog();
        }

        private void checkBoxAuthorIncome_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAuthorIncome.Visible = (checkBoxAuthorIncome.CheckState == CheckState.Checked);
        }

        private void checkBoxAuthorIncome2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAuthorIncome2.Visible = (checkBoxAuthorIncome2.CheckState == CheckState.Checked);
        }
    }
}
