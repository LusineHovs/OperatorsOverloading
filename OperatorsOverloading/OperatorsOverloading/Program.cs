using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector1 = new Vector(9);
            Vector vector2 = new Vector(10);
            Vector vectorSum = vector1 + vector2;
            Vector vectorProduct = vector1 * vector2;
            Console.WriteLine($"The sum of two vectors = {vectorSum}.");
            Console.WriteLine($"The sum of two vectors = {vectorProduct}.");
        }
    }
}
