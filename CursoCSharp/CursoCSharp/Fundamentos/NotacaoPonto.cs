using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
	class NotacaoPonto
	{
		public static void Executar()
		{
			var saudacao = "Hello".Insert(5, " Mundo!").Replace("Mundo", "World").ToUpper();
			Console.WriteLine(saudacao);
			Console.ReadLine();
		}
	}
}
