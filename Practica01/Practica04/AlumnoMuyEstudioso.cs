
using System;

namespace Practica04
{
	/// <summary>
	/// Description of AlumnoMuyEstudioso.
	/// </summary>
	public class AlumnoMuyEstudioso : Alumno
	{
		public AlumnoMuyEstudioso(string nom,int doc,int l, double p) :base(nom,doc,l,p)
		{
		}
		//reescribimos el metodo para que responda las preguntas correctamente
		public override int responderPregunta(int pregunta){
			return pregunta % 3;
		}
	}
}
