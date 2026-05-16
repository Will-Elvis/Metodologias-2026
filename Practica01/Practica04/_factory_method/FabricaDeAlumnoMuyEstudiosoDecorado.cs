
using System;
using Practica04._decorator;

namespace Practica04._factory_method
{
	/// <summary>
	/// Description of FabricaDeAlumnoMuyEstudiosoDecorado.
	/// </summary>
	public class FabricaDeAlumnoMuyEstudiosoDecorado :FabricaDeComparables
	{
		public FabricaDeAlumnoMuyEstudiosoDecorado()
		{
		}

		#region implemented abstract members of FabricaDeComparables

		public override Comparable crearAleatorio()
		{
			IAlumno alumno = (IAlumno)FabricaDeComparables.crearAleatorio(4);

			IAlumno Alumnodecorado = new DecoradoConLegajo(alumno);
			Alumnodecorado = new DecoradoConLetras(Alumnodecorado);
			Alumnodecorado = new DecoradoConPromocion(Alumnodecorado);
			Alumnodecorado = new DecoradoConAsterisco(Alumnodecorado);

			return Alumnodecorado;
		}

		public override Comparable crearPorTeclado()
		{
			IAlumno alumno = (IAlumno)FabricaDeComparables.crearPorTeclado(4);

			IAlumno Alumnodecorado = new DecoradoConLegajo(alumno);
			Alumnodecorado = new DecoradoConLetras(Alumnodecorado);
			Alumnodecorado = new DecoradoConPromocion(Alumnodecorado);
			Alumnodecorado = new DecoradoConAsterisco(Alumnodecorado);

			return Alumnodecorado;
		}

		#endregion
	}
}
