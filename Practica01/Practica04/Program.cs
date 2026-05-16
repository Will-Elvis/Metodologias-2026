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
using Practica04._iterator;
using Practica04._observer;
using Practica04._strategy;
using Practica04._factory_method;
using Practica04.Adapter;
using MetodologíasDeProgramaciónI;
using Practica04._decorator;

namespace Practica04
{
	class Program
	{
		//atributo de la clase 
		static Random azar = new Random();
		
		public static void Main(string[] args)
		{
			//================ MAIN Consola===============================================

			//implementamos  Ejercicio 4 del tp4
			
			
			// ========= PRIMERA SOLUCION ===============
			/*
			// Creamos el profesor del sistema MDPI.
			Teacher teacher = new Teacher();
			// Creamos 10 alumnos comunes.
			for (int i = 0; i < 10; i++){
				// Creamos un Alumno de nuestro sistema.
				IAlumno alumno = new Alumno("Alumno " + i, 40000000 + i, 20000 + i, 4);
				// Adaptamos el Alumno a Student, porque Teacher solo acepta Student.
				Student student = new AlumnoAdapter(alumno);
				// Agregamos el Student a la clase del profesor.
				teacher.goToClass(student);
			}
			// Creamos 10 alumnos muy estudiosos.
			for (int i = 0; i < 10; i++){
				// Creamos un AlumnoMuyEstudioso de nuestro sistema.
				IAlumno alumnoMuyEstudioso = new AlumnoMuyEstudioso("Alumno estudioso " + i,44000000 + i,30000 + i,10);
				// Lo adaptamos a Student para que MDPI pueda usarlo.
				Student student = new AlumnoAdapter(alumnoMuyEstudioso);
				// Lo agregamos a la clase del profesor.
				teacher.goToClass(student);
			}
			// El profesor pasa lista, toma examen y muestra resultados.
			teacher.teachingAClass();
			*/
			
			
			// ========= SEGUNDA SOLUCION (FABRICAS)===============
			/*
			// Creamos el profesor del sistema MDPI.
			Teacher teacher = new Teacher();
		
			// Creamos 10 alumnos comunes usando la fábrica.
			for (int i = 0; i < 10; i++)
			{
				// La opción 2 de la fábrica crea un Alumno.
				IAlumno alumno = (IAlumno)FabricaDeComparables.crearAleatorio(2);
				alumno.setEstrategia(new EstrategiaPorCalificacion());
				// Adaptamos el Alumno a Student y lo agregamos a la clase.
				teacher.goToClass(new AlumnoAdapter(alumno));
			}
		
			// Creamos 10 alumnos muy estudiosos usando la fábrica.
			for (int i = 0; i < 10; i++)
			{
				// La opción 4 de la fábrica crea un AlumnoMuyEstudioso.
				IAlumno alumnoMuyEstudioso = (IAlumno)FabricaDeComparables.crearAleatorio(4);
				alumnoMuyEstudioso.setEstrategia(new EstrategiaPorCalificacion());
				// Adaptamos el AlumnoMuyEstudioso a Student y lo agregamos a la clase.
				teacher.goToClass(new AlumnoAdapter(alumnoMuyEstudioso));
			}
		
			// El profesor pasa lista, toma examen y muestra resultados.
			teacher.teachingAClass();
			*/
			
			// =========== SOLUCION CON DECORADORES ===============
			/*
			Teacher teacher = new Teacher();
			
			for (int i = 0; i < 10; i++){
				IAlumno alumno = (IAlumno)FabricaDeComparables.crearAleatorio(2);
				alumno.setEstrategia(new EstrategiaPorCalificacion());
				IAlumno decorado = new DecoradoConLegajo(alumno);
				decorado = new DecoradoConLetras(decorado);
				decorado = new DecoradoConPromocion(decorado);
				decorado = new DecoradoConAsterisco(decorado);
			
				teacher.goToClass(new AlumnoAdapter(decorado));
			}
			
			for (int i = 0; i < 10; i++){
				IAlumno alumnoMuyEstudioso = (IAlumno)FabricaDeComparables.crearAleatorio(4);
				alumnoMuyEstudioso.setEstrategia(new EstrategiaPorCalificacion());
			
				IAlumno decorado = new DecoradoConLegajo(alumnoMuyEstudioso);
				decorado = new DecoradoConLetras(decorado);
				decorado = new DecoradoConPromocion(decorado);
				decorado = new DecoradoConAsterisco(decorado);
			
				teacher.goToClass(new AlumnoAdapter(decorado));
			}
			
			teacher.teachingAClass();
			*/
			
			// =========== SOLUCION CON FABRICA DE ALUMNOS DECORADOs ============
			//ejercicio 8 poner en ejecucion y comprobar  (todo okey)
			Teacher teacher = new Teacher();

			for (int i = 0; i < 10; i++)
			{
				IAlumno alumno = (IAlumno)FabricaDeComparables.crearAleatorio(5);
				alumno.setEstrategia(new EstrategiaPorCalificacion());
				teacher.goToClass(new AlumnoAdapter(alumno));
			}
			
			for (int i = 0; i < 10; i++)
			{
				IAlumno alumnoMuyEstudioso = (IAlumno)FabricaDeComparables.crearAleatorio(6);
				alumnoMuyEstudioso.setEstrategia(new EstrategiaPorCalificacion());
				teacher.goToClass(new AlumnoAdapter(alumnoMuyEstudioso));
			}
			
			teacher.teachingAClass();
			
			// ================== PRUEBA DE DECORADORES ============
			/*
			IAlumno alumno = new Alumno("Raton Perez", 12345678, 12345, 8);
			alumno.setCalificacion(6);
			
			Console.WriteLine("Sin decorar:");
			Console.WriteLine(alumno.mostrarCalificacion());
			
			Console.WriteLine("\nCon legajo:");
			IAlumno conLegajo = new DecoradoConLegajo(alumno);
			Console.WriteLine(conLegajo.mostrarCalificacion());
			
			Console.WriteLine("\nCon letras:");
			IAlumno conLetras = new DecoradoConLetras(alumno);
			Console.WriteLine(conLetras.mostrarCalificacion());
			
			Console.WriteLine("\nCon promocion:");
			IAlumno conPromocion = new DecoradoConPromocion(alumno);
			Console.WriteLine(conPromocion.mostrarCalificacion());
			
			Console.WriteLine("\nCon asteriscos:");
			IAlumno conAsterisco = new DecoradoConAsterisco(alumno);
			Console.WriteLine(conAsterisco.mostrarCalificacion());
			*/
			
			/*IAlumno decorado = new Alumno("Raton Perez", 12345678, 12345, 8);
			decorado.setCalificacion(6);
			// el orden de los decorados influye muchisimo , este orden fue establecido por el enunciado
			decorado = new DecoradoConLegajo(decorado);
			decorado = new DecoradoConLetras(decorado);
			decorado = new DecoradoConPromocion(decorado);
			decorado = new DecoradoConAsterisco(decorado);
			Console.WriteLine(decorado.mostrarCalificacion());
			*/
			
			Console.WriteLine("Hello World!");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		

		
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

