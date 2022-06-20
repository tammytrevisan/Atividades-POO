namespace Aula6_Exercicio1
{
    /*ATIVIDADE DESENVOLVIDA NO SABADO(18/06) - DURANTE A AULA COM O PROFESSOR
     * NÃO FINALIZADO EM 4 HORAS DE AULA;
     * 
     * 1. Jogo da Velha
Lembra do nosso jogo da velha da aula de matrizes? Vamos refazê-lo orientado a objetos?
Crie uma classe para o Jogo da Velha:
A classe deve conter como dados privados uma matriz 3x3 para representar a grade do jogo
O construtor deve inicializar a matriz vazia
Forneça um método para exibir a matriz com status do jogo
Permita dois jogadores humanos
Forneça um método para jogar o jogo; todo movimento deve ocorrer em uma casa vazia; 
    depois de cada movimento valide se uma vitória ou um empate.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            jogodavelha jogodavelha = new jogodavelha(); // chamando a class
        }
    }
}