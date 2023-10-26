using System;

class Program
{
    static void Main(string[] args)
    {
        string doGuess  = "yes";
        // generate the random number
        int magicNumber = new Random().Next(1, 100);

        do
        {
            Console.Write("What is the guess number? : ");
            string guessNum = Console.ReadLine();
            int guessNumber = int.Parse(guessNum);
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Go lower");
            } else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Go higher");
                }
                    else if (guessNumber == magicNumber)
                    {
                        Console.WriteLine("You guess it right!");
                        doGuess = "no";
                    }
        } while (doGuess == "yes");

    }
}