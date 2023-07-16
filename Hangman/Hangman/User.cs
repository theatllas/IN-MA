using System;

namespace Hangman
{
    class User
    {
        private int userChoice;

        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to Hangman Game!");
            Console.WriteLine();
        }

        public int GetUserChoice()
        {
            Console.WriteLine("Please select the Category: ");
            Console.WriteLine("1. Animals");
            Console.WriteLine("2. Fruits");
            Console.WriteLine("3. Colors");

            while (userChoice <= 0 || userChoice >= 4)
            {
                userChoice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

            }
            return userChoice;
        }


    }
}
