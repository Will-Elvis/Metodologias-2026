
using System;

namespace Practica02._strategy
{
	/// <summary>
	/// Description of EstrategiaPorDni.
	/// </summary>
// Paso numero 2 es poder Crear la estrategia particular que Implementa la Interfaz IEstrategiaDeComparacion
	public class EstrategiaPorDni : IEstrategiaDeComparacion
	{
		public EstrategiaPorDni()
		{
		}

		#region IEstrategiaDeComparacion implementation

		public bool sosIgual(Alumno a, Alumno b)
		{
			return a.getDni() == b.getDni();
		}

		public bool sosMenor(Alumno a, Alumno b)
		{
			return a.getDni() < b.getDni();
		}

		public bool sosMayor(Alumno a, Alumno b)
		{
			return a.getDni() > b.getDni();
		}

		#endregion
	}
}
