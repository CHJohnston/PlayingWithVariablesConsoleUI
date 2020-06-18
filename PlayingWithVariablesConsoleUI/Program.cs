using System;

namespace PlayingWithVariablesConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string thisClass = "True Coders Mark XII v1";
            int favNum = 23;
            char type = 'F';
            bool isMarried = true;
            double myHeight = 5.5;
            decimal myMoneyGoal = 163500.25m;

            Console.WriteLine("True Coders C# Variables Exercise");
            Console.WriteLine($"My class is {thisClass}. My favorite number is {favNum}");
            Console.WriteLine($"I am a {type}. My married status is {isMarried}. I am {myHeight} ft. tall.");
            Console.WriteLine($"I would like to earn ${myMoneyGoal}");
        }
    }
}
