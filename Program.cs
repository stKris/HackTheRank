using System.Collections.Generic;

namespace HackTheRanks
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            // sample data
            n = 9;
            ar = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            // end of sample data
            
            var duplicates = 1;
            var totalPairs = 0;
            var exist = new List<int>();

            if (n >= 1 || n <= 100)
            {
                for (int i = 0; i < n; i++)
                {
                    var temp = ar[i];
                    if(exist.Contains(temp))
                    {
                        continue;
                    }
                    else
                    {
                        exist.Add(temp);
                    }

                    for (int y = 1; y < n; y++)
                    {
                        if (temp == ar[y])
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
            // int n = Convert.ToInt32(Console.ReadLine());

            // int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));

            int result = sockMerchant(0, null);

            System.Console.WriteLine(result);
            System.Console.ReadLine();
        }
    }
}