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
            Program program = new Program();
            HangMan gameOne = new HangMan();

            //WordData wordData = JsonConvert.DeserializeObject<WordData>(File.ReadAllText(@"words.json"));
            ////JObject o = JObject.Parse(wordData);

            //using (StreamReader file = File.OpenText(@"words.json"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    WordData words = (WordData)serializer.Deserialize(file, typeof(WordData));
            //    Console.WriteLine(words.lengths);
            //}

            //using (StreamReader file = File.OpenText(@"words.json"))
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    WordData wordData2 = (WordData)serializer.Deserialize(file, typeof(WordData));
            //    //JObject o = JObject.Parse(wordData2);
            //}

           

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

                if (gameOne.checkForWinner())
                    guesses = 1;
                                     
                guesses -= 1;

                Console.WriteLine( "Guesses Left: " + guesses);
                Console.WriteLine( "Score: " + gameOne.score);
            }
            
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
