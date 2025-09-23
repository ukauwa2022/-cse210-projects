using System;
using System.Collections.Generic;

class Comment
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // in seconds
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (Comment c in comments)
        {
            Console.WriteLine($"- {c.CommenterName}: {c.CommentText}");
        }
        Console.WriteLine(); // blank line between videos
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create Video objects
        Video video1 = new Video("Travel Vlog in Paris", "Emily", 600);
        video1.AddComment(new Comment("John", "Amazing video! I loved the Eiffel Tower shots."));
        video1.AddComment(new Comment("Sarah", "Great editing, keep it up!"));
        video1.AddComment(new Comment("Mark", "This made me want to visit Paris someday."));

        Video video2 = new Video("Python Tutorial for Beginners", "Alex", 1200);
        video2.AddComment(new Comment("Tom", "Very clear explanation, thanks!"));
        video2.AddComment(new Comment("Anna", "Please make one for advanced topics."));
        video2.AddComment(new Comment("Chris", "Subscribed to your channel!"));
        video2.AddComment(new Comment("Jane", "This helped me with my homework."));

        Video video3 = new Video("Cooking Pasta at Home", "Sophia", 900);
        video3.AddComment(new Comment("David", "I tried this recipe, and it was delicious!"));
        video3.AddComment(new Comment("Laura", "You make cooking look so easy."));
        video3.AddComment(new Comment("Mike", "Can you do one with pizza next time?"));

        // Put videos into a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display all videos and their comments
        foreach (Video v in videos)
        {
            v.DisplayVideoInfo();
        }
    }
}
