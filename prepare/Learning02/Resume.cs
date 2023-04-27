using System;

public class Resume
{
    public string _name;
    
    // Creates the member variable list _jobs
    // and initializes it
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

        // iterates through through each job in _jobs 
        // in the class of Job
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}