using System;

abstract class Employee
{
    public string Name;
    public double Salary;
    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
    public abstract void CalculateBonus();

    public void DisplayDetails()
    {
        Console.Write("Name:" + Name);
        Console.WriteLine();
        Console.Write("Salary:" + Salary);
    }
}
class Manager:Employee
{
    public Manager(string name, double salary) : base(name, salary) { }
    double bonus;
    public override void CalculateBonus()
    {
        bonus = Salary * 0.20;
        Console.Write("Bonus:" + bonus);

    }
}
class Developer:Employee
{
    public Developer(string name, double salary) : base(name, salary) { }
    double bonus;
    public override void CalculateBonus()
    {
        bonus = Salary * 0.10;
        Console.WriteLine("Bonus:" + bonus);
    }
}
class Program
{
    static void Main(String[] args)
    {
        Employee em = new Manager("Nikhil", 80000);
        em.DisplayDetails();
        Console.WriteLine();
        em.CalculateBonus();
        Console.WriteLine();

        Employee ed = new Developer("Rachana", 60000);
        ed.DisplayDetails();
        Console.WriteLine();
        ed.CalculateBonus();
    }
}