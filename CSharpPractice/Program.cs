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

            Console.WriteLine( program.OutputMessage("This is a message!") );

            Calc calc = new Calc();
            Console.WriteLine( calc.AddNum(100, 99) );
            Console.WriteLine( calc.SubNum(5, 10) );

            Person personOne = new Person();
            Console.WriteLine(personOne.name);

            Person personTwo = new Person();
            personTwo.SetName("JB Cool");
            Console.WriteLine(personTwo.name);
            Console.WriteLine(personTwo.GetRandName());
            
        }

        public string OutputMessage(string message)
        {
            return message;
        }

        public string ConcatString(string strOne, string strTwo)
        {
            return strOne + strTwo;
        }
    }
}
