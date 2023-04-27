public class Color
{
    private int _red;
    private int _green;
    private int _blue;
    private int _alpha;

    public int Red 
    {
        get { return _red; }
        set { _red = value; }
    }

    public int Green 
    {
        get { return _green; }
        set { _green = value; }
    }

    public int Blue 
    {
        get { return _blue; }
        set { _blue = value; }
    }

    public int Alpha 
    {
        get { return _alpha; }
        set { _alpha = value; }
    }

    public Color(int red, int green, int blue, int alpha = 255)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    public int GetGrey()
    {
        return (Red + Green + Blue) / 3;
    }
}