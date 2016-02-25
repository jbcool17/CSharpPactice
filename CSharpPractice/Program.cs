using System;
using System.Collections.Generic;
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

            //Console.WriteLine( program.OutputMessage("This is a message!") );

            //Calc calc = new Calc();
            //Console.WriteLine( calc.AddNum(100, 99) );
            //Console.WriteLine( calc.SubNum(5, 10) );

            //Person personOne = new Person();
            //Console.WriteLine(personOne.name);

            //Person personTwo = new Person();
            //personTwo.SetName("JB Cool");
            //Console.WriteLine(personTwo.name);
            //Console.WriteLine(personTwo.GetRandName());

            string randWord = gameOne.GetRandWord();
            string word = "default";
            int score = gameOne.score;

            Console.WriteLine("Guess a word from this list: ");
            while ( randWord != word)
            {
                
                Console.WriteLine("===========");
                gameOne.GetWords();
                Console.WriteLine("===========");
                word = Console.ReadLine();
                if (word == randWord)
                {
                    program.OutputMessage("It matches!");
                }
                else if ( score < 3)
                {
                    
                    Console.WriteLine("-----------");
                    program.OutputMessage("Sorry. You Loose :-( :: Score: " + score);
                    program.OutputMessage("The word was: " + randWord);
                    randWord = word;

                }
                else 
                {
                    score -= 1;
                    Console.WriteLine("-----------");
                    program.OutputMessage("Sorry. Please choose again :-( :: Score: " + score);
                }
                
                
            }
           
                        
           // program.OutputMessage(randWord);



            
                
            
            


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
