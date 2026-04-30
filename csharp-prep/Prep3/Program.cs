using System;

class Program
{
    static void Main(string[] args)
    {
       /* Console.Write("What is the magic number of your choice, user? ");
        string mnumber = Console.ReadLine();

        int magnumber = int.Parse(mnumber); */
       
        Random randomGenerator = new Random();
        int magNumber = randomGenerator.Next(1,101);

        int gnumber = -1;
        while ( gnumber != magNumber)
        {
            Console.Write("guess, please: ");
            gnumber = int.Parse(Console.ReadLine());

            if (magNumber > gnumber)
            {
                Console.WriteLine("Try a Higher number");
            }
            else if (magNumber < gnumber)
            {
                Console.WriteLine("Try a lower number, user");
            }
            else
            {
                Console.WriteLine("You guessed the numnber, user!");
            }









        }
        
       
      /*  do 
        {
            if (guessnumber > magnumber)
            {
                    Console.Write("Lower, try again ");
                string gnumber = Console.ReadLine();

            }
            else if (guessnumber < magnumber)
            {
                    Console.Write("Higher, try again ");
                string gnumber = Console.ReadLine();    
            }
            else
            {
                Console.Write("You guessed it, user ");
            }


        } while (guessnumber != magnumber); */
          
           
    }   
}