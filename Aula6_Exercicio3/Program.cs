namespace Aula6_Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatura Cartão");

            Fatura fatura = new Fatura();
            fatura.Numero = 1;
            fatura.DescProdutos = "Bola";
            fatura.Qtde = 10;
            fatura.Preco = 12;

            fatura.Calcular(fatura.Qtde, fatura.Preco);

        }
    }
}