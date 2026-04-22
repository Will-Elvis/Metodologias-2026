
using System;

namespace Practica02._strategy
{
	/// <summary>
	/// Description of IEstrategiaDeComparacion.
	/// </summary>
	
	//Estrategia GENERAL  para que se comparen entre Alumnos
	// Este es el paso Definir la estrategia
	public interface IEstrategiaDeComparacion
	{
		bool sosIgual (Alumno a, Alumno b);
		bool sosMenor (Alumno a, Alumno b);
		bool sosMayor (Alumno a, Alumno b);
	}
}
