/*
 * Creado por SharpDevelop.
 * Usuario: PcHome
 * Fecha: 3/4/2026
 * Hora: 20:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using Practica03._strategy;

namespace Practica03
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
// Paso 3 numero tres modificammos el Contexto para aplicar STRATEGY
	public class Alumno : Persona
	{
		private int legajo;
		private double promedio;
		// Paso 3.1 Creamos la Composicion que esta en el diagrama UML 
		private IEstrategiaDeComparacion estrategia;
		
		public Alumno(string nom,int doc,int l, double p) :base(nom,doc)
		{
			legajo =l;
			promedio= p;
			//Paso 3.2 definir Estrategia por defecto
			estrategia = new EstrategiaPorDni();
		}
		
		//getters
		public int getLegajo(){
			return this.legajo;
		}
		
		public double getPromedio(){
			return this.promedio;
		}
		// Paso 3.3 crear modificador para la estrategia
		public void setEstrategia(IEstrategiaDeComparacion e){
			estrategia = e;
		}
		
		
		// Paso 3.4  este el mas importante por que delegamos la responsabilidad de comparar Alumnos
		// a las estrategias
		//sobreescribimos metodos hereados de Persona
		public override bool sosIgual(Comparable c)
		{
			//return this.legajo == ((Alumno)c).getLegajo();
			//this es el alumno Actual quien posee todos los atributos en esta clase
			// (Alumno)c == un alumno pasado por parametro para comparar con el actual de la clase "this"
			//dellega el trabajo a la estrategia que tiene  el almno por defecto que es por Promdio
			// entonces -- > this.EstratategiaPorPromedio.sosIgual(this,alumnopasado_por_parametro)
			return this.estrategia.sosIgual(this,(Alumno)c);
		}

		public override bool sosMenor(Comparable c)
		{
			//return this.legajo < ((Alumno)c).getLegajo();
			return this.estrategia.sosMenor(this,(Alumno)c);
		}

		public override bool sosMayor(Comparable c)
		{
			//return this.legajo > ((Alumno)c).getLegajo();
			return this.estrategia.sosMayor(this,(Alumno)c);
		}
		/*
		public override string ToString()
		{
		    return "Nombre: " + getNombre() + " DNI: " + getDni() + " Legajo: " + legajo + " Promedio: " + promedio;
		}
		*/
		public IEstrategiaDeComparacion getEstrategia(){
			return this.estrategia;
		}
		
		public override string ToString()
		{
			return "\nEstrategia de Comparacion: " + getEstrategia() +"\nNombre: " + getNombre() + " \nDNI: " + getDni() + " \nLegajo: " + getLegajo() + " \nPromedio: " + getPromedio();
		}


	}
}

