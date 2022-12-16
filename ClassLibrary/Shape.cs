using System.Numerics;

namespace Labb2_library;

public abstract class Shape
{
    public abstract Vector3 Center { get; }
    public abstract float Area { get; }

    public static Shape GenerateShape() 
    {
        int RandomNumber = Random.Shared.Next(6);
        Shape RandomShape = null;
        switch(RandomNumber)
        {
            case 0: RandomShape = new Circle(new Vector2((float)Random.Shared.Next(-10, 10), (float)Random.Shared.Next(-10, 10)), (float)Random.Shared.Next(1, 10)); break;
            case 1: RandomShape = new Rectangle(new Vector2((float)Random.Shared.Next(-10, 10), (float)Random.Shared.Next(-10, 10)), (float)Random.Shared.Next(1, 10)); break;
            case 2: RandomShape = new Rectangle(new Vector2((float)Random.Shared.Next(-10, 10), (float)Random.Shared.Next(-10, 10)), new Vector2((float)Random.Shared.Next(1, 10), (float)Random.Shared.Next(1, 10))); break;
            case 3: RandomShape = new Cuboid(new Vector3((float)Random.Shared.Next(-10, 10), (float)Random.Shared.Next(-10, 10), (float)Random.Shared.Next(-10, 10)), (float)Random.Shared.Next(1, 10)); break;
            case 4: RandomShape = new Cuboid(new Vector3((float)Random.Shared.Next(-10, 10), (float)Random.Shared.Next(-10, 10), (float)Random.Shared.Next(-10, 10)), new Vector3((float)Random.Shared.Next(-10, 10), (float)Random.Shared.Next(-10, 10), (float)Random.Shared.Next(-10, 10))); break;
            case 5: RandomShape = new Sphere(new Vector3((float)Random.Shared.Next(-10, 10), (float)Random.Shared.Next(-10, 10), (float)Random.Shared.Next(-10, 10)), (float)Random.Shared.Next(1, 10)); break;
        }

        return RandomShape;
    }
}


