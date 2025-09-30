// Showing Creativity and Exceeding Requirements: I added the functionality of choosing a random scripture from a library of scriptures, rather than the same scripture every time.

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> potentialScriptures = new List<Scripture>();

        Reference aScriptureReference;
        string aScripturetext;

        aScriptureReference = new Reference("Ether", 12, 27);
        aScripturetext = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
        potentialScriptures.Add(new Scripture(aScriptureReference, aScripturetext));

        aScriptureReference = new Reference("2 Nephi", 3, 1, 2);
        aScripturetext = "And now I speak unto you, Joseph, my last-born. Thou wast born in the wilderness of mine afflictions; yea, in the days of my greatest sorrow did thy mother bear thee. And may the Lord consecrate also unto thee this land, which is a most precious land, for thine inheritance and the inheritance of thy seed with thy brethren, for thy security forever, if it so be that ye shall keep the commandments of the Holy One of Israel.";
        potentialScriptures.Add(new Scripture(aScriptureReference, aScripturetext));

        int randomIndex = new Random().Next(0, potentialScriptures.Count);
        Scripture theScripture = potentialScriptures[randomIndex];

        bool shouldQuit = false;

        do
        {
            Console.Clear();

            Console.WriteLine(theScripture.GetDisplayText());
            Console.WriteLine();
            if (theScripture.IsCompletelyHidden())
            {
                shouldQuit = true;
            }
            else
            {
                Console.Write("Press enter to continue or type 'quit' to finish: ");
                if (Console.ReadLine() == "quit")
                {
                    shouldQuit = true;
                }

                theScripture.HideRandomWords(3);
            }
        } while (!shouldQuit);
    }
}