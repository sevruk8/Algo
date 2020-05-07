using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Объяснение циклов https://youtu.be/hRLRb2UzYGw
            */
            int line = 20; // количество строк в пирамиде
            for (int i = 0; i < line; ++i) // письменное объяснение работы вложенного цикла https://prnt.sc/sarh0k
            {
                int k1 = line - 1 - i;// слевая диагональ
                int k2 = line - 1 + i;// правая диагональ
                for (int j = 0; j <= k2; ++j)
                {
                    if (j >= k1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
