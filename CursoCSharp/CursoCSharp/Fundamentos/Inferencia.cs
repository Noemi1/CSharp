using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
	class Inferencia
	{
		static void Executar()
		{
			var nome = "Leonardo";
			//nome = 123; //Reatribuir com outro tipo

			//var idade; //tipos implicitos devem ser inicializadosx
			var idade = 52;
			Console.WriteLine(idade);
			Console.ReadLine();
		}
	}
}
