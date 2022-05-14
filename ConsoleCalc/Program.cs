using System;
using System.Text.RegularExpressions;
namespace ConsoleCalc
{
    class Program
    {
        static void Main()
        {
            String[] menuOptions = { "Quit", "Addition", "Subtraction", "Multiplication", "Division", "Power","Square root" };
            Menu(menuOptions);
        }

        static void Menu(string[] input)
        {
            Console.WriteLine("C# Calculator");
            Console.WriteLine("-----------------");
            for (int i = 0; i <= input.Length - 1; i++)
            {
                Console.WriteLine($"{i}. {input[i]}");
            }
            Console.WriteLine("-----------------");
            Console.Write("Enter selection > ");
            ConsoleKeyInfo name = Console.ReadKey();
            Char userInput = name.KeyChar;
    
                switch (userInput)
                {
                    case '0':
                        {
                            Console.WriteLine();
                            Console.WriteLine("Program terminated");
                            break;
                        }
                    case '1':
                        {
                            Console.Clear();
                            Console.WriteLine("Addition:");
                            Console.Write("Enter a number > ");
                            double num1 = GetNumber();
                            Console.Write("Enter a number > ");
                            double num2 = GetNumber();
                            Console.Clear();
                            Console.WriteLine($"{num1} + {num2} = {Add(num1, num2)}");
                            Console.WriteLine();
                            AnyKey();
                            Main();
                            break;
                        }
                    case '2':
                        {
                            Console.Clear();
                            Console.WriteLine("Subtraction:");
                            Console.Write("Enter a number > ");
                            double num1 = GetNumber();
                            Console.Write("Enter a number > ");
                            double num2 = GetNumber();
                            Console.Clear();
                            Console.WriteLine($"{num1} - {num2} = {Subtract(num1, num2)}");
                            Console.WriteLine();
                            AnyKey();
                            Main();
                            break;
                        }
                    case '3':
                        {
                            Console.Clear();
                            Console.WriteLine("Multiply:");
                            Console.Write("Enter a number > ");
                            double num1 = GetNumber();
                            Console.Write("Enter a number > ");
                            double num2 = GetNumber();
                            Console.Clear();
                            Console.WriteLine($"{num1} * {num2} = {Multiply(num1, num2)}");
                            Console.WriteLine();
                            AnyKey();
                            Main();
                            break;
                        }
                    case '4':
                        {
                            Console.Clear();
                            Console.WriteLine("Divide:");
                            Console.Write("Enter a number > ");
                            double num1 = GetNumber();
                            Console.Write("Enter a number > ");
                            double num2 = GetNumber();
                            Console.Clear();
                            Console.WriteLine($"{num1} / {num2} = {Divide(num1, num2)}");
                            Console.WriteLine();
                            AnyKey();
                            Main();
                            break;
                        }
                    default:
                        {
                            Main();
                            break;
                        }
                }
            

        
        }
        static double GetNumber()
        {
            string input = Console.ReadLine();
            if (!Regex.IsMatch(input, @"[^0-9-]")) { 
                return Int32.Parse(input);
            }
            Console.Write("Invalid entry > ");
            return GetNumber();
        }

        static double Add(double num1, double num2)
            {
                return num1 + num2;
        }

        static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        static void AnyKey()
        {
            Console.Write("Press any key to continue... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
        }
}

}
