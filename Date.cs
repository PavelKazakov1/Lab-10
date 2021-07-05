using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    class Date
    {

        private DateTime date;


        public Date()
        {
            date = Convert.ToDateTime("1.1.2009");
            
        }

        public Date(string date)
        {
            this.date = DateTime.Parse(date);

        }

        public DateTime Date1 { get { return date; } set { date = value; } }
        public bool LeapYear { get  { return DateTime.IsLeapYear(date.Year); } }

        public DateTime PreviosDay() {
            return date.AddDays(-1);
        }

        public DateTime NextDay()
        {
            return date.AddDays(+1);
        }

        public int RestDays()
        {
            int count = 0;
            int month = DateTime.DaysInMonth(date.Year, date.Month);
            for (int i = date.Day; i < month; i++) {
                count++;
            }
            return count;
        }

        public DateTime this[int i]
        {
            get
            {
                 return date.AddDays(+i);
                
            }
        }

        static public bool operator !(Date date)
        {
            //date = Convert.ToDateTime(date);
            if (date.Date1.Day == DateTime.DaysInMonth(date.Date1.Year, date.Date1.Month)) { return false; }
            else return true;
        }

        static public bool operator true(Date date)
        {
            if (date.Date1.Month == 1) { return true; }
            else return false;
        }

        static public bool operator false(Date date)
        {
            if (date.Date1.Month == 1) { return false; }
            else return true;
        }

        static public bool operator &(Date date, Date date1)
        {
            if (date.Date1 == date1.Date1) { return true; }
            else { return false; }
        }

        static public explicit operator string(Date date)
        {
            return (" Day: " + date.Date1.Day + ", Month: " + date.Date1.Month + " Year: " + date.Date1.Year);
        }
    }
}
