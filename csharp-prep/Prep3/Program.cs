using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";
        do
        {
            string doGuess  = "yes";
            // generate the random number
            int magicNumber = new Random().Next(1, 100);

            int numOfGuesses = 0;
            do
            {
                Console.Write("What is the guess number? : ");
                string guessNum = Console.ReadLine();
                int guessNumber = int.Parse(guessNum);
                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Go lower");
                    numOfGuesses++;
                } else if (guessNumber < magicNumber)
                    {
                        Console.WriteLine("Go higher");
                        numOfGuesses++;
                    }
                        else if (guessNumber == magicNumber)
                        {
                            numOfGuesses++;
                            Console.WriteLine($"You guessed it right in {numOfGuesses} guessess.");
                            doGuess = "no";
                        }
            } while (doGuess == "yes");

            Console.Write("Would you like to play again? ");
            playAgain = Console.ReadLine();
        } while (playAgain == "yes");


    }
}