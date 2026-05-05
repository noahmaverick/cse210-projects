using System;
using Learning02;

class Program
{
    static void Main(string[] args)
    {
    Job job1 = new Job();
    job1._company = "Boeing";
    job1._jobTitle = "Electrical Engineer";
    job1._startYear = 1969;
    job1._endYear = 2026;
    job1.Display();
    Job job2 = new Job();
    job2._company = "Raytheon";
    job2._jobTitle = "Electrical Engineer";
    job2._startYear = 2029;
    job2._endYear = 2067;
    job2.Display();

    Resume myResume = new Resume();
    myResume._name = "Noah Cobb";

    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);

    myResume.Display();
    }
    
    

}