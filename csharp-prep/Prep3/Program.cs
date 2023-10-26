using System;

class Program
{
    static void Main(string[] args)
    {
        string doGuess  = "yes";
            Console.Write("What is the magic number? : ");
            string magicNum = Console.ReadLine();
            int magicNumber = int.Parse(magicNum);
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