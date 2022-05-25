using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - caracteres e textos");

            char primeiraLetra = 'a';//aspas simples para caracter e aspas duplas para texto
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65; //retornará a letra "A", póis é o que o valor representa
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1); //primeiro faz a soma e depois transforma em char
            Console.WriteLine(primeiraLetra);

            double numero = primeiraLetra + 1; //retorna 67
            Console.WriteLine(numero);

            string titulo = "CURSOS " + 2022; //tudo vira string
            Console.WriteLine(titulo);

            string cursosProgramacao = @" - .NET 
                 - JAVA 
                 - JAVASCRIPT";

            Console.WriteLine(cursosProgramacao);
            

            Console.ReadLine();
        }
    }
}
