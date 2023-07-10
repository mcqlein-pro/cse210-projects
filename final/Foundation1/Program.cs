using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos and comments
        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment("User 1", "Comment 1");
        video1.AddComment("User 2", "Comment 2");

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.AddComment("User 3", "Comment 3");

        // Create a list of videos
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine("  " + comment._username + ": " + comment._text);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
