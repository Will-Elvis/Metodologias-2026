
using System;

namespace Practica03._factory_method
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public abstract class FabricaDeComparables
	{
		protected GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
		protected LectorDeDatos lector = new LectorDeDatos();
		//constructor 
		public FabricaDeComparables()
		{
		}
		
		//METODO MAS IMPORTANTE PARA DELEGAR EN FACTORY METHOD 
		public abstract Comparable crearAleatorio();
		//METODO MAS IMPORTANTE PARA DELEGAR EN FACTORY METHOD 
		public abstract Comparable crearPorTeclado();
		// int opcion = {1(Numero),2(Alumno),3(Profesores).4(otroTipoDeCompable)}
		// Comparable comparable = FabricaDeComparables.crearAleatorio(int opcion)
		// Metodos que me piden
		public static Comparable crearAleatorio(int opcion){
			FabricaDeComparables fabrica = null;
			switch(opcion){
				case 1: fabrica = new FabricaDeNumero(); break;
				case 2: fabrica = new FabricaDeAlumno(); break;
				case 3: fabrica = new FabricaDeProfesor(); break;
			}
			return fabrica.crearAleatorio();
		}
		
		// Comparable comparable = FabricaDeComparables.crearPorTeclado(int opcion)
		public static Comparable crearPorTeclado(int opcion){
			FabricaDeComparables fabrica = null;
			switch (opcion) {
				case 1: fabrica = new FabricaDeNumero(); break;
				case 2: fabrica = new FabricaDeAlumno(); break;
				case 3: fabrica = new FabricaDeProfesor(); break;
			}
			return fabrica.crearPorTeclado();
		}
	}
}
