using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged2darray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][,] jaggedArray = new int[3][,]
            {
                new int[,] {{1,8},{6,9}},
                new int[,]{{3,10},{5,6},{9,10}},
                new int[,]{{11,34},{100,88},{90,10}}
            };
            Console.WriteLine(jaggedArray[0][0, 1]);
            Console.WriteLine(jaggedArray[1][2, 1]);
            Console.WriteLine(jaggedArray[2][1, 0]);
            Console.ReadLine();
        }
    }
}
