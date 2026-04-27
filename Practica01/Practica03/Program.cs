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
using Practica03._observer;
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
			
			//ejercicio 7 TP3
			/*IColeccionable coleccion = FabricaDeColeccionables.crearColeccion(4);
			llenar(coleccion,3);
			informar(coleccion,3);
			*/
			
			Profesor profe = new Profesor("Mauro",1234567,7);
			Pila p = new Pila();
			llenar(p,2);
			Iterador ite = p.crearIterador(); // Iterador de pila
			//definimos el primer elemento del iterador 
			ite.primero();
			// se ejecuta mientras el iterador no llego al final de la lista
			while (!ite.fin()) {
				profe.agregarObservador((Observador)ite.actual()); //ite.actual() --> me tira  un Comparable
				ite.siguente();
			}
			dictadoDeClases(profe);
			
			Console.WriteLine("Hello World!");
			Console.Write("Press any key to continue . . . ");
			 Console.ReadKey(true);
		}
		
		// respuesta al Ejericio 7 pero tranquilamente se podria hacer mas facil con factory method
		/*
		public static IColeccionable preguntarColeccion(){
			Console.Write("Que tipo de coleccion desea Crear:");
			int opcion = 0;
			while (!(opcion==5)) {
				Console.WriteLine("Que tipo de coleccion desea crear:");
		        Console.WriteLine("1. Coleccion Tipo Cola");
		        Console.WriteLine("2. Coleccion Tipo Pila");
		        Console.WriteLine("3. Coleccion Tipo Conjunto");
		        Console.WriteLine("4. Coleccion Tipo ColeccionMultiple");
		        Console.WriteLine("5. Salir");
        		Console.Write("Ingrese una opcion: ");
				try {
					opcion = int.Parse(Console.ReadLine());
					//break sale del swith y Return del ambos  corta el flujo del while tambien
					switch (opcion) {
							case 1: return new Cola();
							case 2: return new Pila();
							case 3: return new Conjunto();
							case 4: return new ColeccionMultiple(new Cola(),new Pila());break;
							case 5: return null;
							default: Console.WriteLine("Valor incorrecto intente nuevamente");break;
				}
					
				} catch (Exception) {
					
					Console.WriteLine("Debe ingresar un numero valido.");
				}
			}
		}*/
		
		// Tp3 Modificamos llenar  ejercicio 6
		public static void llenar(IColeccionable cole,int opcion){
			for (int i = 0; i < 20; i++) {
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
				Console.WriteLine("El elemento  esta registrado en la coleccion.");
			}else
				Console.WriteLine("El elemento no se encuentra en la coleccion!!.");
			
			
		}
		/*
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
		*/
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
		
		public static void dictadoDeClases(Profesor profe){
			for (int i = 0; i <= 5; i++) {
				profe.hablarALaClase();
				profe.escribirEnElPizarron();
			}
		}
		
	}
	
}
