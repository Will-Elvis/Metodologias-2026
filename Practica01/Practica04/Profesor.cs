
using System;
using Practica04._strategy;
using Practica04._observer;
using System.Collections.Generic;

namespace Practica04
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor : Persona , Observado
	{
		//atributos
		private int antiguedad;
		private IEstrategiaDeComparacion estrategia;
		private List<Observador> observadores;
		private bool hablando; 
		//constructor
		public Profesor(string nom,int doc,int ant):base(nom,doc)
		{
			this.antiguedad = ant;
			this.estrategia = new EstrategiaPorAntiguedad();
			this.observadores = new List<Observador>();
		}
		//getter
		public int getAntiguedad(){
			return this.antiguedad;
		}
		
		public void hablarALaClase(){
			Console.WriteLine("Hablando de algun tema");
			this.hablando = true;
			this.notificar();
		}
		public void escribirEnElPizarron(){
			Console.WriteLine("Escribiendo en el pizarron");
			this.hablando = false;
			this.notificar(); // el profesor notifica su accion para que cada alumno  se actualize
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

		#region Observado implementation

		public void agregarObservador(Observador o)
		{
			this.observadores.Add(o);
		}

		public void quitarObservador(Observador o)
		{
			this.observadores.Remove(o);
		}

		public void notificar()
		{
			foreach (Observador obs in this.observadores) {
				obs.actualizar(this);
			}
		}
		public bool estaHablando(){
			return this.hablando;
		}

		#endregion
	}
}

