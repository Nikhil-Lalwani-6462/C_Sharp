using System;

class Program
{
    static void Main(String[] args)
    {
        int amount;
        string account, note;
        Bank ba = new Bank();
        Console.Write("Enter amount to deposit in account");
        amount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        Console.Write("Enter Account type of the account:");
        account = Console.ReadLine();

        Console.WriteLine();

        Console.Write("Enter Note:");
        note = Console.ReadLine();

        ba.Deposit(amount);
        ba.Deposit(amount, account);
        ba.Deposit(amount, account, note);

    }
}
class Bank
{
    public void Deposit(int amount)
    {
        Console.WriteLine("Amount deposited in the account:" + amount);
    }
    public void Deposit(int amount, string account)
    {

        Console.WriteLine(+amount + " deposited in " + account + "account");
    }
    public void Deposit(int amount, string account, string note)
    {
        Console.WriteLine(+amount + "deposited in " + account +"Note:"+note);
    }
}


