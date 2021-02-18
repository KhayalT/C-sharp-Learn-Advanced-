using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] {
            //"Engin","Murat","Kerem","Halit","Mustafa","Kaya"
            //};
            //Console.WriteLine(names[0]);
   
             
            List<string> names2 = new List<string> {"Engin","Kaya","Mustafa" };
            names2.Add("HHHH");
            Console.WriteLine(names2[names2.Count-1]);
        }
    }
}
