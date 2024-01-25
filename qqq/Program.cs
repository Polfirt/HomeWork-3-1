using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Если хотите ввести сами, напишитие 'true'. Если же Вам лень, пишите 'false'.");
            bool f = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину списка");
            int a = int.Parse(Console.ReadLine());
            OneDimensionalArray oneDArray = new OneDimensionalArray(a, f);
            Console.WriteLine("\nДля двумерных массивов введите количество рядов и столбцов");
            int d = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            TwoDimensionalArray twoDArray = new TwoDimensionalArray(d, c, f);
            Console.WriteLine("Сам двумерный массив:");
            twoDArray.PrintArray();
            Console.WriteLine("Среднее значение равно");
            twoDArray.CalculateAverage();
            Console.WriteLine("Реверснутый массив:");
            twoDArray.PrintEvenReversedRows();

            Console.WriteLine("Введите длину для трех массивов");
            int k = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int[] g = new int[] { k, m, l };
            JaggedArray jaggedArray = new JaggedArray(g, f);
            Console.WriteLine("Сам массив:");
            jaggedArray.PrintArray();
            Console.WriteLine($"Среднее значение: {jaggedArray.FindAverage()}");
            Console.WriteLine("Среднее значение во всех массивах:");
            double[] subArrayAverages = jaggedArray.FindAverageInEachSubArray();
            foreach (double average in subArrayAverages)
            {
                Console.WriteLine(average);
            }
        }
    }
}
