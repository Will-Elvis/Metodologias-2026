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
using Practica03._iterator;
using Practica03._strategy;
using Practica03._factory_method;

namespace Practica03
{
	class Program
	{
		//atributo de la clase 
		static Random azar = new Random();
		
		public static void Main(string[] args)
		{
			//================ MAIN Consola===============================================
			
			/*
			Pila p = new Pila();
			Cola c = new Cola();
			ColeccionMultiple multiple = new ColeccionMultiple(p,c);
			llenarAlumnos(p);
			llenarAlumnos(c);
			informar(multiple);
			*/
			/* ejercicio 7 TP2
			Pila pila = new Pila();
			Cola cola = new Cola();
			Conjunto conjunto = new Conjunto();
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			llenarAlumnos(conjunto);
			imprimirElementos(pila);
			imprimirElementos(cola);
			imprimirElementos(conjunto);
			*/
			
			//ejercicio 9
			/*Pila pila = new Pila();
			llenarAlumnos(pila);
			cambiarEstrategia(pila,new EstrategiaPorNombre());
			informar(pila);
			cambiarEstrategia(pila,new EstrategiaPorLegajo());
			informar(pila);
			cambiarEstrategia(pila,new EstrategiaPorPromedio());
			informar(pila);
			cambiarEstrategia(pila,new EstrategiaPorDni());
			informar(pila);
			*/
			
			Pila pila = new Pila();
			llenarAlumnos(pila);
			cambiarEstrategia(pila, new EstrategiaPorNombre());
			informar(pila, 2);
			
			Console.WriteLine("Hello World!");
			Console.Write("Press any key to continue . . . ");
			 Console.ReadKey(true);
		}
		
		// Tp3 Modificamos llenar  ejercicio 6
		public static void llenar(IColeccionable cole,int opcion){
			for (int i = 0; i < 20; i++) {
				int valor = azar.Next(1,100);
				Comparable com = FabricaDeComparables.crearAleatorio(opcion);
				//seteamos la estrategia si es un Alumno
				
				cole.agregar(com);
			}
		}
		//Tp3 Modificamos  informar  ejercicio 6
		public static void informar(IColeccionable c,int opcion){
			// Imprime cuantos elementos contiene el coleccionable
			Console.WriteLine("tamaño del Coleccionable: "+c.cuantos());
			//Imprime el minimo del coleccionable
			Console.WriteLine("minimo: "+c.minimo());
			//Imprime el maximo del coleccionable
			Console.WriteLine("maximo: "+c.maximo());
			Comparable comparable = FabricaDeComparables.crearPorTeclado(opcion);
	
			if(c.contiene(comparable)){
				Console.WriteLine("El elemento se esta registrado en la coleccion.");
			}else
				Console.WriteLine("El elemento no se encuentra en la coleccion!!.");
			
			
		}
		
		public static void llenarAlumnos(IColeccionable c){
			List<string> nombres =new List<string>(){
	
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
				string nombre = nombres[indice];
				double promedio = valor/10.0;
				//c.agregar(new Alumno(alumno,documento,legajo,promedio));
				//Ejercicio 02 --> TP2
				Comparable alum = new Alumno(nombre,documento,legajo,promedio);
				//((Alumno)alum).setEstrategia(new EstrategiaPorDni());
				c.agregar(alum);
			}
		}
		//usando el Iterador -- > imprmir todos los elementos del coleccionable
		public static void imprimirElementos(Iterable col){
			Iterador iterador = col.crearIterador();
			iterador.primero();
			//mientras que no llegue a su fin el coleccionable va a seguir ejecutando
			Console.WriteLine("====Inicio======");
			while (!iterador.fin()) {
				Comparable elemento = iterador.actual();
				Console.WriteLine(elemento);
				iterador.siguente();
			}
			Console.WriteLine("====Fin======");
		}
		
		
		public static void cambiarEstrategia(Iterable col,IEstrategiaDeComparacion estrategia){
			Iterador iterador = col.crearIterador();
			iterador.primero();
			while (!iterador.fin()) {
				((Alumno)iterador.actual()).setEstrategia(estrategia);
				iterador.siguente();
			}
		}
		
	}
	
}
