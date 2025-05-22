using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroJogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetJ = new string[3];
            do
            {
                Console.Clear();
                //menu
                Console.WriteLine(@"
█▀▀ ▄▀█ █▀▄ ▄▀█ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   ░░█ █▀█ █▀▀ █▀█ █▀
█▄▄ █▀█ █▄▀ █▀█ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄█ █▄█ █▄█ █▄█ ▄█");
                Console.WriteLine("1 - cadastrar");
                Console.WriteLine("2 - consultar");
                Console.WriteLine("3 - atualizar");
                Console.WriteLine("4 - excluir");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    for (int i = 0; i < vetJ.Length; i++)
                    {
                        Console.WriteLine($"informe o {i + 1}° nome: ");
                        vetJ[i] = Console.ReadLine();
                    }
                    Console.WriteLine("Para continuar, pressione a tecla enter");
                    Console.ReadKey();
                }
                else if (opcao == 2)
                {
                    for (int i = 0; i < vetJ.Length; i++)
                    {
                        Console.WriteLine($"posição: {i} | nome do jogo: {vetJ[i]} ");
                    }
                    Console.WriteLine("Para continuar, pressione a tecla enter");
                    Console.ReadKey();
                }
                else if (opcao == 3)
                {
                    for (int i = 0; i < vetJ.Length; i++)
                    {
                        Console.WriteLine($"informe o jogo que deseja atualizar: {i}");
                        Console.ReadKey();
                    }
                }
                else if (opcao == 4)
                {

                }
            } while (true);
        }
    }
}
