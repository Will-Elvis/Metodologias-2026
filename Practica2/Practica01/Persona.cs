/*
 * Creado por SharpDevelop.
 * Usuario: PcHome
 * Fecha: 3/4/2026
 * Hora: 19:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica02
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public abstract class Persona : Comparable
	{
		//atributos
		private string nombre;
		private int dni;
		public Persona(string n,int d)
		{
			nombre = n;
			dni = d;
		}
		
		//getters 
		public string getNombre(){
			return this.nombre;
		}
		
		public int getDni(){
			return this.dni;
		}

		#region Comparable implementation
		// DNI --> int
		
		public virtual bool sosIgual(Comparable c)
		{
			return this.dni == ((Persona)c).getDni();
		}

		public virtual bool sosMenor(Comparable c)
		{
			return this.dni < ((Persona)c).getDni();
		}

		public virtual bool sosMayor(Comparable c)
		{
			return this.dni > ((Persona)c).getDni();
		}
		
		
		// Nombre --> String 
//		
//		public bool sosIgual(Comparable c)
//		{
//			return this.nombre == ((Persona)c).getNombre();
//		}
//
//		public bool sosMenor(Comparable c)
//		{
//			return this.nombre.CompareTo(((Persona)c).getNombre()) < 0;
//		}
//
//		public bool sosMayor(Comparable c)
//		{
//			return this.nombre.CompareTo(((Persona)c).getNombre()) > 0;
//		}
		public override string ToString()
		{
		    return dni.ToString();
		}
//		
		//averiguar funcionalidad del CompareTo luego en Google  
		//this.obj.CompareTo(obj) > 0 ; --> true  ejemplo JUAN > Ana (true)

		#endregion
	}
}
