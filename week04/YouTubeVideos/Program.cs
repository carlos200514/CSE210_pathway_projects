using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("YouTubeVideos Project.");
        List<Video> videos = new List<Video>();
        Video video1 = new Video();
        video1.SetTitle("Learn C# in 10 Minutes");
        video1.SetAuthor("Code Academy");
        video1.SetLength(600);
        Comment c1 = new Comment();
        c1.SetName("Alice");
        c1.SetText("This was super helpful!");
        Comment c2 = new Comment();
        c2.SetName("Bob");
        c2.SetText("Great explanation, thank you!");
        Comment c3 = new Comment();
        c3.SetName("Charlie");
        c3.SetText("Now I understand classes better.");
        video1.AddComment(c1);
        video1.AddComment(c2);
        video1.AddComment(c3);
        videos.Add(video1);

        Video video2 = new Video();
        video2.SetTitle("Top 5 Programming Tips");
        video2.SetAuthor("Tech World");
        video2.SetLength(420);
        Comment c4 = new Comment();
        c4.SetName("Diana");
        c4.SetText("Tip #3 was amazing!");
        Comment c5 = new Comment();
        c5.SetName("Ethan");
        c5.SetText("I love these kinds of videos.");
        Comment c6 = new Comment();
        c6.SetName("Fiona");
        c6.SetText("Very useful advice.");
        video2.AddComment(c4);
        video2.AddComment(c5);
        video2.AddComment(c6);
        videos.Add(video2);

        Video video3 = new Video();
        video3.SetTitle("Object-Oriented Programming Explained");
        video3.SetAuthor("Programming Simplified");
        video3.SetLength(900);
        Comment c7 = new Comment();
        c7.SetName("George");
        c7.SetText("Finally makes sense!");
        Comment c8 = new Comment();
        c8.SetName("Hannah");
        c8.SetText("Perfect for beginners.");
        Comment c9 = new Comment();
        c9.SetName("Ian");
        c9.SetText("Very clear and simple.");
        video3.AddComment(c7);
        video3.AddComment(c8);
        video3.AddComment(c9);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("\nComments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }
            Console.WriteLine();
        }
    }
}