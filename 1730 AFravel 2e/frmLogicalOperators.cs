using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730_AFravel_2e
    {
    public partial class frmLogicalOperators : Form
        {
        public frmLogicalOperators()
            {
            InitializeComponent();
            }

        private void btnCalculate_Click(object sender, EventArgs e)
            {
            // Clearing Result & Side Effect values
            result01TextBox.Text = "";
            result02TextBox.Text = "";
            result03TextBox.Text = "";
            result03bTextBox.Text = "";
            result04TextBox.Text = "";
            result04bTextBox.Text = "";
            result05TextBox.Text = "";
            result05bTextBox.Text = "";
            result06TextBox.Text = "";
            result06bTextBox.Text = "";
            result07TextBox.Text = "";
            result08TextBox.Text = "";
            result09TextBox.Text = "";
            result09bTextBox.Text = "";
            result10TextBox.Text = "";

            // 01 subtotal >= 250 && subtotal < 500
            decimal subtotal = Convert.ToDecimal(input01aTextBox.Text);
            result01TextBox.Text = (
                subtotal >= 250 && subtotal < 500
                ).ToString();

            // 02 timeInService <= 4 || timeInService >= 12
            int timeInService = Convert.ToInt32(input02aTextBox.Text);
            result02TextBox.Text = (
                timeInService <= 4 || timeInService >= 12
                ).ToString();

            // 03 - 06 initialization
            bool isValid = Convert.ToBoolean(input03aTextBox.Text);
            int years = Convert.ToInt32(input03cTextBox.Text);

            // 03 isValid == true && counter++ < years
            int counter = Convert.ToInt32(input03bTextBox.Text);
            result03TextBox.Text = (
                isValid == true && counter++ < years
                ).ToString();
            result03bTextBox.Text = counter.ToString();

            // 04 isValid == true & counter++ < years
            counter = Convert.ToInt32(input03bTextBox.Text);
            result04TextBox.Text = (
                isValid == true & counter++ < years
                ).ToString();
            result04bTextBox.Text = counter.ToString();

            // 05 isValid == true || counter++ < years
            counter = Convert.ToInt32(input03bTextBox.Text);
            result05TextBox.Text = (
                isValid == true || counter++ < years
                ).ToString();
            result05bTextBox.Text = counter.ToString();

            // 06 isValid == true | counter++ < years
            counter = Convert.ToInt32(input03bTextBox.Text);
            result06TextBox.Text = (
                isValid == true | counter++ < years
                ).ToString();
            result06bTextBox.Text = counter.ToString();

            // 07 date > startDate && date < expirationDate || isValid == true
            DateTime startDate = Convert.ToDateTime(input07aTextBox.Text);
            DateTime expirationDate = Convert.ToDateTime(input07bTextBox.Text);
            DateTime date = Convert.ToDateTime(input07cTextBox.Text);
            isValid = Convert.ToBoolean(input07dTextBox.Text);
            result07TextBox.Text = (
                date > startDate && date < expirationDate || isValid == true
                ).ToString();

            // 08 ((thisYTD > lastYTD) || empType=="Part time") && startYear < currentYear 
            decimal thisYTD = Convert.ToDecimal(input08aTextBox.Text);
            decimal lastYTD = Convert.ToDecimal(input08bTextBox.Text);
            string empType = input08cTextBox.Text;
            int startYear = Convert.ToInt32(input08dTextBox.Text);
            int currentYear = Convert.ToInt32(input08eTextBox.Text);
            result08TextBox.Text = (
                ((thisYTD > lastYTD) || empType == "Part time") && startYear < currentYear
                ).ToString();

            // 09 !(counter++ >= years)
            counter = Convert.ToInt32(input09aTextBox.Text);
            years = Convert.ToInt32(input09bTextBox.Text);
            result09TextBox.Text = (
                !(counter++ >= years)
                ).ToString();
            result09bTextBox.Text = counter.ToString();

            // 10
            int a = Convert.ToInt32(input10aTextBox.Text);
            int b = Convert.ToInt32(input10bTextBox.Text);
            int c = Convert.ToInt32(input10cTextBox.Text);
            int d = Convert.ToInt32(input10dTextBox.Text);
            result10TextBox.Text = (
                a > b && (b < c || c < d)
                ).ToString();
            //bool v = a > b;
            //bool w = b < c;
            //bool x = c < d;
            //bool y = v && w;
            //bool z = y || x;
            //result10TextBox.Text = z.ToString();
            }
        }
    }
