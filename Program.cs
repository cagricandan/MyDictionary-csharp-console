using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {

        static void Main(string[] args)
        {


            MyDictionary<string, int> _mydictionary = new MyDictionary<string, int>();

            _mydictionary.Add("a",2);
            _mydictionary.Add("a", 1);
            _mydictionary.Add("a", 1);


            Console.WriteLine(_mydictionary.Count);
            _mydictionary.ToList();

        }
    }
}
