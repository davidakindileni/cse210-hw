using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        // request input of the grade percentage
        Console.Write("Please input your grade percentage: ");
        string grade = Console.ReadLine();

        // convert the input to an integer
        int intGrade = int.Parse(grade);

        // iterate to determine the letter grade
        if (intGrade >= 90)
        {
            Console.WriteLine("Your letter grade is A");
        }   else if (intGrade >= 80)
            {
                Console.WriteLine("Your letter grade is B");
            }   else if (intGrade >= 70)
                {
                    Console.WriteLine("Your letter grade is C");
                }   else if (intGrade >= 60)
                    {
                        Console.WriteLine("Your letter grade is D");
                    }
        else
        {
            Console.WriteLine("Your letter grade is F");
        }

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