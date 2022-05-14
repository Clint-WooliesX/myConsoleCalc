using System;
using System.Text.RegularExpressions;
using System.Drawing;
using Console = Colorful.Console;
namespace ConsoleCalc
{
    class Program
    {
        public static String[] menuOptions = { "Quit", "Addition", "Subtraction", "Multiplication", "Division", "Power", "Square root" };

        static void Main()
        {
            Console.WriteAscii("C# Calculator", Color.Goldenrod);
            Console.WriteLine("Developed by Clint Kingston 2022", Color.Goldenrod);
            AnyKey();
            Menu(menuOptions);
        }

        static void Menu(string[] input)
        {
            Console.Clear();
            Console.WriteLine("C# Calculator", Color.GreenYellow);
            Console.WriteLine("-----------------", Color.GreenYellow);
            for (int i = 0; i <= input.Length - 1; i++)
            {
                Console.Write($"{i}. ", Color.Blue);
                  Console.WriteLine($"{input[i]}");
            }
            Console.WriteLine("-----------------", Color.GreenYellow);
            Console.Write("Enter selection > ");
            ConsoleKeyInfo name = Console.ReadKey();
            Char userInput = name.KeyChar;
    
                switch (userInput)
                {
                    case '0':
                        {
                            Console.WriteLine();
                            Console.WriteLine("Program terminated", Color.Red);
                            break;
                        }
                    case '1':
                        {
                        Addition();
                            break;
                        }
                    case '2':
                        {
                        Subtraction();
                            break;
                        }
                    case '3':
                        {
                        Multiplication();
                            break;
                        }
                    case '4':
                        {
                        Division();
                            break;
                        }
                case '5':
                    {
                        Power();
                        break;
                    }
                case '6':
                    {
                        Sqrt();
                        break;
                    }
                default:
                        {
                            Main();
                            break;
                        }
                }
        }

        static void AnyKey()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue... ");
            Console.ReadKey();
            Console.Clear();
        }

        static double GetNumber()
        {
            Console.Write("Enter a number > ");
            string input = Console.ReadLine();
            if (!Regex.IsMatch(input, @"[^0-9-]")) { 
                return Int32.Parse(input);
            }
            Console.Write("Invalid entry! Try Again > ", Color.Orange);
            return GetNumber();
        }

        static void Addition()
        {
            Console.Clear();
            Console.WriteLine("Addition:", Color.GreenYellow);
            double num1 = GetNumber();
            double num2 = GetNumber();
            Console.Clear();
            Console.WriteLine($"{num1} + {num2} = {Add(num1, num2)}", Color.Green);
            AnyKey();
            Menu(menuOptions);
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Subtraction:", Color.GreenYellow);
            double num1 = GetNumber();
            double num2 = GetNumber();
            Console.Clear();
            Console.WriteLine($"{num1} - {num2} = {Subtract(num1, num2)}", Color.Green);
            AnyKey();
            Menu(menuOptions);
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Multiply:", Color.GreenYellow);
            double num1 = GetNumber();
            double num2 = GetNumber();
            Console.Clear();
            Console.WriteLine($"{num1} * {num2} = {Multiply(num1, num2)}", Color.Green);
            AnyKey();
            Menu(menuOptions);
        }

        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Divide:", Color.GreenYellow);
            double num1 = GetNumber();
            double num2 = GetNumber();
            Console.Clear();
            Console.WriteLine($"{num1} / {num2} = {Divide(num1, num2)}", Color.Green);
            AnyKey();
            Menu(menuOptions);
        }

        static void Power()
        {
            Console.Clear();
            Console.WriteLine("power:", Color.GreenYellow);
            double num1 = GetNumber();
            Console.WriteLine("To the power of");
            double num2 = GetNumber();
            Console.Clear();
            Console.WriteLine($"{num1} ^ {num2} = {Math.Pow(num1,num2)}", Color.Green);
            AnyKey();
            Menu(menuOptions);
        }

        static void Sqrt()
        {
            Console.Clear();
            Console.WriteLine("Square root:", Color.GreenYellow);
            double num1 = GetNumber();
            Console.Clear();
            Console.WriteLine($"Square root of {num1} = {Math.Sqrt(num1)}", Color.Green);
            Console.WriteLine();
            AnyKey();
            Menu(menuOptions);
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


}

}
