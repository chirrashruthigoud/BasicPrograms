using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class username
    {
        public static void Displayusername()
        {
            Console.WriteLine("Enter your name");
            string username = Console.ReadLine();
            int val = username.Length;
            Console.WriteLine("The number character is" + val);

            if (username.Length > 3 && username.Length < 5)
            {
                Console.WriteLine("Hello" + username + ",How are you ");
                Console.WriteLine("Hello {0} , How are you", username);

            }
            else if(username.Length > 5)
            {
                Console.WriteLine("The name is not having minumum 3 char!!");

            }
        }
    }
}
