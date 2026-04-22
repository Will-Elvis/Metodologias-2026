
using System;

namespace Practica02._strategy
{
	/// <summary>
	/// Description of EstrategiaPorNombre.
	/// </summary>
// Paso numero 2 es poder Crear la estrategia particular que Implementa la Interfaz IEstrategiaDeComparacion
	public class EstrategiaPorNombre: IEstrategiaDeComparacion
	{
		public EstrategiaPorNombre()
		{
		}

		#region IEstrategiaDeComparacion implementation

		public bool sosIgual(Alumno a, Alumno b)
		{
			return a.getNombre() == b.getNombre();
		}

		public bool sosMenor(Alumno a, Alumno b)
		{
			return string.Compare(a.getNombre(),b.getNombre()) < 0;
			
		}

		public bool sosMayor(Alumno a, Alumno b)
		{
			return string.Compare(a.getNombre(),b.getNombre()) > 0;
		}

		#endregion
	}
}
