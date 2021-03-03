using MyDictionary;
using System;
using System.Collections.Generic;
//Gizem Aktürk
//04.03.2021
namespace KampOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyDictionary<int, string> Ogrenci = new  MyDictionary<int, string>();
            Ogrenci.Add(11, "ayse");
            Ogrenci.Add(12, "veli");


        }
    }
}
