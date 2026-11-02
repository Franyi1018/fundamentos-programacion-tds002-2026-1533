using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = -1;

        do
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("    ACTIVIDAD SEMANA 8: 08-FOR-MENÚS");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Tablas de multiplicar del 1 al 10 (Ciclos anidados)");
            Console.WriteLine("2. Dibujar triángulo de asteriscos");
            Console.WriteLine("0. Salir");
            Console.Write("\nSeleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        EjecutarTablasMultiplicar();
                        break;
                    case 2:
                        EjecutarTrianguloAsteriscos();
                        break;
                    case 0:
                        Console.WriteLine("\n¡Saliendo del programa. Éxito!");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida. Presione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nEntrada no válida. Presione una tecla para continuar.");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }

    // --- PARTE 1: TABLAS DE MULTIPLICAR ANIDADAS ---
    static void EjecutarTablasMultiplicar()
    {
        Console.Clear();
        Console.WriteLine("=== TABLAS DE MULTIPLICAR DEL 1 AL 10 ===");
        Console.WriteLine("(Usando ciclos anidados y columnas alineadas)\n");

        // Ciclo externo para los multiplicadores (del 1 al 10)
        for (int i = 1; i <= 10; i++)
        {
            // Ciclo interno para los números a multiplicar (del 1 al 10)
            for (int j = 1; j <= 10; j++)
            {
                int resultado = i * j;
                // Mostrar con formato de columnas alineadas {valor,4}
                Console.Write($"{resultado,4}");
            }
            Console.WriteLine(); // Salto de línea por cada fila de la tabla
        }

        Console.Write("\nPresione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }

    // --- PARTE 2: TRIÁNGULO DE ASTERISCOS ---
    static void EjecutarTrianguloAsteriscos()
    {
        Console.Clear();
        Console.WriteLine("=== TRIÁNGULO DE ASTERISCOS ===");
        
        Console.Write("Ingrese el número de filas (N) para el triángulo: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.WriteLine();
            // Ciclo para las filas
            for (int i = 1; i <= n; i++)
            {
                // Ciclo para imprimir los asteriscos de cada fila
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Error: Por favor ingrese un número entero positivo válido.");
        }

        Console.Write("\nPresione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }
}