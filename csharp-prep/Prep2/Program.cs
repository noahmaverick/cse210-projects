using System;

class Program
{
    static void Main(string[] args)
    {
    
        Console.Write("What is your score?: ");
        string score = Console.ReadLine();

        int scorefromuser = int.Parse(score);
        if (scorefromuser >= 90)
        {
            Console.WriteLine("you have received an A on this project");
            
        }
        else if (scorefromuser >= 80)
        {
            Console.WriteLine("You received a B on the project"); 
        }
        else if (scorefromuser >= 70)
        {
            Console.WriteLine ("you have received a C on this project");
        }
        else if (scorefromuser >= 60)
        {
            Console.WriteLine ("You have received a D on the project");
        }
        else
        {
            Console.WriteLine("You get an F on the project, chud. ");
        }
        Console.WriteLine("that is your grade");
        if (scorefromuser >= 70)
        {
            Console.WriteLine("You dun passed the class boi ");
        }
        else 
        {
            Console.WriteLine ("You have failed the class, boy ");
        }
    }
}