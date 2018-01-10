using System;

namespace TasukePad
{
    class Program
    {
        static string[] keywords = new string[] { "content", "english", "japanese", "essence" };

        public static void Main()
        {
            ChoosePath.ChooseRightPath();
            Input.AddNewElements();
            if (keywords[0].Equals(Console.ReadLine()))
            {
                Output.ReadFromFileAndPrint();
            }
            else
            {
                Console.WriteLine("     !Incorrect keyword...");
                Console.Read();
            }
        }
    }
}