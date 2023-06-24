using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = multidimensional.Generatot(5,1,10);
            for (int i = 0;i < c.GetLength(0); i++) 
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write($"{c[i,j]} ");

                }
                Console.WriteLine();
            }

            var x = multidimensional.NeighboringLargest(c);

            Console.WriteLine(x);
           Console.ReadLine();



        }
    }
}
