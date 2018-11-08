# ExamenEntity
## Examen Entity Framework
### Andrea García Bravo

## 1.
Primero creo las estructuras de datos en su clase especifica. Hago una relacion many to many con ICollection entre pizza e ingredient para crear automaticamente una tabla de relacion.  
Agrego una constante beneficio en appSettings en AppConfig, la cual llamo desde la clase ingredient para multiplicar al precio de los ingredientes que recoge la pizza. Lo convierto a decimal porque de appConfig recoge un string.

## 2.
Creo una interface IEjercicio2 donde llamo a los metodos de un repositorio que he creado.  
En ese repositorio (Ejercicio2Repository), en la clase le hago heredar de la interfaz y de IDisposable.  
Dentro, llamo a un context que he creado en otra clase, y agrego los metodos add, find, remove, entry y savechanges en cada metodo en funcion de lo que queremos que haga.  
En los insert usamos add para agregar pizza o ingrediente.  
En los delete buscamos el id seleccionado y borramos de la base de datos.  
En los update le decimos que modifique la pizza o ingrediente seleccionado.  
Y en el save llamamos a el metodo savechanges que tiene context.  
  
En el archivo context (PizzeriaContext) creamos una interfaz iunitofwork a la que llamamos junto con un dbcontext.  
Dentro de la clase, usamos Dbset con pizza e ingredientes.  
Y dentro de un metodo llamado OnModelCreating, le decimos que entidades de la base de datos son necesarias y a los name le agrego el maximo de caracteres que puede almacenar.

## 3.
Creo un IEnumerable que haga una busqueda en Pizza. Con Take(), le digo que coja las 15 primeras lineas. Y con Skip(), le digo que salte un numero concreto de filas.  
En el primer caso al ser la pagina 1 --> 1-1 * 15. 1-1 es 0 por lo que el resultado (0) le diria que no salte ninguna.

## 4.
Creo un decimal que recoge la constante benefict de appconfig y la convierte en decimal.  
Despues creo una variable que recoge todos los ingredientes que tenga una pizza.  
Si el numero de ingredientes en un pizza es menor de 1, lanza una excepcion.  
Para terminar regresa la suma del precio de los ingredientes por el beneficio.  
  
Despues de todo, en la consola de paquetes NuGet, escribo la linea "enable-migrations" (si no lo he hecho antes) que crea la base de datos.  
Despues, escribo "add-migration InitialCreate" que crea un archivo en la carpeta migration con los cambios que se quieren hacer en la base de datos.  
Una vez hecho, escribo "update-database" para actualizar la base de datos.

