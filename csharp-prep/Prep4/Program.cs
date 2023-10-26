using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string userInput ="";
        List<int> myList;
        myList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            if (userInput != "0")
                {
                    int userInt = int.Parse(userInput);
                    myList.Add(userInt);
                }
        } while (userInput != "0");

        int listSum = myList.Sum();
        Console.WriteLine($"The sum of the list is {listSum}");

        double listAvg = myList.Average();
        Console.WriteLine($"The average of the list is {listAvg}");

        int listMax = myList.Max();
        Console.WriteLine($"The largest number in the list is {listMax}");

        int listMinAbvZero = myList.Where(f => f > 0).Min();
        Console.WriteLine($"The smallest positive number in the list is {listMinAbvZero}");

    }
}