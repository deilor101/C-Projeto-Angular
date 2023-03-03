using bytebank_ADM.Funcionários;
using bytebank_ADM.Utilitario;

Funcionario pedro = new Funcionario("123456789", 2000);
pedro.Nome = "Pedro Silva";


Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor("987654321", 6000);
roberta.Nome = "Roberta Miranda";

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine("Total de bonificacoes: " + gerenciador.TotalDeBonificacao);
Console.WriteLine("Total de Funcionários: " + Funcionario.TotalDeFuncionarios);

pedro.AumentarSalario();
roberta.AumentarSalario();

Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);

Console.WriteLine("Novo salário da Roberta: " + roberta.Salario);



