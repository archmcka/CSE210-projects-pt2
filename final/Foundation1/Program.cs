using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)

    {
        Video video1 = new Video(300,"c# basics","program enthusiast");
        video1.AddComment(new Comment("great","would definitely recommend this to a friend"));
        video1.AddComment(new Comment("hoemwork","great video to help with programming help"));
        video1.AddComment(new Comment("voiceover","weird voiceover but good info"));

        Video video2 = new Video(250,"loop fundamentals","mrlostandconfused");
        video2.AddComment(new Comment("if else","next can you do if else statements"));
        video2.AddComment(new Comment("more","i do appreciate the extra attention to detail in this video"));        
        video2.AddComment(new Comment("question","i have a question about the loop video"));

        Video video3 = new Video(400,"coding for dummies","HELPME");
        video3.AddComment(new Comment("hard","coding looks too hard")); //
        video3.AddComment(new Comment("change","i think i am going to change majors because of this video")); 
        video3.AddComment(new Comment("coding","coding is interesting"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("\nComments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetAuthor()}: {comment.GetText()}");
            }
        }        
    }
}