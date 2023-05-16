using System;

class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction( int WholeNumber )
    {
        _numerator = WholeNumber;
        _denominator = 1;
    }
    public Fraction( int Numerator, int Denominator )
    {
        _numerator = Numerator;
        _denominator = Denominator;
    }
    public string GetFractionString()
    {
        return _numerator + "/" + _denominator;
    }
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}