




using System.Numerics;


namespace Labb2_library;

public class Rectangle : Shape2D
{
    private Vector3 _center;
    private float _circumference;
    private float _area;
    private Vector2 _size;
    private bool _isSquare;


    public override float Circumference { get { return _circumference; } }

    public override Vector3 Center { get { return _center; } }

    public override float Area { get { return _area; } }

    public Vector2 Size { get { return _size; } }


    //if true annars false är det dags för här, sen overrida på något vänster?!
    public bool isSquare 

        {
        get
        {

            if (_size.X == _size.Y)
                return true;
            else
                return false;
        }
        private set
        {
            isSquare = value;
        }
    }
 
    public Rectangle(Vector2 center, Vector2 Size)
    {
        _center = new Vector3(center, 0f);
        _size = Size;
        _circumference = 2 * (_size.X + _size.Y);
        _area = _size.X * _size.Y;
      
        
    }

    public Rectangle (Vector2 center, float width)
    {
        _size = new Vector2(width);
        _center = new Vector3(center, 0f);
    }
    public override string ToString()
    {
        return $"Rectangle @ {_center} has an area of: {_area} circumference of: {_circumference}  {_size} is it a square? {_isSquare}";
    }
}
