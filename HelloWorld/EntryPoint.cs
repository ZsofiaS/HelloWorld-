using System;

class EntryPoint
{
    static void Main()
    {
        Console.WriteLine("hello world");
        Console.WriteLine("What's your name?");
        string answer = Console.ReadLine();
        Console.WriteLine(answer.ToUpper());
    }
}

