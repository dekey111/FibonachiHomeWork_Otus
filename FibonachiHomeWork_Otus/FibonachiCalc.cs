using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiHomeWork_Otus
{
    class FibonachiCalc
    {
        /// <summary>
        /// Рекурсивный метод для вычисления числа Фибоначчи
        /// </summary>
        /// <param name="n">Принимает значение фибоначчи</param>
        /// <returns>Возвращает число фибоначчи</returns>
        public int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        /// <summary>
        /// Итеративный метод для вычисления числа Фибоначчи
        /// </summary>
        /// <param name="n">Принимает значение фибоначчи</param>
        /// <returns>Возврвщает число фибоначчи</returns>
        public int FibonacciIterative(int n)
        {
            if (n <= 1)
                return n;

            int a = 0, b = 1, temp;

            for (int i = 2; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }

        /// <summary>
        /// Метод для измерения времени выполнения функциции
        /// </summary>
        /// <param name="action"></param>
        /// <returns>Возврашает время выполнения</returns>
        public TimeSpan MeasureExecutionTime(Func<int> action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
    }
}
