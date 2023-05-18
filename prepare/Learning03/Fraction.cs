using System;

public class Fraction

{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction (int first)
    {
        _top = first;
        _bottom = 1;
    }
    public Fraction (int first, int second)
    {
        _top = first;
        _bottom = second;
    }
    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }
        public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // Is will be recomputed each time this is called.
        return (double)_top / (double)_bottom;
    }
    // public int GetTop()
    // {
    //     return _top;
    // }
    // public int GetBottom()
    // {
    //     return_bottom;
    // }
    // public void SetTop(int top)
    // {
    //     _top = top;
    // }
    // public void SetBottom(int bottom)
    // {
    //     _bottom = bottom;
    // }
}

