using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11_CalculaPoupanca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando projeto 11");

            double valorInicial = 1000;

            for(int i = 1; i <=12; i++)
            {
                valorInicial = valorInicial + valorInicial * 0.0036;
                if(i == 1)
                {
                    Console.WriteLine("Após 1 mês você terá R$" + valorInicial);
                }
                else
                {
                    Console.WriteLine("Após " + i + " meses você terá R$" + valorInicial);
                }

            }


            Console.ReadLine();
        }
    }
}
