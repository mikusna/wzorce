using System;


class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        //wywołanie nowej metody GetCylinderSize
        string cylinderSize = car.GetCylinderSize();
        Console.WriteLine($"Cylinder size: {cylinderSize}");
        Console.ReadKey();
    }
}



public class Car
{
    public Engine GetEngine()
    {
        return new Engine();
    }

    //nowa metoda GetCylinderSize() w klasie Car
    public string GetCylinderSize()
    {
        return GetEngine().GetCylinder().GetSize();
    }
}

public class Engine
{
    public Cylinder GetCylinder()
    {
        return new Cylinder();
    }
}

public class Cylinder
{
    public string GetSize()
    {
        return "2.0L";
    }
}