using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // This is the default. Both the top and bottom number is 1.
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        // The top number is supplied as a whole number but the bottom is 1.
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        // Both the  top and bottom number are supplied.
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionAsStr()
    {
        string fractValue = $"{_top}/{_bottom}";
        return fractValue;
    }

    public double GetFractionAsDecimalVal()
    {
        return (double)_top / (double)_bottom;
    }
}