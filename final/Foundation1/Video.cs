using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> Comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int CommentCount()
    {
        return Comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {CommentCount()}");
        Console.WriteLine();
        Console.WriteLine("Comments:");

        foreach (Comment comment in Comments)
        {
            comment.Display();
        }

        Console.WriteLine();
    }
}
