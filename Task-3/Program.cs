/*-------------------------------------------------------------------------------------------------------------------
Задайте одномерный массив из 15 случайных чисел. Найдите количество элементов массива, значения которых 
лежат в отрезке [10,99].
-------------------------------------------------------------------------------------------------------------------*/

using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Console.Write("Please enter aray size: ");
            int size = 15;//GetNumber();

            //Console.Write("Please enter min range: ");
            int min = -100;//GetNumber();

            //Console.Write("Please enter max range: ");
            int max = 100;//GetNumber();

            int[] arr=CreateArray(size, min, max);
            PrintArray(arr);

            Console.WriteLine($"{CountRange(arr, 10, 99)} numbers in range [10,99] found in array");
            Console.WriteLine($"{CountRange1(arr, 10, 99)} numbers in range [10,99] found in array");

        }
        static int GetNumber() => Convert.ToInt32(Console.ReadLine());
        static Random rd => new Random();
        static int[] CreateArray(int len, int min, int max) => Enumerable.Range(1, len).Select(x => rd.Next(min,max+1)).ToArray();
        static void PrintArray(int[] numbers) => Console.WriteLine("[" + string.Join(" ", numbers.Select(x => x)) + "]");
        static int CountRange(int[] arr, int min, int max)
        {
            int count = 0;
            foreach (int x in arr)
            {
                if(x>=10 && x<=99)
                    count++;
            }
            return count;
        }
        static int CountRange1(int[] arr, int min, int max) => arr.Aggregate(0, (a,x) => a+=(x>=min&&x<=max)?1:0);
        
    }
}
