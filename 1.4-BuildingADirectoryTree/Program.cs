using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_BuildingADirectoryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // List the subdirectories for Program Files containing the character ‘a’ with a maximum  depth of 5
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Program Files");
            ListDirectories(directoryInfo, "*Microsoft*", 5, 0);
            //ListDirectories(directoryInfo, "?icrosoft", 5, 0);
            Console.ReadKey();
        }
        private static void ListDirectories(DirectoryInfo directoryInfo, string searchPattern, int maxLevel, int currentLevel)
        {
            if (currentLevel >= maxLevel)
            {
                return;
            }
            string indent = new string('-', currentLevel);
            try
            {
                DirectoryInfo[] subDirectories = directoryInfo.GetDirectories(searchPattern);
                foreach (DirectoryInfo subDirectory in subDirectories)
                {
                    Console.WriteLine(indent + subDirectory.Name);
                    ListDirectories(subDirectory, searchPattern, maxLevel, currentLevel + 1);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // You don’t have access to this folder. 
                Console.WriteLine(indent + "Can’t access: " + directoryInfo.Name);
                return;
            }
            catch (DirectoryNotFoundException)
            {
                // The folder is removed while iterating
                Console.WriteLine(indent + "Can’t find: " + directoryInfo.Name);
                return;
            }
        }
    }
}
