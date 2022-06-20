using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6_Exercicio4
{
    internal class Sorteio
    {
        public int numeroComputador;
        public int palpite;
        
        public void Palpite()
        {
            Console.WriteLine("Vamos começar!");

            Random rand = new Random();
            numeroComputador = rand.Next(0, 1000);
            

            for (int i = 0; i < 1500; i++) 
            {
                    Console.Write("\nQual seu palpite com um número entre 0 e 1000: ");
                    int palpite = int.Parse(Console.ReadLine());
                    if (palpite == numeroComputador)
                {
                    Console.WriteLine($"Parabéns o número gerado pelo computador é {numeroComputador}");
                }
                    else if (palpite > numeroComputador)
                {
                    Console.WriteLine("\tSeu palpite foi maior. Tente um novo!");
                }
                else if (palpite < numeroComputador)
                {
                    Console.WriteLine("\tSeu palpite foi menor. Tente outro!");
                }
                    else
                {
                    Console.WriteLine("\tOpção inválida");
                }

                Console.WriteLine($"Número de tentativas: {i+1}");
                
                Console.Write("\nSe desejar para digite: 'P' para parar ");
                string sair = Console.ReadLine(); 
                
                 if (sair.ToUpper() == "P")
                {
                    i = 1600;
                }

            }
            Console.WriteLine($"O número gerado pelo computador é {numeroComputador}");
        }
    }
}
