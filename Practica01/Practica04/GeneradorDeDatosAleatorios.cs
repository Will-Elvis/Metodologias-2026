
using System;
using System.Text;

namespace Practica04
{
	/// <summary>
	/// Description of GeneradorDeDatosAleatorios.
	/// </summary>
	public class GeneradorDeDatosAleatorios
	{
		static Random azar = new Random();
		public GeneradorDeDatosAleatorios()
		{
		}
		public int numeroAleatorio(int max){
			return azar.Next(0,max+1); // sumamos 1 por que Next(a,b-1) Funciona de esta manera
		}
		public string stringAleatorio(int cant)
		{
			const string alfabeto = "abcdefghijklmnopqrstuvwxyz";
			StringBuilder textoAleatorio = new StringBuilder();
		
			for (int i = 0; i < cant; i++) {
				int posicionAleatoria = azar.Next(alfabeto.Length);
				textoAleatorio.Append(alfabeto[posicionAleatoria]); //.Append(Char value) esta va sumando los caracteres a textoAleatorio
			}
		
			return textoAleatorio.ToString();// convertimos a String
		}

	}
}

