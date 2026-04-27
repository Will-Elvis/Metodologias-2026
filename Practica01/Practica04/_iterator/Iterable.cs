
using System;

namespace Practica04._iterator
{
	/// <summary>
	/// Description of Iterable.
	/// </summary>
	// Paso 2 crar el iterable con la funcion de crear su propio Iterable
	// debemos  hacer que pila ,cola ,conjunto implemente Iterable para que asi
	// estas puedan definir  se Iterador propio
	public interface Iterable
	{
		Iterador crearIterador();
	}
}


