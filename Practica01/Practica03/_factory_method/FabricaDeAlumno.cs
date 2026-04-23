
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
			return new Alumno(lector.stringPorTeclado(),lector.numeroPorTeclado(),lector.numeroPorTeclado(),(double)lector.numeroPorTeclado());
		}
		#endregion
	}
}
