using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Enter a list of numbers, type 0 when finished.
        //   Enter number: 18
        //   Enter number: 36
        //   Enter number: 2
        //   Enter number: 48
        //   Enter number: 6
        //   Enter number: 12
        //   Enter number: 9
        //   Enter number: 0 

        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string answer = Console.ReadLine();
            userNumber = int.Parse(answer);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // sum the numbers of the List
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // compute the average
        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average number is: {average}");
        // compute the largest number
        int largest = 0;

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");

    }
}