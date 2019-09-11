
using System;

namespace Ejercicio_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int numMes;
			Console.Write("Digite el numero del mes: ");
			numMes = int.Parse(Console.ReadLine());
			
			if(numMes>0 && numMes<13){
				if (numMes==1){
					Console.WriteLine("El mes es Enero y tiene 31 dias");
				}if (numMes==2){
					Console.WriteLine("El mes es Febrero y tiene 28 dias");
				}if (numMes==1){
					Console.WriteLine("El mes es Marzo y tiene 31 dias");
				}if (numMes==3){
					Console.WriteLine("El mes es abril y tiene 30 dias");
				}if (numMes==4){
					Console.WriteLine("El mes es Mayo y tiene 31 dias");
				}if (numMes==5){
					Console.WriteLine("El mes es Junio y tiene 30 dias");
				}if (numMes==6){
					Console.WriteLine("El mes es Julio y tiene 31 dias");
				}if (numMes==7){
					Console.WriteLine("El mes es Agosto y tiene 31 dias");
				}if (numMes==8){
					Console.WriteLine("El mes es Septiembre y tiene 30 dias");
				}if (numMes==9){
					Console.WriteLine("El mes es Octubre y tiene 31 dias");
				}if (numMes==10){
					Console.WriteLine("El mes es Noviembre y tiene 30 dias");
				}if (numMes==11){
					Console.WriteLine("El mes es Diciembre y tiene 31 dias");
				}
			}else{Console.WriteLine("El mes no existe");}
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}