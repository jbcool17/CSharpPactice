using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class HangMan
    {
        public string word;
        private static List<string> wordList = new List<string>() { "hello", "world", "dogs", "cats", "fish" };
        public int score;
        public List<char> guessedLetters = new List<char>();
        
        public string blankWord;
        
        //Initialize the game 
        public void init()
        {
            word = GetRandWord();
            blankWord = CreateBlankWord(word);
            score = 0;
        }
                
        public void GetWordsList()
        {
            foreach (string word in wordList)
            {
                Console.WriteLine(word);
            }
        }

        private string GetRandWord()
        {
            Random r = new Random();
            int number = r.Next(0, 4);
            word = wordList[number];

            return wordList[number];
        }

        private string CreateBlankWord(string word)
        {
            
            List<char> blankSpacePush = new List<char>();
            char blankSpace = '_';

            for (int i = 0; i < word.Length; i++)
            {
                blankSpacePush.Add(blankSpace);
            }

            return string.Join("", blankSpacePush.ToArray());
        }

        public void checkForLetter(string command)
        {
            char[] array = word.ToCharArray();
            char[] guess = command.ToCharArray();
            guessedLetters.Add(guess[0]);
                        
            Console.WriteLine("Guessed Letter: " + string.Join(",", guessedLetters.ToArray()));

            addsCorrectLetter(guess[0]);
        }

        internal void checkForWinner()
        {
            if ( blankWord == word)
            {
                Console.WriteLine("You won!");
            } else
            {
                Console.WriteLine("Sorry please try again");
            }
        }

        private void addsCorrectLetter(char letter)
        {
            
            for (int i = 0; i < word.Length; i++)
            {
                if ( word[i] == letter )
                {
                    blankWord = blankWord.Remove(i, 1);
                    blankWord = blankWord.Insert(i, letter.ToString());
                    score += 1;
                    Console.WriteLine("FOUND: " + blankWord);
                }                   
               
            }

            
        }
                
    }
}
