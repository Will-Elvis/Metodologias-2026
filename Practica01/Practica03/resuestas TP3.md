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


## RESPUESTA A LA PREGUNTA 7 DEL TP3

### El problema de elegir el tipo de colección en el `main`

Si en el método `main` también se quiere elegir el tipo de colección en la que se van a almacenar los comparables, aparece un problema similar al que se resolvió con **Factory Method** para la creación de `Numero` y `Alumno`.

El `main` tendría que conocer e instanciar directamente clases concretas como:
- `Pila`
- `Cola`
- `Conjunto`
- `ColeccionMultiple`

Esto genera **acoplamiento** y hace que, cada vez que se agregue una nueva colección, haya que modificar el código cliente.

---

### La solución: fábrica para colecciones

Para evitar eso, conviene **encapsular también la creación de las colecciones** en una fábrica.

De este modo:
- El `main` trabaja contra la **interfaz** `IColeccionable`.
- Delega la decisión de qué colección concreta crear a una clase especializada (por ejemplo, `FabricaDeColeccionables`).

---

### Ventajas

Así, el programa queda:
- Más **flexible**.
- Más **reutilizable**.
- Fácil de **extender**, ya que para agregar una nueva colección solo habría que modificar la fábrica y **no el resto del sistema**.


## RESPUESTA A LA PREGUNTA 10 DEL TP3

### Refactorización de la jerarquía de fábricas

Las fábricas de `Alumno` y `Profesor` tienen en común que ambas crean objetos que son subclases de `Persona`. Por lo tanto, comparten parte de la lógica de construcción, como la obtención o generación de `nombre` y `dni`.

---

### Solución propuesta

Sí, podría ampliarse la jerarquía de fábricas agregando una **clase abstracta intermedia**, por ejemplo `FabricaDePersonas`, que herede de `FabricaDeComparables`.

- **`FabricaDePersonas`** (abstracta) → se encarga de la lógica común a todas las personas:
  - Obtener o generar `nombre`
  - Obtener o generar `dni`

- **Fábricas concretas** (`FabricaDeAlumno` y `FabricaDeProfesor`) → se ocupan solo de los datos específicos de cada clase:
  - `FabricaDeAlumno`: agrega atributos como `promedio` o `fecha_de_egreso`
  - `FabricaDeProfesor`: agrega atributos como `antigüedad`

---

### Ventajas

De esta manera se logra:

- **Reducción de duplicación de código**
- **Mejora de la extensibilidad** del diseño