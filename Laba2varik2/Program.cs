using System;
using System.Text;
class Triangle
{
    private (double x, double y) VertexA;
    private (double x, double y) VertexB;
    private (double x, double y) VertexC;

    public Triangle((double x, double y) a, (double x, double y) b, (double x, double) c)
    {
        VertexA = a;
        VertexB = b;
        VertexC = c;
    }

    public double CalculateArea()
    {
        double a = Math.Sqrt(Math.Pow(VertexB.x - VertexA.x, 2) + Math.Pow(VertexB.y - VertexA.y, 2));
        double b = Math.Sqrt(Math.Pow(VertexC.x - VertexB.x, 2) + Math.Pow(VertexC.y - VertexB.y, 2));
        double c = Math.Sqrt(Math.Pow(VertexC.x - VertexA.x, 2) + Math.Pow(VertexC.y - VertexA.y, 2));

        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    public static Triangle InputParametrs()
    {
        Console.WriteLine("Введіть координати першої вершини (х1, y1)");
        var vertexA = InputVertex();
        Console.WriteLine("Введіть координати другої вершини (х2, y2)");
        var vertexB = InputVertex();
        Console.WriteLine("Введіть координати третьої вершини (х3, y3)");
        var vertexC = InputVertex();
        return new Triangle(vertexA, vertexB, vertexC);
    }
    private static (double, double)  InputVertex(){
        Console.WriteLine("X: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        return (x,y);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Triangle triangle = Triangle.InputParametrs();
        Console.WriteLine($"Площа трикутника: {triangle.CalculateArea()}");
    }
}