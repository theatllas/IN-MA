//Welcome to hangman game
//this game has some problems and i try to fix them in future 

using System;
namespace Hangman
{
    /// <summary>
    /// this enum show the category of the words
    /// </summary>
    enum WordCategory
    {
        animal,
        fruit,
        color
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.PrintWelcome();

            ListWord gamesword = new ListWord();


            int choice;
            
            choice = user1.GetUserChoice();
            switch (choice)
            {
                case 1: gamesword.WordsInPlace(WordCategory.animal); break;
                case 2: gamesword.WordsInPlace(WordCategory.fruit);  break;
                case 3: gamesword.WordsInPlace(WordCategory.color);  break;
            }

            gamesword.Randomselect();
            gamesword.SecretWordInitialze();
            gamesword.Operation();



            Console.ReadKey();


        }
    }


}
