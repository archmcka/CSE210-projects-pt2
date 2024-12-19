using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1= new Address("2665 sagebrush ave", "iona","ID","83427");
        Address address2= new Address("1234 glock st", "Ammon","ID","99999");
        Address address3= new Address("674523","mckayla is awesome","ID","83427");

        var lecture = new Lecture
        (
            "how to code like a pro",
            "A deep dive into the world of coding",
            new DateTime(2024, 7, 15, 18, 30, 0),
            address1,
            "Dr. Gibbins",
            "50"
        );
        var reception = new Reception
        (
            " how to properly load and shoot a gun",
            " A deep dive into the world of firearms",
            new DateTime(2024, 7, 15, 18, 30, 0),
            address2,
            "rsvp@email.com"
        );

        var outdoorGathering = new OutdoorGathering
        (
            "how to live of the land",
            "A deep dive into camping and survival",
            new DateTime(2024, 7, 15, 18, 30, 0),
            address3,
            "sunny with a chance of rain"
        );

        Console.WriteLine("LECTURE EVENT");
        Console.WriteLine("-------------");
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortInfo());
        Console.WriteLine("\nFull Description:");
        Console.WriteLine(lecture.GetFullInfo());
        Console.WriteLine("\n");

        Console.WriteLine("RECEPTION EVENT");
        Console.WriteLine("---------------");
        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GetShortInfo());
        Console.WriteLine("\nFull Description:");
        Console.WriteLine(reception.GetFullInfo());
        Console.WriteLine("\n");

        Console.WriteLine("OUTDOOR EVENT");
        Console.WriteLine("-------------");
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorGathering.GetShortInfo());
        Console.WriteLine("\nFull Description:");
        Console.WriteLine(outdoorGathering.GetFullInfo());
    }
}