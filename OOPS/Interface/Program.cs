using System;

interface IEmployee
{
    void GetDetails();

    void DisplayDetails();
}
interface IPerformance
{
    void CalculateBonus();

    void ShowBonus();
}

class Manager : IEmployee, IPerformance
{
    public double salary,bonus;
    public string name,id,rating;
    
    public void GetDetails()
    {
        Console.WriteLine("Enter Employee Id:");
        id = Console.ReadLine();
        Console.WriteLine("Enter Employee Name:");
        name = Console.ReadLine();
        Console.WriteLine("Enter Employee Salary:");
        salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Rating (Excelent/Good/Average):");
        rating = Console.ReadLine();

    }
    public void DisplayDetails()
    {
        Console.WriteLine("Id of the Employee:" + id);
        Console.WriteLine("Name of the Employee:" + name);
        Console.WriteLine("Salary of the Employee:" + salary);
        Console.WriteLine("Ratings of the Employee:" + rating);

    }
    public void CalculateBonus()
    {
        if (rating == "Excelent")
        {
            bonus = salary * 0.20;
        }
        else if (rating == "Good")
        {
            bonus = salary * 0.10;
        }
        else if (rating == "Average")
        {
            bonus = salary * 0.05;
        }
        else
        {
            bonus = 0.0;
        }
    }
    public void ShowBonus()
    {
        Console.WriteLine("Bonus of the Employee:" + bonus);
    }
}
class Program
{

    static void Main()
    {
        Manager ma = new Manager();
        ma.GetDetails();
        ma.DisplayDetails();
        ma.CalculateBonus();
        ma.ShowBonus();

    }
}