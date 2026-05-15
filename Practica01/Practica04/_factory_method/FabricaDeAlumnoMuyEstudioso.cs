
using System;

namespace Practica04._factory_method
{
	/// <summary>
	/// Description of FabricaDeAlumnoMuyEstudioso.
	/// </summary>
	public class FabricaDeAlumnoMuyEstudioso :FabricaDeComparables
	{
		public FabricaDeAlumnoMuyEstudioso()
		{
		}

		#region implemented abstract members of FabricaDeComparables

		public override Comparable crearAleatorio()
		{
			return new AlumnoMuyEstudioso(generador.stringAleatorio(10),generador.numeroAleatorio(100000000),generador.numeroAleatorio(10000),(double)generador.numeroAleatorio(10));
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

			return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio);
		}

		#endregion
	}
}
