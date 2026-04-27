
using System;

namespace Practica04
{
	/// <summary>
	/// Description of LectorDeDatos.
	/// </summary>
	public class LectorDeDatos
	{
		public LectorDeDatos()
		{
		}
		//devuelve un numero leido por teclado
		public int numeroPorTeclado(){
			return int.Parse(Console.ReadLine());
		}
		//devuelve un string leido por teclado
		public string stringPorTeclado(){
			return Console.ReadLine();
		}
	}
}

