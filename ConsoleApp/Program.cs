﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine(ClassLibrary.Class.GetFromClassLibrary());
            Console.WriteLine("Waiting...");
            Console.ReadLine();
        }
    }
}
