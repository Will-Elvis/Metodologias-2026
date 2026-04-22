
using System;
using System.Collections.Generic;

namespace Practica02
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto
	{
		private List<Comparable> listaElementos;
		public Conjunto()
		{
			listaElementos = new List<Comparable>();
		}
		
		public void agregar(Comparable c){
			if(!pertenece(c)){
				this.listaElementos.Add(c);
			}
		}
		public bool pertenece(Comparable c){
			foreach (Comparable e in this.listaElementos) {
				if(c.sosIgual(e)){
					return true;
				}
			}
			return false;
		}
	}
}
