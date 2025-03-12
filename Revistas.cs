// Revistas
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una lista para almacenar los títulos de las revistas
        List<string> catalogo = new List<string>();

        // Agregar 10 títulos al catálogo
        Console.WriteLine("Ingrese 10 títulos de revistas:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Título {i + 1}: ");
            string titulo = Console.ReadLine();
            catalogo.Add(titulo);
        }

        // Mostrar el menú de opciones
        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Buscar un título");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingrese el título a buscar: ");
                string tituloBuscar = Console.ReadLine();

                // Buscar el título en el catálogo
                if (catalogo.Contains(tituloBuscar))
                {
                    Console.WriteLine("Encontrado");
                }
                else
                {
                    Console.WriteLine("No encontrado");
                }
            }
            else if (opcion == "2")
            {
                Console.WriteLine("Saliendo del programa...");
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }
        }
    }
}