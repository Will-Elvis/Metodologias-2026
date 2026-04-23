
using System;

namespace Practica03._strategy
{
	/// <summary>
	/// Description of EstrategiaPorLegajo.
	/// </summary>
// Paso numero 2 es poder Crear la estrategia particular que Implementa la Interfaz IEstrategiaDeComparacion
	public class EstrategiaPorLegajo: IEstrategiaDeComparacion
	{
		public EstrategiaPorLegajo()
		{
		}

		#region IEstrategiaDeComparacion implementation

		public bool sosIgual(Alumno a, Alumno b)
		{
			return a.getLegajo() == b.getLegajo();
		}

		public bool sosMenor(Alumno a, Alumno b)
		{
			return a.getLegajo() < b.getLegajo();
		}

		public bool sosMayor(Alumno a, Alumno b)
		{
			return a.getLegajo() > b.getLegajo();
		}

		#endregion
		
		//Consejo aprender a usar TERNARIOS 
	}
}

