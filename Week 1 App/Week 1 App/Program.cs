﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;

            //Console.WriteLine prints text between brackets in a line
            Console.WriteLine("Please enter your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();


            Console.WriteLine(name + age);
            Console.ReadLine();
        }
    }
}
