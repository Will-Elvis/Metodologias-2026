Repsuesta Teorica del 10 :

Al agregar `AlumnoEgresado` como subclase de `Alumno`, la mayor parte del sistema debería seguir funcionando sin modificaciones importantes, porque todas las colecciones, iteradores y estrategias trabajan con tipos generales como `Comparable`, `Persona` o `Alumno`.

Solo habría que:

- Agregar la nueva clase.
- Realizar modificaciones puntuales en los lugares donde se quiera usar el nuevo atributo `fecha_de_egreso`, por ejemplo:
  - En el método `ToString`.
  - En la creación de objetos.
  - Eventualmente, en nuevas estrategias de comparación si se quisiera comparar por fecha de egreso.
 
Respuesta Teorica del  11 

Para poder imprimir únicamente los alumnos que tengan mejor promedio que un "alumno promedio" de 7.00 sin modificar la función del ejercicio 7, es necesario cambiar el mecanismo de recorrido y no la función de impresión.

La solución consiste en:

1. Incorporar un **iterador especial** que:
   - Reciba como referencia un alumno con promedio 7.00.
   - Utilice una estrategia de comparación por promedio.
   - Recorra solamente aquellos alumnos del conjunto que resulten **mayores** según esa estrategia.

2. De esta forma:
   - La función `imprimirElementos` permanece intacta.
   - El iterador entrega solo los elementos deseados.

Esto aprovecha conjuntamente los patrones **Strategy** e **Iterator**:
- **Strategy** define el criterio de comparación.
- **Iterator** controla qué elementos son recorridos.



