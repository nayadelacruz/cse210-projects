using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade Score? ");
        string gradeScore = Console.ReadLine();
        int numberGrade = int.Parse(gradeScore);

        string letter = "";

        if (numberGrade >= 90)
        {
            letter = "A";
        }
        else if (numberGrade >= 80)
        {
            letter = "B";
        }
        else if (numberGrade >= 70)
        {
            letter = "C";
        }
        else if (numberGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }



        Console.WriteLine($"Your grade is: {letter}");

        if (numberGrade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}