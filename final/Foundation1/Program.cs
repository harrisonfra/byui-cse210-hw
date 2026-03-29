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

        Comment comment1 = new Comment();
        comment1._name = "Adam";
        comment1._comment = "Great video!";
        Comment comment2 = new Comment();
        comment2._name = "Noah";
        comment2._comment = "I learned a lot!";
        Comment comment3 = new Comment();
        comment3._name = "Joseph";
        comment3._comment = "Can't wait to watch more!";

        video1._comments.Add(comment1);
        video1._comments.Add(comment2);
        video1._comments.Add(comment3);

        Comment comment4 = new Comment();
        comment4._name = "Sarah";
        comment4._comment = "This was very helpful!";
        Comment comment5 = new Comment();
        comment5._name = "Hagar";
        comment5._comment = "Thanks for sharing!";
        Comment comment6 = new Comment();
        comment6._name = "Keturah";
        comment6._comment = "I have a question about the code.";

        video2._comments.Add(comment4);
        video2._comments.Add(comment5);
        video2._comments.Add(comment6);

        Comment comment7 = new Comment();
        comment7._name = "Abraham";
        comment7._comment = "Awesome tutorial!";
        Comment comment8 = new Comment();
        comment8._name = "Isaac";
        comment8._comment = "I wish I found this sooner!";
        Comment comment9 = new Comment();
        comment9._name = "Jacob";
        comment9._comment = "Can you make beginner videos?";

        video3._comments.Add(comment7);
        video3._comments.Add(comment8);
        video3._comments.Add(comment9);

        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.CommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._name}: {comment._comment}");
            }
        }
    }
}