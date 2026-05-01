using System;
using System.ComponentModel.Design.Serialization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int ListNumber = -1;
        while (ListNumber != 0)
        {
            Console.Write("Please add your desired numbers to the list, type '0' when finished: ");
            string userwant = Console.ReadLine();
            ListNumber = int.Parse(userwant);
            
            if (ListNumber != 0)
            {
                numbers.Add(ListNumber);
            }
        }

        Console.WriteLine("Numbers list:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers [0];
        foreach (int number in numbers)
        {
            
        
        
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The highest number of the list is {max}");
    }
}