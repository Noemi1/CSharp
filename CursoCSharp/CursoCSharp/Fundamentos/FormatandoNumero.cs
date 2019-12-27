using System;
using System.Globalization;//Ignorar o contexto de virgula ou ponto


namespace CursoCSharp.Fundamentos
{
	class FormatandoNumero
	{
		public static void Executar()
		{
			double valor = 15.155; 
			Console.WriteLine(valor);
			Console.WriteLine(valor.ToString("f1"));//Float com uma casa decimal
			Console.WriteLine(valor.ToString("C"));  //valor para Moeda atual (varia de acordo com a linguagem do sistema)
			Console.WriteLine(valor.ToString("P")); //percentual
			Console.WriteLine(valor.ToString("#.###"));

			CultureInfo cultura = new CultureInfo("pt-BR");
			Console.WriteLine(valor.ToString("C2"));

			Console.ReadLine();


		}
	}
}
