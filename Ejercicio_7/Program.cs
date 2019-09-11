
using System;

namespace Ejercicio_7
{
	class Program
	{
		public static void Main(string[] args)
		{
			double num1,num2,num3;
			Console.Write("Digite el numero 1: ");
			num1 = double.Parse(Console.ReadLine());
			Console.Write("Digite el numero 2: ");
			num2 = double.Parse(Console.ReadLine());
			Console.Write("Digite el numero 3: ");
			num3 = double.Parse(Console.ReadLine());
			
			if (num1==num2 && num1==num3){
				Console.WriteLine("Los tres numeros son iguales Numero 1: "+num1 +"  Numero 2: "+num2+"  Numero 3: "+num3);
			}else if (num1==num2 && num3 != num1){
				Console.WriteLine("los numeros mayores son el primer digitado: "+num1+ " y el segundo: "+num2);
			}else if (num1==num3 && num2 != num1){
				Console.WriteLine("los numeros mayores son el primer digitado: "+num1+ " y el tercero: "+num3);
			}else if (num3==num2 && num1 != num3){
				Console.WriteLine("los numeros mayores son el tercer digitado: "+num3+ " y el segundo: "+num2);
			}else if (num1>num2 && num1>num3){
				Console.WriteLine("El numero mayor es el primer numero digitado : "+num1);
			}else if (num2>num1 & num2>num3){
				Console.WriteLine("El numero mayor es el segundo numero digitado : "+num2);
			}else {
				Console.WriteLine("El numero mayor es el tercer numero digitado : "+num3);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}