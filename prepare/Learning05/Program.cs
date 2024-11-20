using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("pleace pick which shape you want to know more about ");
        // Console.WriteLine("1. square  2. rectangle  3. circle");
        // string userinput = Console.ReadLine();
        // switch (userinput)
        // {
        //     case "1":   
        //         Square 
        // }
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("blue",4);
        Shape.Add(s1); 

        Rectangle r1 = new Rectangle("green", 3,4);
        Shape.Add(s2);

        Circle c1 = new Circle("yellow",4);
        Shape.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

        }

    }
}