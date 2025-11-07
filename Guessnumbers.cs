using System;

namespace GuessNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("lets start the puzzle games!");
            Console.WriteLine("we will give you a number between 1-100");

            var random = new Random();
            int target = random.Next(1,101); 
            int guess = 0;
            int attemps = 0;

            while(target != guess)
            {
                Console.WriteLine("input your guess number");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out guess)){
                    Console.WriteLine("you didnt input a right number!");
                    continue;
                }
                attemps++;

                if (guess > target){ Console.WriteLine("it is lager");}
                else if (guess < target){ Console.WriteLine("it is smaller");}
                else {
                    Console.WriteLine($"you won! the number is {target}");
                    Console.WriteLine($"you've tried {attemps} times");
                }

            }
            Console.WriteLine("press any key to quit");
            Console.ReadKey();

        }


    }

}