using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("c# basics","program enthusiast",300);
        video1.AddComment(new comment("great","would definitely recommend this to a friend"));
        video1.AddComment(new comment("hoemwork","great video to help with programming help"));
        video1.AddComment(new comment("voiceover","weird voiceover but good info"));

        Video video2 = new Video("loop fundamentals","mrlostandconfused",250);
        video2.AddComment(new comment("if else","next can you do if else statements"));
        video2.AddComment(new comment("more","i do appreciate the extra attention to detail in this video"));        
        video2.AddComment(new comment("question","i have a question about the loop video"));

        Video video3 = new Video("coding for dummies","HELPME",400);
        video3.AddComment(new comment("hard","coding looks too hard")); //
        video3.AddComment(new comment("change","i think i am going to change majors because of this video")); 
        video3.AddComment(new comment("coding","coding is interesting"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("\nComments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
        }        
    }
}