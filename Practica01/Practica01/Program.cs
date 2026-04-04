/*
 * Creado por SharpDevelop.
 * Usuario: PcHome
 * Fecha: 28/3/2026
 * Hora: 19:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica01
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
//			Ejercicio  7
//			Pila pila = new Pila();
//			Cola cola = new Cola();
//			llenar(pila);
//			llenar(cola);
//			informar(pila);
//			informar(cola);
			//ejercicio 9
			
			Pila p = new Pila();
			Cola c = new Cola();
			ColeccionMultiple multiple = new ColeccionMultiple(p,c);
			llenar(p);
			llenar(c);
			informar(p);
			informar(c);
			informar(multiple);
			Console.Write("Press any key to continue . . . ");
			 Console.ReadKey(true);
		}
		
		//atributo de la clase 
		static Random azar = new Random();
		// metodos de la clase 
		public static void llenar(IColeccionable c){
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
		
		public static void llenarAlumnos(IColeccionable c){
			List<string> alumnos =new List<string>(){
    "Ana", "Juan", "Pedro", "Lucia", "Maria",
    "Carlos", "Sofia", "Miguel", "Laura", "Tomas",
    "Valentina", "Lucas", "Camila", "Mateo", "Martina",
    "Benjamin", "Julieta", "Franco", "Agustina", "Nicolas",
    "Paula", "Santiago", "Carolina", "Diego", "Florencia",
    "Joaquin", "Micaela", "Bruno", "Antonella", "Gonzalo",
    "Victoria", "Ezequiel", "Rocio", "Facundo", "Melina",
    "Ramiro", "Noelia", "Federico", "Aldana", "Marcos",
    "Bianca", "Leandro", "Candela", "Maximiliano", "Delfina",
    "Iván", "Cecilia", "Hernán", "Elena", "Matías"};
			
			for (int i = 0; i < 20; i++) {
				//azar
				int legajo = azar.Next(10000,100000);
				int documento = azar.Next(10000000,100000000);
				int valor = azar.Next(10,101);
				int indice = azar.Next(0,50);
				string alumno = alumnos[indice];
				double promedio = valor/10.0;
				c.agregar(new Alumno(alumno,documento,legajo,promedio));
			}
		}
		
	}
	
}