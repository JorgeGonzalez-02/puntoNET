/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 09/10/2019
 * Time: 07:50 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto1
{
	class Program
	{
		public static void Main(string[] args)
		{
			long num,fac=1;
			Console.Write("Digite el numero (Entero,positivo): ");
			num = int.Parse(Console.ReadLine());
			if (num>0) {
				for (int i = 1; i <= num ; i++) {
				fac*=i;
			   }
				Console.WriteLine(fac);
			}else
				Console.WriteLine("Error no se permiten numeros negativos");
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}