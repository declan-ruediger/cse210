using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int favouriteNumber = PromptUserNumber();
        DisplayResult(name, favouriteNumber);
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static void DisplayResult(string name, int favouriteNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {SquareNumber(favouriteNumber)}");
    }
    static int SquareNumber(int number)
    {
        return (int)Math.Pow(number, 2);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    
}