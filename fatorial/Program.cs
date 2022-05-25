using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine("executando fatorial de " + n);
            for (int i = n-1; i>1;i--)
                n *= i;
            
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
