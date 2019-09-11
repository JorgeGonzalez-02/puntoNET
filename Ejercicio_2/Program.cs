
using System;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			double bases,altura,radio;
			int opciones;

			Console.WriteLine("Programa para calcular el area de diferentes figuras geometricas: ");
			Console.WriteLine("------------------------------------------------------------------");
			
			Console.WriteLine("Opciones");
			Console.WriteLine("1- Area del circulo");
			Console.WriteLine("2- Area del rectangulo");
			Console.WriteLine("3- Area del triangulo");
			
			Console.Write("Digite la opcion: ");	
			opciones = int.Parse(Console.ReadLine());
			
			if (opciones == 1)
			{
				Console.Write("Digite el radio del circulo: ");
				radio = double.Parse(Console.ReadLine());
				Console.WriteLine("El area del circulo es: "+ (Math.PI*Math.Pow(radio,2)));
			}
			if (opciones == 2)
			{
				Console.Write("Digite la base del rectangulo: ");
				bases = double.Parse(Console.ReadLine());
				Console.Write("Digite la altura del rectangulo: ");
				altura = double.Parse(Console.ReadLine());
				Console.WriteLine("El area del rectangulo es: "+ (bases*altura));
			}
			if (opciones == 2)
			{
				Console.Write("Digite la base del rectangulo: ");
				bases = double.Parse(Console.ReadLine());
				Console.Write("Digite la altura del rectangulo: ");
				altura = double.Parse(Console.ReadLine());
				Console.WriteLine("El area del rectangulo es: "+ (bases*altura)/2);
			}
			 	
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}