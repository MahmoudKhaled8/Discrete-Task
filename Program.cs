using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discrete_project_2
{
    internal class Program
    {
        static bool IsPerfect(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0) sum = sum + i;
            }
            if (sum == num) return true;
            return false;
        }
        static void Main(string[] args)
        {
            int j, k;
            Console.WriteLine("Enter number :1");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number :2");
            k = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            for (int i=j; i<=k; i++)
            {
                if (IsPerfect(i)) Console.WriteLine("{0}",i);
            }
        }
    }
}
