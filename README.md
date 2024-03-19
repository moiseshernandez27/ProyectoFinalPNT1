Proyecto de práctica profesionalizante - PNT1 - 1° 2C 2023
Proyecto realizado usando .NET y patrón MVC por:

Hernández, Moises @moiseshernandez27
Objetivo de la aplicación
La aplicación tiene como objetivo principal permitir a los usuarios registrarse y loguearse para gestionar sus tareas diarias. Podrán crear, modificar, eliminar tareas, así como establecer el estado de cada tarea (hecha o pendiente) y utilizar un timer para aplicar la técnica Pomodoro, registrando cuántos pomodoros han completado.

Funcionalidades
Registro de usuarios
Se podrá dar de alta un nuevo usuario con los campos:

Nombre
Email (debe tener un formato correcto mail@dominio.com)
Edad (debe ser un número entero mayor a 12)
Contraseña (alfanumérico, al menos 5 caracteres con 1 mayúscula, 1 minúscula y 1 carácter especial)
Todos los campos son obligatorios

Inicio de sesión
Se ingresa al portal con:

Email
Contraseña
Cierre de sesión
Se podrá cerrar la sesión del usuario sin perder ningún dato. Al volver a ingresar desde el mismo o cualquier otro navegador se visualizará lo mismo que antes de cerrarla.

Creación de tareas
No se puede crear una tarea sin descripción (front y back)
La descripción debe ser alfanumérica (front)
Modificación de tareas
Se podrá modificar:

El estado de la tarea (hecha o no). Para este punto hay que validar que no se pueda marcar como hecha una tarea que está configurada para ser con pomodoro y no tenga ninguno completado
La descripción de la misma
Si es o no una tarea con pomodoro **En el caso que tenga pomodoros, permitir agregar
Eliminación de tareas
Se podrá eliminar cualquier tarea.

Diagrama de clases
![tareas](https://github.com/moiseshernandez27/ProyectoFinalPNT1/assets/26515616/7caceada-835f-4bf4-97c4-efc87551e6c9)

Navegación por el sitio
Paso	Descripción	Pantalla
1	Acceder a la pantalla de registro	Registro
2	Ingresar un nombre válido	Registro
3	Ingresar un correo electrónico válido	Registro
4	Ingresar una edad válida	Registro
5	Ingresar una contraseña con al menos 5 caracteres, incluyendo al menos 1 mayúscula, 1 minúscula y 1 carácter especial	Registro
6	Hacer click en "Registrarse"	Registro
7	Verificar que se redirija a la pantalla de inicio de sesión después de un registro exitoso	Inicio de sesión
8	Ingresar un correo electrónico válido	Inicio de sesión
9	Ingresar la contraseña correspondiente	Inicio de sesión
10	Hacer click en "Iniciar Sesión"	Inicio de sesión
11	Verificar que se redirija a la pantalla principal después de un inicio de sesión exitoso	Pantalla principal
12	Hacer click en "Crear"	Pantalla principal
13	Ingresar la descripción para la tarea	Pantalla principal > Modal creación tarea
14	Si se desea que la tarea tenga pomodoros, hacer click en el checkbox	Pantalla principal > Modal creación tarea
15	Hacer click en "Guardar"	Pantalla principal > Modal creación tarea
16	Verificar que se cierre el modal y la tarea se agregue correctamente	Pantalla principal
17	Hacer click sobre el lápiz de la tarea para editarla	Pantalla principal
18	Modificar la descripción de la tarea y la configuración de pomodoro	Pantalla principal > Modal modificación tarea
19	Hacer click en "Guardar cambios"	Pantalla principal > Modal modificación tarea
20	Verificar que se cierre el modal y las modificaciones hayan impactado	Pantalla principal
21	Hacer click en el checkbox de la tarea para marcarla como hecha	Pantalla principal
22	Verificar que quede "Hecha" y se traslade al listado de abajo	Pantalla principal
23	Hacer click en el tacho de basura de la tarea para eliminarla	Pantalla principal
24	Confirmar la eliminación	Pantalla principal
25	Verificar que se haya eliminado y no aparezca en ningún listado	Pantalla principal
26	Verificar estar logueado en la aplicación	Pantalla principal
27	Hacer click en "Cerrar Sesión"	Pantalla principal
28	Verificar que se redirija a la pantalla de inicio de sesión	Inicio de sesión
