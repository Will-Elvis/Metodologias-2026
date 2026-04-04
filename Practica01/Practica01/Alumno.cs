/*
 * Creado por SharpDevelop.
 * Usuario: PcHome
 * Fecha: 3/4/2026
 * Hora: 20:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica01
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona
	{
		private int legajo;
		private double promedio;
		
		public Alumno(string nom,int doc,int l, double p) :base(nom,doc)
		{
			legajo =l;
			promedio= p;
		}
		
		//getters
		public int getLegajo(){
			return this.legajo;
		}
		
		public double getPromedio(){
			return this.promedio;
		}
	}
}
