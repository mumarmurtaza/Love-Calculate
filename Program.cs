using System;

class LoveCalculator
{
    static int CalculateLoveScore(string name1, string name2)
    {
        int total = 0;
        string combinedNames = name1.ToLower() + name2.ToLower();
        
        foreach (char c in combinedNames)
        {
            total += (int)c;
        }
        
        return (total % 100) + 1; // Ensure score is between 1-100
    }
    
    static void Main()
    {
        Console.Write("Enter first name: ");
        string name1 = Console.ReadLine();
        
        Console.Write("Enter second name: ");
        string name2 = Console.ReadLine();
        
        int loveScore = CalculateLoveScore(name1, name2);
        
        Console.WriteLine($"Love percentage between {name1} and {name2} is {loveScore}%");
    }
}
