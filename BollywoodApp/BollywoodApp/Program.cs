using System;

class Program
{
    static void Main(string[] args)
    {
        //  Console.WriteLine("Hello World!");
        Console.WriteLine("Welcome in Bollywood App...\n1. Movie\n2. Actor\nEnter Your Choice : ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Movie movie = new Movie();
                break;
            case 2:
                Actor actor = new Actor();
                break;
            default:
                Console.WriteLine("You Enter Invalid Choice \n Thank You for Visisting...");
                Console.ReadLine();
                break;
        }
    }
}

