namespace Aula6_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salário Atualizado");


            Empregado empregado = new Empregado();
            Console.Write("Informe o nome do empregado: ");
            empregado.nome = Console.ReadLine();
            Console.Write("Informe seu cargo: ");
            empregado.cargo = Console.ReadLine();
            Console.Write("Informe seu salário: ");
            empregado.salario = double.Parse(Console.ReadLine());

            empregado.salario = empregado.AumentoSalario(empregado.salario);

            empregado.Imprimir(empregado.salario);
        }
    }
}