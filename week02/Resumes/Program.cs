using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Resume resume = new Resume();
        resume._name = "Allison Rose";

        resume._jobs.Add(new Job());
        resume._jobs[resume._jobs.Count - 1]._jobTitle = "Software Engineer";
        resume._jobs[resume._jobs.Count - 1]._company = "Microsoft";
        resume._jobs[resume._jobs.Count - 1]._startYear = 2019;
        resume._jobs[resume._jobs.Count - 1]._endYear = 2022;

        resume._jobs.Add(new Job());
        resume._jobs[resume._jobs.Count - 1]._jobTitle = "Manager";
        resume._jobs[resume._jobs.Count - 1]._company = "Apple";
        resume._jobs[resume._jobs.Count - 1]._startYear = 2022;
        resume._jobs[resume._jobs.Count - 1]._endYear = 2023;

        resume.Display();

    }
}