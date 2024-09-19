/* using System;
namespace Forloop
{
    class Forloop
    {
        public static void main(string[] args)
        {
            int num1, num2;
            string oprtr;
            bool isValid;

            
        
            while (true);

            Console.WriteLine("Enter a number to multiply:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter how many times do you want to multiply");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (oprtr)
            {
                case "+":                    
                    for (int j = 1; j <= num2; j++)
                    {
                        int sum = num1 + j;
                        Console.WriteLine($"{num1} + {j} = {sum}");
                    }
                    break;

                case "-":
                    for (int j = 1; j >= num2; j--)
                    {
                        int sum = num1 - j;
                        Console.WriteLine($"{num1} - {j} {sum}");
                    }
            }
        }
    }
} */