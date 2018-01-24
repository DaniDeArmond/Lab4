using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        public static long GetFactorial(int Base)
        {
            long Factorial = 1;
            for (int i = 1; i <= Base; i++)
            {
                Factorial *= i;
            }
            return Factorial;
        }
        public static long RecursiveFactorial(int Base)
        {
            long Factorial = 1;
            if (Base == 1)
            {
                return 1;
            }
            Factorial = Base * RecursiveFactorial(Base - 1);
            return Factorial;
        }

        static void Main(string[] args)
        {
            int UserInput; 
            long Answer;
            string DoAgain;
            bool Exit = false;

            Console.WriteLine("This program will calculate the factorial of a number.");

            while (Exit == false)
            {
                Console.WriteLine("Please enter a positive integer between 1 and 20." + Environment.NewLine);

                UserInput = int.Parse(Console.ReadLine());

                //Answer = GetFactorial(UserInput); //Uses For Loop
                Answer = RecursiveFactorial(UserInput); //Uses Recursion

                Console.WriteLine($"The factorial of {UserInput} is {Answer}.");

                Console.WriteLine("Would you like to calculate another factorial? (Y or N)");
                DoAgain = Console.ReadLine();

                if (DoAgain == "Y" || DoAgain == "y")
                {
                    Exit = false;
                }
                else if (DoAgain == "N" || DoAgain == "n")
                {
                    Console.WriteLine("Thanks for using the program. Goodbye!");
                    Exit = true;
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("You did not enter Y or N. Goodbye!");
                    Exit = true;
                    Console.Read();
                }
            }

        }
    }
}
