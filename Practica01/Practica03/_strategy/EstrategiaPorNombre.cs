
using System;

namespace Practica03._strategy
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

		public bool sosIgual(Comparable a, Comparable b)
		{
			//return a.getNombre() == b.getNombre();
			return ((Alumno)a).getNombre() == ((Alumno)b).getNombre();
		}

		public bool sosMenor(Comparable a, Comparable b)
		{
			//return string.Compare(a.getNombre(),b.getNombre()) < 0;
			return string.Compare(((Alumno)a).getNombre(),((Alumno)b).getNombre()) < 0;
			
		}

		public bool sosMayor(Comparable a, Comparable b)
		{
			//return string.Compare(a.getNombre(),b.getNombre()) > 0;
			return string.Compare(((Alumno)a).getNombre(),((Alumno)b).getNombre()) > 0;
		}

		#endregion
	}
}

