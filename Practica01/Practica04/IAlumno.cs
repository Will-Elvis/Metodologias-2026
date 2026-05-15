
using System;
using Practica04._strategy;

namespace Practica04
{
	/// <summary>
	/// Description of IAlumno.
	/// </summary>
	public interface IAlumno : Comparable
	{
		void setEstrategia(IEstrategiaDeComparacion nvaEstrategia);
		int getLegajo();
		double getPromedio();
		string getNombre();
		int getDni();
		int getCalificacion();
		void setCalificacion(int cal);
		int responderPregunta(int pregunta);
		string mostrarCalificacion();
		
	}
}
