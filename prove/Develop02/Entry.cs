using System;

// creates a public accessable class called 'Entry'
public class Entry
{
    // creates a public string named _prompt, which is empty
    public string _prompt = "";
    public string _entry = "";
    public string _date = "";
    
    // Creates a function called WriteEntry that returns nothing (void).
    // It accepts/requires three parameters, all strings: date, prompt, entry.
    public void WriteEntry(string date, string prompt, string entry)
    {
        // declaring that previously declared variables (ex: _prompt) are to be 
        // passed to the WriteEntry function to fulfill the parameter requirements.
        _prompt = prompt;
        _entry = entry;
        _date = date;
    }   

    // Creates a function called Display that writes a line to the terminal.
    // Returns nothing, so 'void'. Writes the three variables with colons in between.
    public void Display()
    {
        Console.WriteLine($"{_date}: {_prompt}: {_entry}");
    }
}