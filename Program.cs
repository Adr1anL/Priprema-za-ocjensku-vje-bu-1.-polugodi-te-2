using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pppzv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi recenicu: ");

            string[] x = Console.ReadLine().Split(' ');

            Console.WriteLine(x[0]);
            Console.WriteLine(x[x.Length - 1]);

            Console.ReadKey();
        }
    }
}
