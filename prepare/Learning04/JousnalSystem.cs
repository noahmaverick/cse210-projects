using System;

namespace Learning04;

public class JousnalSystem
/* inputs we are prompting for: 1. The response to the prompt for program will generate,*/ 
{
    static void Main(string[] args)
    {
    Prompt prompt1 = new Prompt();
    prompt1._bestPartOfDayNC = "Welcome back user, please, tell me about the most interesting part of your day";
    prompt1._interestingPersonNC = "Welcome back user, please tell me who the most interesting person you interacted with today was";
    prompt1._handInLifeNC = "Welcome back user, please tell me how you have seen the hand of the Lord in your life today";
    prompt1._strongestEmotionNC = "Welcome back user, please tell me about the strongest empotion you expereinced today";
    prompt1._doOverNC = "Welocme back user, please tell me about one thing you would do over today if you could";
    prompt1._goalMetNC = "Welcome back user, please describe a goal you met today";
    prompt1._shortComingNC = "Welcome back user, please describe a shortcoming of yours today";
    prompt1._somethingNotableNC = "Welcome back user, please describe a notable thought you had today";
    prompt1._favoriteNovelNC = "Welcome back user, please describe something about your favorite novel or movie that's been on your mind lately";
    prompt1._datingLifeNC = "Welcome back user, please describe to me how your dating life has been thus far";
    prompt1._familyMessageNC = "Welcome back user, please describe to me a message you'd send to your family in these times";
    prompt1.Display();
    }



}
