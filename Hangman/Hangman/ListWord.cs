using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class ListWord
    {
        private string[] listedWords = new string[10];
        private string selectedWord;
        private char[] secretWord;

        /// <summary>
        /// This method puts the words in the array based on the selected category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public void WordsInPlace(WordCategory category)
        {
            switch (category)
            {
                // In case it is animal
                case WordCategory.animal:
                    listedWords[0] = "tiger";
                    listedWords[1] = "zebra";
                    listedWords[2] = "lion";
                    listedWords[3] = "giraffe";
                    listedWords[4] = "bear";
                    listedWords[5] = "lizzard";
                    listedWords[6] = "jaguar";
                    listedWords[7] = "cheetah";
                    listedWords[8] = "deer";
                    listedWords[9] = "eagle";
                    break;
                // In case it is fruit
                case WordCategory.fruit:
                    listedWords[0] = "banana";
                    listedWords[1] = "apple";
                    listedWords[2] = "peach";
                    listedWords[3] = "cherries";
                    listedWords[4] = "strawberry";
                    listedWords[5] = "grapes";
                    listedWords[6] = "coconut";
                    listedWords[7] = "pineapple";
                    listedWords[8] = "watermelon";
                    listedWords[9] = "avocado";
                    break;
                // In case it is color
                case WordCategory.color:
                    listedWords[0] = "violet";
                    listedWords[1] = "magenta";
                    listedWords[2] = "yellow";
                    listedWords[3] = "skyblue";
                    listedWords[4] = "pink";
                    listedWords[5] = "green";
                    listedWords[6] = "black";
                    listedWords[7] = "gray";
                    listedWords[8] = "orange";
                    listedWords[9] = "white";
                    break;
            }

        }

        /// <summary>
        /// This mehod selects a rondom word for us
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public void Randomselect()
        {
            Random randGen = new Random();
            var index = randGen.Next(0, listedWords.Length);
            selectedWord = listedWords[index];
        }


        public void SecretWordInitialze()
        {
            secretWord = new char[selectedWord.Length];
            for (int i = 0; i < secretWord.Length; i++)
            {
                // all the word letters will be hidden for the user
                secretWord[i] = '*';
            }
        }

        public int Operation()
        {
            // limiting the number of chances
            int chances = selectedWord.Length + 3;

            while (true)
            {


                Console.WriteLine(secretWord);
                Console.WriteLine();
                Console.WriteLine("Number of chances: " + chances);
                Console.WriteLine();


                // Reading input from the user
                char playerGuess = char.Parse(Console.ReadLine());


                // replacing the Tru Playerguesses with the * letters
                for (int j = 0; j < selectedWord.Length; j++)
                {
                    if (selectedWord[j] == playerGuess)
                    {
                        secretWord[j] = playerGuess;
                    }

                }


                int length = selectedWord.Length;

                // This loop is for checking if the word is compeletly guessed or not
                // if yes the game is over
                for (int j = 0; j < selectedWord.Length; j++)
                {
                    if (secretWord[j] != '*')
                    {
                        length--;

                    }

                    if (length == 0)
                    {
                        Console.WriteLine("The word is " + selectedWord + ". You are free!");
                        return 0;
                    }
                }


                chances = chances - 1;

                // check if theres no chances
                if (chances == 0)
                {
                    Console.WriteLine("You are hanged. ");
                    return 0;
                }

            }
        }
    }
}
