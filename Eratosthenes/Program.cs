using System;
using System.Linq;

namespace Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Решето Эратосфена до 255. Сложность линейная O(n) или O(n*log(log(n)))

            int[] arr = Enumerable.Range(2, 255).ToArray(); //массив целых чисел до 255
            int capacity = 2;
            for (int i = 4; i < 255; ++i)
            {
                int isPrime = 1;
                for (int j = 0; j < capacity; ++j)
                {
                    if (i % arr[j] == 0)
                    {
                        isPrime = 0;
                        break;
                    }
                        
                }
                if (isPrime == 1)
                {
                    arr[capacity++] = i;
                }
                
            }
            Console.WriteLine("Простые число до 255:");
            for(int k = 0; k < capacity; ++k)
            {
                Console.Write($"{arr[k]} ");
            }
            Console.WriteLine();

            // Число простое?

            Console.WriteLine("Введите целое положительное число больше 1, которое хотите проверить:");
            uint num = (uint)Convert.ToInt32(Console.ReadLine());
            bool isP = isPrime(num);
            Console.WriteLine(isP ? $"Число {num} простое" : $"Число {num} не простое");
            Console.ReadKey();
        }
        static bool isPrime (uint n)
        {
            var result = true;
            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
            /*
            int last = (int)Math.Sqrt(n);
            for(int i = 1; i < last; ++i)
            {
                if (n % i == 0)
                {
                    return 0;
                }
            }
            return 1;*/
        }
    }
}
