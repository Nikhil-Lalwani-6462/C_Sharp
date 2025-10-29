// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(String[] args)
    {
        string ch;
        int no;
        int days;
        Vehicle ve = new Vehicle();
        Console.WriteLine("Enter Choice Car/Bike/Bus:");
        ch = Console.ReadLine();
        Console.WriteLine("Enter Number of day you want a vehicle for rent");
        no = Convert.ToInt32(Console.ReadLine());

        days = ve.calculateRent(no, ch.ToLower());
        Console.WriteLine("Rent of the vehicle for number of days:" +days);


        
    }
}
class Vehicle
{
    int BikeRent = 500;
    int CarRent = 1000;
    int BusRent = 2000;
    int Rent = 0;

    public int calculateRent(int days, string ch)
    {
        if (ch == "bike")
        {

            Rent = BikeRent * days;


        }
        else if (ch == "car")
        {

            Rent = CarRent * days;

        }
        else if (ch == "bus")
        {
            Rent = BusRent * days;
        }
        else
        {
            Console.WriteLine("Invalid Vehicle Choice");
        }
        return Rent;
    }
}
