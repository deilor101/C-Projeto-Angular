using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionários
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; } 
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; } 

        public virtual double GetBonificacao()
        {
            return this.Salario * 0.10;
        }

        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;
            this.Cpf = cpf; 
            TotalDeFuncionarios++;
            Console.WriteLine("Criando um funcionário");
        }

        public virtual void AumentarSalario()
        {
            this.Salario = this.Salario + (this.Salario * 0.1);
        }
        
    }
}
