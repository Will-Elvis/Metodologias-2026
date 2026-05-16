
using System;

namespace Practica04._decorator
{
	/// <summary>
	/// Description of DecoradoConLetras.
	/// </summary>
	public class DecoradoConLetras :AlumnoDecorator
	{
		public DecoradoConLetras(IAlumno alu) : base(alu)
		{
		}
		
		//metodo
		
		public override string mostrarCalificacion()
		{
			string[] numerosEnletras = new string[] {"CERO", "UNO", "DOS", "TRES", "CUATRO","CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ"};

			string resultado = base.mostrarCalificacion(); //ratonperez 6
			resultado += " (" + numerosEnletras[adicional.getCalificacion()] + ")";
			return resultado;
		}
	}
}
