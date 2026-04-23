## RESPUESTA A LA PREGUNTA 1 DEL TP3

### 1. Repetición en los métodos `llenar` y `llenarAlumnos`

La única diferencia entre ambos métodos era el tipo de objeto que se creaba dentro de cada uno:

- En `llenar` → se generaban objetos de tipo `Numero`.
- En `llenarAlumnos` → se generaban objetos de tipo `Alumno`.

El resto de la lógica era igual:
- repetir varias veces,
- crear un objeto que implemente `Comparable`,
- agregarlo a una colección.

Esto muestra que había **código repetido** y que lo único que cambiaba era la clase concreta que se instanciaba.

---

### 2. Problemas similares con el método `informar`

A medida que se ejecutaban distintos `main`, hubo que ir modificando `informar` para que pudiera trabajar con diferentes tipos de objetos:

- Si la colección contenía **números** → `informar` debía pedir un número por teclado y crear un `Numero` para buscarlo.
- Si la colección contenía **alumnos** → debía pedir un dato correspondiente al alumno (como el DNI) y crear un `Alumno` para verificar si estaba en la colección.

Es decir, `informar` comenzó a **depender del tipo concreto** de objeto almacenado.

---

### 3. Impacto de agregar una nueva clase (`Profesor`)

Si apareciera una nueva clase `Profesor`, que se quisiera comparar por antigüedad, habría que volver a modificar el código existente:

- Crear un nuevo método como `llenarProfesores`, **o** modificar `llenar`.
- Cambiar `informar` para que pida la antigüedad y cree un `Profesor` para buscarlo en la colección.

> Esto haría que **cada nueva clase** obligue a tocar métodos que ya estaban funcionando, generando código repetido y poco flexible.

---

### Conclusión

Por eso se introduce el patrón **Factory Method**, para delegar la creación de objetos y permitir que `llenar` e `informar` trabajen de manera más general con objetos `Comparable`.