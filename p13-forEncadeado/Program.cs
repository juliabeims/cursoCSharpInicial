using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13_forEncadeado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*
            //**
            //***
            //****
            //*****
            Console.WriteLine("Executando programa 13");

            for (int i = 1; i < 10; i++)
            {
                for(int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
