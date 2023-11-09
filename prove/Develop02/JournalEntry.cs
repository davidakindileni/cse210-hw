    using System;

public class JrnlEntry
{
    public string _dateTime = "";
    public string _jrnlPrompt = "";
    public string _jrnlEntry = "";

    // public JrnlEntry()
    // {
    // }

    // displays entries
    public void Display()
    {
        Console.WriteLine($"\n\tDate: {_dateTime}");
        Console.WriteLine($"\tPrompt: {_jrnlPrompt}");
        Console.WriteLine($"\tEntry: {_jrnlEntry}");
    }
}