using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = 101;

        do
        {
            Console.Write("What is the your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber )
            {
                Console.WriteLine("Lower");
            }
            else if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);
    }
}