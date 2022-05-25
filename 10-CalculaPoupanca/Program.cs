using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando projeto 10 - calculo poupança");

            int n = 1;
            double valorInvestido = 1000;
            
            while (n <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                if (n == 1) {
                    Console.WriteLine("após " + n + " mês você terá R$" + valorInvestido);
                }
                else { Console.WriteLine("após " + n + " meses você terá R$" + valorInvestido);
                }
       
                n++;
            }

            Console.ReadLine();
        }
    }
}
