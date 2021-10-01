using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730_AFravel_2c
    {
    public partial class frmDataTypes : Form
        {
        //Creating variables (different scope)
        private byte byte1, byte2, byte3;
        private sbyte sbyte1, sbyte2, sbyte3;
        private short short1, short2, short3;
        private ushort ushort1, ushort2, ushort3;
        private int int1, int2, int3;
        private uint uint1, uint2, uint3;
        private long long1, long2, long3;
        private ulong ulong1, ulong2, ulong3;
        private float float1, float2, float3;
        private double double1, double2, double3;
        private decimal decimal1, decimal2, decimal3;
        public frmDataTypes()
            {
            InitializeComponent();
            }

        //"Set Minimum" button
        private void setMinBtn_Click(object sender, EventArgs e)
            {
            //Using built-in c# class to assign MinValues to variables
            byte1 = Byte.MinValue;
            sbyte1 = SByte.MinValue;
            short1 = Int16.MinValue;
            ushort1 = UInt16.MinValue;
            int1 = Int32.MinValue;
            uint1 = UInt32.MinValue;
            long1 = Int64.MinValue;
            ulong1 = UInt64.MinValue;
            float1 = Single.MinValue;
            double1 = Double.MinValue;
            decimal1 = Decimal.MinValue;

            //Assigning the MinValues to the column 1 text boxes
            byte1TextBox.Text = byte1.ToString();
            sbyte1TextBox.Text = sbyte1.ToString();
            short1TextBox.Text = short1.ToString();
            ushort1TextBox.Text = ushort1.ToString();
            int1TextBox.Text = int1.ToString();
            uint1TextBox.Text = uint1.ToString();
            long1TextBox.Text = long1.ToString();
            ulong1TextBox.Text = ulong1.ToString();
            float1TextBox.Text = float1.ToString();
            double1TextBox.Text = double1.ToString();
            decimal1TextBox.Text = decimal1.ToString();
            }

        //"Set Maximum" button
        private void setMaxBtn_Click(object sender, EventArgs e)
            {
            //Using built-in c# class to assign MaxValues to variables
            byte2 = Byte.MaxValue;
            sbyte2 = SByte.MaxValue;
            short2 = Int16.MaxValue;
            ushort2 = UInt16.MaxValue;
            int2 = Int32.MaxValue;
            uint2 = UInt32.MaxValue;
            long2 = Int64.MaxValue;
            ulong2 = UInt64.MaxValue;
            float2 = Single.MaxValue;
            double2 = Double.MaxValue;
            decimal2 = Decimal.MaxValue;

            //Assigning the MaxValues to the column 2 text boxes
            byte2TextBox.Text = byte2.ToString();
            sbyte2TextBox.Text = sbyte2.ToString();
            short2TextBox.Text = short2.ToString();
            ushort2TextBox.Text = ushort2.ToString();
            int2TextBox.Text = int2.ToString();
            uint2TextBox.Text = uint2.ToString();
            long2TextBox.Text = long2.ToString();
            ulong2TextBox.Text = ulong2.ToString();
            float2TextBox.Text = float2.ToString();
            double2TextBox.Text = double2.ToString();
            decimal2TextBox.Text = decimal2.ToString();
            }

        //Minimum column (column 1) updates during text change
        private void input1TextBox_TextChanged(object sender, EventArgs e)
            {
            try
                {
                byte1 = Convert.ToByte(input1TextBox.Text);
                byte1TextBox.Text = byte1.ToString();
                }
            catch (Exception) { byte1TextBox.Text = "Error"; byte1 = 0; }
            try
                {
                sbyte1 = Convert.ToSByte(input1TextBox.Text);
                sbyte1TextBox.Text = sbyte1.ToString();
                }
            catch (Exception) { sbyte1TextBox.Text = "Error"; sbyte1 = 0; }
            try
                {
                short1 = Convert.ToInt16(input1TextBox.Text);
                short1TextBox.Text = short1.ToString();
                }
            catch (Exception) { short1TextBox.Text = "Error"; short1 = 0; }
            try
                {
                ushort1 = Convert.ToUInt16(input1TextBox.Text);
                ushort1TextBox.Text = ushort1.ToString();
                }
            catch (Exception) { ushort1TextBox.Text = "Error"; ushort1 = 0; }
            try
                {
                int1 = Convert.ToInt32(input1TextBox.Text);
                int1TextBox.Text = int1.ToString();
                }
            catch (Exception) { int1TextBox.Text = "Error"; int1 = 0; }
            try
                {
                uint1 = Convert.ToUInt32(input1TextBox.Text);
                uint1TextBox.Text = uint1.ToString();
                }
            catch (Exception) { uint1TextBox.Text = "Error"; uint1 = 0; }
            try
                {
                long1 = Convert.ToInt64(input1TextBox.Text);
                long1TextBox.Text = long1.ToString();
                }
            catch (Exception) { long1TextBox.Text = "Error"; long1 = 0; }
            try
                {
                ulong1 = Convert.ToUInt64(input1TextBox.Text);
                ulong1TextBox.Text = ulong1.ToString();
                }
            catch (Exception) { ulong1TextBox.Text = "Error"; ulong1 = 0; }
            try
                {
                float1 = Convert.ToSingle(input1TextBox.Text);
                float1TextBox.Text = float1.ToString();
                }
            catch (Exception) { float1TextBox.Text = "Error"; float1 = 0.0f; }
            try
                {
                double1 = Convert.ToDouble(input1TextBox.Text);
                double1TextBox.Text = double1.ToString();
                }
            catch (Exception) { double1TextBox.Text = "Error"; double1 = 0.0; }
            try
                {
                decimal1 = Convert.ToDecimal(input1TextBox.Text);
                decimal1TextBox.Text = decimal1.ToString();
                }
            catch (Exception) { decimal1TextBox.Text = "Error"; decimal1 = 0m; }
            }

        //Maximum column (column 2) updates during text change
        private void input2TextBox_TextChanged(object sender, EventArgs e)
            {
            try
                {
                byte2 = Convert.ToByte(input2TextBox.Text);
                byte2TextBox.Text = byte2.ToString();
                }
            catch (Exception) { byte2TextBox.Text = "Error"; byte2 = 0; }
            try
                {
                sbyte2 = Convert.ToSByte(input2TextBox.Text);
                sbyte2TextBox.Text = sbyte2.ToString();
                }
            catch (Exception) { sbyte2TextBox.Text = "Error"; sbyte2 = 0; }
            try
                {
                short2 = Convert.ToInt16(input2TextBox.Text);
                short2TextBox.Text = short2.ToString();
                }
            catch (Exception) { short2TextBox.Text = "Error"; short2 = 0; }
            try
                {
                ushort2 = Convert.ToUInt16(input2TextBox.Text);
                ushort2TextBox.Text = ushort2.ToString();
                }
            catch (Exception) { ushort2TextBox.Text = "Error"; ushort2 = 0; }
            try
                {
                int2 = Convert.ToInt32(input2TextBox.Text);
                int2TextBox.Text = int2.ToString();
                }
            catch (Exception) { int2TextBox.Text = "Error"; int2 = 0; }
            try
                {
                uint2 = Convert.ToUInt32(input2TextBox.Text);
                uint2TextBox.Text = uint2.ToString();
                }
            catch (Exception) { uint2TextBox.Text = "Error"; uint2 = 0; }
            try
                {
                long2 = Convert.ToInt64(input2TextBox.Text);
                long2TextBox.Text = long2.ToString();
                }
            catch (Exception) { long2TextBox.Text = "Error"; long2 = 0; }
            try
                {
                ulong2 = Convert.ToUInt64(input2TextBox.Text);
                ulong2TextBox.Text = ulong2.ToString();
                }
            catch (Exception) { ulong2TextBox.Text = "Error"; ulong2 = 0; }
            try
                {
                float2 = Convert.ToSingle(input2TextBox.Text);
                float2TextBox.Text = float2.ToString();
                }
            catch (Exception) { float2TextBox.Text = "Error"; float2 = 0; }
            try
                {
                double2 = Convert.ToDouble(input2TextBox.Text);
                double2TextBox.Text = double2.ToString();
                }
            catch (Exception) { double2TextBox.Text = "Error"; double2 = 0; }
            try
                {
                decimal2 = Convert.ToDecimal(input2TextBox.Text);
                decimal2TextBox.Text = decimal2.ToString();
                }
            catch (Exception) { decimal2TextBox.Text = "Error"; decimal2 = 0; }
            }

        //Add button (column 3)
        private void addBtn_Click(object sender, EventArgs e)
            {
            //byte
            try { 
            this.byte3 = Convert.ToByte(this.byte1 + this.byte2);
            //displaying variable in the text box
            byte3TextBox.Text = byte3.ToString();
                }
            catch (Exception) { byte3TextBox.Text = "Error"; byte1 = 0; }
            //sbyte
            try
                {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 + this.sbyte2);
                //displaying variable in the text box
                sbyte3TextBox.Text = sbyte3.ToString();
                }
            catch (Exception) { sbyte3TextBox.Text = "Error"; sbyte3 = 0; }
            //short
            try
                {
                this.short3 = Convert.ToInt16(this.short1 + this.short2);
                //displaying variable in the text box
                short3TextBox.Text = short3.ToString();
                }
            catch (Exception) { short3TextBox.Text = "Error"; short3 = 0; }
            //ushort
            try
                {
                this.ushort3 = Convert.ToUInt16(this.ushort1 + this.ushort2);
                //displaying variable in the text box
                ushort3TextBox.Text = ushort3.ToString();
                }
            catch (Exception) { ushort3TextBox.Text = "Error"; ushort3 = 0; }
            //int (int is the data type used for "+", so no conversion needed
            //int will not throw an exception, but just overflow
            try
                {
                this.int3 = checked(this.int1 + this.int2); //checked() tests for overflow
                //displaying variable in the text box
                int3TextBox.Text = int3.ToString();
                }
            catch (Exception) { int3TextBox.Text = "Error"; int3 = 0; }
            //uint
            try
                {
                this.uint3 = checked(this.uint1 + this.uint2); //checked() tests for overflow
                //displaying variable in the text box
                uint3TextBox.Text = uint3.ToString();
                }
            catch (Exception) { uint3TextBox.Text = "Error"; uint3 = 0; }
            //long
            try
                {
                this.long3 = checked(this.long1 + this.long2); //checked() tests for overflow
                //displaying variable in the text box
                long3TextBox.Text = long3.ToString();
                }
            catch (Exception) { long3TextBox.Text = "Error"; long3 = 0; }
            //ulong
            try
                {
                this.ulong3 = checked(this.ulong1 + this.ulong2); //checked() tests for overflow
                //displaying variable in the text box
                ulong3TextBox.Text = ulong3.ToString();
                }
            catch (Exception) { ulong3TextBox.Text = "Error"; ulong3 = 0; }
            //float
            try
                {
                this.float3 = checked(this.float1 + this.float2); //checked() tests for overflow
                //displaying variable in the text box
                float3TextBox.Text = float3.ToString();
                }
            catch (Exception) { float3TextBox.Text = "Error"; float3 = 0; }
            //double
            try
                {
                this.double3 = checked(this.double1 + this.double2); //checked() tests for overflow
                //displaying variable in the text box
                double3TextBox.Text = double3.ToString();
                }
            catch (Exception) { double3TextBox.Text = "Error"; double3 = 0; }
            //decimal
            try
                {
                this.decimal3 = checked(this.decimal1 + this.decimal2); //checked() tests for overflow
                //displaying variable in the text box
                decimal3TextBox.Text = decimal3.ToString();
                }
            catch (Exception) { decimal3TextBox.Text = "Error"; decimal3 = 0; }
            }

        //Subtract button (column 3)
        private void subtractBtn_Click(object sender, EventArgs e)
            {
            //byte
            try
                {
                this.byte3 = Convert.ToByte(this.byte1 - this.byte2);
                //displaying variable in the text box
                byte3TextBox.Text = byte3.ToString();
                }
            catch (Exception) { byte3TextBox.Text = "Error"; byte1 = 0; }
            //sbyte
            try
                {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 - this.sbyte2);
                //displaying variable in the text box
                sbyte3TextBox.Text = sbyte3.ToString();
                }
            catch (Exception) { sbyte3TextBox.Text = "Error"; sbyte3 = 0; }
            //short
            try
                {
                this.short3 = Convert.ToInt16(this.short1 - this.short2);
                //displaying variable in the text box
                short3TextBox.Text = short3.ToString();
                }
            catch (Exception) { short3TextBox.Text = "Error"; short3 = 0; }
            //ushort
            try
                {
                this.ushort3 = Convert.ToUInt16(this.ushort1 - this.ushort2);
                //displaying variable in the text box
                ushort3TextBox.Text = ushort3.ToString();
                }
            catch (Exception) { ushort3TextBox.Text = "Error"; ushort3 = 0; }
            //int (int is the data type used for "-", so no conversion needed
            //int will not throw an exception, but just overflow
            try
                {
                this.int3 = checked(this.int1 - this.int2); //checked() tests for overflow
                //displaying variable in the text box
                int3TextBox.Text = int3.ToString();
                }
            catch (Exception) { int3TextBox.Text = "Error"; int3 = 0; }
            //uint
            try
                {
                this.uint3 = checked(this.uint1 - this.uint2); //checked() tests for overflow
                //displaying variable in the text box
                uint3TextBox.Text = uint3.ToString();
                }
            catch (Exception) { uint3TextBox.Text = "Error"; uint3 = 0; }
            //long
            try
                {
                this.long3 = checked(this.long1 - this.long2); //checked() tests for overflow
                //displaying variable in the text box
                long3TextBox.Text = long3.ToString();
                }
            catch (Exception) { long3TextBox.Text = "Error"; long3 = 0; }
            //ulong
            try
                {
                this.ulong3 = checked(this.ulong1 - this.ulong2); //checked() tests for overflow
                //displaying variable in the text box
                ulong3TextBox.Text = ulong3.ToString();
                }
            catch (Exception) { ulong3TextBox.Text = "Error"; ulong3 = 0; }
            //float
            try
                {
                this.float3 = checked(this.float1 - this.float2); //checked() tests for overflow
                //displaying variable in the text box
                float3TextBox.Text = float3.ToString();
                }
            catch (Exception) { float3TextBox.Text = "Error"; float3 = 0; }
            //double
            try
                {
                this.double3 = checked(this.double1 - this.double2); //checked() tests for overflow
                //displaying variable in the text box
                double3TextBox.Text = double3.ToString();
                }
            catch (Exception) { double3TextBox.Text = "Error"; double3 = 0; }
            //decimal
            try
                {
                this.decimal3 = checked(this.decimal1 - this.decimal2); //checked() tests for overflow
                //displaying variable in the text box
                decimal3TextBox.Text = decimal3.ToString();
                }
            catch (Exception) { decimal3TextBox.Text = "Error"; decimal3 = 0; }
            }

        //Multiply button (column 3)
        private void multiplyBtn_Click(object sender, EventArgs e)
            {
            //byte
            try
                {
                this.byte3 = Convert.ToByte(this.byte1 * this.byte2);
                //displaying variable in the text box
                byte3TextBox.Text = byte3.ToString();
                }
            catch (Exception) { byte3TextBox.Text = "Error"; byte1 = 0; }
            //sbyte
            try
                {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 * this.sbyte2);
                //displaying variable in the text box
                sbyte3TextBox.Text = sbyte3.ToString();
                }
            catch (Exception) { sbyte3TextBox.Text = "Error"; sbyte3 = 0; }
            //short
            try
                {
                this.short3 = Convert.ToInt16(this.short1 * this.short2);
                //displaying variable in the text box
                short3TextBox.Text = short3.ToString();
                }
            catch (Exception) { short3TextBox.Text = "Error"; short3 = 0; }
            //ushort
            try
                {
                this.ushort3 = Convert.ToUInt16(this.ushort1 * this.ushort2);
                //displaying variable in the text box
                ushort3TextBox.Text = ushort3.ToString();
                }
            catch (Exception) { ushort3TextBox.Text = "Error"; ushort3 = 0; }
            //int (int is the data type used for "*", so no conversion needed
            //int will not throw an exception, but just overflow
            try
                {
                this.int3 = checked(this.int1 * this.int2); //checked() tests for overflow
                //displaying variable in the text box
                int3TextBox.Text = int3.ToString();
                }
            catch (Exception) { int3TextBox.Text = "Error"; int3 = 0; }
            //uint
            try
                {
                this.uint3 = checked(this.uint1 * this.uint2); //checked() tests for overflow
                //displaying variable in the text box
                uint3TextBox.Text = uint3.ToString();
                }
            catch (Exception) { uint3TextBox.Text = "Error"; uint3 = 0; }
            //long
            try
                {
                this.long3 = checked(this.long1 * this.long2); //checked() tests for overflow
                //displaying variable in the text box
                long3TextBox.Text = long3.ToString();
                }
            catch (Exception) { long3TextBox.Text = "Error"; long3 = 0; }
            //ulong
            try
                {
                this.ulong3 = checked(this.ulong1 * this.ulong2); //checked() tests for overflow
                //displaying variable in the text box
                ulong3TextBox.Text = ulong3.ToString();
                }
            catch (Exception) { ulong3TextBox.Text = "Error"; ulong3 = 0; }
            //float
            try
                {
                this.float3 = checked(this.float1 * this.float2); //checked() tests for overflow
                //displaying variable in the text box
                float3TextBox.Text = float3.ToString();
                }
            catch (Exception) { float3TextBox.Text = "Error"; float3 = 0; }
            //double
            try
                {
                this.double3 = checked(this.double1 * this.double2); //checked() tests for overflow
                //displaying variable in the text box
                double3TextBox.Text = double3.ToString();
                }
            catch (Exception) { double3TextBox.Text = "Error"; double3 = 0; }
            //decimal
            try
                {
                this.decimal3 = checked(this.decimal1 * this.decimal2); //checked() tests for overflow
                //displaying variable in the text box
                decimal3TextBox.Text = decimal3.ToString();
                }
            catch (Exception) { decimal3TextBox.Text = "Error"; decimal3 = 0; }
            }

        //Divide button (column 3)
        private void divideBtn_Click(object sender, EventArgs e)
            {
            //byte
            try
                {
                this.byte3 = Convert.ToByte(this.byte1 / this.byte2);
                //displaying variable in the text box
                byte3TextBox.Text = byte3.ToString();
                }
            catch (Exception) { byte3TextBox.Text = "Error"; byte1 = 0; }
            //sbyte
            try
                {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 / this.sbyte2);
                //displaying variable in the text box
                sbyte3TextBox.Text = sbyte3.ToString();
                }
            catch (Exception) { sbyte3TextBox.Text = "Error"; sbyte3 = 0; }
            //short
            try
                {
                this.short3 = Convert.ToInt16(this.short1 / this.short2);
                //displaying variable in the text box
                short3TextBox.Text = short3.ToString();
                }
            catch (Exception) { short3TextBox.Text = "Error"; short3 = 0; }
            //ushort
            try
                {
                this.ushort3 = Convert.ToUInt16(this.ushort1 / this.ushort2);
                //displaying variable in the text box
                ushort3TextBox.Text = ushort3.ToString();
                }
            catch (Exception) { ushort3TextBox.Text = "Error"; ushort3 = 0; }
            //int (int is the data type used for "/", so no conversion needed
            //int will not throw an exception, but just overflow
            try
                {
                this.int3 = checked(this.int1 / this.int2); //checked() tests for overflow
                //displaying variable in the text box
                int3TextBox.Text = int3.ToString();
                }
            catch (Exception) { int3TextBox.Text = "Error"; int3 = 0; }
            //uint
            try
                {
                this.uint3 = checked(this.uint1 / this.uint2); //checked() tests for overflow
                //displaying variable in the text box
                uint3TextBox.Text = uint3.ToString();
                }
            catch (Exception) { uint3TextBox.Text = "Error"; uint3 = 0; }
            //long
            try
                {
                this.long3 = checked(this.long1 / this.long2); //checked() tests for overflow
                //displaying variable in the text box
                long3TextBox.Text = long3.ToString();
                }
            catch (Exception) { long3TextBox.Text = "Error"; long3 = 0; }
            //ulong
            try
                {
                this.ulong3 = checked(this.ulong1 / this.ulong2); //checked() tests for overflow
                //displaying variable in the text box
                ulong3TextBox.Text = ulong3.ToString();
                }
            catch (Exception) { ulong3TextBox.Text = "Error"; ulong3 = 0; }
            //float
            try
                {
                this.float3 = checked(this.float1 / this.float2); //checked() tests for overflow
                //displaying variable in the text box
                float3TextBox.Text = float3.ToString();
                }
            catch (Exception) { float3TextBox.Text = "Error"; float3 = 0; }
            //double
            try
                {
                this.double3 = checked(this.double1 / this.double2); //checked() tests for overflow
                //displaying variable in the text box
                double3TextBox.Text = double3.ToString();
                }
            catch (Exception) { double3TextBox.Text = "Error"; double3 = 0; }
            //decimal
            try
                {
                this.decimal3 = checked(this.decimal1 / this.decimal2); //checked() tests for overflow
                //displaying variable in the text box
                decimal3TextBox.Text = decimal3.ToString();
                }
            catch (Exception) { decimal3TextBox.Text = "Error"; decimal3 = 0; }
            }
        }
    }