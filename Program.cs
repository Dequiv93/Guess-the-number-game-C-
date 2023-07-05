using System;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to Guess the Number! ");
        
        // Defining the number to be guessed
        Random random = new Random ();
        int secretNumber = random.Next(1, 100 + 1);
        
        Console.WriteLine("I am Thinking in a number between 1 and 100.");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter your Guess:  ");
        
            string input = Console.ReadLine();
        
            int guess = int.Parse(input);

            Console.WriteLine(guess);
        
            if (guess > secretNumber)
            {
             Console.WriteLine("too high! ❌");  
            }
            else if (guess < secretNumber)
            {
             Console.WriteLine("too low! ");  
            }
            else
            {
             Console.WriteLine("You won! ✅🤗");
             return;
            }  
        }
        Console.WriteLine("Game Over ⏲");






        
    }


}