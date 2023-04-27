using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates a new instance of Job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2010;
        job1._endYear = 2012;

        // Writes the company name only
        // Console.WriteLine(job1._company);

        // Displays entire instance of this Job:
        // job1.Display();

        // Creates a new instance of Job
        Job job2 = new Job();
        job2._jobTitle = "Graphic Artist";
        job2._company = "Microsoft Designs";
        job2._startYear = 2012;
        job2._endYear = 2015;

        // Writes the company name only
        // Console.WriteLine(job2._company);

        // Displays entire instance of this Job:
        // job2.Display();
    
        // Creates an instance of a resume, 
        // attaches a name to it, and adds 
        // the two jobs from previous
        Resume resume1 = new Resume();
        resume1._name = "John Doe";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Displays the resume by calling it.
        resume1.Display();






    }
}