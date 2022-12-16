




using System.Numerics;


namespace Labb2_library;

public class Sphere : Shape3D
{
    private Vector3 _center;
    private float _volume;
    private float _area;
    private float _radius;
    

  
    public override float Volume { get { return _volume; } }

    public override Vector3 Center { get { return _center; } }

    public override float Area { get { return _area; } }

   



 

    public Sphere(Vector3 center, float radius)
    {
        _center = center;
        _volume = (4f / 3f) * MathF.PI * MathF.Pow(radius, 3);
        _area = 4 * MathF.PI * MathF.Pow(radius, 2);
        _radius = radius;


    }
    public override string ToString()
    {
        return $"sphere @({_center.X}, {_center.Y}, {_center.Z}), r = {_radius}";

    }
}

