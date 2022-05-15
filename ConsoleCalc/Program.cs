using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;
namespace ConsoleCalc
{
    class Program
    {
        public static String[] menuOptions = { "Quit", "Addition", "Subtraction", "Multiplication", "Division", "Power", "Square root" };
        public static int menuSelection = 0;
        static void Main()
        {
            Console.WriteAscii("C# Calculator", Color.Goldenrod);  
            Console.WriteAscii("Developed by ", Color.DarkBlue);
            Console.WriteAscii("Clint Kingston 2022", Color.DarkBlue);
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
                if (i == menuSelection)
                {
                    Console.BackgroundColor = Color.White;
                    Console.ForegroundColor = Color.Black;
                }
                Console.Write($"{i}. ", Color.Blue);
                  Console.WriteLine($"{input[i]}");
                Console.ResetColor();
            }
            Console.WriteLine("-----------------", Color.GreenYellow);
            Console.Write("Up/Down and Enter to Select", Color.Blue);
            Console.CursorVisible = false;
            ConsoleKeyInfo name = Console.ReadKey();
            if (name.Key == ConsoleKey.DownArrow)
            {
                menuSelection+= 1;
                if (menuSelection > menuOptions.Length - 1) menuSelection = 0;
                Menu(menuOptions);
            }
            if (name.Key == ConsoleKey.UpArrow)
            {
                menuSelection -= 1;
                if (menuSelection < 0 ) menuSelection = menuOptions.Length - 1;
                Menu(menuOptions);
            }
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
            Console.Write("Press any key to continue... ",Color.Purple);
            Console.ReadKey();
            Console.Clear();
        }

        static double GetNumber()
        {
            Console.Write("Enter a number > ");
            string input = Console.ReadLine();
                    try
                    {
                        return Int32.Parse(input);
                    }
                    catch
                    {
                Console.WriteLine("Invalid entry!", Color.Red);
                return GetNumber();
            }

        }

        static double[] NumberArray()
        {

            bool moreData = true;
            var numbers = new List<double>();
            while (moreData == true)
            {
                Console.Write("Input a number or press enter > ");
                string num = Console.ReadLine();
                if (num.Length > 0)
                {
                    try
                    {
                        numbers.Add(Int32.Parse(num));
                    }
                    catch
                    {
                        Console.WriteLine("invalid number!", Color.Red);
                    }
                }
                else moreData = false;
            }
            double[] numberArray = numbers.ToArray();
            return numberArray;
        }

        static void Addition()
        {
            Console.Clear();
            Console.WriteLine("Addition:", Color.GreenYellow);
            double[] numbers = NumberArray();            
            Console.Clear();
            Console.WriteLine($"{String.Join(" + ", numbers)} = {Add(numbers)}", Color.Green);
            AnyKey();
            Menu(menuOptions);
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Subtraction:", Color.GreenYellow);
            double[] numbers = NumberArray();
            Console.Clear();
            Console.WriteLine($"{String.Join(" - ", numbers)} = {Subtract(numbers)}", Color.Green);
            AnyKey();
            Menu(menuOptions);
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("Multiply:", Color.GreenYellow);
            double[] numbers = NumberArray();
            Console.Clear();
            Console.WriteLine($"{String.Join(" * ", numbers)} = {Multiply(numbers)}", Color.Green);
            AnyKey();
            Menu(menuOptions);
        }

        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Divide:", Color.GreenYellow);
            double[] numbers = NumberArray();
            Console.Clear();
            Console.WriteLine($"{String.Join(" / ", numbers)} = {Divide(numbers)}", Color.Green);
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



        static double Add(double[] numbers)
        {
            double total=0;
            foreach (var value in numbers)
            {
                total += value;
            }
            return total;
        }

        static double Subtract(double[] numbers)
        {
            double total = numbers[0];
            for (int i = 1; i <= numbers.Length - 1; i++)
            {
                total -= numbers[i];
            }
            return total;
        }

        static double Multiply(double[] numbers)
        {
            double total = numbers[0];
            for(int i = 1;i<=numbers.Length-1;i++)
            {
                total = total * numbers[i];
            }
            return total;
        }

        static double Divide(double[] numbers)
        {
            double total = numbers[0];
            for (int i = 1; i <= numbers.Length - 1; i++)
            {
                total = total / numbers[i];
            }
            return total;
        }

    }

}
