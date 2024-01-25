using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqq
{
    class OneDimensionalArray
    {
        private int[] array;


        public OneDimensionalArray(int size, bool userInput = false)
        {
            array = new int[size];
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
                array[i] = rand.Next(-1000, 1001);
            }
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;
            Console.WriteLine("Среднее значение: " + average);
            int[] newArray = new int[array.Length];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) <= 100)
                {
                    newArray[count] = array[i];
                    count++;
                }
            }
            Array.Resize(ref newArray, count);
            Console.WriteLine("Новый массив без элементов >100 по модулю:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }
            int[] uniqueArray = new int[array.Length];
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Array.IndexOf(uniqueArray, array[i], 0, count) == -1)
                {
                    uniqueArray[count] = array[i];
                    count++;
                }
            }
            Array.Resize(ref uniqueArray, count);
            Console.WriteLine("\nНовый массив после удаления повторов:");
            for (int i = 0; i < uniqueArray.Length; i++)
            {
                Console.Write(uniqueArray[i] + " ");
            }
        }


        public void FillArrayUserInput()
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            int[] array = Array.ConvertAll(inputArray, int.Parse);
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;
            Console.WriteLine("Среднее значение: " + average);
            int[] newArray = new int[array.Length];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) <= 100)
                {
                    newArray[count] = array[i];
                    count++;
                }
            }
            Array.Resize(ref newArray, count);
            Console.WriteLine("Новый массив без элементов >100 по модулю:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }
            int[] uniqueArray = new int[array.Length];
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Array.IndexOf(uniqueArray, array[i], 0, count) == -1)
                {
                    uniqueArray[count] = array[i];
                    count++;
                }
            }
            Array.Resize(ref uniqueArray, count);
            Console.WriteLine("\nНовый массив после удаления повторов:");
            for (int i = 0; i < uniqueArray.Length; i++)
            {
                Console.Write(uniqueArray[i] + " ");
            }
        }
    }
}
