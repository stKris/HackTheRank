using System.Collections.Generic;

namespace HackTheRanks
{

/*
Alex works at a clothing store. There is a large pile of socks that must be paired by color for sale.
Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.
For example, there are  socks with colors. There is one pair of color and one of color.
There are three odd socks left, one of each color. The number of pairs is.

Function Description:
Complete the sockMerchant function in the editor below. It must return an integer representing the number of matching pairs of socks that are available.
sockMerchant has the following parameter(s):

 n: the number of socks in the pile
 ar: the colors of each sock

 */
    class Program
    {
        static int sockMerchant(int numberOfSocksInPile, int[] socksColors)
        {   
            var duplicates = 1;
            var totalPairs = 0;
            var exist = new List<int>();

            if (numberOfSocksInPile >= 1 || numberOfSocksInPile <= 100)
            {
                for (int i = 0; i < numberOfSocksInPile; i++)
                {
                    var temp = socksColors[i];
                    if(exist.Contains(temp))
                    {
                        continue;
                    }
                    else
                    {
                        exist.Add(temp);
                    }

                    for (int y = 1; y < numberOfSocksInPile; y++)
                    {
                        if (temp == socksColors[y])
                        {
                            duplicates++;
                        }
                    }

                    if (duplicates % 2 != 0)
                    {
                        duplicates--;
                    }

                    while (duplicates % 2 == 0 && duplicates > 0)
                    {
                        totalPairs++;
                        duplicates-=2;
                    }
                }
            }

            return totalPairs;
        }

        static void Main(string[] args)
        {
            int result = sockMerchant(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });

            System.Console.WriteLine(result);
            System.Console.ReadLine();
        }
    }
}