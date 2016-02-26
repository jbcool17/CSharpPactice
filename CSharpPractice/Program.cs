using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();
            HangMan gameOne = new HangMan();
                

            //Init Game
            gameOne.init();
            string randomWord = gameOne.word;
            string input;

            //Opening Message
            Console.WriteLine("Welcome to HangMan");
            Console.WriteLine("Please guess a letter");
            
            Console.WriteLine("The Word: " + gameOne.blankWord);
                       

            //Game Loop
            int guesses = 10;
            while (guesses > 0)
            {
                input = Console.ReadLine();
                gameOne.checkForLetter(input);
                gameOne.checkForWinner();
                     
                guesses -= 1;

                Console.WriteLine( "Guesses Left: " + guesses);
                Console.WriteLine( "Score: " + gameOne.score);
            }
            
            //while ( randWord != word)
            //{
                
            //    Console.WriteLine("===========");
            //    gameOne.GetWords();
            //    Console.WriteLine("===========");
            //    word = Console.ReadLine();

            //    if (word == randWord)
            //    {
            //        program.OutputMessage("It matches!");
            //    }
            //    else if ( score < 3)
            //    {
                    
            //        Console.WriteLine("-----------");
            //        program.OutputMessage("Sorry. You Loose :-( :: Score: " + score);
            //        program.OutputMessage("The word was: " + randWord);
            //        randWord = word;

            //    }
            //    else 
            //    {
            //        score -= 1;
            //        Console.WriteLine("-----------");
            //        program.OutputMessage("Sorry. Please choose again :-( :: Score: " + score);
            //    }
                
            //}

        }

        public string OutputMessage(string message)
        {
            Console.WriteLine("Output: " + message);

            return message;
        }

        public string ConcatString(string strOne, string strTwo)
        {
            return strOne + strTwo;
        }
    }
}
