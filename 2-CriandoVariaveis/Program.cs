using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando projeto 2 - criando variáveis");

            int idade;
            idade = 32;

            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine("Sua idade é " + idade);



            Console.WriteLine("execução finalizada. tecle enter para sair");
            Console.ReadLine();
        }
    }
}
