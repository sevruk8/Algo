using System;

namespace Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Алгоритм Эвклида - поиск наибольшего общего натурального числа делителя
            int numA;
            int numB;
            int coeffA;
            int coeffB;
            Console.WriteLine("Введите целое положительное число А");
            numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое положительное число Б");
            numB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"НОД простого алгоритма Эвклида = {Euclidius(numA, numB)}");
            Console.WriteLine($"НОД ускоренного алгоритма Эвклида = {EuclidiusFast(numA, numB)}");
            Console.WriteLine($"НОД ускоренного алгоритма Эвклида = {EuclidiusExt(numA, numB, out coeffA, out coeffB)}");
            Console.WriteLine($"ax + by = {numA * coeffA + numB * coeffB}");
        }

        // Простой алгоритм Эвклида. Сложность: O(n) - линейная
        static int Euclidius(int numA, int numB)
        {
            while (numA != numB)
            {
                if(numA > numB)
                {
                    numA = numA - numB;
                }
                else
                {
                    numB = numB - numA;
                }
            }
            return numA;
        }

        // Ускоренный алгоритм Эвклида. Сложность: O(log(n)) - логарифмическая
        static int EuclidiusFast (int numA, int numB)
        {
            int c;
            while (numB != 0)
            {
                c = numA % numB;
                numA = numB;
                numB = c;
            }
            return numA;
        }

        // Расширенный алгоритм Эвклида. Сложность: O(log(n)) - логарифмическая
        static int EuclidiusExt(int numA, int numB, out int x, out int y)
        {
            int q, r, x1, x2, y1, y2;
            if (numB == 0)
            {
                x = 1;
                y = 0;
                return numA;
            }
            x2 = 1;
            x1 = 0;
            y2 = 0;
            y1 = 1;

            while (numB > 0)
            {
                q = numA / numB;
                r = numA - q * numB;
                x = x2 - q * x1;
                y = y2 - q * y1;
                numA = numB;
                numB = r;
                x2 = x1;
                x1 = x;
                y2 = y1;
                y1 = y;
            }
            x = x2;
            y = y2;
            return numA;
        }
    }
}
