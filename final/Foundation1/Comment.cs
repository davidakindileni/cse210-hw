using System;

public class Comment
{
    // define member variables
    private string _name;
    private string _text;

    // define constructor
    public Comment(string name, string text)
    {
        this._name = name;
        this._text = text;
    }

    // define getters and setters
    public string GetComment()
    {
        return $"{this._name}:\n    {this._text}";
    }
}