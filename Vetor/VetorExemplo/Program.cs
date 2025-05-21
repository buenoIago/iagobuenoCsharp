using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetn = new string[3];

            //vetn[0] = "iago";
            //vetn[1] = "andre";
            //vetn[2] = "william";

            Console.WriteLine("Informe o primeiro nome: ");
            vetn[0] = Console.ReadLine();
            Console.WriteLine("Informe o segundo nome: ");
            vetn[1] = Console.ReadLine();
            Console.WriteLine("Informe o terceiro nome: ");
            vetn[2] = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine("APRESENTANDO OS VALORES DO VETOR");
            Console.WriteLine(" ");
            Console.WriteLine("o primeiro nome é: " + vetn[0]);
            Console.WriteLine("o segundo nome é: " + vetn[1]);
            Console.WriteLine("o terceiro nome é: " + vetn[2]);
        }
    }
}
