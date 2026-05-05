using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Security.AccessControl;

namespace Learning02;

public class Job
    {
        public string _company = "";
        public string _jobTitle = "";

        public int _startYear;
        public int _endYear;

        public void Display()
    {
        Console.WriteLine($"{_company}, {_jobTitle}");
        Console.WriteLine($"{_startYear}, {_endYear}");
    }
    
    }
