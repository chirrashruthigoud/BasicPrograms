using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Leapyear
    {
        public static void LeapyearorNot()
        {
            Console.WriteLine("Enter the year : ");
            string num = Console.ReadLine();
            int leapYear = Convert.ToInt32(num);

            if (leapYear % 4 == 0 && leapYear % 100 != 0 || leapYear % 400 == 0)
            {
                Console.WriteLine("This Is LeapYear " + leapYear);
            }


            else
            {
                Console.WriteLine("This is not LeapYear" + leapYear);
            }
        }
    }
}
