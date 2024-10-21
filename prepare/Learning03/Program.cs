using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1=new Fraction();
        Console.WriteLine(f1.GetNumbersFraction());
        Console.WriteLine(f1.GetDecimal());

        Fraction f2=new Fraction();
        Console.WriteLine(f2.GetNumbersFraction());
        Console.WriteLine(f2.GetDecimal());

        Fraction f3=new Fraction();
        Console.WriteLine(f3.GetNumbersFraction());
        Console.WriteLine(f3.GetDecimal());

        Fraction f4=new Fraction();
        Console.WriteLine(f4.GetNumbersFraction());
        Console.WriteLine(f4.GetDecimal());
    }
}