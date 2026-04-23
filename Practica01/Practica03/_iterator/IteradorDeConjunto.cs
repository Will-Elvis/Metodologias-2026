
using System;

namespace Practica03._iterator
{
	/// <summary>
	/// Description of IteradorDeConjunto.
	/// </summary>
	public class IteradorDeConjunto : Iterador
	{
		private int indice;
		private Conjunto conjunto;
		public IteradorDeConjunto(Conjunto con)
		{
			this.conjunto = con;
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
			return this.indice >= this.conjunto.cuantos();
		}
		public Comparable actual()
		{
			return this.conjunto.getListaElementos()[indice];
		}
		#endregion
	}
}

