/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 09/10/2019
 * Time: 08:26 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num;
			Console.Write("Ingrese el numero: ");
			num = int.Parse(Console.ReadLine());
			for (int i = 1; i <= num; i++) {
				
				for (int j = 1; j <= i; j++) {
					Console.Write(i);
				}
				Console.WriteLine("");
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}