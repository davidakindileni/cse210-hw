using System;

public class Square : Shape
{
    // derived class for square shape

    // define member variables 
    private double _side = 0;
    private string _type = "Square";

    // define constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    public override string GetShapeType()
    {
        return _type;
    }

    // define functions
    public override double GetArea()
    {
        return _side * _side;
    }

}