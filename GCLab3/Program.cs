using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool help = true;
            do
            {
                Console.Write("Please enter a valid number: "); //Prompts user to enter a valid number

                int userInt = Validation(); //Checks for validation in seperate method

                Console.WriteLine("Number  Squared Cubed"); //Shows what each thing in table means
                Console.WriteLine("======  ======= ======");
                for (int i = 1; i <= userInt; i++) //calculates how many rows you would like
                {
                    for (int j = 1; j <= 1; j++) //calculates what is in the first column
                    {
                        int product = i * j;
                        Console.Write($"{product}\t");
                    }

                    for (int j = 1; j <= 1; j++)//calculates what the square is of the entered number
                    {
                        int product = i * i;
                        Console.Write($"{product}\t");
                    }

                    for (int j = 1; j <= 1; j++)//calculates what the cube is of the entered number
                    {
                        int product = i * i * i;
                        Console.Write($"{product}\t");
                    }
                    //this is the end of the row--columns are done
                    Console.WriteLine();
                }

                Console.WriteLine("Would you like to continue? (y/n) ");//Prompts user the continue

                bool success = true;
                while (success)
                {
                    string answer = Console.ReadLine();

                    if (answer == "y" || answer == "Y")
                    {
                        help = true;
                        success = false;
                    }
                    else if (answer == "n" || answer == "N")
                    {
                        Console.WriteLine("\nGoodbye!");
                        help = false;
                        success = true;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid answer! ");
                        Console.Write("Please enter (y/n) if you would like to continue: ");
                        success = true;
                    }
                }
            } while (help);
        }
        private static int Validation()//Checks validation to make sure it is an integer
        {
            while (true)
            {
                string input = Console.ReadLine();
                bool success = int.TryParse(input, out int userInt);

                if (success)
                {
                    return userInt;
                }
                else
                {
                    Console.WriteLine("Make sure to enter a valid integer! ");
                    Console.Write("Please enter a valid number: ");
                }
            }
        }

    }
}
