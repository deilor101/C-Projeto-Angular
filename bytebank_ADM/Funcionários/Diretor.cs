using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionários
{
    public class Diretor: Funcionario
    {   
        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }

        public Diretor(string cpf, double salario): base(cpf, salario)
        {
            Console.WriteLine("Criando um diretor");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
