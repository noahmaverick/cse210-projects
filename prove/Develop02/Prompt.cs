using System;

namespace Develop02;

public class Prompt
{
    public Prompt(string prompt)
    {
        _promptNC = prompt;
    }
    public string _promptNC = "";
    // public string _interestingPersonNC = "";
    // public string _handInLifeNC = "";
    // public string _strongestEmotionNC = "";
    // public string _doOverNC = "";
    // public string _goalMetNC = "";
    // public string _shortComingNC = "";
    // public string _somethingNotableNC = "";
    // public string _favoriteNovelNC = "";
    // public string _datingLifeNC = "";
    // public string _familyMessageNC = "";
    

    public void Display()
    {
        Console.WriteLine(_promptNC);
    
        // Console.WriteLine($"{_datingLifeNC}");
    }
}


