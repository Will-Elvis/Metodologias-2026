
using System;

namespace Practica03
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor : Persona
	{
		//atributos
		private int antiguedad;
		//constructor
		public Profesor(string nom,int doc,int ant):base(nom,doc)
		{
			this.antiguedad = ant;
		}
		//getter
		public int getAntiguedad(){
			return this.antiguedad;
		}
		public void hablarALaClase(){
			Console.WriteLine("Hablando de algun tema");
		}
		public void escribirEnElPizarron(){
			Console.WriteLine("Escribiendo en el pizarron");
		}
	}
}
