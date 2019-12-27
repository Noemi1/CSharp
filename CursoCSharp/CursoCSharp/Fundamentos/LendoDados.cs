using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;//Ignorar o contexto de virgula ou ponto

namespace CursoCSharp.Fundamentos
{
	class LendoDados
	{
		public static void Executar()
		{
			Console.WriteLine("Qual é o seu nome? ");
			var nome = Console.ReadLine();

			Console.WriteLine("Qual é sua idade? ");
			var idade = int.Parse(Console.ReadLine());

			Console.WriteLine("Qual é o salário que deseja? ");
			var salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.WriteLine($"Nome: {nome}, Idade: {idade}, Pretensão Salarial: {salario}");
			Console.ReadLine();
		}

	}
}
