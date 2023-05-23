using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello! What is your name?");
        var name = Console.ReadLine();
        Console.WriteLine("How old are you?");
        var age = Console.ReadLine();
        
        if(Int32.Parse(age) >= 18){
            Console.WriteLine($"Welcome {name}! You can shop.");
        } else {
            Console.WriteLine($"Welcome {name}! You cannot shop.");
        }
    }
}
