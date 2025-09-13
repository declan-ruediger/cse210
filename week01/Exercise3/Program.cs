using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = new Random().Next(1, 100 + 1);

        int guess = 0;

        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        } while (guess != magicNumber);
    }
}