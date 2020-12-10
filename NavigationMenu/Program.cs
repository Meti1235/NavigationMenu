using System;
using System.Collections.Generic;
using System.IO;

namespace NavigationMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Read();
            MyCSVParser myCSVParser = new MyCSVParser();

            using (var reader = new StreamReader(@"../../../Navigation.csv"))
            {
                List<Menu> myMenuList = myCSVParser.DeserializeCSV(reader.ReadToEnd());
                //myMenuList.RecursivePrint();
                Console.WriteLine("------------------------------------------");
                myMenuList.PrintMenu();
                Console.ReadLine();
            }

            Console.WriteLine("Successfull I guess...");
            Console.ReadLine();
        }
    }
}
