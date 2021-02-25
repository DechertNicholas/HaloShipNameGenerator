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
            public string Name()
            {
                string path = "..\\Factories\\UNSC\\Constructors";
                string[] allLines = File.ReadAllLines(path);

                string name = allLines[new Random().Next(allLines.Length)];

                return name;
            }
        }
      
    }
}
