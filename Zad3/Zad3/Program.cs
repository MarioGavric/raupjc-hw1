﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {

            IGenericList<string> stringList = new GenericList<string>();
            stringList.Add(" Hello ");
            stringList.Add(" World ");
            stringList.Add("!");
            foreach (string value in stringList)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
