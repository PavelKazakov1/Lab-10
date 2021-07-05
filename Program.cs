using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date();
            Date date2 = new Date("15.02.2021");
            Date date3 = new Date("01.01.2021");
            Console.WriteLine(date2.LeapYear);

            Console.WriteLine(date2.PreviosDay());

            Console.WriteLine(date2.NextDay());

             Console.WriteLine(date2.RestDays());

            Console.WriteLine("Input index:");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(i +" days from current date is " + date1[i]);

            Console.WriteLine(!date2);

            if (date2) Console.WriteLine("Its begining of the year");
            else Console.WriteLine("Its not begining of the year");

            if (date2 & date3) Console.WriteLine("The same dates");
            else Console.WriteLine("Different dates");
            
            Console.WriteLine((string)date1);
            Console.ReadKey();

        }
    }
}
