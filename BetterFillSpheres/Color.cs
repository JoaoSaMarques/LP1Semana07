public class Color
{
    //RGB + Alpha
    private int _red;
    private int _green;
    private int _blue;
    private int _alpha;

    //Red
    public int Red 
    {
        get { return _red; }
        set { _red = value; }
    }

    //Green
    public int Green 
    {
        get { return _green; }
        set { _green = value; }
    }

    //Blue
    public int Blue 
    {
        get { return _blue; }
        set { _blue = value; }
    }
    
    //Alpha
    public int Alpha 
    {
        get { return _alpha; }
        set { _alpha = value; }
    }

    //Color
    public Color(int red, int green, int blue, int alpha = 255)
    {
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;
    }

    //Grey
    public int GetGrey()
    {
        return (Red + Green + Blue) / 3;
    }
}