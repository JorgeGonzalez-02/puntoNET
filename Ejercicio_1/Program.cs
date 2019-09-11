
using System;

namespace Ejercicio_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			double num1,num2;
			int opciones;
			
			Console.Write("Digite el numero: ");
			num1  = Double.Parse(Console.ReadLine());
			
			Console.Write("Digite el segundo numero: ");
			num2  = Double.Parse(Console.ReadLine());
			
			Console.WriteLine ("las opciones son: ");
			Console.WriteLine ("1 - Adicion");
			Console.WriteLine ("2 - Sustracion");
			Console.WriteLine ("3 - Multiplicacion");
			Console.WriteLine ("4 - DIvision");
			
			Console.Write("Digite su opcion: ");
			opciones = int.Parse(Console.ReadLine());
			
			if (opciones == 1)
			{
				Console.WriteLine( "La suma de los dos numeros es: "+  (num1 + num2));
			}
			if (opciones == 2) 
			{
				Console.WriteLine( "La resta de los dos numeros es: "+  (num1 - num2));
			}
			if (opciones == 3) 
			{
				Console.WriteLine( "La multiplicacion de los dos numeros es: "+  (num1 * num2));
			}
			if (opciones == 4) 
			{
				Console.WriteLine( "La division de los dos numeros es: "+  (num1 / num2));
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}