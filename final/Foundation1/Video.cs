using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }
    private int CommentCount()
    {
        return comments.Count;
    }
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {CommentCount()}");
        Console.WriteLine();
        Console.WriteLine("Comments:");
        foreach (Comment comment in comments)
        {
            comment.Display();
        }
        Console.WriteLine();
    }
}
