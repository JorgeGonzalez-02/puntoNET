
using System;

namespace Ejercicio_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			double n,fn;
			Console.Write("Digite el valor de n: ");
			n = double.Parse(Console.ReadLine());
			
			fn = (1/Math.Sqrt(5)) * (Math.Pow(((1+Math.Sqrt(5))/2),n) - Math.Pow(((1-Math.Sqrt(5))/2),n));
			
			Console.WriteLine("El resulatdo de la formula es: "+fn);

			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}