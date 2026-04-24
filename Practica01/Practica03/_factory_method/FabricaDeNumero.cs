
using System;

namespace Practica03._factory_method
{
	/// <summary>
	/// Description of FabricaDeNumero.
	/// </summary>
	public class FabricaDeNumero :FabricaDeComparables
	{
		public FabricaDeNumero()
		{
		}
		#region implemented abstract members of FabricaDeComparables
		public override Comparable crearAleatorio()
		{
			return new Numero(generador.numeroAleatorio(40));
		}
		public override Comparable crearPorTeclado()
		{
			Console.Write("Ingrese un numero para buscar: ");
			int numero = lector.numeroPorTeclado();
			return new Numero(numero);
		}
		#endregion
	}
}
