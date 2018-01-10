using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TasukePad
{
    class Input//create list, input new elements, add them to file
    {
        private static List<string> newElements = new List<string>();//i static, i new v odnom flakone!!!

        public static void AddNewElements()
        {
            Console.WriteLine("     !Add new elements...");
            while (newElements.Count < 3)//nado uprostit
            {
                newElements.Add(Console.ReadLine());
                Console.WriteLine($"     !Add {newElements.Count}...");
            }
            File.AppendAllLines(ChoosePath.rightPath, newElements, Encoding.UTF8);
            Console.WriteLine("     !Appending completed...");
        }
    }
}
