# Prediccion-Resultados-Alumnos-Version-2

>[!WARNING]
>La aplicación no fue testeada a fondo, y no contiene casos de validación. Puede contener errores críticos. No se recomienda usarla fuera de un ámbito informal.


## Acerca de:
Aplicación creada como una evolución de [Predicción de resultados de alumnos.](https://github.com/cer0uno1/Prediccion-de-Resultados-de-Alumnos)

Practicamente realiza las mismas operaciones, solo que en este caso utiliza un CRUD básico manejado por consultas en una base de datos MySQL. Escrita en C#, utiliza Windows Forms para crear una IU para que el usuario pueda utilizarla.

## Modo de uso:

El formulario principal contiene seis botones:

- El primer botón se encarga de la consulta INSERT, para agregar los datos ingresados a la base de datos.

- El segundo botón se encarga de la consulta DELETE, en este caso se utiliza el DNI del alumno como clave primaria, y se borran los datos de solo ese alumno.

- El tercer botón se encarga de la consulta UPDATE, utilizando un SELECT selecciona los datos del alumno (utilizando la misma metodología del segundo botón). Luego, se actualizan los datos del alumno con los ingresados.

- El cuarto botón se encarga de mostrar los datos de un alumno en especifico, utilizando SELECT, y la clave primaria DNI.

- El quinto botón realiza lo mismo que el anterior, pero sin limitarse a un solo individuo.

- El sexto y último botón se encarga de cerrar la aplicación.

## Créditos:
Ideado y diseñado originalmente por [Sebastián M. Errecalde](https://github.com/cer0uno1), Agosto - Diciembre 2023.
