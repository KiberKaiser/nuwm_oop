using System;
using System.Collections.Generic;
using System.Text;
namespace lab3 
{
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

        ~Triangle()
        {
            Console.WriteLine("Трикутний був знищений.");
        }
        public double CalculateArea()
        {
            double a = Math.Sqrt(Math.Pow(VertexB.x - VertexA.x, 2) + Math.Pow(VertexB.y - VertexA.y, 2));
            double b = Math.Sqrt(Math.Pow(VertexC.x - VertexB.x, 2) + Math.Pow(VertexC.y - VertexB.y, 2));
            double c = Math.Sqrt(Math.Pow(VertexC.x - VertexA.x, 2) + Math.Pow(VertexC.y - VertexA.y, 2));

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine("Введіть кількість трикутників: ");
            int n = int.Parse(Console.ReadLine());
            Triangle[] triangles = new Triangle[n];
            
            double maxArea = 0;
            int maxIndex = 0;

            for (int i = 0; i < n; i++)
            {
                double area = triangles[i].CalculateArea();
                if (area > maxArea)
                {
                    maxArea = area;
                    maxIndex = i;
                }
            }

            Console.WriteLine($"Найбільша площа: {maxArea}, у трикутника {maxIndex + 1}");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.ReadKey();
        }
    }
}