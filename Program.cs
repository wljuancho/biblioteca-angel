using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            ShowMainMenu();
            string opcion = Console.ReadLine()?.Trim() ?? "";

            switch (opcion)
            {
                case "1":
                    BooksMenu();
                    break;
                case "2":
                    Console.WriteLine("Acción: abrir menú de usuarios.");
                    break;
                case "3":
                    Console.WriteLine("Acción: abrir menú de préstamos.");
                    break;
                case "4":
                    Console.WriteLine("Acción: abrir menú de búsquedas y reportes.");
                    break;
                case "5":
                    Console.WriteLine("Acción: abrir menú de guardar y cargar datos.");
                    break;
                case "6":
                    continuar = ConfirmExitAndSave();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, ingrese una opción del 1 al 6.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void ShowMainMenu()
    {
        Console.WriteLine("--------- MENÚ PRINCIPAL ---------");
        Console.WriteLine("1. Libros");
        Console.WriteLine("2. Usuarios");
        Console.WriteLine("3. Préstamos");
        Console.WriteLine("4. Búsquedas y reportes");
        Console.WriteLine("5. Guardar / Cargar datos");
        Console.WriteLine("6. Salir");
        Console.Write("Seleccione una opción: ");
    }

    static void BooksMenu()
    {
        bool volver = false;

        while (!volver)
        {
            ShowBooksMenu();
            string opcion = Console.ReadLine()?.Trim() ?? "";

            switch (opcion)
            {
                case "1.1":
                    RegisterBook();
                    break;
                case "1.2":
                    ListBooksMenu();
                    break;
                case "1.3":
                    ViewBookDetail();
                    break;
                case "1.4":
                    UpdateBookMenu();
                    break;
                case "1.5":
                    DeleteBook();
                    break;
                case "0":
                case "volver":
                    volver = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Seleccione una opción del menú de libros o escriba volver.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void ShowBooksMenu()
    {
        Console.WriteLine("--------- MENÚ LIBROS ---------");
        Console.WriteLine("1.1 Registrar libro");
        Console.WriteLine("1.2 Listar libros");
        Console.WriteLine("1.2.1 Listar todos");
        Console.WriteLine("1.2.2 Listar disponibles");
        Console.WriteLine("1.2.3 Listar prestados");
        Console.WriteLine("1.3 Ver detalle por ID/ISBN");
        Console.WriteLine("1.4 Actualizar libro");
        Console.WriteLine("1.4.1 Editar título");
        Console.WriteLine("1.4.2 Editar autor");
        Console.WriteLine("1.4.3 Editar año/categoría");
        Console.WriteLine("1.5 Eliminar libro");
        Console.WriteLine("0 o volver: Volver al menú principal");
        Console.Write("Seleccione una opción: ");
    }

    static void RegisterBook()
    {
        Console.WriteLine("Acción simulada: registrar un nuevo libro.");
    }

    static void ListBooksMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.WriteLine("--------- LISTAR LIBROS ---------");
            Console.WriteLine("1.2.1 Listar todos");
            Console.WriteLine("1.2.2 Listar disponibles");
            Console.WriteLine("1.2.3 Listar prestados");
            Console.WriteLine("0 o volver: Volver al menú de libros");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine()?.Trim() ?? "";
            switch (opcion)
            {
                case "1.2.1":
                    ListBooksAll();
                    break;
                case "1.2.2":
                    ListBooksAvailable();
                    break;
                case "1.2.3":
                    ListBooksBorrowed();
                    break;
                case "0":
                case "volver":
                    volver = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Seleccione 1.2.1, 1.2.2, 1.2.3 o volver.");
                    break;
            }
            Console.WriteLine();
        }
    }

    static void ListBooksAll()
    {
        Console.WriteLine("Acción simulada: listar todos los libros.");
    }

    static void ListBooksAvailable()
    {
        Console.WriteLine("Acción simulada: listar los libros disponibles.");
    }

    static void ListBooksBorrowed()
    {
        Console.WriteLine("Acción simulada: listar los libros prestados.");
    }

    static void ViewBookDetail()
    {
        Console.WriteLine("Acción simulada: mostrar el detalle de un libro por ID o ISBN.");
    }

    static void UpdateBookMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.WriteLine("--------- ACTUALIZAR LIBRO ---------");
            Console.WriteLine("1.4.1 Editar título");
            Console.WriteLine("1.4.2 Editar autor");
            Console.WriteLine("1.4.3 Editar año/categoría");
            Console.WriteLine("0 o volver: Volver al menú de libros");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine()?.Trim() ?? "";
            switch (opcion)
            {
                case "1.4.1":
                    EditBookTitle();
                    break;
                case "1.4.2":
                    EditBookAuthor();
                    break;
                case "1.4.3":
                    EditBookYearCategory();
                    break;
                case "0":
                case "volver":
                    volver = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Seleccione una opción o escriba volver.");
                    break;
            }
            Console.WriteLine();
        }
    }

    static void EditBookTitle()
    {
        Console.WriteLine("Acción simulada: editar el título de un libro.");
    }

    static void EditBookAuthor()
    {
        Console.WriteLine("Acción simulada: editar el autor de un libro.");
    }

    static void EditBookYearCategory()
    {
        Console.WriteLine("Acción simulada: editar el año y/o la categoría de un libro.");
    }

    static void DeleteBook()
    {
        Console.WriteLine("Acción simulada: validar que el libro no esté prestado antes de eliminarlo.");
    }

    static void UsersMenu()
    {
        bool volver = false;

        while (!volver)
        {
            Console.WriteLine("--------- MENÚ USUARIOS ---------");
            Console.WriteLine("2.1 Registrar usuario");
            Console.WriteLine("2.2 Listar usuarios");
            Console.WriteLine("2.3 Ver detalle por ID/documento");
            Console.WriteLine("2.4 Actualizar usuario");
            Console.WriteLine("2.4.1 Editar nombre");
            Console.WriteLine("2.4.2 Editar contacto");
            Console.WriteLine("2.4.3 Activar/desactivar");
            Console.WriteLine("2.5 Eliminar usuario");
            Console.WriteLine("0 o volver: Volver al menú principal");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine()?.Trim().ToLowerInvariant() ?? "";
            switch (opcion)
            {
                case "2.1": RegisterUser(); break;
                case "2.2": ListUsers(); break;
                case "2.3": ViewUserDetail(); break;
                case "2.4.1": EditUserName(); break;
                case "2.4.2": EditUserContact(); break;
                case "2.4.3": ToggleUserActiveStatus(); break;
                case "2.4": UpdateUserMenu(); break;
                case "2.5": DeleteUser(); break;
                case "0":
                case "volver": volver = true; break;
                default: Console.WriteLine("Opción no válida. Seleccione una opción del menú de usuarios o escriba volver."); break;
            }
            Console.WriteLine();
        }
    }

    static void RegisterUser()
    {
        Console.WriteLine("Acción simulada: registrar un nuevo usuario.");
    }

    static void ListUsers()
    {
        Console.WriteLine("Acción simulada: listar todos los usuarios.");
    }

    static void ViewUserDetail()
    {
        Console.WriteLine("Acción simulada: mostrar el detalle de un usuario por ID o documento.");
    }

    static void UpdateUserMenu()
    {
        bool volver = false;
        while (!volver)
        {
            Console.WriteLine("--------- ACTUALIZAR USUARIO ---------");
            Console.WriteLine("2.4.1 Editar nombre");
            Console.WriteLine("2.4.2 Editar contacto");
            Console.WriteLine("2.4.3 Activar/desactivar");
            Console.WriteLine("0 o volver: Volver al menú de usuarios");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine()?.Trim().ToLowerInvariant() ?? "";

            switch (opcion)
            {
                case "2.4.1": EditUserName(); break;
                case "2.4.2": EditUserContact(); break;
                case "2.4.3": ToggleUserActiveStatus(); break;
                case "0":
                case "volver": volver = true; break;
                default: Console.WriteLine("Opción no válida. Seleccione una opción o escriba volver."); break;
            }
            Console.WriteLine();
        }
    }

    static void EditUserName()
    {
        Console.WriteLine("Acción simulada: editar el nombre de un usuario.");
    }

    static void EditUserContact()
    {
        Console.WriteLine("Acción simulada: editar el contacto de un usuario.");
    }

    static void ToggleUserActiveStatus()
    {
        Console.WriteLine("Acción simulada: activar o desactivar el estado de un usuario.");
    }

    static void DeleteUser()
    {
        Console.WriteLine("Acción simulada: validar que el usuario no tenga préstamos activos antes de eliminarlo.");
    }
    static void LoansMenu()
    {
        bool volver = false;
        while (!volver)
        {
            Console.WriteLine("--------- MENÚ PRÉSTAMOS ---------");
            Console.WriteLine("3.1 Crear préstamo");
            Console.WriteLine("3.2 Listar préstamos");
            Console.WriteLine("3.2.1 Todos");
            Console.WriteLine("3.2.2 Activos");
            Console.WriteLine("3.2.3 Cerrados");
            Console.WriteLine("3.3 Ver detalle por ID");
            Console.WriteLine("3.4 Registrar devolución");
            Console.WriteLine("3.5 Eliminar préstamo");
            Console.WriteLine("0 o volver: Volver al menú principal");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine()?.Trim().ToLowerInvariant() ?? "";

            switch (opcion)
            {
                case "3.1": CreateLoan(); break;
                case "3.2": ListLoansMenu(); break;
                case "3.2.1": ListLoansAll(); break;
                case "3.2.2": ListLoansActive(); break;
                case "3.2.3": ListLoansClosed(); break;
                case "3.3": ViewLoanDetail(); break;
                case "3.4": RegisterReturn(); break;
                case "3.5": DeleteLoan(); break;
                case "0":
                case "volver": volver = true; break;
                default: Console.WriteLine("Opción no válida. Seleccione una opción del menú de préstamos o escriba volver."); break;
            }
            Console.WriteLine();
        }
    }

    static void CreateLoan()
    {
        Console.WriteLine("Acción simulada: crear préstamo. Validar: usuario existente y activo, libro existente y disponible, y máximo de préstamos activos del usuario.");
    }

    static void ListLoansMenu()
    {
        bool volver = false;
        while (!volver)
        {
            Console.WriteLine("--------- LISTAR PRÉSTAMOS ---------");
            Console.WriteLine("3.2.1 Todos");
            Console.WriteLine("3.2.2 Activos");
            Console.WriteLine("3.2.3 Cerrados");
            Console.WriteLine("0 o volver: Volver al menú de préstamos");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine()?.Trim().ToLowerInvariant() ?? "";

            switch (opcion)
            {
                case "3.2.1": ListLoansAll(); break;
                case "3.2.2": ListLoansActive(); break;
                case "3.2.3": ListLoansClosed(); break;
                case "0":
                case "volver": volver = true; break;
                default: Console.WriteLine("Opción no válida. Seleccione una opción o escriba volver."); break;
            }
            Console.WriteLine();
        }
    }

    static void ListLoansAll() { Console.WriteLine("Acción simulada: listar todos los préstamos."); }
    static void ListLoansActive() { Console.WriteLine("Acción simulada: listar los préstamos activos."); }
    static void ListLoansClosed() { Console.WriteLine("Acción simulada: listar los préstamos cerrados o devueltos."); }
    static void ViewLoanDetail() { Console.WriteLine("Acción simulada: mostrar el detalle de un préstamo por ID."); }
    static void RegisterReturn() { Console.WriteLine("Acción simulada: marcar el préstamo como devuelto y el libro como disponible."); }
    static void DeleteLoan() { Console.WriteLine("Acción simulada: eliminar préstamo solo si está cerrado o fue creado por error; si está activo, devolver el libro automáticamente."); }
    static bool ConfirmExitAndSave()
    {
        while (true)
        {
            Console.Write("¿Guardar antes de salir? (S/N): ");
            string respuesta = Console.ReadLine()?.Trim().ToUpperInvariant() ?? "";

            if (respuesta == "S")
            {
                Console.WriteLine("Acción simulada: guardando datos antes de salir.");
                Console.WriteLine("Saliendo del sistema. ¡Hasta pronto!");
                return false;
            }

            if (respuesta == "N")
            {
                Console.WriteLine("Saliendo del sistema sin guardar. ¡Hasta pronto!");
                return false;
            }

            Console.WriteLine("Respuesta no válida. Debe escribir S o N.");
        }
    }
}


