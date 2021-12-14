using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1730_AFravel_3c
{
    public class Ex3cCalculations
    {
        // Calc 0
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            if (index > 0 == index < 8)
            {
                for (int i = 0; i < days.Length;)
                {
                    return days[index - 1];
                }
            }
            else
            {
                return "Invalid index";
            }
            return "Invalid index";
        }
        // Calc 1
        public static string Calc1(string search)
        {
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            search = search.Trim().ToUpper();
            int index = Array.IndexOf(days, search);
            if (index >= 0)
            {
                return hours[index];
            }
            else
            {
                return "Invalid input";
            }
        }
        // Calc 2
        public static int Calc2(int[] numbers)
        {
            int sum = 0;
            foreach (int ok in numbers)
            {
                sum += ok;
            }
            return sum;
        }
        // Calc 3
        public static double Calc3(double[] numbers,  int count)
        {
            double sum = 0.0;
            if (numbers.GetLength(0) > 1)
            {
                for (int i = 0; i < count; i++)
                {
                    sum += numbers[i];
                }
                return sum;
            }
            else
            {
                return 0.0;
            }
        }
        // Calc 5
        public static double Calc5(double[] numbers)
        {
            if (numbers.GetLength(0) > 0)
            {
                int count = Int32.Parse(numbers.GetLength(0).ToString());
                double sum = Ex3cCalculations.Calc3(numbers, count);
                double average = sum / count;
                return average;
            }
            return 0.0;
        }
        //Calc 6
        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);
                foreach (int number in numbers)
                {
                    if (number >= avg)
                    {
                        aboveAvgList.Add(number);
                    }
                }
            }
            return aboveAvgList.ToArray();
        }
    }
}
