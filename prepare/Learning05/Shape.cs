using System;

public abstract class Shape
{
    // This is the base class for all the shapes

    // define member variables
    private string _color;

    // define getters and setters
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    // define functions
    public abstract double GetArea();

    public abstract string GetShapeType();

}