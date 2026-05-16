
using System;
using Practica04._strategy;

namespace Practica04._decorator
{
	/// <summary>
	/// Description of AlumnoDecorator.
	/// </summary>
	public abstract class AlumnoDecorator: IAlumno
	{
		protected IAlumno adicional;
		public AlumnoDecorator(IAlumno alu)
		{
			this.adicional = alu;
		}

		#region IAlumno implementation

		public void setEstrategia(IEstrategiaDeComparacion nvaEstrategia)
		{
			this.adicional.setEstrategia(nvaEstrategia);
		}

		public int getLegajo()
		{
			return this.adicional.getLegajo();
		}

		public double getPromedio()
		{
			return this.adicional.getPromedio();
		}

		public string getNombre()
		{
			return this.adicional.getNombre();
		}

		public int getDni()
		{
			return this.adicional.getDni();
		}

		public int getCalificacion()
		{
			return this.adicional.getCalificacion();
		}

		public void setCalificacion(int cal)
		{
			this.adicional.setCalificacion(cal);
		}

		public int responderPregunta(int pregunta)
		{
			return this.adicional.responderPregunta(pregunta);
		}

		public virtual string mostrarCalificacion()
		{
			return this.adicional.mostrarCalificacion();
		}

		#endregion

		#region Comparable implementation
		/*
		Compará los alumnos que están adentro de los decoradores.
		*/
		public bool sosIgual(Comparable c)
		{
			return this.adicional.sosIgual(((AlumnoDecorator)c).adicional);
		}

		public bool sosMenor(Comparable c)
		{
			return this.adicional.sosMenor(((AlumnoDecorator)c).adicional);
		}

		public bool sosMayor(Comparable c)
		{
			return this.adicional.sosMayor(((AlumnoDecorator)c).adicional);
		}

		#endregion
	}
}
