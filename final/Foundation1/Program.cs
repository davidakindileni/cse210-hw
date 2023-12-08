using System;

class Program
{
    static void InitializeProgram(List<Video> videoList)
    {
        Comment comment1; Comment comment2; Comment comment3;
        Video video; List<Comment> commentList;

        comment1 = new Comment("Deb Hopkins", "Thanks for this. I made it for my husband and he loved it!.");
        comment2 = new Comment("Susy Harper", "Yuk! Sorry, nothing 'wow'-ish about this receipe.");
        comment3 = new Comment("Garfield Gibbons", "Hmmm. Not too bad.");
        commentList = new List<Comment> { comment1, comment2, comment3 };
        video = new Video("Omelette fit for a King!",
        "How to make a healthy delicious omelette", 1200, commentList);
        videoList.Add(video);

        comment1 = new Comment("Susan Hanson", "Beautiful instructions, thank you so much!");
        comment2 = new Comment("Gary Harper", "My wife and I have started trying these ...");
        comment3 = new Comment("Vickie Edgar", "Dance has many genres. This is just one of them.");
        commentList = new List<Comment> { comment1, comment2, comment3 };
        video = new Video("So you think you can't dance?",
        "Guiding you through the rudiments of dancing", 3600, commentList);
        videoList.Add(video);

        comment1 = new Comment("Loretta Crocket", "Now my 8-year old goes to bed late every night...'Mum, in a minute. I need to finish writing this'. Thanks.");
        comment2 = new Comment("Justin May", "This is so simple to understand and develop interest in.");
        comment3 = new Comment("Carlton Moncur", "I appreciate the video, but I think the program idea presented would be better if it was done in a simpler programming language.");
        commentList = new List<Comment> { comment1, comment2, comment3 };
        video = new Video("You ain't too young to write programs",
        "A video teaching young kids to write computer programs for fun and learning", 480, commentList);
        videoList.Add(video);
    }
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video> { };
        InitializeProgram(videoList);
        Console.WriteLine();
        foreach (Video video in videoList)
        {
            video.Display();
            Console.WriteLine();
            video.DisplayComments();
            Console.WriteLine();
        }
    }
}