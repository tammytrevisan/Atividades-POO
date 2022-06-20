using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6_Exercicio2
{
    internal class Empregado
    {
        public string nome;
        public string cargo;
        public double salario;  
        //construtor
        public void DadosEmpregado(double salario, string nome, string cargo)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        public double AumentoSalario(double salario)
        {
            if (salario <= 0)
            {
                return 0.0;
            }
            else if (salario >= 0 && salario <= 400)
            {
                salario = (salario * 0.15)+salario;
                return salario;
            }
            else if (salario > 400 && salario <= 800)
            {
                salario = (salario * 0.12)+salario;
                return salario;
            }
            else if (salario > 800 && salario <= 1200)
            {
                salario = (salario * 0.10)+salario;
                return salario;
            }
            else if (salario > 1200 && salario <= 2000)
            {
                salario = (salario * 0.07)+salario;
                return salario;
            }
            else if (salario > 2000)
            {
                salario = (salario * 0.04)+salario;
                return salario; 
            }
            else
            {
                return 0.0;
            }
        }
        public void Imprimir(double salario)
        {
            Console.WriteLine($"Seu aumento foi de {salario.ToString("F2")}");
        }
    }
}
