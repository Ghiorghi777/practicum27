using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum27
{
    internal class Program
    {
        static void Main()
        {
            //Console.Write("Введите количество элементов массива: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            //// Заполнение массива
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Введите элемент {i + 1}: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //// Вывод в обратном порядке с помощью for
            //Console.WriteLine("Массив в обратном порядке:");
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.Read();
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            // Заполнение массива
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            // Переворачиваем массив
            Array.Reverse(array);

            // Выводим перевернутый массив
            Console.WriteLine("Массив в обратном порядке:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.Read();
        }
    }
}
