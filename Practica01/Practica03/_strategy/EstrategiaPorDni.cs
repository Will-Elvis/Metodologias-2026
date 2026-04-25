
using System;

namespace Practica03._strategy
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

		public bool sosIgual(Comparable a, Comparable b)
		{
			//return a.getDni() == b.getDni();
			return ((Alumno)a).getDni() == ((Alumno)b).getDni();
		}

		public bool sosMenor(Comparable a, Comparable b)
		{
			//return a.getDni() < b.getDni();
			return ((Alumno)a).getDni() < ((Alumno)b).getDni();
		}

		public bool sosMayor(Comparable a, Comparable b)
		{
			//return a.getDni() > b.getDni();
			return ((Alumno)a).getDni() > ((Alumno)b).getDni();
		}

		#endregion
	}
}

