
using System;

namespace Practica03._factory_method
{
	/// <summary>
	/// Description of FabricaDeAlumno.
	/// </summary>
	public class FabricaDeAlumno : FabricaDeComparables
	{
		public FabricaDeAlumno()
		{
		}
		#region implemented abstract members of FabricaDeComparables
		public override Comparable crearAleatorio()
		{
			return new Alumno(generador.stringAleatorio(5),generador.numeroAleatorio(100000000),generador.numeroAleatorio(10000),(double)generador.numeroAleatorio(10));
		}
		public override Comparable crearPorTeclado()
		{
			Console.Write("Ingrese un nombre: ");
			string nombre = lector.stringPorTeclado();
			
			Console.Write("Ingrese un DNI: ");
			int dni = lector.numeroPorTeclado();
			
			Console.Write("Ingrese un legajo: ");
			int legajo = lector.numeroPorTeclado();
			
			Console.Write("Ingrese un promedio: ");
			double promedio = lector.numeroPorTeclado();
			
			// antes 
			//return new Alumno(lector.stringPorTeclado(),lector.numeroPorTeclado(),lector.numeroPorTeclado(),(double)lector.numeroPorTeclado());
			return new Alumno(nombre, dni, legajo, promedio);

			
		}
		#endregion
	}
}
