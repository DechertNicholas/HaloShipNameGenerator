using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GuiltySpark.Factories
{
    public class GetRandom
    {
        public class UNSC {

            // Name will contain the constructors for each pattern of name
            //each ctor will randomly pull from the text list 
            //Name will randomly choose which ctor to use
            public string Noun()
            {
                string noun = "..\\Factories\\UNSC\\Constructors\\Nouns.txt";
                string[] allLines = File.ReadAllLines(noun);

                string name = allLines[new Random().Next(allLines.Length)];

                return noun;
            }

            public string Adjective()
            {
                string adjective = "..\\Factories\\UNSC\\Constructors\\adjectives.txt";
                string[] allLines = File.ReadAllLines(adjective);

                string name = allLines[new Random().Next(allLines.Length)];

                return adjective;
            }
        }
      
    }
}
