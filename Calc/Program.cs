using System;

namespace Calc
{
    class Program
    {
        /*Небольшой калькулятор, в котором реализованы различные простые циклы и алгоритмы*/
        static void Main(string[] args)
        {
            //инициализируем переменные для хранения
            float num1;
            char sing;
            float num2;
            float result = 0.0f;

            //Запрашиваем числа и знак
            Console.WriteLine("Введите первое целое число:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите знак: (+, -, /, *)");
            sing = Convert.ToChar(Console.ReadLine());
            if(sing == '/') //если знак "деление", то всегда второе число должно быть больше 0
            {
                do
                {
                    Console.WriteLine("Введите второе число больше 0");
                    num2 = float.Parse(Console.ReadLine()); ;
                }
                while (num2 == 0);
            }
            else
            {
                Console.WriteLine("Введите второе целое число:");
                num2 = float.Parse(Console.ReadLine());
            }
            switch (sing) //подсчет результата
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine($"Результат {num1}{sing}{num2}={result}");
        }
    }
}
