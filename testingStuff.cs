using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newARSrepo
{
    class testingStuff
    {
        public static void Main(string[] args)
        {
            string resp, command;

            Console.WriteLine("Create a username? Y/N: ");
            resp = Console.ReadLine();
            command = resp.ToUpper();

            if (command == "Y")
            {
                Console.WriteLine("Enter a name you want to be included: ");
                Number(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("ok bye:P");
            }

        }

        static void Number(string name)
        {
           
            Random rand = new Random();
            int numRange = rand.Next(10, 9999);

            Console.WriteLine("Hello, " + name + numRange);

        }
    }
}
