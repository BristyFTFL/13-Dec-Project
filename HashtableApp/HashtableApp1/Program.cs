﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHashtable = new Hashtable();
            aHashtable.Add("111", "ASP.NET MVC");
            aHashtable.Add("222", "JAVA Basics");
            aHashtable.Add("101", "Laravel");
            aHashtable.Add("384", "Zend");
            aHashtable.Add("987", "SEO");
            string courseName = (string) aHashtable["101"];
            Console.WriteLine(courseName);
            Console.ReadKey();
        }
    }
}
