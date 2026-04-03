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
			
	
			Console.Write("Press any key to continue . . . ");
			 Console.ReadKey(true);
		}
		
		// metodos de la clase 
		public static void llenar(IColeccionable c){
			Random azar = new Random();
			for (int i = 0; i < 20; i++) {
				int valor = azar.Next(1,100);
				Comparable com = new Numero(valor);
				c.agregar(com);
			}
		}
		
		public static void informar(IColeccionable c){
			//cuantos
			Console.WriteLine("tamaño del Coleccionable: "+c.cuantos());
			//minimo
			Console.WriteLine("minimo: "+c.minimo());
			//maximo
			Console.WriteLine("maximo: "+c.maximo());
			//contiene
			Console.WriteLine("Ingrese un valor para buscar en la Coleccion: ");
			int read = int.Parse(Console.ReadLine());
			Comparable com = new Numero(read);
			if(c.contiene(com)){
				Console.WriteLine("el elemento se encuentra en la lista");	
			}else
				Console.WriteLine("el elemento no se encuentra en la lista");
		}
		
	}
	
}