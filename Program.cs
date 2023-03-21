using System;
using System.Collections;
using System.Drawing;
using System.IO;

namespace assignment
{
    class Program
    {

        string[] roadOneArray = File.ReadAllLines("Road_1_256.txt"); // Read the contents of the file
        string[] roadTwoArray = File.ReadAllLines("Road_2_256.txt");
        string[] roadThreeArray = File.ReadAllLines("Road_3_256.txt");
        int[] roadOneArrayInt = Array.ConvertAll<string, int>(roadOneArray, int.Parse);
        int[] roadTwoArrayInt = Array.ConvertAll<string, int>(roadTwoArray, int.Parse);
        int[] roadThreeArrayInt = Array.ConvertAll<string, int>(roadThreeArray, int.Parse);

        static void Main(string[] args)
        {
            Console.WriteLine("Which road do you want to display: 1, 2 or 3");
            string roadType = Console.ReadLine();
            if (roadType == "1")
            {
                Console.WriteLine("1 SELECTED");
                Sort.sortRoads(roadOneArrayInt);
            }
            if (roadType == "2")
            {
                Console.WriteLine("2 SELECTED");
                Sort.sortRoads(roadTwoArrayInt);
            }
            if (roadType == "3")
            {
                Console.WriteLine("3 SELECTED");
                Sort.sortRoads(roadThreeArrayInt);
            }
        }

    }


}
