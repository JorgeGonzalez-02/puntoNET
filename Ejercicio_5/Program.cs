
using System;

namespace Ejercicio_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			char caracter;
			Console.Write("Digite el caracter: ");
			caracter = char.ToUpper(Convert.ToChar(Console.ReadLine())) ;
			
			Console.WriteLine(caracter);
			
			if (caracter == 'A' || caracter=='E' || caracter=='I' || caracter=='O' || caracter=='U'){
				
				Console.WriteLine("El carcter digitado es vocal. ");
			}if (caracter=='0' || caracter=='1' || caracter=='2' || caracter=='3' || caracter=='4' || caracter=='5' || caracter=='6' || caracter=='7' || caracter=='8' || caracter=='9' ){
				Console.WriteLine("El caracter es numerico. ");
			}if (caracter=='B'||caracter== 'C' || caracter=='D' || caracter=='F' || caracter== 'G'
			     || caracter== 'H'|| caracter=='J'|| caracter== 'K'|| caracter=='L'|| caracter=='M'
			     || caracter== 'Ñ'|| caracter=='P'|| caracter== 'Q'|| caracter=='R'|| caracter=='S'
			     || caracter== 'T'|| caracter=='V'|| caracter== 'W'|| caracter=='X'|| caracter=='Y'
			     || caracter== 'Z'){
				Console.WriteLine("El caracter es una consonante.");
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}