using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Common
{
    public static class DateTimeSettings
    {
        public static DateTime GetTheDay(DateTime time)
        {
            int Year = time.Year;

            int Month = time.Month;

            int Day = time.Day - 1;
            
            if(Day == 0)
            {
                Month -= 1;
                Day = DateTime.DaysInMonth(Year, Month);
            }

            DateTime dt = new DateTime(Year, Month, Day);

            return new DateTime(Year, Month, Day);
        }

        public static double GetTheDelayOfReturning(DateTime toDay, DateTime endTime)
        {
            TimeSpan Delay = toDay - endTime;

            return Delay.TotalDays;
        }

        //تاریخ شمسی
        public static string ToPersianDateString(this DateTime georgianDate)
        {
            System.Globalization.PersianCalendar persianCalendar = new System.Globalization.PersianCalendar();

            string year = persianCalendar.GetYear(georgianDate).ToString();
            string month = persianCalendar.GetMonth(georgianDate).ToString().PadLeft(2, '0');
            string day = persianCalendar.GetDayOfMonth(georgianDate).ToString().PadLeft(2, '0');
            string persianDateString = string.Format("{0}/{1}/{2}", year, month, day);
            return persianDateString;
        }

        //تاریخ میلادی
        public static DateTime ToGeorgianDateTime(string persianDate)
        {
            string YearInEnglish = persianDate.Substring(0, 4);
            int year = Convert.ToInt32(YearInEnglish);

            string MontInEnglish = persianDate.Substring(5, 2);
            int month = Convert.ToInt32(MontInEnglish);

            string DayInEnglish = persianDate.Substring(8, 2);
            int day = Convert.ToInt32(DayInEnglish);

            DateTime georgianDateTime = new DateTime(year, month, day, new System.Globalization.PersianCalendar());
            return georgianDateTime;
        }
    }
}
