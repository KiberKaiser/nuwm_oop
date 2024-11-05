using System;

interface IMovingPoint
{
    void SetInitialPosition();
    void SetCoefficients();
    void DisplayCoefficients();
    double CalculatePosition(double t);
    void DisplayPosition(double t);
}

class MovingPoint1D : IMovingPoint
{
    protected double x0, a1;

    public void SetInitialPosition()
    {
        Console.WriteLine("Введіть початкове положення точки (x0): ");
        x0 = Convert.ToDouble(Console.ReadLine());
    }

    public void SetCoefficients()
    {
        Console.WriteLine("Введіть коефіцієнт a1: ");
        a1 = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayCoefficients()
    {
        Console.WriteLine($"Коефіцієнт a1: {a1}");
    }

    public double CalculatePosition(double t)
    {
        return x0 + a1 * Math.Sin(t);
    }

    public void DisplayPosition(double t)
    {
        double x = CalculatePosition(t);
        Console.WriteLine($"Координата точки на прямій при t = {t} сек.: x = {x}");
    }
}

class MovingPoint3D : IMovingPoint
{
    protected double x0, y0, z0, a1, a2, a3;

    public void SetInitialPosition()
    {
        Console.WriteLine("Введіть початкове положення точки (x0, y0, z0): ");
        x0 = Convert.ToDouble(Console.ReadLine());
        y0 = Convert.ToDouble(Console.ReadLine());
        z0 = Convert.ToDouble(Console.ReadLine());
    }

    public void SetCoefficients()
    {
        Console.WriteLine("Введіть коефіцієнти a1, a2, a3: ");
        a1 = Convert.ToDouble(Console.ReadLine());
        a2 = Convert.ToDouble(Console.ReadLine());
        a3 = Convert.ToDouble(Console.ReadLine());
    }

    public void DisplayCoefficients()
    {
        Console.WriteLine($"Коефіцієнти a1: {a1}, a2: {a2}, a3: {a3}");
    }

    public double CalculatePosition(double t)
    {
        return x0 + a1 * Math.Sin(t);  
    }

    public void DisplayPosition(double t)
    {
        CalculatePosition3D(t, out double x, out double y, out double z);
        Console.WriteLine($"Координати точки при t = {t} сек.: x = {x}, y = {y}, z = {z}");
    }

    public void CalculatePosition3D(double t, out double x, out double y, out double z)
    {
        x = x0 + a1 * Math.Sin(t);
        y = y0 + a2 * Math.Cos(t);
        z = z0 + a3 * t * t;
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Оберіть тип точки: 1 - Точка на прямій, 2 - Точка в просторі");
            Console.WriteLine("О - вихід з програми");

            if (!int.TryParse(Console.ReadLine(), out int choice) || (choice != 1 && choice != 2 && choice != 0))
            {
                Console.WriteLine("Невірне значення. Виберіть 1, 2 або 0 для виходу.");
                continue;
            }

            if (choice == 0)
            {
                Console.WriteLine("Вихід з програми.");
                break;
            }

            Console.WriteLine("Введіть момент часу t:");
            double t;
            while (!double.TryParse(Console.ReadLine(), out t))
            {
                Console.WriteLine("Невірне значення. Введіть числове значення для t:");
            }

            if (choice == 1)
            {
                IMovingPoint point = new MovingPoint1D();
                point.SetInitialPosition();
                point.SetCoefficients();
                point.DisplayCoefficients();
                point.DisplayPosition(t);
            }
            else if (choice == 2)
            {
                IMovingPoint point3D = new MovingPoint3D();
                point3D.SetInitialPosition();
                point3D.SetCoefficients();
                point3D.DisplayCoefficients();
                point3D.DisplayPosition(t);
            }
        }
    }
}