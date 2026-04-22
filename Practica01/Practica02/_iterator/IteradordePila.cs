
using System;

namespace Practica02._iterator
{
	/// <summary>
	/// Description of IteradordePila.
	/// </summary>
	public class IteradordePila : Iterador
	{
		private Pila pila;
		private int indice;
		public IteradordePila(Pila pila)
		{
			this.pila = pila;
			primero();
		}

		#region Iterador implementation

		public void primero()
		{
			this.indice = 0;
		}

		public void siguente()
		{
			this.indice++;
		}

		public bool fin()
		{
			return this.indice >= this.pila.cuantos();
		}

		public Comparable actual()
		{
			return this.pila.getPila()[indice];
		}

		#endregion
	}
}
