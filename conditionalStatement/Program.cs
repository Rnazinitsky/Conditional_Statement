/* Author: Robert Nazinitsky
 * Class: ISM 4300
 * Date: 9/12/19
 * Description: Takes user input as an integer and displays the expected letter grade for the class.
 */
using System;

namespace conditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            try //attempt to run the program, break if error
            {
                Console.WriteLine("Please enter the grade you expect to get in ISM 4300: ");
                int grade = int.Parse(Console.ReadLine()); //gets user input as string and converts to int
                //check each possible grade between 0 and 100 and display the appropriate letter grade
                if (grade < 60 && grade > 0)
                {
                    Console.WriteLine("F");
                }
                else if (grade ==60 || grade == 61)
                {
                    Console.WriteLine("D-");
                }
                else if (grade >=62 && grade <= 67)
                {
                    Console.WriteLine("D");
                }
                else if (grade ==68 || grade == 69)
                {
                    Console.WriteLine("D+");
                }
                else if (grade == 70 || grade == 71)
                {
                    Console.WriteLine("C-");
                }
                else if (grade >= 72 && grade <= 77)
                {
                    Console.WriteLine("C");
                }
                else if (grade == 78 || grade == 79)
                {
                    Console.WriteLine("C+");
                }
                else if (grade == 80 || grade == 81)
                {
                    Console.WriteLine("B-");
                }
                else if (grade >= 82 && grade <= 87)
                {
                    Console.WriteLine("B");
                }
                else if (grade == 88 || grade == 89)
                {
                    Console.WriteLine("B+");
                }
                else if (grade == 90 || grade == 91)
                {
                    Console.WriteLine("A-");
                }
                else if (grade >= 92 && grade <= 97)
                {
                    Console.WriteLine("A");
                }
                else if (grade >= 98 && grade <= 100)
                {
                    Console.WriteLine("A+");
                }

            }
            catch //if an error occurs while running, display message
            {
                Console.WriteLine("There was an error trying to get your letter grade. Please enter a grade between 0 and 100.");
            }
            
        }
    }
}
