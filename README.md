# Sistema de Biblioteca en C#

Proyecto de consola desarrollado para la evidencia **220501097-04-AA1 – EV07: Definición de clases y objetos base del sistema de biblioteca en C# aplicando programación orientada a objetos y Git Flow**.

## Descripción

La aplicación conserva los menús funcionales desarrollados en EV06 e incorpora el modelo de dominio básico de la biblioteca. Las clases `Libro`, `Usuario` y `Prestamo`, junto con el enumerador `EstadoPrestamo`, están organizadas en `Models/`. La opción 7 del menú principal muestra objetos de prueba y sus propiedades y métodos.

## Modelo de dominio

- `Models/Libro.cs`: propiedades, constructores, disponibilidad inicial, resumen, detalle y `ToString()`.
- `Models/Usuario.cs`: propiedades, constructores, estado activo inicial, resumen, detalle y `ToString()`.
- `Models/EstadoPrestamo.cs`: estados `Activo`, `Devuelto` y `Vencido`.
- `Models/Prestamo.cs`: fechas `DateTime` y `DateTime?`, estado inicial activo, fecha de devolución nula y métodos de resumen, detalle, vencimiento y días transcurridos.

## Ejecutar

Requisitos: Git y el SDK de .NET compatible con `Biblioteca-angel.csproj`.

Desde la carpeta del proyecto:

```powershell
dotnet run
```

En el menú principal, seleccione **7. Demostrar objetos de prueba (EV07)** para ver:

- Dos libros y dos usuarios, con resúmenes y detalles.
- Un préstamo, con resumen, detalle, estado, validación `EstaVencido()` y días transcurridos.
- Los valores iniciales `Disponible = true` y `Activo = true`.

La opción 6 conserva la salida del sistema.

## Git Flow aplicado

- `main`: versión integrada de entrega.
- `develop`: integración progresiva del proyecto.
- Ramas de funcionalidad conservadas en el repositorio remoto:
  - `feature/main-menu-navigation`
  - `feature/books-menu`
  - `feature/users-menu`
  - `feature/loans-menu`
  - `feature/search-reports-menu`
  - `feature/persistence-menu`
  - `feature/exit-flow`
  - `feature/models-libro`
  - `feature/models-usuario`
  - `feature/models-prestamo`
  - `feature/models-enum-estado-prestamo`
  - `feature/models-testing-objetos`
- Ramas de soporte: `fix/menu-integration` y `docs/update-readme`.

Cada módulo se trabajó en su propia rama, con commits descriptivos y merge a `develop`. El incremento EV06 se integró previamente en `main`; el incremento EV07 se integró en `develop` y se publica en `main` mediante un merge de `develop`.

Convenciones usadas en los mensajes de commit:

- `feat:` funcionalidad nueva.
- `fix:` correcciones.
- `docs:` documentación.

Las ramas `feature` se mantienen después de los merges para conservar la evidencia del trabajo incremental.
