/*
 * Creado por SharpDevelop.
 * Usuario: PcHome
 * Fecha: 30/3/2026
 * Hora: 17:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Practica01
{
	/// <summary>
	/// Description of IColeccionable.
	/// </summary>
	public interface IColeccionable
	{
		int cuantos();
		int maximo();
		int minimo();
		void agregar(Comparable c);
		bool contiene(Comparable c);
	}
}
