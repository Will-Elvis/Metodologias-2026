/*
 * Creado por SharpDevelop.
 * Usuario: PcHome
 * Fecha: 30/3/2026
 * Hora: 17:36
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using Practica02._iterator;

namespace Practica02
{
	/// <summary>
	/// Una Pila sigue el principio de LIFO(last In First Out)
	/// </summary>
	public class Pila : IColeccionable, Iterable
	{
		private List<Comparable> elementos;
		public Pila()
		{
			elementos = new List<Comparable>();
		}
		
		//metodos
		
		
		//push  : Inserta un elemento en la parte superior de la Pila
		public void apilar(Comparable e){
			elementos.Add(e);
		}

		public Comparable desapilar(){
			int i = (elementos.Count)-1;
			if (i >= 0){
				Comparable e = elementos[i];
				elementos.RemoveAt(i);
				return e;
			}else
				throw new InvalidOperationException("No hay elementos en la Pila");
		}
		public List<Comparable> getPila(){
			return this.elementos;
		}
		
		#region IColeccionable implementation
		public int cuantos()
		{
			return this.elementos.Count;
		}
		public Comparable maximo()
		{
			if(elementos.Count > 0){
				Comparable e = elementos[0] ;
				foreach (Comparable c in this.elementos) {
					if(e.sosMayor(c)==false){
						e = c;
					}
				}
				return e;
			}else
				throw new Exception("La coleccion esta vacia no se puede encontrar el Maximo");
			
		}
		public Comparable minimo()
		{
			if(elementos.Count > 0){
				Comparable e = elementos[0];
				foreach (Comparable c in this.elementos) {
					if (!e.sosMenor(c)) {
						e = c;
					}
				}
				return e;
			}else
				throw new Exception("La Coleccion esta vacia no se puede encontrar el minimo");
			
		}
		public void agregar(Comparable c)
		{
			elementos.Add(c);
		}
		public bool contiene(Comparable c)
		{
			foreach (Comparable e in this.elementos) {
				if (c.sosIgual(e)) {
					return true;
				}
			}
			return false;
		}
		#endregion
		
		public override string ToString(){
			return elementos.ToString();
		}

		#region Iterable implementation
		public Iterador crearIterador()
		{
			return new IteradorDePila(this);
		}
		#endregion
	}
}
