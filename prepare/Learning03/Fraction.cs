using System.ComponentModel.DataAnnotations;

public class Fraction
{
    private int _Top = 0;
    private int _Bottom = 0; 

public Fraction()
    {
        _Top = 1;
        _Bottom = 1;
        
    }
public Fraction(int top)
    {
        _Top = top;
        _Bottom = 1;
    }
public Fraction(int top, int bottom)
    {
        _Top = top;
        _Bottom = bottom;
    }

    public int GetTop()
    {
        return _Top;
    }
    public void SetTop(int top)
    {
        _Top = top;
    }
    public int GetBottom()
    {
        return _Bottom;
    }
    public void SetBottom(int bottom)
    {
        _Bottom = bottom;
    }
public string GetFractionString()
    {
        return $"{_Top}/{_Bottom}";
    }
public string GetFractionDecimal()
    {
        return ((double)_Top / (double)_Bottom).ToString();
    }
}