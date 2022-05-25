using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - escopo");

            int idadeJoao = 16;
            bool acompanhado = false;
            string mensagemAdicional;

            if (acompanhado)
            {
                mensagemAdicional = "João está acompanhado";
            }
            else
                mensagemAdicional = "João não está acompanhado";

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("João pode entrar. " + mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João não pode entrar. " + mensagemAdicional);
            }




            Console.ReadLine();
        }
    }
}
