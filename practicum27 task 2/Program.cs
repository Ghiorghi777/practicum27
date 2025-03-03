using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum27_task_2
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int n = 10; // Размер массива
            int[] array = new int[n];

            // Заполняем массив случайными числами от 1 до 100
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(1, 101);
            }

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            // Пузырьковая сортировка
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Обмен элементов
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                    Console.Read();
                }
            }
        }
    }
} 
