using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int userNumber =0;
        List<int> numbers = new List<int>();
    
        while (userNumber != 0)
        {
            Console.WriteLine("please add a number. 0 when done");
            userNumber= int.Parse(Console.ReadLine());
        
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int total=0;
        int max=0;
        foreach (int number in numbers)
        {
            total += number;
            if (number> max)
            {
                max = number;
            }
        }
        float average = total / numbers.Count;

        Console.WriteLine ("the total is ", total);
        Console.WriteLine ("the biggest number is", max);
        Console.WriteLine ("the aerage is ", average);
    }
}