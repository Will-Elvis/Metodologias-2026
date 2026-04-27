
using System;

namespace Practica04._iterator
{
	/// <summary>
	/// Description of IteradorDePila.
	/// </summary>
	public class IteradorDePila : Iterador
	{
		private Pila pila;
		private int indice;
		public IteradorDePila(Pila pila)
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


