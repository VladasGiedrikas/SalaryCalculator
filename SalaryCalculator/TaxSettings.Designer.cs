namespace SalaryCalculator
{
    partial class TaxSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNpdTax = new System.Windows.Forms.TextBox();
            this.textBoxAuthorIncomeTax = new System.Windows.Forms.TextBox();
            this.textBoxSocoialInsuranceTax = new System.Windows.Forms.TextBox();
            this.textBoxHelthInsuranceTax = new System.Windows.Forms.TextBox();
            this.textBoxIncomeTax = new System.Windows.Forms.TextBox();
            this.textBoxPnpdTax = new System.Windows.Forms.TextBox();
            this.textBoxSodraTax = new System.Windows.Forms.TextBox();
            this.buttonCancelSettings = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(170, 389);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(102, 40);
            this.buttonSaveSettings.TabIndex = 0;
            this.buttonSaveSettings.Text = "Išsaugoti";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "NPD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PNPD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pajamų mokestis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sveikatos draudimas ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pensijų ir soc. draudimas ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Autorines pajamos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Sodra mokama dabdavio";
            // 
            // textBoxNpdTax
            // 
            this.textBoxNpdTax.Location = new System.Drawing.Point(273, 94);
            this.textBoxNpdTax.Name = "textBoxNpdTax";
            this.textBoxNpdTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxNpdTax.Size = new System.Drawing.Size(100, 22);
            this.textBoxNpdTax.TabIndex = 8;
            this.textBoxNpdTax.Text = "310";
            // 
            // textBoxAuthorIncomeTax
            // 
            this.textBoxAuthorIncomeTax.Location = new System.Drawing.Point(273, 291);
            this.textBoxAuthorIncomeTax.Name = "textBoxAuthorIncomeTax";
            this.textBoxAuthorIncomeTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxAuthorIncomeTax.Size = new System.Drawing.Size(100, 22);
            this.textBoxAuthorIncomeTax.TabIndex = 9;
            this.textBoxAuthorIncomeTax.Text = "15";
            // 
            // textBoxSocoialInsuranceTax
            // 
            this.textBoxSocoialInsuranceTax.Location = new System.Drawing.Point(273, 255);
            this.textBoxSocoialInsuranceTax.Name = "textBoxSocoialInsuranceTax";
            this.textBoxSocoialInsuranceTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxSocoialInsuranceTax.Size = new System.Drawing.Size(100, 22);
            this.textBoxSocoialInsuranceTax.TabIndex = 10;
            this.textBoxSocoialInsuranceTax.Text = "3";
            // 
            // textBoxHelthInsuranceTax
            // 
            this.textBoxHelthInsuranceTax.Location = new System.Drawing.Point(273, 220);
            this.textBoxHelthInsuranceTax.Name = "textBoxHelthInsuranceTax";
            this.textBoxHelthInsuranceTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxHelthInsuranceTax.Size = new System.Drawing.Size(100, 22);
            this.textBoxHelthInsuranceTax.TabIndex = 11;
            this.textBoxHelthInsuranceTax.Text = "6";
            // 
            // textBoxIncomeTax
            // 
            this.textBoxIncomeTax.Location = new System.Drawing.Point(273, 179);
            this.textBoxIncomeTax.Name = "textBoxIncomeTax";
            this.textBoxIncomeTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxIncomeTax.Size = new System.Drawing.Size(100, 22);
            this.textBoxIncomeTax.TabIndex = 12;
            this.textBoxIncomeTax.Text = "15";
            // 
            // textBoxPnpdTax
            // 
            this.textBoxPnpdTax.Location = new System.Drawing.Point(273, 138);
            this.textBoxPnpdTax.Name = "textBoxPnpdTax";
            this.textBoxPnpdTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPnpdTax.Size = new System.Drawing.Size(100, 22);
            this.textBoxPnpdTax.TabIndex = 13;
            this.textBoxPnpdTax.Text = "100";
            // 
            // textBoxSodraTax
            // 
            this.textBoxSodraTax.Location = new System.Drawing.Point(273, 323);
            this.textBoxSodraTax.Name = "textBoxSodraTax";
            this.textBoxSodraTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxSodraTax.Size = new System.Drawing.Size(100, 22);
            this.textBoxSodraTax.TabIndex = 14;
            this.textBoxSodraTax.Text = "31.18";
            // 
            // buttonCancelSettings
            // 
            this.buttonCancelSettings.Location = new System.Drawing.Point(298, 389);
            this.buttonCancelSettings.Name = "buttonCancelSettings";
            this.buttonCancelSettings.Size = new System.Drawing.Size(96, 40);
            this.buttonCancelSettings.TabIndex = 15;
            this.buttonCancelSettings.Text = "Atšaukti";
            this.buttonCancelSettings.UseVisualStyleBackColor = true;
            this.buttonCancelSettings.Click += new System.EventHandler(this.buttonCancelSettings_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(376, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "€";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(376, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "€";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(376, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(376, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(376, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(376, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(376, 328);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "%";
            // 
            // TaxSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 532);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonCancelSettings);
            this.Controls.Add(this.textBoxSodraTax);
            this.Controls.Add(this.textBoxPnpdTax);
            this.Controls.Add(this.textBoxIncomeTax);
            this.Controls.Add(this.textBoxHelthInsuranceTax);
            this.Controls.Add(this.textBoxSocoialInsuranceTax);
            this.Controls.Add(this.textBoxAuthorIncomeTax);
            this.Controls.Add(this.textBoxNpdTax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveSettings);
            this.Name = "TaxSettings";
            this.Text = "TaxSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNpdTax;
        private System.Windows.Forms.TextBox textBoxAuthorIncomeTax;
        private System.Windows.Forms.TextBox textBoxSocoialInsuranceTax;
        private System.Windows.Forms.TextBox textBoxHelthInsuranceTax;
        private System.Windows.Forms.TextBox textBoxIncomeTax;
        private System.Windows.Forms.TextBox textBoxPnpdTax;
        private System.Windows.Forms.TextBox textBoxSodraTax;
        private System.Windows.Forms.Button buttonCancelSettings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}