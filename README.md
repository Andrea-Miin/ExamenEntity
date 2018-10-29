# ExamenEntity
## Examen Entity Framework
### Andrea García Bravo
29/10/2018

## 1.
Primero creo las estructuras de datos en su clase especifica. Hago una relacion many to many entre pizza e ingredient y agrego una tabla de relacion.  
Creo una constante del beneficio, la cual multiplico despues a la suma del precio de los ingredientes que recoge la pizza.

## 2.
A la clase le hago heredar del repositorio DbContext. Con ello, implemento Unit of Work.  
Dentro de la clase, implemento Repository Pattern al usar DbSet<>.

## 3.

Para la alternativa con LINQ, creo IEnumerable que haga una busqueda en Pizza. Y con Take(), le digo que coja las 15 primeras lineas.

## 4.

Despues de todo, en la consola de paquetes NuGet, escribo la linea enable-migrations que crea y actualiza la base de datos.

