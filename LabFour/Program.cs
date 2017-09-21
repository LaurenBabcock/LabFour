//Name: Lauren Babcock
//Date: September 19, 2017
//Program: Lab 4
//Purpose: Calculate the factorial of a number entered by the user.

using System;

namespace LabFour
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            

            Console.WriteLine("Welcome to the factorial calculator!");

            while (run == true)
            {
                long numberEntered;
                long factorial = 1;

                //Prompt the user to enter an integer between 1-20 (the factorial of 20 is the largest factorial that this program can calculate accurately)
                Console.Write("Enter an integer that is greater than 0 but less than 21: ");
                numberEntered = long.Parse(Console.ReadLine());

                if (numberEntered > 20)
                {
                    //IF the user enters an integer greater than 20, let them know this program can't calculate that
                    Console.WriteLine("Sorry, that factorial cannot be accurately calculated by this program.");
                }
                else if(numberEntered == 0){
                    //If the user enters 0, let them know that 0 does not have a factorial
                    Console.WriteLine("Sorry, the number 0 does not have a factorial.");
                }
                else
                {
                    //Calculate the factorial of the entered number & output the result to the console.
                    for (int i = 1; i <= numberEntered; i++)
                    {
                        factorial *= i;
                    }

                    Console.WriteLine("The factorial of " + numberEntered + " is " + factorial);
                }

                //Prompt the user to continue
                Console.WriteLine();
                run = Continue();
                Console.WriteLine();
            }
        }

        static bool Continue()
        {
            Console.Write("Would you like to continue (Y/N)? ");
            string input = Console.ReadLine().ToUpper();
            bool doAgain;
            if (input == "Y")
            {
                doAgain = true;
            }
            else if (input == "N")
            {
                doAgain = false;
            }
            else
            {
                Console.WriteLine("That is not a valid response. Please try again.");
                doAgain = Continue();
            }

            return doAgain;
        }
    }
}
