using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1730_AFravel_3b
{
    public class Ex3bCalculations
    {
        // 0) Calculate discountPercent
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent;
        }
        // 1) Calculate discountPercent using output argument
        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
        }
        // 2) Calculate futureValue
        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 1; i <= months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
        // 3) Calculate futureValue using ref argument
        public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            for (int i = 1; i <= months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
        }
        // 4) Calculate degrees Celsius
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double calculation = 0.0;
            calculation = (fahrenheit - 32) * 5.0 / 9.0;
            return calculation;
        }
        // 5) Calculate degrees Fahrenheit
        public static void CelsiusToFahrenheit(double celsius, out double fahrenheit)
        {
            fahrenheit = (celsius * 9/5) + 32;
        }
        // 6) Gross Pay
        public static decimal GrossPay(decimal hours, decimal rate)
        {
            decimal total = 0;
            if (hours <= 40)
            {
                total = hours * rate;
            }
            else
            {
                decimal standardPay = 0.0m;
                decimal overtimePay = 0.0m;
                decimal overtimeMultiplier = 1.5m;
                standardPay = (40 * rate);
                overtimePay = (hours - 40) * (rate * overtimeMultiplier);
                total = standardPay + overtimePay;
            }
            return total;
        }
        // 7) Total Hours
        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;
            int startIndex = 0;
            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = Decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }
            return total;
        }
        // 8) Gross Pay (string)
        public static decimal GrossPay(string strNumbers, decimal rate)
        {
            decimal totalHours = TotalHours(strNumbers);
            return GrossPay(totalHours, rate);
        }
    }
}

