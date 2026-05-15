
using System;
using MetodologíasDeProgramaciónI;

namespace Practica04.Adapter
{
	/// <summary>
	/// Description of AlumnoAdapter.
	/// </summary>
	public class AlumnoAdapter: Student
	{
		//atributos 
		private IAlumno alumno; //composicion de lo que queremos adaptar
		public AlumnoAdapter(IAlumno alu)
		{
			this.alumno = alu;
		}
		//getter 
		public IAlumno getAlumno(){
			return this.alumno;
		}

		#region Student implementation

		public string getName()
		{
			//devolvemos nombre
			return this.alumno.getNombre();
		}

		public int yourAnswerIs(int question)
		{
			//respondemos una pregunta
			return this.alumno.responderPregunta(question);
		}

		public void setScore(int score)
		{
			//cambiamos calificaion
			this.alumno.setCalificacion(score);
		}

		public string showResult()
		{
			//mostramos resultado
			return this.alumno.mostrarCalificacion();
		}

		public bool equals(Student student)
		{
			//convertimos student en alumno adapter para poder poder acceder al alumno interno
			return this.alumno.sosIgual(((AlumnoAdapter)student).alumno);
		}

		public bool lessThan(Student student)
		{
			return this.alumno.sosMenor(((AlumnoAdapter)student).alumno);
		}

		public bool greaterThan(Student student)
		{
			return this.alumno.sosMayor(((AlumnoAdapter)student).alumno);
		}

		#endregion
	}
}
