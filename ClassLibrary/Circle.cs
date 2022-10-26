using System.Numerics;



namespace Labb2_library;

public class Circle : Shape2D
{
    private Vector3 _center;
    private float _radius;
    private float _circumference;
    private float _area;


    public override float Circumference { get { return _circumference; } }

    public override Vector3 Center { get { return _center; } }

    public override float Area { get { return _area; } }

    public Circle(Vector2 center, float radius)
    {
        _center = new Vector3(center, 0f);
        _radius = radius;
        _circumference = radius * 2 * MathF.PI;
        _area = MathF.PI * MathF.Pow(radius, 2.0F);
    }
    public override string ToString()
    {
        return $"Circle of the diensions: {_center} has a radius of: {_radius} a circumference of: {_circumference} an area of: {_area}";
    }

}


