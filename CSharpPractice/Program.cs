using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
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

            HangMan game = new HangMan();
            
            //Init Game
            game.init();
            string randomWord = game.word;
            string input;
            
            //Game Loop
            int guesses = game.guesses;

            while (guesses > 0)
            {
                input = Console.ReadLine();
                Console.Clear();
                game.checkForLetter(input);
                
                //check for Winner
                if (game.checkForWinner())
                {
                    guesses = 0;
                    Console.WriteLine("Winner");
                }
                else if (guesses == 0)
                {
                    Console.Clear();
                    Console.WriteLine("You lost man!");
                }
                else
                {
                    guesses -= 1;
                    
                    Console.WriteLine("Nothing yet...keep going");
                    Console.WriteLine("You have " + guesses + " guesses left.");
                }      
                 
                Console.WriteLine("Guessed Letters: " + string.Join(",", game.guessedLetters.ToArray()));
                Console.WriteLine( "Score: " + game.score);
                Console.WriteLine("The Word: " + game.blankWord);
                Console.WriteLine("------------------------------------------");
            }
            
        }        
    }
}
