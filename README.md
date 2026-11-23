# Sistema de Biblioteca en C#

Proyecto de consola para las evidencias de programación del sistema de biblioteca, con integración incremental mediante Git Flow.

## Actividades reflejadas en este repositorio

- **EV06 – Funciones:** `Program.cs` mantiene las opciones del menú como métodos `static`, con navegación, validación de entradas, opciones de volver y confirmaciones. Las acciones de EV06 siguen siendo mensajes simulados; los modelos y servicios de las actividades posteriores no convierten esos stubs en CRUD real.
- **EV07 – POO:** `Models/` contiene `Libro`, `Usuario`, `Prestamo` y `EstadoPrestamo`, con propiedades, constructores, valores iniciales, resúmenes, detalles y métodos requeridos. La opción 7 muestra los objetos de prueba.
- **EV08 – List y Services:** `Services/` contiene un servicio por entidad. Cada servicio administra una `List<T>` privada y ofrece operaciones de gestión, búsqueda, ordenación y estadísticas. La opción 8 ejecuta una demostración de punta a punta.

EV01–EV05 corresponden a infografías, configuración del entorno o ejercicios/proyectos previos independientes descritos en la guía; sus entregables no forman parte de este repositorio del Sistema de Biblioteca.

## Capa Services

- `LibroService`: agregar, eliminar por ID, obtener todos, buscar por ISBN/título/autor, ordenar por título/año y calcular total, disponibles y prestados.
- `UsuarioService`: agregar, eliminar por ID, obtener todos, buscar por documento/nombre, ordenar por nombre y calcular total, activos e inactivos.
- `PrestamoService`: agregar, eliminar por ID, obtener todos, buscar por ID/estado, ordenar por fecha límite y calcular total, préstamos activos/vencidos/devueltos y promedio de días.

La guía pide ordenación de préstamos por fecha límite, pero no define un plazo ni incluye esa propiedad en el modelo de EV07. Para esta actividad, el servicio calcula la fecha límite como `FechaPrestamo + 14 días`; la regla está centralizada en `PrestamoService` y se muestra en la demostración.

Los métodos para eliminar devuelven `true` si encontraron y eliminaron un registro, o `false` si el ID no existe. Las búsquedas por texto no distinguen mayúsculas/minúsculas. El promedio de días se calcula sobre préstamos devueltos; si no hay ninguno, devuelve cero.

## Ejecución y demostración

Requisitos: .NET 10 SDK (LTS), configurado como `net10.0` en `Biblioteca-angel.csproj`. `global.json` selecciona una versión estable de la línea 10.x.

```powershell
dotnet run
```

- **6:** salir (se conserva el flujo de EV06).
- **7:** mostrar los objetos de prueba de EV07.
- **8:** crear servicios y datos de prueba; comparar `Array` y `List<T>`; ejecutar búsquedas, ordenaciones y KPIs para las tres entidades.

## Git Flow

- `main`: incremento integrado de entrega.
- `develop`: integración continua del trabajo.
- Cada funcionalidad se desarrolla en una rama `feature/*` creada desde `develop`, se registra con commits claros, se sube al remoto y se fusiona en `develop` mediante merge commit. Al cerrar EV08, `develop` se fusiona en `main`.
- Las ramas `feature` se conservan después de fusionarlas como evidencia del proceso.

Ramas EV08:

- `feature/services-setup`
- `feature/libro-service`
- `feature/usuario-service`
- `feature/prestamo-service`
- `feature/services-kpis`
- `feature/services-demo`

Ramas previas conservadas: `feature/main-menu-navigation`, `feature/books-menu`, `feature/users-menu`, `feature/loans-menu`, `feature/search-reports-menu`, `feature/persistence-menu`, `feature/exit-flow`, `feature/models-libro`, `feature/models-usuario`, `feature/models-prestamo`, `feature/models-enum-estado-prestamo`, `feature/models-testing-objetos` y `feature/ev07-demo-menu`.

Ramas de soporte conservadas: `fix/menu-integration` y `docs/update-readme`.

Convención de commits: `feat:` para funcionalidad, `fix:` para correcciones y `docs:` para documentación; los merges llevan mensajes `merge:` que identifican la rama integrada.
