using System;

class Program
{
    static void Main(string[] args)
    {
        ExampleGenerator exampleGenerator = new ExampleGenerator([
            "rise",
            "patent",
            "accurate",
            "twilight",
            "north",
            "beer",
            "forget",
            "ivory",
            "physical",
            "senior",
            "therapist",
            "manner",
            "dismissal",
            "index",
            "interactive",
            "long",
            "pawn",
            "route",
            "astonishing",
            "certain",
            "perceive",
            "scrape",
            "consideration",
            "accumulation",
            "kitchen",
            "portrait",
            "indoor",
            "crutch",
            "candle",
            "proclaim",
            "maid",
            "economist",
            "decline",
            "heir",
            "as",
            "will",
            "decorative",
            "extent",
            "outer",
            "bundle",
            "weigh",
            "harsh",
            "ignite",
            "soar",
            "artist",
            "surround",
            "taxi",
            "retailer",
            "freight",
            "safari"
        ], 15, 700);

        List<Video> videos = new List<Video>();

        string randomTitle, randomAuthor, randomName, randomText;
        int randomDuration;
        Video randomVideo;

        int i, o;

        for (i = 0; i < 4; i++)
        {
            randomTitle = exampleGenerator.GetRandomWords(5);
            randomAuthor = exampleGenerator.GetRandomWords(2);
            randomDuration = exampleGenerator.GetRandomNumber();

            randomVideo = new Video(randomTitle, randomAuthor, randomDuration);

            for (o = 0; o < 4; o++)
            {
                randomName = exampleGenerator.GetRandomWords(2);
                randomText = exampleGenerator.GetRandomWords(30);

                randomVideo.AddComment(new Comment(randomName, randomText));
            }

            videos.Add(randomVideo);
        }

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine();
        }
        
    }
}