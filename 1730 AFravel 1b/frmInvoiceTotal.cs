using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730_AFravel_1b
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //txtTotal.Text = "Hello";
            //txtTotal.ReadOnly = true;
            //txtTotal.TabIndex = 5;
            //txtDiscountAmt.Text = txtDiscountPercent.Text;

            txtDiscountAmt.Text = (Convert.ToDecimal(txtSubtotal.Text) * Convert.ToDecimal(txtDiscountPercent.Text) / 100) .ToString("0.00");

            txtTotal.Text = (Convert.ToDecimal(txtSubtotal.Text) - Convert.ToDecimal(txtDiscountAmt.Text)).ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
