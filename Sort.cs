using System;
using System.Collections;
using System.Drawing;
using System.IO;


namespace assignment
{
    class Sort
    {
        public static bool sortRoads(int[] roadArray)
        {
            int temp = 0;
            for (int i = 0; i <= roadArray.Length - 1; i++)
            {
                for (int j = i + 1; j < roadArray.Length; j++)
                {
                    if (roadArray[i] > roadArray[j])
                    {
                        temp = roadArray[i];
                        roadArray[i] = roadArray[j];
                        roadArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Ascending order - every 10");
            for (int i = 1; i <= roadArray.Length - 1; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(roadArray[i - 1]);
                }
            }

            temp = 0;
            for (int i = 0; i <= roadArray.Length - 1; i++)
            {
                for (int j = i + 1; j < roadArray.Length; j++)
                {
                    if (roadArray[i] < roadArray[j])
                    {
                        temp = roadArray[i];
                        roadArray[i] = roadArray[j];
                        roadArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Descending Order - every 10");
            for (int i = 1; i <= roadArray.Length - 1; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(roadArray[i - 1]);
                }
            }
            temp = 0;
            for (int i = 0; i <= roadArray.Length - 1; i++)
            {
                for (int j = i + 1; j < roadArray.Length; j++)
                {
                    if (roadArray[i] > roadArray[j])
                    {
                        temp = roadArray[i];
                        roadArray[i] = roadArray[j];
                        roadArray[j] = temp;
                    }
                }
            }
            Search.searchRoads(roadArray);
            return true;
        }
    }
}
