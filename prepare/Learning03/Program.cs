using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fract1 = new Fraction();
        Console.WriteLine(fract1.GetFractionAsStr());
        Console.WriteLine(fract1.GetFractionAsDecimalVal());

        Fraction fract2 = new Fraction(2);
        Console.WriteLine(fract2.GetFractionAsStr());
        Console.WriteLine(fract2.GetFractionAsDecimalVal());

        Fraction fract3 = new Fraction(7, 11);
        Console.WriteLine(fract3.GetFractionAsStr());
        Console.WriteLine(fract3.GetFractionAsDecimalVal());

        Fraction fract4 = new Fraction(21, 56);
        Console.WriteLine(fract4.GetFractionAsStr());
        Console.WriteLine(fract4.GetFractionAsDecimalVal());
    }
}