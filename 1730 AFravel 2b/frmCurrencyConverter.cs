﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730_AFravel_2b
    {
    public partial class frmCurrencyConverter : Form
        {
        public frmCurrencyConverter()
            {
            InitializeComponent();
            }

        private void btnReset_Click(object sender, EventArgs e)
            {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.717976";
            txtAmountBhutan.Text = "0.00";
            txtRateBhutan.Text = "0.0139831";
            txtAmountCosta.Text = "0.00";
            txtRateCosta.Text = "0.00176122";
            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.15528";
            }
        private void btnExit_Click(object sender, EventArgs e)
            {
            this.Close();
            }

        private void amountChanged(object sender, EventArgs e)
            {
            //Australia
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            decimal usdAustralia = amountAustralia * rateAustralia;
            txtUSDAustralia.Text = usdAustralia.ToString("0.00");
            //Bhutan
            decimal amountBhutan = Convert.ToDecimal(txtAmountBhutan.Text);
            decimal rateBhutan = Convert.ToDecimal(txtRateBhutan.Text);
            decimal usdBhutan = amountBhutan * rateBhutan;
            txtUSDBhutan.Text = usdBhutan.ToString("0.00");
            //Costa Rica
            decimal amountCosta = Convert.ToDecimal(txtAmountCosta.Text);
            decimal rateCosta = Convert.ToDecimal(txtRateCosta.Text);
            decimal usdCosta = amountCosta * rateCosta;
            txtUSDCosta.Text = usdCosta.ToString("0.00");
            //Euro
            decimal amountEuro = Convert.ToDecimal(txtAmountEuro.Text);
            decimal rateEuro = Convert.ToDecimal(txtRateEuro.Text);
            decimal usdEuro = amountEuro * rateEuro;
            txtUSDEuro.Text = usdEuro.ToString("0.00");
            //Total
            decimal totalUSD = usdAustralia + usdBhutan + usdCosta + usdEuro;
            txtTotalUSD.Text = totalUSD.ToString("0.00");
            }
        }
    }
