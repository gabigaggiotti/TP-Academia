# TP-Academia
Trabajo Practico Integrador -Academia NET

## Integrantes
49810 - Gabriele Gaggiotti
47433 - Tomás Lardizábal

## Sistema de Gestión Académica


El Sistema de Gestión Académica (SGA) registra y administra las actividades académicas de la universidad en torno a las entidades principales de Alumnos, Profesores, Materias y Cursos.

Tanto los Alumnos como los Profesores tienen datos en común tales como Legajo, Nombre, Apellido, Dirección entre otros. 

Las materias pertenecen a un Plan y tienen cantidad de horas de cursado semanales y totales. Los Planes son de una Especialidad.

Al inicio de cada año académico, la dirección académica crea los Cursos para cada Materia, a los que se les asigna una Comisión y cupo definido. 

Cada Curso tiene asignado Docentes en diferentes cargos.

Los Alumnos se inscriben a los diferentes Cursos, los cuales corresponden a una Materia, una Comisión y un año calendario de cursado. Al hacerlo el sistema deberá registrar los datos de dicha inscripción. El sistema solo permitirá inscripciones a Cursos que no tengan el cupo agotado.

Teniendo en cuenta este modelo las funcionalidades a implementar son las siguientes:

1. Alta, Baja, Modificaciones y Consulta de Usuarios.
2. Alta, Baja, Modificaciones y Consulta de Alumnos.
3. Alta, Baja, Modificaciones y Consulta de Especialidades.
4. Alta, Baja, Modificaciones y Consulta de Profesores.
5. Alta, Baja, Modificaciones y Consulta de Planes y Materias.
6. Alta, Baja, Modificaciones y Consulta de Comisiones.
7. Alta, Baja, Modificaciones y Consulta de Cursos.
8. Inscripciones de Alumnos a Cursos.
9. Registro de Notas.
10. Reporte de Cursos.
11. Reporte de Planes.

Para poder implementar estas funcionalidades se sugiere utilizar los siguientes Modelo de Objetos y de Datos (el diagrama de Datos fue hecho utilizando SQL Server).

### Modelo de Objetos

![Modelo de objetos](https://github.com/gabigaggiotti/TP-Academia/blob/7122e6ddc606214bc71560afc7e4b2a76777610d/Imagenes/Modelo%20de%20Objetos.png)

### Modelo de Datos

![Modelo de datos](https://github.com/gabigaggiotti/TP-Academia/blob/6638e46adccc67f810a37d53cd60cffdcf1e16e7/Imagenes/Modelo%20de%20Datos.png)
