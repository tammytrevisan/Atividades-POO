namespace Aula6_Exercicio2
{
    /*A fim de representar empregados em uma empresa, crie uma classe chamada Empregado 
     * que inclui os seguintes atributos; nome, cargo e salário mensal.
Sua classe deve ter um construtor que inicializa os três atributos e também fornecer 
    métodos que executem as seguintes ações:
Se o salário mensal não for positivo, configure-o como 0.0.
Conceder aumento de salários a seus funcionários de acordo com os dados abaixo: 
    Salário de 0 até 400.00 ganha 15% 
    Salário de 400.01 até 800.00 ganha 12% 
    Salário de 800.01 até 1200.00 ganha 10% S
    alário de 1200.01 até 2000.00 ganha 7% 
    Acima de 2000.00 ganha 4%
Imprimir o salário de um funcionário*/
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