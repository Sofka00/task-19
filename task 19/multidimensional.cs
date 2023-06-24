using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace task_19
{
    internal class multidimensional
    {
        public static int[,] Generatot(int n, int min, int max)
        {
            int[,] array = new int[n, n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(min, max);
                }
            }
            return array;
        }

        public static int MinElement(int[,] array)
        {
            int min = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }

        public static int MaxElement(int[,] array)
        {
            int max = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }

        public static string MinIndex(int[,] array)
        {
            int min = array[0, 0];
            string index = "";

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        index = $"{i} {j}";
                    }
                }
            }
            return index;
        }

        public static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}");
                }
                Console.WriteLine();
            }
        }

        public static string MaxIndex(int[,] array)
        {
            int max = array[0, 0];
            string index = "";

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        index = $"{i} {j}";
                    }
                }
            }
            return index;
        }

        public static int NeighboringLargest(int[,] array)
        {
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLongLength(1); j++)
                {
                    if (j == 0 && i == array.GetLength(0) - 1)
                    {
                        count++;
                        continue;
                    }

                    if (j == 0)
                    {
                        if (array[i, j] > array[i + 1, j])
                        {
                            count++;
                        }

                        continue;
                    }

                    if (i == array.GetLength(0) - 1)
                    {
                        if (array[i, j] > array[i, j - 1])
                        {
                            count++;
                        }

                        continue;
                    }

                    if (array[i, j] > array[i + 1, j])
                    {
                        if (array[i, j] > array[j, j - 1])
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
