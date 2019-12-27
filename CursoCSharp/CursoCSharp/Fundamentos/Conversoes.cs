using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
	class Conversoes
	{
		public static void Executar()
		{
			int inteiro = 10;
			double quebrado = inteiro;
			Console.WriteLine("Conversão de int para double ocorre implicitamente");

			double bubble = 10;
			int toint = (int)bubble;
			Console.WriteLine("Conversão de int para double não ocorre implicitamente");

			Console.WriteLine("Digite sua idade");
			string idadeStr = Console.ReadLine();
			int idadeInt = int.Parse(idadeStr);
			Console.WriteLine($"Idade: {idadeInt}");

			Console.WriteLine("Digite um numero");
			string palavra = Console.ReadLine();
			int numero;
			int.TryParse(palavra, out numero);
			Console.WriteLine($"Numero: {numero}");

			Console.Write("Digite um numero1  ");
			int.TryParse(Console.ReadLine(), out int numero1);
			Console.WriteLine($"Numero1: {numero1}");

			Console.ReadLine();
		}
	}
}
