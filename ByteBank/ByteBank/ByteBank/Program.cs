using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
			Funcionario carlos = new Funcionario();

			carlos.Nome = "Carlos";
			carlos.CPF = "124.155.066-21";
			carlos.Salario = 2000;

			gerenciador.Registrar(carlos);

			Console.WriteLine(carlos.Nome);
			Console.WriteLine(carlos.GetBonificacao());

			Diretor roberta = new Diretor();

			roberta.Nome = "Roberta";
			roberta.CPF = "156.665.461-55";
			roberta.Salario = 5000;

			gerenciador.Registrar(roberta);

			Console.WriteLine(roberta.Nome);
			Console.WriteLine(roberta.GetBonificacao());

			Console.WriteLine("Total de bonificacoes: " + gerenciador.GetTotalBonificacao());

			Console.ReadLine();
		}
	}
}
