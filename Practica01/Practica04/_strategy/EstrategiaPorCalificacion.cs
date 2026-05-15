
using System;

namespace Practica04._strategy
{
	/// <summary>
	/// Description of EstrategiaPorCalificacion.
	/// </summary>
	public class EstrategiaPorCalificacion: IEstrategiaDeComparacion
	{
		public EstrategiaPorCalificacion()
		{
		}

		#region IEstrategiaDeComparacion implementation

		public bool sosIgual(Comparable a, Comparable b)
		{
			// IAlumno sirve como tipo común para Alumno, AlumnoMuyEstudioso y futuros decoradores.
			return ((IAlumno)a).getCalificacion() == ((IAlumno)b).getCalificacion();
		}

		public bool sosMenor(Comparable a, Comparable b)
		{
			//IAlumno sirve como tipo común para Alumno, AlumnoMuyEstudioso y futuros decoradores.
			return ((IAlumno)a).getCalificacion() < ((IAlumno)b).getCalificacion();
		}

		public bool sosMayor(Comparable a, Comparable b)
		{
			//IAlumno sirve como tipo común para Alumno, AlumnoMuyEstudioso y futuros decoradores.
			return ((IAlumno)a).getCalificacion() > ((IAlumno)b).getCalificacion();
		}

		#endregion
	}
}
