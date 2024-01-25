using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqq
{
    class TwoDimensionalArray
    {
        private int[,] array;

        public TwoDimensionalArray(int rows, int cols, bool userInput = false)
        {
            array = new int[rows, cols];
            if (userInput)
            {
                FillArrayUserInput();
            }
            else
            {
                FillArrayRandom();
            }
        }

        public void FillArrayUserInput()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"Введите элемент под номером ({i}, {j}): ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void FillArrayRandom()
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(-1000, 1001);
                }
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void PrintEvenReversedRows()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = array.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                else
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public void CalculateAverage()
        {
            double b = 0;
            double sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            b = sum / array.Length;
            Console.WriteLine(b);

        }
    }
}
