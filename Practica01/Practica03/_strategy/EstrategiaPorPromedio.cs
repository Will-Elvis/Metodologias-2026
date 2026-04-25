
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

		public bool sosIgual(Comparable a, Comparable b)
		{
			return ((Alumno)a).getPromedio() == ((Alumno)b).getPromedio();
		}

		public bool sosMenor(Comparable a, Comparable b)
		{
			//return a.getPromedio() < b.getPromedio();
			return ((Alumno)a).getPromedio() < ((Alumno)b).getPromedio();
		}

		public bool sosMayor(Comparable a, Comparable b)
		{
			//return a.getPromedio() > b.getPromedio();
			return ((Alumno)a).getPromedio() > ((Alumno)b).getPromedio();
		}

		#endregion
	}
}

