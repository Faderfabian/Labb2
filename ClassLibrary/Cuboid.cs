
using System.Numerics;


namespace Labb2_library;

public class Cuboid : Shape3D
{
    private Vector3 _center;
    private float _volume;
    private float _area;
    private Vector3 _size;


    public override float Volume { get { return _volume; } }

    public override Vector3 Center { get { return _center; } }

    public override float Area { get { return _area; } }

    public Vector3 Size { get { return _size; } }


        
     public bool IsCube
        {
            get
            {
                return _size.X == _size.Y && _size.X == _size.Z;
            }
        }

    public Cuboid(Vector3 center, Vector3 Size)
    {
        _center = center;
        _size = Size;
        _area = 2 * (_size.X * _size.Y + _size.Z * _size.X + _size.Y * _size.Z);
        _volume = _size.X * _size.Y * _size.Z;


    }



    public Cuboid(Vector3 center, float width) : this(center, new Vector3(width, width, width))
    {
      
    }

    public override string ToString()
    {
        return $"{(IsCube ? "Cube" : "Cuboid")} @ ({_center.X}, {_center.Y}, {_center.Z})  w = {_size.X}, h = {_size.Y}, l = {_size.Z}";
    }
}
