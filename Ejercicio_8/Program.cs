
using System;

namespace Ejercicio_8
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("El algoritmo para determinar el costo y el descuento que tendra un articulo es :");
			Console.WriteLine("---------------------------------------------------------------------------------");
			
			Console.WriteLine("int precio;");
			Console.WriteLine("double descuento;");
			Console.WriteLine("Console.Write(\"Digite el precio: \");");
			Console.WriteLine("precio = int.Parse(Console.ReadLine());");
			
			Console.WriteLine("if (precio>=200){");
				Console.WriteLine("descuento =precio*0.15;");
				Console.WriteLine("Console.WriteLine(\"El descuento es de: \"+descuento);");
				Console.WriteLine("Console.WriteLine(\"El costo total a pagar con descuento es de: \"+(precio-descuento));");	
			Console.WriteLine("}else if (precio>100 && precio<200){");
				Console.WriteLine("descuento =precio*0.12;");
				Console.WriteLine("Console.WriteLine(\"El descuento es de: \"+descuento);");
				Console.WriteLine("Console.WriteLine(\"El costo total a pagar con descuento es de: \"+(precio-descuento));");	
			Console.WriteLine("}else if (precio<100){");
				Console.WriteLine("descuento =precio*0.10;");
                Console.WriteLine("Console.WriteLine(\"El descuento es de: \"+descuento);");
			    Console.WriteLine("Console.WriteLine(\"El costo total a pagar con descuento es de: \"+(precio-descuento));");
			Console.WriteLine("}");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}