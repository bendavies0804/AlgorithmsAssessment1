using System;
using System.Collections;
using System.Drawing;
using System.IO;


namespace assignment
{
    class Search
    {
        public static bool searchRoads(int[] roadArray)
        {
            Console.WriteLine("What number are you searching for? ");
            string toSearchStr = Console.ReadLine();
            int toSearch = Convert.ToUInt16(toSearchStr);
            /*
            int min = 0;
            int max = roadArray.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (toSearch == roadArray[mid])
                {
                    Console.WriteLine(Convert.ToString(mid));
                    break;
                }
                else if (toSearch < roadArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            */
            int count = 0;
            for (int i = 1; i <= roadArray.Length - 1; i++)
            {
                if (roadArray[i] == toSearch)
                {
                    Console.WriteLine("Found at: " + Convert.ToString(i));
                    count = 1;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Not found.");
            }
            return true;
        }

    }

}
