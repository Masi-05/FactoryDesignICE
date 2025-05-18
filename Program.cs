
using PROG7311FactoryDesign;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        GunFactory factory = new GunFactory();

        IGun ar = factory.GetGun("AR");
        ar.Shoot();

        IGun shotgun = factory.GetGun("Shotgun");
        shotgun.Shoot();


    }
}
