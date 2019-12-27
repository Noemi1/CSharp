using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
	class VariaveisEConstantes
	{
		public static void Executar()
		{
			double raio = 4.5;
			const double pi = 3.14;
			const string raioStr = "4.5";
			var oi = raio + Convert.ToDouble(raioStr);
			double area = pi * raio * raio;
			Console.WriteLine("Area: " + area);
			
			Console.WriteLine();
			decimal decMax = decimal.MaxValue;
			Console.WriteLine("decMax: " + decMax);
			decimal decMin = decimal.MinValue;
			Console.WriteLine("decMin: " + decMin);

			Console.WriteLine();
			short numShortMax = short.MaxValue;
			Console.WriteLine("numShortMax: " + numShortMax);
			short numShortMin = short.MinValue;
			Console.WriteLine("numShortMin: " + numShortMin);

			Console.WriteLine();
			byte byteMax = byte.MaxValue;
			Console.WriteLine("byteMax: " + byteMax);
			byte byteMin = byte.MinValue;
			Console.WriteLine("byteMin: " + byteMin);

			Console.WriteLine();
			int intMax = int.MaxValue;
			Console.WriteLine("intMax: " + intMax);
			int intMin = int.MinValue;
			Console.WriteLine("intMin: " + intMin);
			
			Console.ReadLine();


		}
	}
}
