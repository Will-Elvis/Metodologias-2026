
using System;

namespace Practica04._decorator
{
	/// <summary>
	/// Description of DecoradoConAsterisco.
	/// </summary>
	public class DecoradoConAsterisco : AlumnoDecorator
	{
		public DecoradoConAsterisco(IAlumno alu):base(alu)
		{
			
		}
		public override string mostrarCalificacion(){
			string baseTexto = base.mostrarCalificacion();
			string resultado = "";
			
			for (int i = 0; i < baseTexto.Length + 4; i++){
				resultado += "*";
			}

			resultado += "\n* " + baseTexto + " *\n";

			for (int i = 0; i < baseTexto.Length + 4; i++){
				resultado += "*";
			}
			return resultado;
		}
	}
}
