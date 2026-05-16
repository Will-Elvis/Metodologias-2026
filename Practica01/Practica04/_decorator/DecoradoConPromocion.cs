
using System;

namespace Practica04._decorator
{
	/// <summary>
	/// Description of DecoradoConPromocion.
	/// </summary>
	public class DecoradoConPromocion:AlumnoDecorator
	{
		public DecoradoConPromocion(IAlumno alu) : base(alu)
		{
		}
		//sobreescribimos metodo
		public override string mostrarCalificacion()
		{
			string resultado = base.mostrarCalificacion();

			if (adicional.getCalificacion() < 4)
				resultado += " (DESAPROBADO)";
			else if (adicional.getCalificacion() >= 4 && adicional.getCalificacion() < 7)
				resultado += " (APROBADO)";
			else
				resultado += " (PROMOCION)";

			return resultado;
		}
	}
}
