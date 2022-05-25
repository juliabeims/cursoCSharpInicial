using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executar o projeto 4");


            double salario = 1200.50;

            int salarioEmInteiro = (int)salario; //o int suporta até 32 bits

            Console.WriteLine(salarioEmInteiro);

            //o long é uma variavel de 64 bits
            long idade = 1300000000000000;

            Console.WriteLine(idade);

            short quantidadeProduto = 150;//o short suporta 16 bits

            Console.WriteLine(quantidadeProduto);

            float altura = 1.80f; //incomum de usar

            Console.WriteLine(altura);

            /*
            int teste = 10;
            double testeDouble = teste;
            Console.WriteLine("teste double é " + testeDouble);
            */

            double teste = 10.0;
            int testeInt = (int)teste;
            Console.WriteLine(testeInt);
            Console.ReadLine();
        }
    }
}
