using System;
using System.ComponentModel;

namespace TheCalculator
{
    class Program
    {

        enum Menu
        {
            ADDITION = 1,
            SUBTRACTION,
            MULTIPLICATION,
            DIVISION,
            EXPONENTIATION,
            ROOT,
            EXIT = 0
        }

        static void Main(string[] args)
        {
            Console.Clear();

            bool choseExit = false;
            while (!choseExit)
            {
                Console.WriteLine("WELCOME TO THE C#LCULATOR\n");

                Console.WriteLine
                (
                    "[1] ADDITION\n" +
                    "[2] SUBTRACTION\n" +
                    "[3] MULTIPLICATION\n" +
                    "[4] DIVISION\n" +
                    "[5] EXPONENTIATION\n" +
                    "[6] ROOT\n" +
                    "[0] EXIT\n"
                );

                Console.WriteLine("TYPE THE OPÇÃO");

                Menu option = (Menu)int.Parse(Console.ReadLine());

                switch (option)
                {
                    case Menu.ADDITION:
                        Addition();
                        break;

                    case Menu.SUBTRACTION:
                        Subtraction();
                        break;

                    case Menu.MULTIPLICATION:
                        Multiplication();
                        break;

                    case Menu.DIVISION:
                        Division();
                        break;

                    case Menu.EXPONENTIATION:
                        Exponentiation();
                        break;

                    case Menu.ROOT:
                        Root();
                        break;

                    case Menu.EXIT:
                        choseExit = true;
                        break;
                }

                Console.WriteLine(option);
                Console.Clear();

            }
        }

        static void Addition()
        {

            Console.Clear();

            Console.WriteLine("WELCOME TO ADDITION\n");

            Console.Write("TYPE THE FIRST: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("TYPE THE SECOND: ");
            int b = int.Parse(Console.ReadLine());

            int result = a + b;

            Console.Write($"THE RESULT IS: {result}\n");

            Console.Write("TYPE ENTER TO RUN TO MENU...");

            Console.ReadLine();
        }

        static void Subtraction()
        {
            Console.Clear();

            Console.WriteLine("WELCOME TO SUBTRACTION\n");

            Console.Write("TYPE THE FIRST: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("TYPE THE SECOND: ");
            int b = int.Parse(Console.ReadLine());

            int result = a - b;

            Console.WriteLine($"THE RESULT IS: {result}\n");

            Console.Write("TYPE ENTER TO RUN TO MENU...");

            Console.ReadLine();
        }

        static void Multiplication()
        {
            Console.Clear();

            Console.WriteLine("WELCOME TO MULTIPLICATION\n");

            Console.Write("TYPE THE FIRST: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("TYPE THE SECOND: ");
            int b = int.Parse(Console.ReadLine());

            int result = a * b;

            Console.WriteLine($"THE RESULT IS: {result}\n");

            Console.Write("TYPE ENTER TO RUN TO MENU...");

            Console.ReadLine();
        }

        static void Division()
        {
            Console.Clear();

            Console.WriteLine("WELCOME TO DIVISION\n");

            Console.Write("TYPE THE FIRST: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("TYPE THE SECOND: ");
            int b = int.Parse(Console.ReadLine());

            float result = (float)a / (float)b;

            Console.WriteLine($"THE RESULT IS: {result}\n");

            Console.Write("TYPE ENTER TO RUN TO MENU...");

            Console.ReadLine();
        }

        static void Exponentiation()
        {
            Console.Clear();

            Console.WriteLine("WELCOME TO EXPONENTIATION\n");

            Console.Write("TYPE THE BASE: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("TYPE THE EXPONENTIATION: ");
            int b = int.Parse(Console.ReadLine());

            int result = (int)Math.Pow(a, b);

            Console.WriteLine($"THE RESULT IS: {result}\n");

            Console.Write("TYPE ENTER TO RUN TO MENU...");

            Console.ReadLine();
        }

        static void Root()
        {
            Console.Clear();

            Console.WriteLine("WELCOME TO ROOT\n");

            Console.Write("TYPE THE ROOT: ");
            int a = int.Parse(Console.ReadLine());

            double result = Math.Sqrt(a);

            Console.WriteLine($"THE RESULT IS: {result}\n");

            Console.Write("TYPE ENTER TO RUN TO MENU...");

            Console.ReadLine();
        }
    }
}
