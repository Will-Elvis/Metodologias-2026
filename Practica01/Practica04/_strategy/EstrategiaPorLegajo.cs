
using System;

namespace Practica04._strategy
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

		public bool sosIgual(Comparable a, Comparable b)
		{
			//return a.getLegajo() == b.getLegajo();
			return ((Alumno)a).getLegajo() == ((Alumno)b).getLegajo();
		}

		public bool sosMenor(Comparable a, Comparable b)
		{
			//return a.getLegajo() < b.getLegajo();
			return ((Alumno)a).getLegajo() < ((Alumno)b).getLegajo();
		}

		public bool sosMayor(Comparable a, Comparable b)
		{
			//return a.getLegajo() > b.getLegajo();
			return ((Alumno)a).getLegajo() > ((Alumno)b).getLegajo();
		}

		#endregion
		
		//Consejo aprender a usar TERNARIOS 
	}
}


