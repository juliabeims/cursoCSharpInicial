using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos, pode entrar");
            }
            else{
                if(quantidadePessoas > 1)
                {
                    Console.WriteLine("João está acompanhado, pode entrar");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18, não pode entrar");
                }
                
            }




            Console.ReadLine();
        }
    }
}
