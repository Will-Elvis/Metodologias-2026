
using System;

namespace Practica04._decorator
{
	/// <summary>
	/// Description of DecoradoConLegajo.
	/// </summary>
	public class DecoradoConLegajo : AlumnoDecorator
	{
		public DecoradoConLegajo(IAlumno alu) : base(alu)
		{
		}
		
		public override string mostrarCalificacion()
		{
			string resultado = base.mostrarCalificacion();
			// Insertamos el legajo justo antes de la tabulación que separa el nombre de la calificación
			//profe
			//resultado = resultado.Insert(resultado.IndexOf("\t")," (" + adicional.getLegajo() + ")");
			//================================
			// Buscamos la posicion donde empieza la calificacion.
			int posicionTabulacion = resultado.IndexOf("\t"); //guardamos el valor de la posiciond de la tabulacion
		
			// Armamos el texto que queremos agregar despues del nombre.
			string legajo = " (" + adicional.getLegajo() + ")"; //-->> (legajo)
		
			// Insertamos el legajo antes de la calificacion.
			// IndexOf("\t") Busca la posicion de un valor en concreto dentro de nuestro STRING "resultado"
			resultado = resultado.Insert(posicionTabulacion, legajo); // insertamos el texto del legajo en la posición donde estaba la tabulación.
			return resultado;
		}
	}
}
