using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("    ACTIVIDAD SEMANA 6: 06-DECISIONES");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Evaluador de Calificaciones");
            Console.WriteLine("2. Calculadora con Switch");
            Console.WriteLine("3. Salir");
            Console.Write("\nSeleccione una opción (1-3): ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        EvaluarCalificacion();
                        break;
                    case 2:
                        EjecutarCalculadora();
                        break;
                    case 3:
                        Console.WriteLine("\n¡Saliendo del programa!");
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

        } while (opcion != 3);
    }

    // --- PARTE 1: CALIFICACIÓN ---
    static void EvaluarCalificacion()
    {
        Console.Clear();
        Console.WriteLine("--- 1. EVALUADOR DE CALIFICACIONES ---");
        Console.Write("Ingrese la nota obtenida (0 - 100): ");

        if (int.TryParse(Console.ReadLine(), out int nota))
        {
            if (nota >= 0 && nota <= 100)
            {
                string letra;

                // Estructura if - else if - else solicitada
                if (nota >= 90)
                {
                    letra = "A";
                }
                else if (nota >= 80)
                {
                    letra = "B";
                }
                else if (nota >= 70)
                {
                    letra = "C";
                }
                else
                {
                    letra = "F";
                }

                Console.WriteLine($"\nResultado: Su calificación es '{letra}' (Nota: {nota})");
            }
            else
            {
                Console.WriteLine("\nError: La nota debe estar en el rango de 0 a 100.");
            }
        }
        else
        {
            Console.WriteLine("\nError: Debe ingresar un valor numérico entero válido.");
        }

        Console.Write("\nPresione una tecla para volver al menú...");
        Console.ReadKey();
    }

    // --- PARTE 2: CALCULADORA ---
    static void EjecutarCalculadora()
    {
        Console.Clear();
        Console.WriteLine("--- 2. CALCULADORA CON SWITCH ---");

        Console.Write("Ingrese el primer número: ");
        if (double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.Write("Ingrese el segundo número: ");
            if (double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("\nElija una operación:");
                Console.WriteLine("1. Sumar (+)");
                Console.WriteLine("2. Restar (-)");
                Console.WriteLine("3. Multiplicar (*)");
                Console.WriteLine("4. Dividir (/)");
                Console.Write("Opción (1-4): ");

                if (int.TryParse(Console.ReadLine(), out int operacion))
                {
                    Console.WriteLine("\n--- RESULTADO ---");
                    // Estructura switch solicitada
                    switch (operacion)
                    {
                        case 1:
                            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                            break;
                        case 2:
                            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                            break;
                        case 3:
                            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                            break;
                        case 4:
                            if (num2 != 0)
                            {
                                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                            }
                            else
                            {
                                Console.WriteLine("Error: No se puede dividir entre cero.");
                            }
                            break;
                        default:
                            Console.WriteLine("Opción de operación no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Opción no válida.");
                }
            }
            else
            {
                Console.WriteLine("Error: Segundo número no válido.");
            }
        }
        else
        {
            Console.WriteLine("Error: Primer número no válido.");
        }

        Console.Write("\nPresione una tecla para volver al menú...");
        Console.ReadKey();
    }
}