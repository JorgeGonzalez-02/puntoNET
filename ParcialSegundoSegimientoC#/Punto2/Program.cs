/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 09/10/2019
 * Time: 07:55 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto2
{
	class Program
	{
		public static void Main(string[] args)
		{
			const string contraseñaP="password123";
			string contraseñaI;
			int intentos=3,i=1;
			
			while (i <= intentos) {
				Console.WriteLine("Por favor ingrese la contraseña");
				Console.WriteLine("-------------------------------");
				Console.WriteLine("");
				Console.WriteLine("Contraseña: ");
				contraseñaI=Console.ReadLine();
			
					if (contraseñaP==contraseñaI){
						Console.WriteLine("Ingresado con exito!");
						break;
					}else{
						Console.WriteLine("Contraseña incorrecta!");
					}
					if (i==3 && contraseñaP!=contraseñaI) {
						Console.WriteLine("Intento fallido!");
					}
				i++;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}