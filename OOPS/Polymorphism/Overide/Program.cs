// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(String[] args)
    {
        string ch,new_ch;
        int no;

        Console.WriteLine("Enter Choice Car/Bike/Bus:");
        ch = Console.ReadLine();

        Console.WriteLine("Enter Number of day you want a vehicle for rent");
        no = Convert.ToInt32(Console.ReadLine());

        Vehicle ve;

        new_ch = ch.ToLower();
        if (new_ch == "bike")
        {
            ve = new Bike();
            ve.calculateRent(no);
        }
        else if (new_ch == "car")
        {
            ve = new Car();
            ve.calculateRent(no);
        }
        else if (new_ch == "bus")
        {
            ve = new Bus();
            ve.calculateRent(no);

        }
        else
        {
            Console.WriteLine("Invalid choice for rent");
        }
    }
}
class Vehicle
{
    public virtual void calculateRent(int days)
    {
        Console.WriteLine("Days for the vehicle for rent:"+days);
    }

}
class Bike : Vehicle
{
    int BikeRent = 500, Rent;

    public override void calculateRent(int days)
    {
        Rent = days * BikeRent;
        Console.WriteLine("Rent for the bike for" + days + ":" + Rent);
    }

}
class Car : Vehicle
{
    int CarRent = 1000, Rent;
    public override void calculateRent(int days)
    {
        Rent = days * CarRent;
        Console.WriteLine("Rent for the Car for" + days + ":" + Rent);
    }
}
class Bus : Vehicle
{
    int BusRent = 2000,Rent;
    public override void calculateRent(int days)
    {
        Rent = days * BusRent;
        Console.WriteLine("Rent for the Bus for" + days + ":" + Rent);
    }
}
    
