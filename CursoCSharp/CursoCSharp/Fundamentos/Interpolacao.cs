using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
	class Interpolacao
	{
		public static void Executar()
		{
			string nome = "Noemi";
			string sobreNome = "Cavalcanti";

			Console.WriteLine("O segundo nome da {0} é {1} ", nome, sobreNome);
			Console.WriteLine($"Nome: {nome}, Sobrenome: {sobreNome}.");
			Console.WriteLine($"1 + 1 = {1 + 1}");



			Console.ReadLine();
		}
	}
}
