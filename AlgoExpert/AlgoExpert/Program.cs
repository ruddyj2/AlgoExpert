using NUnit.Framework;
using System;
using System.Linq;
namespace AlgoExpert
{
    class Program
    {

        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            var nums = new System.Collections.Generic.List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && array[i] + array[j] == targetSum)
                    {
                        if (!nums.Contains(array[i]))
                        {
                            nums.Add(array[i]);
                        }
                        if (!nums.Contains(array[j]))
                        {
                            nums.Add(array[j]);
                        }
                    }
                }
            }
             return nums.ToArray();
        }

        static void Main(string[] args)
        {
            var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 15 };
            var targetsum = 18;

            var output = TwoNumberSum(array, targetsum);
            Console.WriteLine("[" + String.Join(",", output) + "]");
        }
    }
}


