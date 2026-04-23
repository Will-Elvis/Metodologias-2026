
using System;

namespace Practica03._strategy
{
	/// <summary>
	/// Description of EstrategiaPorPromedio.
	/// </summary>
// Paso numero 2 es poder Crear la estrategia particular que Implementa la Interfaz IEstrategiaDeComparacion
	public class EstrategiaPorPromedio: IEstrategiaDeComparacion
	{
		
		public EstrategiaPorPromedio()
		{
		}

		#region IEstrategiaDeComparacion implementation

		public bool sosIgual(Alumno a, Alumno b)
		{
			return a.getPromedio() == b.getPromedio();
		}

		public bool sosMenor(Alumno a, Alumno b)
		{
			return a.getPromedio() < b.getPromedio();
		}

		public bool sosMayor(Alumno a, Alumno b)
		{
			return a.getPromedio() > b.getPromedio();
		}

		#endregion
	}
}

