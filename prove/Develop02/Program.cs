using System;

// Creates a publicly accessible class called 'Program'
public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        Console.Write("Welcome to the Journal program\n");

        string selection = "";
        int selectionNumber = 0;

        do
        {
            Console.Write("\nHere are your options:\n1 - Add a Journal Entry\n2 - Display the number of Journal Entries\n3 - Display all Journal Entries\n4 - Save Journal\n5 - Load Journal\n6 - Close Program\n\n");
    
            Console.WriteLine("Select the number of the choice that you'd like to make (1-6): ");
            selection = Console.ReadLine();
            selectionNumber = int.Parse(selection);
            
            if (selectionNumber == 1)
            {
            journal.AddEntry();
            Console.WriteLine("\nYour entry has been recorded.\nSelect again.");
            }
            if (selectionNumber == 2)
            {
            journal.CountEntries();
            }
            if (selectionNumber == 3)
            {
            journal.DisplayJournal();
            }
            if (selectionNumber == 4)
            {
                Console.WriteLine("\nYou chose #4.");
            }
            if (selectionNumber == 5)
            {
                Console.WriteLine("\nYou chose #5.");
            }
            if (selectionNumber == 5)
            {
                Console.Write("\nThank you for using this program. Goodbye.\n\n");
                break;
            }
        } while (selectionNumber != 6);
    }
}