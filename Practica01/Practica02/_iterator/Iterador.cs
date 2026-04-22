
using System;

namespace Practica02._iterator
{
	/// <summary>
	/// Description of Iterador.
	/// </summary>
	//Paso 1 definir el iterador con sun metodos
	public interface Iterador
	{
		void primero();
		void siguente();
		bool fin();
		Comparable actual();
	}
}
