using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Welcome "+name+" . Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        String decision = Console.ReadLine();
        if(decision == "Yes")
        {
            int count = 0;
            // heads -> 0, tails -> 1
            for(int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                int val = rnd.Next(2);
                Console.WriteLine("Heads or Tails?");
                string user_input = Console.ReadLine();
                if ((val == 0 && user_input == "Heads") || (val == 1 && user_input == "Tails"))
                {
                    Console.WriteLine("Correct!");
                    count++;
                }
                else
                    Console.WriteLine("Wrong!");
                Console.WriteLine(val);
            }
            Console.WriteLine("Thank you "+name+" . You got a score of "+count+"!");
        }
        else
        {
            Console.WriteLine("You are a coward "+name);
        }
    }
}
