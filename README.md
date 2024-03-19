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
![image](https://github.com/moiseshernandez27/ProyectoFinalPNT1/assets/26515616/55c6fb6c-a0da-4f0e-b7d1-b234cfd44eca)
