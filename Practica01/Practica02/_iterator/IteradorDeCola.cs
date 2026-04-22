
using System;

namespace Practica02._iterator
{
	/// <summary>
	/// Description of IteradorDeCola.
	/// </summary>
	public class IteradorDeCola : Iterador
	{
		private Cola cola;
		private int indice;
		public IteradorDeCola(Cola cola)
		{
			this.cola = cola;
			primero();
		}

		#region Iterador implementation
		//seteamos el indice a 0
		public void primero()
		{
			this.indice = 0;
		}
		// incrementamos el indice  en 1
		public void siguente()
		{
			this.indice++;
		}

		public bool fin()
		{
			return this.indice >= this.cola.cuantos();
		}

		public Comparable actual()
		{
			return this.cola.getElementos()[indice];
		}

		#endregion
	}
}
