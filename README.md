# Sistema de Biblioteca en C#

Proyecto de consola desarrollado para la evidencia **220501097-04-AA1 – EV06: Aplicación de la sintaxis básica de C# - Funciones**.

## Descripción

Aplicación de consola con navegación interactiva entre el menú principal y sus submenús. Las operaciones se representan mediante funciones `static` que muestran mensajes descriptivos, sin clases de dominio, colecciones reales, CRUD real ni persistencia real.

## Requisitos técnicos cumplidos

- Menú principal funcional.
- Submenús completos para libros, usuarios, préstamos, búsquedas/reportes y datos.
- Navegación real entre menús.
- Opciones para volver al menú anterior.
- Validación de opciones y entradas inválidas.
- Confirmaciones `S/N` para reiniciar datos y salir.
- Funciones `static`, `switch`, `if` y ciclos `while`.
- Sin POO ni persistencia real.

## Menús

### Menú principal

1. Libros
2. Usuarios
3. Préstamos
4. Búsquedas y reportes
5. Guardar / Cargar datos
6. Salir

### Navegación

- Las opciones numeradas permiten acceder a cada módulo.
- Escriba `0` o `volver` para regresar al menú anterior.
- Las opciones inválidas muestran un mensaje y permiten repetir la elección.
- La salida pregunta si se deben guardar los datos antes de finalizar.

## Ejecución

Requisitos:

- Git instalado.
- .NET SDK compatible con el proyecto configurado.

Ejecutar desde la carpeta del proyecto:

```powershell
dotnet run
```

## Git Flow aplicado

Ramas utilizadas:

- `main`: versión integrada entregable.
- `develop`: integración de los módulos.
- `feature/main-menu-navigation`
- `feature/books-menu`
- `feature/users-menu`
- `feature/loans-menu`
- `feature/search-reports-menu`
- `feature/persistence-menu`
- `feature/exit-flow`
- `fix/menu-integration`
- `docs/update-readme`

No se creó ni utilizó `feature/project-bootstrap`, conforme a la decisión del proyecto.

Los cambios se realizaron mediante commits con convención:

- `feat:` nuevas funcionalidades.
- `fix:` corrección de errores o integración.
- `docs:` documentación.

## Historial de entrega

1. Creación de ramas desde `develop`.
2. Implementación de cada módulo por su propia rama feature.
3. Merge de cada rama feature en `develop`.
4. Corrección de integración fusionada en `develop`.
5. Actualización documental en una rama `docs/`.
6. Merge final de `develop` en `main`.
