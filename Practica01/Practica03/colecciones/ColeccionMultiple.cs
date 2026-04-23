/*
 * Creado por SharpDevelop.
 * Usuario: PcHome
 * Fecha: 3/4/2026
 * Hora: 16:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica03
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary>
	public class ColeccionMultiple: IColeccionable
	{
		private Pila pila;
		private Cola cola;
		public ColeccionMultiple(Pila p, Cola c)
		{
			this.pila = p;
			this.cola = c;
		}
		
		#region IColeccionable implementation
		public int cuantos()
		{
			return pila.cuantos()+cola.cuantos();
		}
		public Comparable minimo()
		{
			Comparable p = pila.minimo();
			Comparable c = cola.minimo();
			if(p.sosMenor(c)){
				return p;
			}else
				return c;
		}
		public Comparable maximo()
		{
			Comparable p = pila.maximo();
			Comparable c = cola.maximo();
			if(p.sosMayor(c)){
				return p;
			}else
				return c;
		}
		public void agregar(Comparable c)
		{
			throw new NotImplementedException("Este metodo no hace nada Ejercicio 8 practica 1");
		}
		public bool contiene(Comparable c)
		{
			return pila.contiene(c)||cola.contiene(c); // true si el alguna se cumple , false en caso de
			// no estar en ninguna y true si esta en ambas
		}
		#endregion
	}
}

