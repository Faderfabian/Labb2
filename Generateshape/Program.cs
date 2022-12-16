using System.Numerics;

using Labb2_library;
 

static void Main(string[] args)
{
 
    Shape[] shapes = new Shape[20];
    for (int i = 0; i < shapes.Length; i++)
    {
        shapes[i] = GenerateShape();
    }

   
    foreach (Shape shape in shapes)
    {
        Console.WriteLine(shape);
    }

  
    float totalArea = 0;
    foreach (Shape shape in shapes)
    {
        totalArea += shape.Area;
    }
    float averageArea = totalArea / shapes.Length;

  
    Console.WriteLine("The average area of the shapes is: " + averageArea);
}

private static Shape GenerateShape()
{
   
    Random rnd = new Random();
    int shapeType = rnd.Next(1, 5);
    if (shapeType == 1)
    {
        
        Vector2 center = new Vector2(rnd.Next(-10, 11), rnd.Next(-10, 11));
        float radius = rnd.Next(1, 11);
        return new Circle(center, radius);
    }
    else
    {
        
        Vector2 center = new Vector2(rnd.Next(-10, 11), rnd.Next(-10, 11));
        Vector2 size = new Vector2(rnd.Next(1, 11), rnd.Next(1, 11));
        return new Rectangle(center, size);
    }
}