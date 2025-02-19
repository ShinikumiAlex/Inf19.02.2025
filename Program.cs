using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf19._02._2025_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] mas = new int[10];
                Output(mas);
                Console.ReadKey();
            }
        }
        static int RandomValue()
        {
            return new Random().Next(-10, 11);
        }

        static void Output(int[] omas)
        {
            for (int i = 0; i < omas.Length; i++)
            {
                Random rnd = new Random();
                omas[i] = rnd.Next(-10, 10);
                Console.WriteLine($"mas[{i}] = {omas[i]} ");
            }
        }
    }
}
