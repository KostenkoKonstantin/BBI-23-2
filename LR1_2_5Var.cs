using System;
using System.Linq;

public abstract class Embrasure
{
    public string Name { get; set; }
    public double Width { get; set; }
    public double Length { get; set; }
    public double Thickness { get; set; }

    public abstract double CalculateCost();

    public static void Write(Embrasure[] m) 
    {
        for (int i = 0; i < m.Length; i++)
        {
            for (int j = i + 1; j < m.Length; j++)
            {
                double costi = m[i].CalculateCost();
                double costj = m[j].CalculateCost();
                if (costi > costj)
                {
                    Embrasure temp = m[i];
                    m[i] = m[j];
                    m[j] = temp;
                }
            }
        }
        for (int i = 0; i < m.Length; i++)
        {
            Console.WriteLine($"{m[i].Name}  Ширина: {m[i].Width}, Длина: {m[i].Length}, Толщина: {m[i].Thickness}, Цена: {m[i].CalculateCost()}");
        }
    }
}

public class Window : Embrasure
{
    public int Layers { get; set; }

    public Window(string name, double width, double length, double thickness, int layers)
    {
        Name = name;
        Width = width;
        Length = length;
        Thickness = thickness;
        Layers = layers;
    }

    public override double CalculateCost()
    {
        return Width * Length * Thickness * 10 + Layers * 50;
    }
}

public class Door : Embrasure
{
    public bool IsOrnate { get; set; }
    public bool IsGlass { get; set; }

    public Door(string name, double width, double length, double thickness, bool isOrnate, bool isGlass)
    {
        Name = name;
        Width = width;
        Length = length;
        Thickness = thickness;
        IsOrnate = isOrnate;
        IsGlass = isGlass;
    }

    public override double CalculateCost()
    {
        double cost = Width * Length * Thickness * 20;
        if (IsOrnate)
        {
            cost += 100;
        }
        if (IsGlass)
        {
            cost += 50;
        }
        return cost;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Window[] windows = new Window[]
        {
            new Window("Окно 1", 1.5, 0.8, 0.1, 3),
            new Window("Окно 2", 1.2, 0.9, 0.1, 2),
            new Window("Окно 3", 1.8, 1.0, 0.1, 4),
            new Window("Окно 4", 1.6, 0.8, 0.1, 3),
            new Window("Окно 5", 1.4, 0.9, 0.1, 2)
        };

        Door[] doors = new Door[]
        {
            new Door("Дверь 1", 0.8, 2.0, 0.2, true, false),
            new Door("Дверь 2", 0.9, 1.8, 0.2, false, true),
            new Door("Дверь 3", 1.0, 2.1, 0.2, true, true),
            new Door("Дверь 4", 0.7, 1.9, 0.2, false, false),
            new Door("Дверь 5", 0.8, 2.0, 0.2, true, false)
        };

        Embrasure.Write(doors);
        Embrasure.Write(windows);

        Console.WriteLine("///////////////////////////////////////////////////");
        Embrasure[] embrasures = new Embrasure[windows.Length + doors.Length];

        int windowIndex = 0;
        int doorIndex = 0;

        for (int i = 0; i < embrasures.Length; i++)
        {
            if (windowIndex < windows.Length)
            {
                embrasures[i] = windows[windowIndex];
                windowIndex++;
            }
            else if (doorIndex < doors.Length)
            {
                embrasures[i] = doors[doorIndex];
                doorIndex++;
            }
            else
            {
                break;
            }
        }

        Embrasure.Write(embrasures);

    }
}