using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqq
{
    class JaggedArray
    {
        private int[][] array;

        public JaggedArray(int[] lengths, bool userInput = false)
        {
            array = new int[lengths.Length][];
            for (int i = 0; i < lengths.Length; i++)
            {
                array[i] = new int[lengths[i]];
            }
            if (userInput)
            {
                FillArrayUserInput();
            }
            else
            {
                FillArrayRandom();
            }
        }

        public void FillArrayRandom()
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rand.Next(-1000, 1001);
                }
            }
        }

        public void FillArrayUserInput()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"Введите значение элемента [{i},{j}]: ");
                    array[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public double FindAverage()
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    count++;
                }
            }
            return sum / count;
        }

        public double[] FindAverageInEachSubArray()
        {
            double[] averages = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                double sum = 0;
                foreach (int num in array[i])
                {
                    sum += num;
                }
                averages[i] = sum / array[i].Length;
            }
            return averages;
        }

        public void MultiplyEvenElements()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] *= i * j;
                    }
                }
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(String.Join(" ", array[i]));
            }
        }
    }
}
