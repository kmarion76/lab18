using System;
using System.Collections.Generic;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] games = { "cod", "wow", "mario" };
            List test = new List(10);
            test.Insert("Hi");
            test.Insert("my");
            test.Insert("name");
            test.Insert("is");
            test.Insert("kevin");

            //Test for number 1
            test.RemoveAt(1);
            //Test for number 2
            test.PrintReverse(games);
            //Test for number 3
            test.InsertAt(1, "spiderman");
            
            
        }
    }
}
