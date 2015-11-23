using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please,enter two numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
