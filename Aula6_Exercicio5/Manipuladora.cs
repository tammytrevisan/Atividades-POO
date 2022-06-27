using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6_Exercicio5
{
    internal class Manipuladora
    {
        public string Nome;
        
        public void Abreviar ()
        {

            Console.WriteLine("Qual seu nome completo? ");
            Nome = Console.ReadLine();
            string[] separa = Nome.Split(' '); // separa a string pelo espaço e coloca em um vetor

            foreach (string sep in separa) // varrendo array
            {
                if (sep.Length < 3)
                {
                    Console.Write($"{sep.Substring(0, 2)} "); // determina posição dos caracteres da palavra
                }
                else
                {
                    Console.Write($"{sep.Substring(0, 1)}. ");
                }
            }
                       
        }

        public void inverte()
        {
            Console.WriteLine("\n\nEscreva uma palavra: ");
            string palavra = Console.ReadLine();

            string invertendo = new string (palavra.Reverse().ToArray());
            Console.WriteLine(invertendo);
        }
        public void contarVogaiseConsoantes()
        {
            Console.WriteLine("\n\nEscreva uma palavra: ");
            string palavra = Console.ReadLine();
            int caracterTotal = palavra.Count();
            int vogais = palavra.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'));
            int consoantes = caracterTotal - vogais;
            Console.WriteLine($"\nA palavra {palavra} possui {vogais} vogais e {consoantes} consoantes");
        }

    }
}
