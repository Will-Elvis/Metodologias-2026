/*
 * Creado por SharpDevelop.
 * Usuario: PcHome
 * Fecha: 2/4/2026
 * Hora: 11:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Practica01
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola : IColeccionable
	{
		private List<Comparable> elementos;
		public Cola()
		{
			elementos = new List<Comparable>();
		}
		// metodos de  un Cola
		public void encolar(Comparable c){
			elementos.Add(c);
		}
		public Comparable desencolar(){
			if(elementos.Count > 0){
				Comparable e = elementos[0];
				elementos.RemoveAt(0);
				return e;
			}else
				throw new Exception("La Cola esta Vacia");
		}
		

		#region IColeccionable implementation

		public int cuantos()
		{
			return this.elementos.Count;
		}

		public Comparable maximo()
		{
			if(elementos.Count > 0){
				Comparable e = this.elementos[0];
				foreach (Comparable c in this.elementos) {
					if(e.sosMayor(c) == false){
						e = c;
					}
				}
				return e;
			}else
				throw new Exception("La Cola esta vacia no se puede encontrar Maximo");
		}

		public Comparable minimo()
		{
			if(elementos.Count > 0){
				Comparable e = this.elementos[0];
				foreach (Comparable c in this.elementos) {
					if (e.sosMenor(c) == false) {
						e=c;
					}
				}
				return e;
			}else
				throw new Exception("La Cola esta vacia no se puede encontrar Minimo");
		}

		public void agregar(Comparable c)
		{
			this.elementos.Add(c);
		}

		public bool contiene(Comparable c)
		{
			foreach (Comparable e in this.elementos) {
				if(c.sosIgual(e)){
					return true;
				}
			}
			return false;
		}

		#endregion
	}
}
