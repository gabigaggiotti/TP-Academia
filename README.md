# TP-Academia
Trabajo Practico Integrador -Academia NET

## Sistema de Gestión Académica


El Sistema de Gestión Académica (SGA) registra y administra las actividades académicas de la universidad en torno a las entidades principales de Alumnos, Profesores, Materias y Cursos.

Tanto los Alumnos como los Profesores tienen datos en común tales como Legajo, Nombre, Apellido, Dirección entre otros. 

Las materias pertenecen a un Plan y tienen cantidad de horas de cursado semanales y totales. Los Planes son de una Especialidad.

Al inicio de cada año académico, la dirección académica crea los Cursos para cada Materia, a los que se les asigna una Comisión y cupo definido. 

Cada Curso tiene asignado Docentes en diferentes cargos.

Los Alumnos se inscriben a los diferentes Cursos, los cuales corresponden a una Materia, una Comisión y un año calendario de cursado. Al hacerlo el sistema deberá registrar los datos de dicha inscripción. El sistema solo permitirá inscripciones a Cursos que no tengan el cupo agotado.

Teniendo en cuenta este modelo las funcionalidades a implementar son las siguientes:

Alta, Baja, Modificaciones y Consulta de Usuarios
Alta, Baja, Modificaciones y Consulta de Alumnos 
Alta, Baja, Modificaciones y Consulta de Especialidades
Alta, Baja, Modificaciones y Consulta de Profesores
Alta, Baja, Modificaciones y Consulta de Planes y Materias
Alta, Baja, Modificaciones y Consulta de Comisiones
Alta, Baja, Modificaciones y Consulta de Cursos
Inscripciones de Alumnos a Cursos
Registro de Notas
Reporte de Cursos
Reporte de Planes

Para poder implementar estas funcionalidades se sugiere utilizar los siguientes Modelo de Objetos y de Datos (el diagrama de Datos fue hecho utilizando SQL Server).
