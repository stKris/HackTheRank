using System;
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
    public class Program
    {
        public static void Main(string[] args)
        {
            int result = SockMerchant(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });

            Console.WriteLine(result);
        }

        public static int SockMerchant(int numberOfSocksInPile, int[] socksColors)
        {
            var totalPairs = 0;
            var socksPerColor = new Dictionary<int, int>();

            if (numberOfSocksInPile != socksColors.Length)
            {
                return 0;
            }

            if (numberOfSocksInPile >= 1 || numberOfSocksInPile <= 100)
            {
                for (int i = 0; i < numberOfSocksInPile; i++)
                {
                    var temp = socksColors[i];
                    if (!socksPerColor.ContainsKey(temp))
                    {
                        socksPerColor.Add(temp, 0);
                    }

                    socksPerColor[temp]++;
                }

                foreach (var socks in socksPerColor)
                {
                    totalPairs += Math.DivRem(socks.Value, 2, out totalPairs);
                }
            }

            return totalPairs;
        }
    }
}