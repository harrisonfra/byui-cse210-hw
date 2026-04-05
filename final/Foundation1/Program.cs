using System;
class Program   
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "How to Pass Your C# Class";
        video1._author = "Brother Gibbons";
        video1._length = 900;

        Video video2 = new Video();
        video2._title = "Learn CSS in 20 Minutes";
        video2._author = "Brother Phillips";
        video2._length = 1200;

        Video video3 = new Video();
        video3._title = "Advanced Python Programming";
        video3._author = "Code Academy";
        video3._length = 720;

        video1._comments.Add(new Comment("Adam", "Great video!"));
        video1._comments.Add(new Comment("Noah", "I learned a lot!"));
        video1._comments.Add(new Comment("Joseph", "Can't wait to watch more!"));

        video2._comments.Add(new Comment("Sarah", "This was very helpful!"));
        video2._comments.Add(new Comment("Hagar", "Thanks for sharing!"));
        video2._comments.Add(new Comment("Keturah", "I have a question about the code."));

        video3._comments.Add(new Comment("Abraham", "Awesome tutorial!"));
        video3._comments.Add(new Comment("Isaac", "I wish I found this sooner!"));
        video3._comments.Add(new Comment("Jacob", "Can you make beginner videos?"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.CommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                comment.Display();
            }

            Console.WriteLine();
        }
    }
}