/*
 * Creado por SharpDevelop.
 * Usuario: PcHome
 * Fecha: 29/3/2026
 * Hora: 18:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica01
{
	/// <summary>
	/// Description of Numero.
	/// </summary>
	public class Numero : Comparable
	{
		private int valor;
		
		public Numero(int valor)
		{
			this.valor = valor;
		}
		
		public int getValor(){
			return this.valor;
		}
		
		public bool sosIgual(Comparable c)
		{
			return this.valor == ((Numero)c).getValor();
		}
		public bool sosMenor(Comparable c)
		{
			return this.valor < ((Numero)c).getValor();
		}
		public bool sosMayor(Comparable c)
		{
			return this.valor > ((Numero)c).getValor();
		}
		
		public override string ToString()
		{
		    return valor.ToString();
		}
		
	}
}
