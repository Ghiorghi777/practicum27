using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum27_task_3
{
    internal class Program
    {
        static void Main()
        {
            // Явная инициализация массива
            int[] array = { 3, 8, 1, 9, 4, 7, 2, 5 };

            // Переменные для максимального и минимального элементов
            int max = array[0], min = array[0];
            int maxIndex = 0, minIndex = 0;

            // Поиск максимального и минимального элементов
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            // Вывод найденных значений
            Console.WriteLine($"Максимальный элемент: {max} (индекс {maxIndex})");
            Console.WriteLine($"Минимальный элемент: {min} (индекс {minIndex})");

            // Обмен местами максимального и минимального элементов
            int temp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = temp;

            // Вывод измененного массива
            Console.WriteLine("Массив после замены:");
            PrintArray(array);

            // Количество элементов между минимальным и максимальным
            int elementsBetween = Math.Abs(maxIndex - minIndex) - 1;
            Console.WriteLine($"Количество элементов между минимальным и максимальным: {elementsBetween}");
        }

        static void PrintArray(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.Write(num + " ");
                Console.WriteLine();
            }
            Console.Read();
        }
       
    }
}
