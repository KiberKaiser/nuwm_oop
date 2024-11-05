using System;
using System.Text;

class Vector
{
    protected int[] elements;

 
    public Vector()
    {
        elements = new int[4];
    }

    public void SetElements(int[] values)
    {
        if (values.Length != 4)
        {
            throw new ArgumentException("Вектор повинен містити рівно 4 елементи.");
        }
        for (int i = 0; i < 4; i++)
        {
            elements[i] = values[i];
        }
    }


    public void Display()
    {
        Console.WriteLine("Вектор:");
        foreach (int element in elements)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    public int FindMaxElement()
    {
        int max = elements[0];
        for (int i = 1; i < elements.Length; i++)
        {
            if (elements[i] > max)
            {
                max = elements[i];
            }
        }
        return max;
    }
}

class Matrix : Vector
{

    public Matrix()
    {
        elements = new int[16]; 
    }
    public void SetElements(int[,] values)
    {
        if (values.GetLength(0) != 4 || values.GetLength(1) != 4)
        {
            throw new ArgumentException("Матриця повинна бути розміром 4x4.");
        }

        int index = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                elements[index] = values[i, j];
                index++;
            }
        }
    }

    public void Display()
    {
        Console.WriteLine("Матриця 4x4:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(elements[i * 4 + j] + " "); 
            }
            Console.WriteLine();
        }
    }
    public int FindMaxElement()
    {
        int max = elements[0];
        for (int i = 1; i < elements.Length; i++)
        {
            if (elements[i] > max)
            {
                max = elements[i];
            }
        }
        return max;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Vector vector = new Vector();
        vector.SetElements(new int[] { 1, 3, 5, 2 });
        vector.Display();
        Console.WriteLine("Максимальний елемент вектора: " + vector.FindMaxElement());

        
        Matrix matrix = new Matrix();
        matrix.SetElements(new int[,] {
            { 1, 5, 9, 13 },
            { 3, 7, 11, 15 },
            { 2, 6, 10, 14 },
            { 4, 8, 12, 16 }
        });
        matrix.Display();
        Console.WriteLine("Максимальний елемент матриці: " + matrix.FindMaxElement());
    }
}