using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 7, 3, 4, 9, 2, 5 };
            int[] sortedOddArr = arr.Where(x => x % 2 != 0).OrderByDescending(x => x).ToArray();
        }
    }
}
