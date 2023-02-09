using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Poweroftwo
    {
        public static void CalaculateNumber()
        {
            int i;
            int number = 67;
            int N = 22;
            for (i = 0; i <= N; i++)
            {
                double pow = Math.Pow(number, i);
                Console.WriteLine("Calculated 2 power" + i + " : " + pow);
            }
        }
    }
}
