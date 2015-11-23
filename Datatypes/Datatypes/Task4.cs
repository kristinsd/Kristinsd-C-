using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    class Task4
    {
        Console.WriteLine("Please,enter the sides of your rectangle: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int S = a * b;
            Console.WriteLine("S of you rectangle  is: {0}",S);
    }
}
