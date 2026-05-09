using System;
using System.Runtime.CompilerServices;

namespace Develop02
{
    public class Entries
    {
        public string PromptText;
        public string Response;
        public DateTime Date;

        public Entries(string prompt, string response, DateTime date)
        {
            PromptText = prompt;
            Response = response;
            Date = date;
        }
        public void Display()
        {
            Console.WriteLine($"{Date.ToShortDateString()} - {PromptText}");
            Console.WriteLine(Response);
            Console.WriteLine();
        }
    }
}