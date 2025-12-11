using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Best Soccer Moments!", "ESPN", 500);
        video1.Comments.Add(new Comment("Nathan", "Messi is the GOAT!"));
        video1.Comments.Add(new Comment("Bryce", "Zlatan's goal is iconic!"));
        video1.Comments.Add(new Comment("Devin", "Soccer sucks."));
        videos.Add(video1);

        Video video2 = new Video("How to Paint!", "Bob Ross", 1000);
        video2.Comments.Add(new Comment("Dane", "Can you do this with a Crayola Kit?"));
        video2.Comments.Add(new Comment("Isabelle", "This is so cool!"));
        video2.Comments.Add(new Comment("Logan", "What kind of brush do you use?"));
        videos.Add(video2);

        Video video3 = new Video("Top Ten Most Dangerous Animals!", "National Geographic", 1500);
        video3.Comments.Add(new Comment("Mia", "Polar Bears are adorable!"));
        video3.Comments.Add(new Comment("Sally", "I am never visiting Australia!"));
        video3.Comments.Add(new Comment("Kevin", "I survived a Black Mamba bite."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
