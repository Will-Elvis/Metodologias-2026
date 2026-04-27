
using System;

namespace Practica04._strategy
{
	/// <summary>
	/// Description of EstrategiaPorAntiguedad.
	/// </summary>
	public class EstrategiaPorAntiguedad : IEstrategiaDeComparacion
	{
		public EstrategiaPorAntiguedad()
		{
		}
		#region IEstrategiaDeComparacion implementation
		public bool sosIgual(Comparable a, Comparable b)
		{
			return ((Profesor)a).getAntiguedad() == ((Profesor)b).getAntiguedad();
		}
		public bool sosMenor(Comparable a, Comparable b)
		{
			return ((Profesor)a).getAntiguedad() < ((Profesor)b).getAntiguedad();
		}
		public bool sosMayor(Comparable a, Comparable b)
		{
			return ((Profesor)a).getAntiguedad() > ((Profesor)b).getAntiguedad();
		}
		#endregion
	}
}

