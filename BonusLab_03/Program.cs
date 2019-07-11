using System;

namespace BonusLab_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string strContinue = "";
            Console.WriteLine("Welcome to the Guess a Number Game!");
            Console.WriteLine("***********************************");

            do
            {
                Console.WriteLine("I'm thinking of a number between 1 and 100.");

                Random random = new Random();
                int theNum = random.Next(1, 100);
                int guessNum = 0;
                int guessCount = 0;

                do
                {
                    Console.Write("\nEnter your guess: ");
                    guessNum = int.Parse(Console.ReadLine());
                    guessCount++;

                    if (guessNum == theNum)
                    {
                        break;
                    }
                    else if (guessNum < theNum)
                    {
                        if (guessNum < (theNum - 10))
                        {
                            Console.WriteLine("Way too low!");
                        }
                        else if (guessNum > (theNum - 10))
                        {
                            Console.WriteLine("Too low, but getting warmer!");
                        }
                    }
                    else if (guessNum > theNum)
                    {
                        if (guessNum > (theNum + 10))
                        {
                            Console.WriteLine("Way too high!");
                        }
                        else if (guessNum < (theNum + 10))
                        {
                            Console.WriteLine("Too high, but getting warmer!");
                        }
                    }
                } while (guessNum != theNum);

                Console.WriteLine("You got it in " + guessCount + " tries.");

                if (guessCount <= 2)
                {
                    Console.WriteLine("You must be a psychic!");
                }
                else if (guessCount > 2 && guessCount < 5)
                {
                    Console.WriteLine("Pretty good!");
                }
                else
                {
                    Console.WriteLine("You're stupid!");
                }

                Console.Write("Try again? (y/n)");
                strContinue = Console.ReadLine();

            } while (strContinue == "y");
        }
    }
}
