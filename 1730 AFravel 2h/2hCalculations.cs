using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1730_AFravel_2h
{
    public class _2hCalculations
    {
        // 6
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch
            {

            }
            return result;
        }
        // 7
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch
            {

            }
            return result;
        }
        //8
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();
            return result;
        }
        //9
        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime currentDate;
            DateTime dueDate;
            try
            {
                currentDate = DateTime.Parse(strDateA);
                dueDate = DateTime.Parse(strDateB);
                TimeSpan timeTillDue = currentDate - dueDate;
                result = timeTillDue.TotalDays.ToString() + " days";
            }
            catch
            {

            }
            return result;
        }
        //10
        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime currentDate;
            DateTime dueDate;
            try
            {
                currentDate = DateTime.Parse(strDateA);
                dueDate = DateTime.Parse(strDateB);
                TimeSpan timeTillDue = currentDate - dueDate;
                if (currentDate > dueDate)
                {
                    result = timeTillDue.TotalDays.ToString() + " days past due";
                }   
                else
                {
                    result = "On time";
                }
            }
            catch
            {

            }
            return result;
        }
        // STRING METHODS
    }
}