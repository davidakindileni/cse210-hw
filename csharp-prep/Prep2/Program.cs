using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        // declare letterGrade as a string variable
        string letterGrade;

        // request input of the grade percentage
        Console.Write("Please input your grade percentage: ");
        string grade = Console.ReadLine();

        // convert the input to an integer
        int intGrade = int.Parse(grade);

        // iterate to determine the letter grade
        if (intGrade >= 90)
        {
            letterGrade = "A";
        }   else if (intGrade >= 80)
            {
                letterGrade = "B";
            }   else if (intGrade >= 70)
                {
                    letterGrade = "C";
                }   else if (intGrade >= 60)
                    {
                        letterGrade = "D";
                    }
        else
        {
            letterGrade = "F";
        }

        // print the letter grade
        Console.WriteLine($"Your letter grade is {letterGrade}");

        // determine if the grade percentage passed or not and display appropriate message
        if (intGrade >= 70)
        {
            Console.WriteLine("Congratulations! You have passed!");
        }   else 
            {
                Console.WriteLine("Don't give up. Please try again. You've got this!");
            }
    }
}