




using System.Numerics;


namespace Labb2_library;

public class Cuboid : Shape3D
{
    private Vector3 _center;
    private float _volume;
    private float _area;
    private Vector3 _size;
    private bool _isSquare;


    public override float Volume { get { return _volume; } }

    public override Vector3 Center { get { return _center; } }

    public override float Area { get { return _area; } }

    public Vector3 Size { get { return _size; } }


        
    public bool isCube

    {
        get
        {

            if (_size.X == _size.Y == _size.Z)
                return true;
            else
                return false;
        }
        private set
        {
            isCube = value;
        }
    }

    public Cuboid(Vector3 center, Vector3 Size)
    {
        _center = new Vector3(center, 0f);
        _size = Size;
        _volume = 2 * (_size.X + _size.Y + _size.Z);
        _area = _size.X * _size.Y;


    }

    public Cuboid(Vector3 center, float width)
    {
        _size = new Vector3(width);
        _center = new Vector3(center, 0f);
    }
    public override string ToString()
    {
        return $"Rectangle @ {_center} has an area of: {_area} circumference of: {_volume}  {_size} is it a square? {_isSquare}";
    }
}

