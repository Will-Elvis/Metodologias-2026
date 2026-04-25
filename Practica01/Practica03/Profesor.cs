
using System;
using Practica03._strategy;

namespace Practica03
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor : Persona
	{
		//atributos
		private int antiguedad;
		private IEstrategiaDeComparacion estrategia;
		//constructor
		public Profesor(string nom,int doc,int ant):base(nom,doc)
		{
			this.antiguedad = ant;
			this.estrategia = new EstrategiaPorAntiguedad();
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

		#region Comparable implementation

		public override bool sosIgual(Comparable c)
		{
			return this.estrategia.sosIgual(this,c);
		}

		public override bool sosMenor(Comparable c)
		{
			return this.estrategia.sosMenor(this,c);
		}

		public override bool sosMayor(Comparable c)
		{
			return this.estrategia.sosMayor(this,c);
		}

		#endregion
	}
}
