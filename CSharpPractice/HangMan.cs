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
        public int score = wordList.Count() ;
        
        
        public HangMan()
        {
            word = "unknown";
        }

        public void SetName(string newName)
        {
            word = newName;
        }

        public void GetWords()
        {
            foreach (string word in wordList)
            {
                Console.WriteLine(word);
            }
        }

        public string GetRandWord()
        {
            Random r = new Random();
            int number = r.Next(0, 4);

            return wordList[number];
        }
    }
}
