using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public class Person
    {
        public string name;
        private string randName = "jake";
        private List<string> wordList = new List<string>() { "jake", "jackie", "cheryl", "casey", "joe"  };

        public Person()
        {
            name = "unknown";
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public string GetRandName()
        {
            Random r = new Random();
            int number = r.Next(0, 4);
                        
            return wordList[number];
        }
               
    }
}
