/*
 * Creado por SharpDevelop.
 * Usuario: PcHome
 * Fecha: 3/4/2026
 * Hora: 20:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using Practica04._strategy;
using Practica04._observer;

namespace Practica04
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona, Observador
	{
		//atributos 
		private int legajo;
		private double promedio;
		private List<string> frases;
		private int calificacion; // representa la ultima calificacion
		private IEstrategiaDeComparacion estrategia;
		Random azar = new Random();
		
		public Alumno(string nom,int doc,int l, double p) :base(nom,doc)
		{
			legajo =l;
			promedio= p;
			estrategia = new EstrategiaPorDni();
			frases = new List<string>(){"Mirando el celular","Dibujando en el margen de la carpeta", "Tirando aviones de papel"};
		}
		
		//getters
		public int getCalificacion(){
			return this.calificacion;
		}
		public void setCalificacion(int valordecalificacion){
			this.calificacion = valordecalificacion;
		}
		public int getLegajo(){
			return this.legajo;
		}
		public double getPromedio(){
			return this.promedio;
		}
		public void setEstrategia(IEstrategiaDeComparacion e){
			estrategia = e;
		}
		//metodos de la intefaz Comparable
		public override bool sosIgual(Comparable c)
		{
			return this.estrategia.sosIgual(this,(Alumno)c);
		}

		public override bool sosMenor(Comparable c)
		{
			return this.estrategia.sosMenor(this,(Alumno)c);
		}

		public override bool sosMayor(Comparable c)
		{
			return this.estrategia.sosMayor(this,(Alumno)c);
		}
		public IEstrategiaDeComparacion getEstrategia(){
			return this.estrategia;
		}
		public override string ToString()
		{
			return "\nEstrategia de Comparacion: " + getEstrategia() +"\nNombre: " + getNombre() + " \nDNI: " + getDni() + " \nLegajo: " + getLegajo() + " \nPromedio: " + getPromedio();
		}
		public void prestarAtencion(){
			Console.WriteLine("Prestando atencion: ");
		}
		public void distraerse(){
			int indiceAleatorio = azar.Next(this.frases.Count);
			Console.WriteLine(this.frases[indiceAleatorio]);
		}
		//nuevos metodos para la clase alumno
		public int responderPregunta(int pregunta){
			return azar.Next(1,4);
		}
		public string mostrarCalificacion(){
			// raton perez  7
			return this.getNombre() + " " + this.getCalificacion();
		}
		#region Observador implementation
		public void actualizar(Observado o)
		{
			//si es True
			if(((Profesor)o).estaHablando()){
				this.prestarAtencion();
			}else
				this.distraerse();
		}
		#endregion
	}
}


