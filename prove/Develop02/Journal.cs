using System;
using System.ComponentModel;
using System.IO;
using System.Text;

public class Jrnl
{
    public List<JrnlEntry> _jrnl = new List<JrnlEntry> ();
    private string userFileName;

    // public Jrnl()
    // {
    // }

    // display each journal entry
    public void Display()
    {
        if (_jrnl.Count==0)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.Write($"\n\tNo journal entries to display.\n");
            Console.ForegroundColor=ConsoleColor.White;
        }
        else
        {
            Console.WriteLine("\n\t===   Your Journal Entries   ===");
            foreach (JrnlEntry jrnlEntry in _jrnl)
            {
                jrnlEntry.Display();
            }
            Console.WriteLine("\n\t===      End of Entries      ===");
        }
    }

    public void SaveJrnlFile()
    {
        if (_jrnl.Count==0)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.Write($"\n\tNo journal entries to save.\n");
            Console.ForegroundColor=ConsoleColor.White;
        }
        else
        {
            Console.Write("\n\tEnter filename to save to: ");
            string userInput = Console.ReadLine();
            userFileName = userInput + ".txt";

            if (File.Exists(userFileName))
            {
                // Append journal entries
                using (StreamWriter outputFile = new StreamWriter(userFileName, append: true))
                {
                    foreach (JrnlEntry jrnlEntry in _jrnl)
                    {
                        outputFile.WriteLine($"{jrnlEntry._dateTime}; {jrnlEntry._jrnlPrompt}; {jrnlEntry._jrnlEntry}");
                    }
                }
                Console.Write($"\tJournal entries have been successfully added to the {userFileName}.\n");
                // reset journal file
                _jrnl.Clear();
            }
            else
            {
                Console.ForegroundColor=ConsoleColor.Red;
                Console.Write($"\t{userFileName} does not exist. Create the file and save the entries (y or n)? ");
                Console.ForegroundColor=ConsoleColor.White;
                string userResp = Console.ReadLine();

                if ((userResp == "y") || (userResp == "Y"))
                {
                    using (StreamWriter outputFile = new StreamWriter(userFileName))
                    {
                        foreach (JrnlEntry jrnlEntry in _jrnl)
                        {
                            outputFile.WriteLine($"{jrnlEntry._dateTime}; {jrnlEntry._jrnlPrompt}; {jrnlEntry._jrnlEntry}");
                        }
                    }

                    Console.Write($"\n\tCreated {userFileName} successfully.\n");
                    Console.Write("\tJournal entries recorded.\n");
                // reset journal file
                _jrnl.Clear();
                }
            }
        }
    }

    public void LoadJrnlFile()
    {
        Console.Write("\n\tEnter the filename to load: ");
        string userInput = Console.ReadLine();
        userFileName = userInput + ".txt";
        if (File.Exists(userFileName))
        {
            if (userFileName.Length > 0)
            {
                List<string> readText = File.ReadAllLines(userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
                foreach (string line in readText)
                {
                    string[] entries = line.Split("; ");
                    JrnlEntry entry = new JrnlEntry();

                    entry._dateTime = entries[0];
                    entry._jrnlPrompt = entries[1];
                    entry._jrnlEntry = entries[2];
                    _jrnl.Add(entry);
                }
                Console.Write($"\tJournal entries from {userFileName} have been successfully loaded.\n");
                // empty loaded file
                string sourceFile="blank.txt";
                File.Copy(sourceFile, userFileName, true);
            }
            else
            {
                Console.ForegroundColor=ConsoleColor.Red;
                Console.Write($"\n\t{userFileName} is empty. Please try again.\n");
                Console.ForegroundColor=ConsoleColor.White;
            }
        }
        else
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.Write($"\n\t{userFileName} does not exist. Please try again.\n");
            Console.ForegroundColor=ConsoleColor.White;
        }
    }

}