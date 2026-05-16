
using System;
using Practica04._decorator;

namespace Practica04._factory_method
{
	/// <summary>
	/// Description of FabricaDeAlumnoDecorado.
	/// </summary>
	public class FabricaDeAlumnoDecorado: FabricaDeComparables
	{
		public FabricaDeAlumnoDecorado()
		{
		}

		#region implemented abstract members of FabricaDeComparables

		public override Comparable crearAleatorio()
		{
			IAlumno alumno = (IAlumno)FabricaDeComparables.crearAleatorio(2);

			IAlumno Alumnodecorado = new DecoradoConLegajo(alumno);
			Alumnodecorado = new DecoradoConLetras(Alumnodecorado);
			Alumnodecorado = new DecoradoConPromocion(Alumnodecorado);
			Alumnodecorado = new DecoradoConAsterisco(Alumnodecorado);

			return Alumnodecorado;
		}

		public override Comparable crearPorTeclado()
		{
			IAlumno alumno = (IAlumno)FabricaDeComparables.crearPorTeclado(2);

			IAlumno decorado = new DecoradoConLegajo(alumno);
			decorado = new DecoradoConLetras(decorado);
			decorado = new DecoradoConPromocion(decorado);
			decorado = new DecoradoConAsterisco(decorado);

			return decorado;
		}

		#endregion
	}
}
