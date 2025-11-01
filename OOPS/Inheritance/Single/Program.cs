using System;
class Base
{
    public int no;
    public virtual void reverseNo()
    {
        Console.WriteLine("Enter No:");
        no = Convert.ToInt32(Console.ReadLine());
    }

}
class Derived : Base
{
    int reversed;
    public override void reverseNo()
    {
        base.reverseNo();
        Console.WriteLine("Before reverse:"+no);
        while (no > 0)
        {
            int digit = no % 10;
            reversed = reversed * 10 + digit;
            no = no / 10;
        }
        Console.WriteLine("After reverse:" +reversed);

    }
}
class Program
{
    static void Main(String[] args)
    {
        Derived de = new Derived();
        de.reverseNo();   
    }
}