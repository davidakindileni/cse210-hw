using System;

public class Video
{
    // define member variables
    private string _author;
    private string _title;
    private int _length;
    List<Comment> _commentList;

    // define constructor
    public Video(string author, string title, int length, List<Comment> list)
    {
        this._author = author;
        this._title = title;
        this._length = length;
        this._commentList = list;
    }

    // define getters and setters
    public string GetAuthor()
    {
        return this._author;
    }
    public string GetTitle()
    {
        return this._title;
    }
    public int GetLength()
    {
        return this._length;
    }

    // define methods
    public void Display()
    {
        Console.WriteLine($"Video Title   : {this._title}\nAuthor        : {this._author}\nLength        : {this._length} seconds" +
        $"\nTotal comments: {this._commentList.Count}");
    }
    public void DisplayComments()
    {
        Console.WriteLine("***   Comments   ***");
        Console.WriteLine("--------------------");
        for (int i = 0; i < this._commentList.Count; i++)
        {
            Console.WriteLine(this._commentList[i].GetComment());
            if (i < this._commentList.Count - 1)
            {
                Console.WriteLine("    ........");
            }
        }
        Console.WriteLine("====================");
    }
}