using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);

        if (gradeNumber >= 90)
        {
            string gradeLetter = "A";
            Console.Write($"your grade is {gradeLetter}. You passed!");
        }
        
        else if (gradeNumber >= 80 && gradeNumber <90)
        {
            string gradeLetter = "B";
            Console.Write($"your grade is {gradeLetter}. You passed!");
        }
        else if (gradeNumber >= 70 && gradeNumber <80)
        {
            string gradeLetter = "C";
            Console.Write($"your grade is {gradeLetter}. You passed!");
        }
        else if (gradeNumber >= 60 && gradeNumber <70)
        {
            string gradeLetter = "D";
            Console.Write($"your grade is {gradeLetter}. You did not pass.");
        }
        else if (gradeNumber <60)
        {
            string gradeLetter = "F";
            Console.Write($"your grade is {gradeLetter}. You did not pass.");
        }
        

    }
}