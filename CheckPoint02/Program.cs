﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CheckPoint02
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";            

            try
            {
                text = System.IO.File.ReadAllText("../../Text.txt");
                Task1 T1 = new Task1(text);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибки:" + e.Message);
            }
            
            //Task1 T1 = new Task1(text);
            
            Console.ReadKey();
        }
    }
}