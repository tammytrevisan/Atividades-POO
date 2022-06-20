using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6_Exercicio1
{
    internal class jogodavelha
    {
        private string[,] Tabuleiro = new string[3, 3];

        int Contador = 0; // qtde de jogadas, máximo 9

        private string JogadorX;
        private string Jogador0;

        public bool Turno = true;
        public jogodavelha() // construtora
        {
            JogadorX = string.Empty;
            Jogador0 = string.Empty;

            IniciarJogo();

        }

        private void IniciarJogo()
        {


            Console.WriteLine("Jogo da Velha");

            Console.WriteLine("Digite o nome do Jogador 1 - X: ");
            JogadorX = Console.ReadLine();

            Console.WriteLine("Digite o nome do Jogador 2 - 0: ");
            Jogador0 = Console.ReadLine();


            // Desenha o tabuleiro com as posições determinadas
            Preencher();
            ApresentarTabuleiro();

            /// vai mostrar o tabuleiro e chamar a jogada
            Jogada();

        }
        private void ApresentarTabuleiro()
        {
            Console.Clear();

            Console.WriteLine($"Competidores: \n\tX {JogadorX} \n\t0 {Jogador0} ");

            Console.WriteLine();
            Console.WriteLine($"    {Tabuleiro[2, 0]}         |       {Tabuleiro[2, 1]}        |       {Tabuleiro[2, 2]}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"    {Tabuleiro[1, 0]}         |       {Tabuleiro[1, 1]}        |       {Tabuleiro[1, 2]}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"    {Tabuleiro[0, 0]}         |       {Tabuleiro[0, 1]}        |       {Tabuleiro[0, 2]}");
            Console.WriteLine();


        }

        private void Preencher()
        {

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    /*
                    // linha 1
                    Tabuleiro[0, 0] = "7";
                    Tabuleiro[0, 1] = "8";
                    Tabuleiro[0, 2] = "9";
                    // linha 2
                    Tabuleiro[1, 0] = "4";
                    Tabuleiro[1, 1] = "5";
                    Tabuleiro[1, 2] = "6";
                    // linha 3
                    Tabuleiro[2, 0] = "1";
                    Tabuleiro[2, 1] = "2";
                    Tabuleiro[2, 2] = "3";
                    */

                    Contador++;
                    Tabuleiro[linha, coluna] = Convert.ToString(Contador);
                }
            }
        }

        private bool Vencedor()
        {
            return false;
        }
        private void Jogada()
        {
            /*bool Limite = Contador > 0;
            bool Fim = Vencedor() || Limite;*/

            while (Contador > 0)
            {
                Console.WriteLine($"Jogador {Turno} - Informe a posição desejada");
                bool ValidarEntrada = int.TryParse(Console.ReadLine(), out int EscolhadoJogador);

                if (ValidarEntrada)
                {
                    switch (EscolhadoJogador)
                    {
                        case 7:
                            Tabuleiro[2, 0] = Turno ? "O" : "X";
                            Contador--;
                            ApresentarTabuleiro();
                            Turno = !Turno;// mudando o turno
                            break;
                        case 8:
                            Tabuleiro[2, 1] = Turno ? "O" : "X";
                            Contador--;
                            ApresentarTabuleiro();
                            Turno = !Turno;
                            break;
                        case 9:
                            Tabuleiro[2, 2] = Turno ? "O" : "X";
                            Contador--;
                            ApresentarTabuleiro();
                            Turno = !Turno;
                            break;
                        case 4:
                            Tabuleiro[1, 0] = Turno ? "O" : "X";
                            Contador--;
                            ApresentarTabuleiro();
                            Turno = !Turno;
                            break;
                        case 5:
                            Tabuleiro[1, 1] = Turno ? "O" : "X";
                            Contador--;
                            ApresentarTabuleiro();
                            Turno = !Turno;
                            break;
                        case 6:
                            Tabuleiro[1, 2] = Turno ? "O" : "X";
                            Contador--;
                            ApresentarTabuleiro();
                            Turno = !Turno;
                            break;
                        case 1:
                            Tabuleiro[0, 0] = Turno ? "O" : "X";
                            Contador--;
                            ApresentarTabuleiro();
                            Turno = !Turno;
                            break;
                        case 2:
                            Tabuleiro[0, 1] = Turno ? "O" : "X";
                            Contador--;
                            ApresentarTabuleiro();
                            Turno = !Turno;
                            break;
                        case 3:
                            Tabuleiro[0, 2] = Turno ? "O" : "X";
                            Contador--;
                            ApresentarTabuleiro();
                            Turno = !Turno;
                            break;

                        default:
                            Console.WriteLine("Posição Inválida. Entre com uma nova posição: ");
                            break;
                    }
                }
            }
            Console.WriteLine("Fim das Jogadas!");
        }
    }


}