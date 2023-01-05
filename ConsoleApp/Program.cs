
using System.Numerics;

using Labb2_library;




float totalArea = 0;

for (int i = 0; i < 20; i++)
{
    Shape shape = Shape.GenerateShape();
    totalArea += shape.Area;
    Console.WriteLine(shape);
}
Console.WriteLine();
Console.WriteLine("Average area of all shapes are: " + (totalArea / 20));

