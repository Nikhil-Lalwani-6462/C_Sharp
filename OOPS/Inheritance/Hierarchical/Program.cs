using System;
class Base
{
    public int sum;
    public int product;
}
class Derived1 : Base
{
    int no1, no2;
    public void add()
    {
        Console.WriteLine("Enter No1 for addition:");
        no1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter No2 for addition:");
        no2 = Convert.ToInt32(Console.ReadLine());
        sum = no1 + no2;
        Console.WriteLine("Addition of Numbers:" +sum);
    }   
}
class Derived2 : Base
{
    int no1, no2;
    public void multiply()
    {
        Console.WriteLine("Enter No1 for multiplication:");
        no1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter No2 for multiplication:");
        no2 = Convert.ToInt32(Console.ReadLine());
        product = no1 * no2;
        Console.WriteLine("Multiplication of numbers:"+product);
    }
}
class Program
{
    static void Main(String[] args)
    {
        Derived1 de1 = new Derived1();
        de1.add();
        Derived2 de2 = new Derived2();
        de2.multiply();
    }
}