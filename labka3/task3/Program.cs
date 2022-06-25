using System;
using System.Linq;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 78, 11, 13, 5, 225 };
            int tvir = list.Aggregate(seed: 1, func: (result, item) => result * (item % 10)); 
            Console.WriteLine("Твiр останнiх цифр елементiв послiдовностi: " + tvir);
        }
    }
}
