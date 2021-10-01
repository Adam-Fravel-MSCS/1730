using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730_AFravel_2d
    {
    public partial class frmIfStatements : Form
        {
        public frmIfStatements()
            {
            InitializeComponent();
            }
        //Set Pass Values button
        private void setPassValuesBtn_Click(object sender, EventArgs e)
            {
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "2";
            textBox6Input.Text = "Fravel";
            textBox7Input.Text = "1";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "2";
            textBox9Input.Text = "538";
            textBox10InputA.Text = "2";
            textBox10InputB.Text = "3";
            }
        //Set Fail Values button
        private void setFailValuesBtn_Click(object sender, EventArgs e)
            {
            textBox1Input.Text = "Frank n";
            textBox2Input.Text = "Beans!";
            textBox3Input.Text = "6.9";
            textBox4Input.Text = "true";
            textBox5InputA.Text = "Beans";
            textBox5InputB.Text = "Make";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "-5";
            textBox8InputA.Text = "2";
            textBox8InputB.Text = "1";
            textBox9Input.Text = "477";
            textBox10InputA.Text = "4";
            textBox10InputB.Text = "3";
            }
        //Calculate button
        private void calculateBtn_Click(object sender, EventArgs e)
            {
            //Setting ResultA column text to Fail
            textBox1ResultA.Text = "Fail";
            textBox2ResultA.Text = "Fail";
            textBox3ResultA.Text = "Fail";
            textBox4ResultA.Text = "Fail";
            textBox5ResultA.Text = "Fail";
            textBox6ResultA.Text = "Fail";
            textBox7ResultA.Text = "Fail";
            textBox8ResultA.Text = "Fail";
            textBox9ResultA.Text = "Fail";
            textBox10ResultA.Text = "Fail";
            //Setting ResultB column text to Success
            textBox1ResultB.Text = "Success";
            textBox2ResultB.Text = "Success";
            textBox3ResultB.Text = "Success";
            textBox4ResultB.Text = "Success";
            textBox5ResultB.Text = "Success";
            textBox6ResultB.Text = "Success";
            textBox7ResultB.Text = "Success";
            textBox8ResultB.Text = "Success";
            textBox9ResultB.Text = "Success";
            textBox10ResultB.Text = "Success";
            //Test row 1
            if (textBox1Input.Text == "Frank")
                textBox1ResultA.Text = "Success";
            if (textBox1Input.Text != "Frank")
                textBox1ResultB.Text = "Fail";
            //Test row 2
            if (textBox2Input.Text == "")
                textBox2ResultA.Text = "Success";
            if (textBox2Input.Text != "")
                textBox2ResultB.Text = "Fail";
            //Test row 3
            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3ResultA.Text = "Success";
            if (val3 != 2.3m)
                textBox3ResultB.Text = "Fail";
            //Test row 4
            bool val4 = Convert.ToBoolean(textBox4Input.Text);
            if (val4 == false)
                textBox4ResultA.Text = "Success";
            if (val4 != false)
                textBox4ResultB.Text = "Fail";
            //Test row 5
            if (textBox5InputA.Text == textBox5InputB.Text)
                textBox5ResultA.Text = "Success";
            if (textBox5InputA.Text != textBox5InputB.Text)
                textBox5ResultB.Text = "Fail";
            //Test row 6
            if (textBox6Input.Text != "Jones")
                textBox6ResultA.Text = "Success";
            if (textBox6Input.Text == "Jones")
                textBox6ResultB.Text = "Fail";
            //Test row 7
            int val7 = Convert.ToInt32(textBox7Input.Text);
            if (val7 > 0)
                textBox7ResultA.Text = "Success";
            if (val7 < 0)
                textBox7ResultB.Text = "Fail";
            //Test row 8
            uint val8A = Convert.ToUInt32(textBox8InputA.Text);
            uint val8B = Convert.ToUInt32(textBox8InputB.Text);
            if (val8A < val8B)
                textBox8ResultA.Text = "Success";
            if (val8A > val8B)
                textBox8ResultB.Text = "Fail";
            //Test row 9
            int val9 = Convert.ToInt32(textBox9Input.Text);
            if (val9 >= 500)
                textBox9ResultA.Text = "Success";
            if (val9 <= 500)
                textBox9ResultB.Text = "Fail";
            //Test row 10
            uint val10A = Convert.ToUInt32(textBox10InputA.Text);
            uint val10B = Convert.ToUInt32(textBox10InputB.Text);
            if (val10A <= val10B)
                textBox10ResultA.Text = "Success";
            if (val10A >= val10B)
                textBox10ResultB.Text = "Fail";
            }
        }
    }
