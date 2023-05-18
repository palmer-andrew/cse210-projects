using System;

// creates a publicly accessible class called 'Journal'
public class Journal
{
    public string _journalOwner;

    //This is assigning an attribute to the Journal class that it is a list of Entry instances, held as a variable in all entries, 
    // and also giving it a starting value of nothing (ie nothing is in that list) 
    public List<Entry> _allEntries = new List<Entry>();

    public void AddEntry()
    {
        Entry entry = new Entry();

        // obtains current date and time 
        DateTime theCurrentTime = DateTime.Now;
        // shortens date time
        string dateText = theCurrentTime.ToShortDateString();

        string prompt = GetPrompt();

        Console.WriteLine(prompt);
        string promptResponse = Console.ReadLine();

        entry.WriteEntry(dateText, prompt, promptResponse);

        Console.WriteLine($"\n{dateText}: {prompt}: {promptResponse}");

        _allEntries.Add(entry);
    }
    
    public void CountEntries()
    {
        if (_allEntries.Count == 1)
        {
        Console.WriteLine($"\nThere is {_allEntries.Count} entry in your journal.");
        }
        else
        {
        Console.WriteLine($"\nThere are {_allEntries.Count} entries in your journal.");   
        }
    }

    public void DisplayJournal()
    {
        // _allEntries.Display();
        
        foreach (var x in _allEntries)
        {
            Console.WriteLine(x);
        }
        
        
    }
    // public void SaveJournal()
    // {
    // }

    // public void LoadJournal()
    // {
    // // filename = Console.ReadLine()
    // }


    public string GetPrompt()
    {
        string[] prompts = new string[5];
        prompts[0] = "Who did you talk to today?";
        prompts[1] = "What scripture did you read today?";
        prompts[2] = "What spiritual promptings did you receive today?";
        prompts[3] = "What was the most inspiring thing you saw or heard today?";
        prompts[4] = "What are you hoping to happen tomorrow?";
        Random rnd = new Random();
        return prompts[rnd.Next(0,prompts.Length)];
    }
}