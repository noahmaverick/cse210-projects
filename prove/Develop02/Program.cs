using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using Develop02;

namespace Develop02
{
    


/* inputs we are prompting for: 1. The response to the prompt for program will generate,*/
class Program
{
    private string fileName = "journal.txt";
    public List<Entries> entries = new List<Entries>();

    static void Main(string[] args)
    {
        List<Prompt> prompts = new List<Prompt>();
        Prompt _bestPartOfDayNC = new Prompt("Welcome back user, please, tell me about the most interesting part of your day");
        Prompt _interestingPersonNC = new Prompt("Welcome back user, please tell me who the most interesting person you interacted with today was");
        Prompt _handInLifeNC = new Prompt("Welcome back user, please tell me how you have seen the hand of the Lord in your life today");
        Prompt _strongestEmotionNC = new Prompt("Welcome back user, please tell me about the strongest empotion you expereinced today");
        Prompt _doOverNC = new Prompt("Welocme back user, please tell me about one thing you would do over today if you could");
        Prompt _goalMetNC = new Prompt("Welcome back user, please describe a goal you met today");
        Prompt _shortComingNC = new Prompt("Welcome back user, please describe a shortcoming of yours today");
        Prompt _somethingNotableNC = new Prompt("Welcome back user, please describe a notable thought you had today");
        Prompt _favoriteNovelNC = new Prompt("Welcome back user, please describe something about your favorite novel or movie that's been on your mind lately");
        Prompt _datingLifeNC = new Prompt("Welcome back user, please describe to me how your dating life has been thus far");
        Prompt _familyMessageNC = new Prompt("Welcome back user, please describe to me a message you'd send to your family in these times");
        prompts.Add(_bestPartOfDayNC);
        prompts.Add(_interestingPersonNC);
        prompts.Add(_handInLifeNC);
        prompts.Add(_strongestEmotionNC);
        prompts.Add(_doOverNC);
        prompts.Add(_goalMetNC);
        prompts.Add(_shortComingNC);
        prompts.Add(_somethingNotableNC);
        prompts.Add(_favoriteNovelNC);
        prompts.Add(_datingLifeNC);
        prompts.Add(_familyMessageNC);
        Program p = new Program();
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nHere is the Menu from Noah Cobb's Journla");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save entries");
            Console.WriteLine("4. Load entries");
            Console.WriteLine("5. Quit");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    p.WriteEntry(prompts);
                    break;
                case "2":
                    p.DisplayEntries();
                    break;
                case "3":
                    p.SaveEntries();
                    break;
                case"4":
                    p.LoadEntries();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                Console.WriteLine ("Invalid choiice, user.  Try agian.");
                break;
            }
        }
        p.DisplayPrompt(prompts);

    }
    public string DisplayPrompt(List<Prompt> list)
    {
        Random random = new Random();
        int num = random.Next(0,9);

        Console.WriteLine(list[num]);

        list[num].Display();
        return "";
    }
    public void WriteEntry(List<Prompt> prompts)
    {
        Random random = new Random();
        int index = random.Next(0, prompts.Count);

        prompts[index].Display();

        Console.Write("> ");
        string response = Console.ReadLine();

        Entries newEntries = new Entries(prompts[index]._promptNC, response, DateTime.Now);
        entries.Add(newEntries); 

        Console.WriteLine("Entry recorded.");

    }
    public void SaveEntries()
    {
        using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Entries e in entries)
                {
                    writer.WriteLine("Entry");
                    writer.WriteLine(e.Date);
                    writer.WriteLine(e.PromptText);
                    writer.WriteLine(e.Response);
                }
            }
            Console.WriteLine("Entreis saved.");
        }
    public void LoadEntries()
    {
      if (!File.Exists(fileName))
        {
            Console.WriteLine("No saved journal present.");
            return;      
        }      
        entries.Clear();

        string[] lines = File.ReadAllLines(fileName);
        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i] == "Entry")
            {
                DateTime date = DateTime.Parse(lines[i + 1]);
                string prompt = lines[i + 2];
                string response = lines[i + 3];
                Entries loadedEntry = new Entries(prompt, response, date);
                entries.Add(loadedEntry);
                Console.WriteLine("Entries loaded.");
            }        
        }
    }   
    public void DisplayEntries()
    {
        foreach (Entries e in entries)
            {
                e.Display();
            }
    }
     
    
       
    }
}


