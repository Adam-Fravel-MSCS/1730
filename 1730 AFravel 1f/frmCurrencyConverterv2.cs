using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730_AFravel_1f
    {
    public partial class frmCurrencyConverterv2 : Form
        {
        public frmCurrencyConverterv2()
            {
            InitializeComponent();
            }
        private void frmCurrencyConverterv2_Load(object sender, EventArgs e)
            {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCosta.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnAustralia.Text + ":";
            txtRate.Text = "0.717976";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            //focus would not work on just this method, so I used select instead
            //txtCurrency.Focus();
            txtCurrency.Select();
            }
        private void btnAustralia_Click(object sender, EventArgs e)
            {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCosta.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.717976";
            lblCurrency.Text = btnAustralia.Text + ":";
            txtCurrency.Focus();
            }
        private void btnBhutan_Click(object sender, EventArgs e)
            {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnCosta.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.0139831";
            lblCurrency.Text = btnBhutan.Text + ":";
            txtCurrency.Focus();
            }
        private void btnCosta_Click(object sender, EventArgs e)
            {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCosta.BackgroundImage = picCostaRica.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.00176122";
            lblCurrency.Text = btnCosta.Text + ":";
            txtCurrency.Focus();
            }
        private void btnEuro_Click(object sender, EventArgs e)
            {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCosta.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuro.Image;
            txtRate.Text = "1.15528";
            lblCurrency.Text = btnEuro.Text + ":";
            txtCurrency.Focus();
            }
        private void calcUSD(object sender, EventArgs e)
            {
            txtUSDollars.Text = (Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)).ToString("0.00");
            }
        private void txtCurrency_Enter(object sender, EventArgs e)
            {
            txtCurrency.SelectAll();
            }
        private void btnAdd_Click(object sender, EventArgs e)
            {          
            txtTotalUSD.Text = (Convert.ToDecimal(txtUSDollars.Text) + Convert.ToDecimal(txtTotalUSD.Text)).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;
            txtCurrency.Focus();
            }

        private void btnReset_Click(object sender, EventArgs e)
            {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCosta.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnAustralia.Text + ":";
            lblEquation.Text = "";
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.717976";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Select();
            }

        private void btnExit_Click(object sender, EventArgs e)
            {
            this.Close();
            }
        }
    }
