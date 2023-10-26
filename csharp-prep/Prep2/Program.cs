using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input your grade percentage: ");
        string grade = Console.ReadLine();
        int intGrade = int.Parse(grade);

        if (intGrade >= 90)
        {
            Console.WriteLine($"Your letter grade is A");
        }   else if (intGrade >= 80)
            {
                Console.WriteLine($"Your letter grade is B");
            }   else if (intGrade >= 70)
                {
                    Console.WriteLine($"Your letter grade is C");
                }   else if (intGrade >= 60)
                    {
                        Console.WriteLine($"Your letter grade is D");
                    }
        else
        {
            Console.WriteLine($"Your letter grade is F");
        }

        
    }
}