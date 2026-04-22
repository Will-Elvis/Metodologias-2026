
using System;
using System.Collections.Generic;
using Practica02._iterator;

namespace Practica02
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto : IColeccionable ,Iterable
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
		
		//getter del List<Comparable>
		
		public List<Comparable> getListaElementos(){
			return this.listaElementos;
		}
		// metodos  de la implementacion de la  INTERFAZ IColeccionable.cs
		public int cuantos()
		{
			return this.listaElementos.Count;
		}

		public Comparable maximo()
		{
			//si la lista posee elementos
			if(this.listaElementos.Count > 0 ){
				Comparable valorInicial = this.listaElementos[0];
				foreach (Comparable e in this.listaElementos) {
					if(!valorInicial.sosMayor(e)){
						valorInicial = e;
					}
				}
				return valorInicial;
				
			}else
				throw new Exception("La lista esta vacia");
			//caso contratio mandamos un mensajito
		}

		public Comparable minimo()
		{
			//si la lista posee elementos
			if(this.listaElementos.Count > 0 ){
				Comparable valorInicial = this.listaElementos[0];
				foreach (Comparable e in this.listaElementos) {
					if(!valorInicial.sosMenor(e)){
						valorInicial = e;
					}
				}
				return valorInicial;
				
			}else
				throw new Exception("la lista esta vacia");
			//caso contratio mandamos un mensajito
		}

		public bool contiene(Comparable c)
		{
			return pertenece(c);
		}

		#region Iterable implementation

		public Iterador crearIterador()
		{
			return new IteradorDeConjunto(this);
		}

		#endregion
	}
}
