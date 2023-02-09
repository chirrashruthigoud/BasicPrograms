using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Harmonic
    {
        public static void Harmonicnumber()
        {
            Console.WriteLine("Enter a value for N");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("value must be greater than 0");
                return;
            }
            double sum = 0.0;
            for (int i = 1; i < N; i++)
            {
                sum += 1.0 / i;
            }
            Console.WriteLine("The " +N+ "th harmonic number is: " + sum);
              
        }
    }
}
