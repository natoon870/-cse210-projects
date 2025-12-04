using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

       
        Video video1 = new Video();
        video1._title = "Best Soccer Moments!";
        video1._author = "ESPN";
        video1._length = 500;
        video1.Comments.Add(new Comment("Nathan", "Messi is the GOAT!"));
        video1.Comments.Add(new Comment("Bryce", "Zlatan's goal is iconic!"));
        video1.Comments.Add(new Comment("Devin", "Soccer sucks."));
        videos.Add(video1);

     
        Video video2 = new Video();
        video2._title = "How to Paint!";
        video2._author = "Bob Ross";
        video2._length = 1000;
        video2.Comments.Add(new Comment("Dane", "Can you do this with a Crayola Kit?"));
        video2.Comments.Add(new Comment("Isabelle", "This is so cool!"));
        video2.Comments.Add(new Comment("Logan", "What kind of brush do you use?"));
        videos.Add(video2);

       
        Video video3 = new Video();
        video3._title = "Top Ten Most Dangerous Animals!";
        video3._author = "National Geographic";
        video3._length = 1500;
        video3.Comments.Add(new Comment("Mia", "Polar Bears are adorable!"));
        video3.Comments.Add(new Comment("Sally", "I am never visiting Australia!"));
        video3.Comments.Add(new Comment("Kevin", "I survived a Black Mamba bite."));
        videos.Add(video3);

      
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine();
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video1._length} seconds");
            Console.WriteLine($"Number of comments: {video.CommentCount()}");
            Console.WriteLine();
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}