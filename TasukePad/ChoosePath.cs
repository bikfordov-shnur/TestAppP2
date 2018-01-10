using System;

namespace TasukePad
{
    class ChoosePath//create array, input right keyword to choose between paths
    {
        private static string[] paths = new string[] { @"E:\CatalogEnglish.txt", @"E:\CatalogJapanese.txt", @"E:\CatalogIsEssence.txt" };//i static, i new v odnom flakone!!!
        public static string rightPath;//or maybe file? or catalog?

        public static void ChooseRightPath()
        {
            Console.WriteLine("     !Choose right path...");
            switch (Console.ReadLine())
            {
                case "english":
                    rightPath = paths[0];
                    break;
                case "japanese":
                    rightPath = paths[1];
                    break;
                case "essence":
                    rightPath = paths[2];
                    break;
                default:
                    Console.WriteLine("     !Incorrect keyword...");
                    break;
            }
        }
    }
}
