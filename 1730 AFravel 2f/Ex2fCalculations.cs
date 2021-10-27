using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1730_AFravel_2f
    {
    public class Ex2fCalculations
        {
        public static string Calc01(string input)
            {
            // #1: if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                {
                discountPercent = 0.2m;
                }
            return discountPercent.ToString("n2");
            }
        public static string Calc02(string input)
            {
            // #2 if {block}
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            string status = "Standard rate: ";
            if (subtotal >= 100m)
                {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
                }
            return status;
            }
        public static string Calc03(string input)
            {
            // #3 if else
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
            }
        public static string Calc04(string input)
            {
            //#4 if else if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100 && subtotal < 200)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
            }
        public static string Calc05(string input)
            {
            //#5 Better range test
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
            }
        public static string Calc06(string inputA, string inputB)
            {
            //#6 Nested if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(inputA);
            string customerType = inputB;
            if (customerType == "R")
                {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
                }
            else // customerType isn't R
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
            }
        public static string Calc07(string input)
            {
            //#7 Validate input: non-empty string
            decimal ethereum = 0m;
            if (input != "")
                {
                //decimal dollars = Decimal.Parse(input);
                ethereum = Decimal.Parse(input) * 200;
                return ethereum.ToString("n2");
                }
            return "Invalid input";
            }
        public static string Calc08(string inputA, string inputB)
            {
            // #8 Validate input, calculate quantity * price, shipping
            // Shipping = $5.00 for orders under $50.00
            decimal total = 0m;
            if (inputA != "" && inputB != "")
                {
                decimal price = 0m;
                decimal quantity = 0m;
                price = Decimal.Parse(inputA);
                quantity = Decimal.Parse(inputB);
                total = Decimal.Parse(inputA) * Decimal.Parse(inputB);
                if (total < 50)
                    {
                    total = total + 5;
                    return total.ToString("n2");
                    }
                else if (total >= 50)
                    {
                    return total.ToString("n2");
                    }
                }
                return "Invalid input";
            }
        public static string Calc09(string inputA, string inputB)
            {
            // #9 Validate input, calculate difference * rate
            // energy meter readings. inputA is beginning of month, inputB is end of month. 10 cents per kWh
            decimal difference = 0m;
            if (inputA != "" && inputB != "" && Decimal.Parse(inputB) >= Decimal.Parse(inputA))
                {
                decimal beginning = 0m;
                decimal end = 0m;
                decimal rate = 0.1m;
                beginning = Decimal.Parse(inputA);
                end = Decimal.Parse(inputB);
                difference = (Decimal.Parse(inputB) - Decimal.Parse(inputA)) * rate;
                return difference.ToString("n2");
                }
            return "Invalid input";
            }
        public static string Calc10(string inputA, string inputB)
            {
            // #10 Validate input, divide large num by small
            // both numbers must be > 0
            double result = 0.0;
            if (inputA != "" && inputB != "" && Double.Parse(inputA) > 0 && Double.Parse(inputB) > 0)
                {
                if (Double.Parse(inputA) >= Double.Parse(inputB))
                    {
                    result = Double.Parse(inputA) / Double.Parse(inputB);
                    return result.ToString("n2");
                    }
                else if (Double.Parse(inputA) <= Double.Parse(inputB))
                    {
                    result = Double.Parse(inputB) / Double.Parse(inputA);
                    return result.ToString("n2");
                    }
                }
            return "Invalid input";
            }
        }
    }
