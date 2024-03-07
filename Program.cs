using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_10001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = Int32.Parse(System.Console.ReadLine().Trim());
            int B = Int32.Parse(System.Console.ReadLine().Trim());
            int X = A + B;
            Console.Write("X = {0}\n", X);
            Console.ReadLine();
        }
    }
}
