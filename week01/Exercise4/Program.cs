using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numberList = new List<int>();

        int numberToAdd;

        // Get List of Numbers from user
        do
        {
            Console.Write("Enter number: ");
            numberToAdd = int.Parse(Console.ReadLine());

            if (numberToAdd != 0)
            {
                numberList.Add(numberToAdd);
            }
        } while (numberToAdd != 0);

        Console.WriteLine($"The sum is: {numberList.Sum()}");

        Console.WriteLine($"The average is: {numberList.Average()}");

        Console.WriteLine($"The largest number is: {numberList.Max()}");
    }
}