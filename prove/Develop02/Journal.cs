using System;
using System.IO; 

// creates a publicly accessible class called 'Journal'
public class Journal
{
    public string _journalOwner;
    public string fileName = "myFile.txt";

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
        foreach (Entry x in _allEntries)
        {
            Console.WriteLine($"{x._date}: {x._prompt} - {x._entry}");
        }
    }
    public void SaveJournal()
    {
        Console.WriteLine("What filename do you want to Save the journal as (best as txt)? ");
        fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName)) 
        {
            foreach (Entry x in _allEntries) 
            {
                outputFile.WriteLine($"{x._date}: {x._prompt} - {x._entry}");
            }
        }
            Console.WriteLine($"Journal Saved to {fileName}");
    }

    public void LoadJournal()
    {
        Console.WriteLine("What filename do you want to Load (best as txt)? ");
        string fileName = Console.ReadLine();
        string filePath = (@$"C:\Desktop\{fileName}");
        using (StreamReader reader = new StreamReader(fileName))
        // note that this function is not working properly. possibly not the correct file path?
        
        {
            string line;  
            // Read line by line  
            while ((line = reader.ReadLine()) != null)  
            {  
                Console.WriteLine(line);  
            }
            Console.WriteLine($"Opened file {fileName}");

        }
    }
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