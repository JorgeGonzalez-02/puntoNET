
using System;

namespace Ejercicio_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombreCliente;
			int unidades;
			double cargo;
			
			Console.Write("Digite su nombre: ");
			nombreCliente = Console.ReadLine();
			Console.Write("Digite unidades consumidas: ");
			unidades = int.Parse(Console.ReadLine());
			
			if (unidades<=199){
				cargo = unidades*1.20;
			}else if (unidades>=200 && unidades<400){
				cargo = unidades*1.50;
			}else if (unidades>=400 && unidades<600){
				cargo = unidades*1.80;
			}else {
				cargo = unidades*2.00;
			}
			
			Console.WriteLine("Señor "+nombreCliente);
			Console.WriteLine("Total a pagar es: "+cargo);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}