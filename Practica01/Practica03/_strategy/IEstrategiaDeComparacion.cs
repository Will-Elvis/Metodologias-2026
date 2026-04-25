
using System;

namespace Practica03._strategy
{
	/// <summary>
	/// Description of IEstrategiaDeComparacion.
	/// </summary>
	
	//Estrategia GENERAL  para que se comparen entre Alumnos
	// Este es el paso Definir la estrategia
	public interface IEstrategiaDeComparacion
	{
		bool sosIgual (Comparable a, Comparable b);
		bool sosMenor (Comparable a, Comparable b);
		bool sosMayor (Comparable a, Comparable b);
	}
}

