using System;

class Reverse
{
    public string StringReverse(string word)
    {
        string new_word = "";
        int length = word.Length - 1;

        while (length >= 0)
        {
            new_word += word[length];
            length--;
        }

        return new_word;
    }
}

class Palindrome
{
    public bool IsPalindrome(string word)
    {
        int start = 0;
        int end = word.Length - 1;

        if (word.Length <= 1)
            return true;

        while (start < end)
        {
            if (word[start] != word[end])
                return false;
            start++;
            end--;
        }

        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        menu();
        Console.WriteLine();
        Console.Write("Enter Choice as per the Menu Options: ");
        int ch = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        switch (ch)
        {
            case 1:
                ReverseOperation();
                break;

            case 2:
                PalindromeOperation();
                break;

            default:
                Console.WriteLine("Invalid Choice!");
                break;
        }
    }

    static void menu()
    {
        Console.WriteLine("1. Reverse String");
        Console.WriteLine("2. Palindrome String");
    }

    static void ReverseOperation()
    {
        Console.Write("Enter a string to reverse: ");
        string user_string = Console.ReadLine();
        Reverse rev = new Reverse();
        string Reverse_String = rev.StringReverse(user_string);
        Console.WriteLine("Reversed String: " + Reverse_String);
    }

    static void PalindromeOperation()
    {
        Console.Write("Enter string to check whether it is palindrome: ");
        string user_input = Console.ReadLine();
        Palindrome pal = new Palindrome();
        bool check_palindrome = pal.IsPalindrome(user_input);

        if (check_palindrome)
            Console.WriteLine("Given String is Palindrome");
        else
            Console.WriteLine("Given String is not Palindrome");
    }
}
