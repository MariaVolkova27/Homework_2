using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дан двумерный массив.
            
            732
            496
            185

            Отсортировать данные в нем по возрастанию.

            123
            456
            789

            Вывести результат на печать.*/

            int[,] array = new int[,] { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

            int[] new_array = new int[array.GetLength(0)* array.GetLength(1)];

            for (int i = 0; i < array.GetLength(0); i++) // делаем из двумерного массива одномерный
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    new_array[i * array.GetLength(1) + j] = array[i, j];
                }
            }

            for (int i = 0; i < new_array.Length; i++) // сортировка массива по возрастанию пузырьковым методом
            {
                for (int j = 0; j < new_array.Length - 1 - i; j++)
                {
                    if (new_array[j] > new_array[j + 1])
                    {
                        int temp = new_array[j];
                        new_array[j] = new_array[j + 1];
                        new_array[j + 1] = temp;
                    }
                }
            }

            int[,] array_sorted = new int[array.GetLength(0), array.GetLength(1)];

            for (int i = 0; i < new_array.Length; i++) // делаем из одномерного массива двумерный
            {
                array_sorted[i / array.GetLength(0), i % array.GetLength(0)] = new_array[i];
            }

            for (int i = 0; i < array_sorted.GetLength(0); i++) // выводим отсортированный массив на печать
            {
                for (int j = 0; j < array_sorted.GetLength(1); j++)
                {
                    Console.Write(array_sorted[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
