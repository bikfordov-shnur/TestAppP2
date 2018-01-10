using System;
using System.IO;
using System.Text;

namespace TasukePad
{
    class Output//create array, copy from file to array all elements, print them
    {
        public static void ReadFromFileAndPrint()
        {
            string[] wordArray = File.ReadAllLines(ChoosePath.rightPath, Encoding.UTF8);//pochemu massiv tak sebya vedet!!!
            foreach (string word in wordArray)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("     !All elements from this file");
            Console.Read();
        }
    }
}
