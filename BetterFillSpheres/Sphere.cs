public class Sphere
{
    //Color + Radius + Times Thrown
    private Color _color;
    private float _radius;
    private int _timesThrown;

    //Color
    public Color Color 
    {
        get { return _color; }
        set { _color = value; }
    }

    //Radius
    public float Radius 
    {
        get { return _radius; }
        set { _radius = value; }
    }

    //Times Thrown
    public int TimesThrown 
    {
        get { return _timesThrown; }
    }

    //Define Sphere
    public Sphere(Color color, float radius)
    {
        Color = color;
        Radius = radius;
        _timesThrown = 0;
    }

    //Times thrown
    public void Throw()
    {
        _timesThrown++;
    }
}