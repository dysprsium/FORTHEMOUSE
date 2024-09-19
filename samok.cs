/* using System;
namespace Samok
{
    class Samok
    {
        public static void Main(String[] args)
        {
            int num1, add, sub, multi, div, result;
            string opertr, choices;
            bool isValid;

            do
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter first value:");
                    isValid = int.TryParse(Console.ReadLine(), out num1);
                } while (isValid == false);

                do
                {
                    Console.Clear();
                    Console.WriteLine("Choose an operator (+, -, *, /)");
                    opertr = Console.ReadLine();
                    isValid = opertr == "+" || opertr == "-" || opertr == "*" || opertr == "/";
                }
                while (isValid == false);


                switch (opertr)
                {
                    case "+":                       
                            Console.Clear();
                            Console.WriteLine("How many times do you want it to be added?");
                            add = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= add; i++)
                        {
                            result = num1 + i;
                            Console.WriteLine($"{num1} + {i} = {result}");
                        }
                        break;

                    case "-":
                        Console.Clear();
                        Console.WriteLine("How many times do you want it to be subtracted?");
                        sub = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= sub; i++)
                        {
                            result = num1 - i;
                            Console.WriteLine($"{num1} - {i} = {result}");
                        }
                        break;

                    case "*":
                        Console.Clear();
                        Console.WriteLine("How many times do you want it to be multiplied?");
                        multi = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= multi; i++)
                        {
                            result = num1 * i;
                            Console.WriteLine($"{num1} * {i} = {result}");

                        }
                        break;
                    case "/":
                        Console.Clear();
                        Console.WriteLine("How many times do you want it to be divided?");
                        div = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= div; i++)
                        {
                            result = num1 / i;
                            Console.WriteLine($"{num1} / {i} = {result}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to calculate again? Y/N");
                choices = Console.ReadLine().ToUpper();
                Console.Clear();

            } while (choices == "Y");
    }
    }
} */
