/*
 * Creado por SharpDevelop.
 * Usuario: PcHome
 * Fecha: 28/3/2026
 * Hora: 19:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica01
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Pila p= new Pila();
			Numero num1 = new Numero(29);
			Numero num2 = new Numero(22);
			Numero num3 = new Numero(23);
			Numero num4 = new Numero(242);
			p.apilar(num1);
			p.apilar(num2);
			p.apilar(num3);
			p.apilar(num4);
			Console.WriteLine(p.getPila());
			Console.WriteLine(p.desapilar());
			Console.WriteLine(p.maximo());
			Console.WriteLine(p.minimo());
			Console.WriteLine(p.contiene(new Numero(24)));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
	}
}