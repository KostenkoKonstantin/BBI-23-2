using System;

public struct Rectangle
{
    private double Width { get; set; }
    private double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Area()
    {
        return Width * Height;
    }

    public double Perimeter()
    {
        return 2 * (Width + Height);
    }

   
    public static void Compare(Rectangle r1, Rectangle r2)
    {
        Console.WriteLine("Сравнение прямоугольников:");
        Console.WriteLine("---------------------");

        Console.WriteLine("Прямоугольник 1: {0}x{1}", r1.Width, r1.Height);
        Console.WriteLine("Прямоугольник 2: {0}x{1}", r2.Width, r2.Height);
        

        Console.WriteLine("\nРезультаты сравнения:");
        Console.WriteLine("---------------------");

        if (r1.Width > r2.Width)
            Console.WriteLine("Самый длинный : {0} (Прямоугольник {1})", r1.Width,"1");
        if (r1.Width < r2.Width)
            Console.WriteLine("Самый длинный : {0} (Прямоугольник {1})", r2.Width,"2");
        else
            Console.WriteLine("Длинны равны");


        if (r1.Height > r2.Height)
            Console.WriteLine("Самый широкий : {0} (Прямоугольник {1})", r1.Height, "1");
        if (r1.Height < r2.Height)
            Console.WriteLine("Самый широкий : {0} (Прямоугольник {1})", r2.Height, "2");
        else
            Console.WriteLine("Ширина равна");

        if (r1.Area() > r2.Area())
            Console.WriteLine("Самый большой по площади : {0} (Прямоугольник {1})", r1.Area(), "1");
        if (r1.Area() < r2.Area())
            Console.WriteLine("Самый большой по площади : {0} (Прямоугольник {1})", r2.Area(), "2");
        else
            Console.WriteLine("площади равны");

        Console.WriteLine("\n /////////////////////////////");

    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle r1 = new Rectangle(3, 4);
        Rectangle r2 = new Rectangle(2, 6);
        Rectangle r3 = new Rectangle(4, 4);

        Rectangle.Compare(r1, r2);  
        Rectangle.Compare(r2, r3);
        Rectangle.Compare(r1, r3);
    }
}