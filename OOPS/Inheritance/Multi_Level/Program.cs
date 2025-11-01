using System;

class Student
{
    public string name;
    public int roll_no;

    public void studentInput()
    {
        Console.WriteLine("Enter Student Roll No:");
        roll_no = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Student Name:");
        name = Console.ReadLine();

    }
    public void studentDisplay()
    {
        Console.WriteLine("Student Roll No:" + roll_no);
        Console.WriteLine("Student Name:" + name);
    }

}
class Marks : Student
{
    public int sub1, sub2, sub3;
    public void inputMarks()
    {
        Console.WriteLine("Enter Subject 1 Marks:");
        sub1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Subject 2 Marks:");
        sub2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Subject 3 Marks:");
        sub3 = Convert.ToInt32(Console.ReadLine());
    }
}
class Result : Marks
{
    public int total = 300;

    public float average, percentage,obtained;
    public void totalMarks()
    {
        obtained = sub1 + sub2 + sub3;
        Console.WriteLine("Total Marks:" + total);
        Console.WriteLine("Obtained Marks:" + obtained);
    }
    public void marksPercentage()
    {
        average = obtained / total;
        percentage = average * 100;
        Console.WriteLine("Percentage:"+percentage);
    }
}
class Program
{
    static void Main()
    {
        Result re = new Result();
        re.studentInput();
        re.inputMarks();
        re.totalMarks();
        re.marksPercentage();

    }
}