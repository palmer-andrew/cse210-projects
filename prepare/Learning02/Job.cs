using System;

// creates a public class 'Job'
public class Job
{
    // creates member variables
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Display function for this class.
    // Will operate when given code 'Display();'
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}