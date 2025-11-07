using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("welcome to the PUZZLES!");
        Console.WriteLine("this is the number between 1 to 100, can you guess?");
        
        var random = new Random();
        int target = random.Next(1,101);
        int guess = 0;
        int attempts = 0;

        while (guess != target){
        
            Console.WriteLine("pls input your number!");
            string input = Console.ReadLine();

            if(!int.TryParse(input, out guess)){
                Console.WriteLine("please write the right number!");
                continue;
            }
            attempts++;

            if (guess > target) Console.WriteLine("your number is too large");
            else if (guess < target) Console.WriteLine("your number is too small");

            else {
                Console.WriteLine($"you got the number!the answer is {target}");
                Console.WriteLine($"in total you have guess {attempts} times");
            }
        }

        Console.WriteLine("\n press any key to quit");
        Console.ReadKey();

    }
}
