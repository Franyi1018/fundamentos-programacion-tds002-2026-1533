using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("    ACTIVIDAD SEMANA 7: 07-CICLOS");
        Console.WriteLine("========================================");

        int numero = 0;
        bool esValido = false;

        // 1. Pide un número entre 1 y 12 y valídalo con do-while
        do
        {
            Console.Write("Ingrese un número entero entre 1 y 12: ");
            string entrada = Console.ReadLine() ?? "";

            if (int.TryParse(entrada, out numero))
            {
                if (numero >= 1 && numero <= 12)
                {
                    esValido = true;
                }
                else
                {
                    Console.WriteLine("Error: El número debe estar estrictamente entre 1 y 12. Intente de nuevo.\n");
                }
            }
            else
            {
                Console.WriteLine("Error: Entrada no válida. Ingrese un número entero.\n");
            }

        } while (!esValido);

        Console.WriteLine($"\n¡Número válido aceptado: {numero}!\n");
        Console.WriteLine($"--- TABLA DE MULTIPLICAR DEL {numero} (DEL 1 AL 12) ---");

        // 2. Muestra su tabla de multiplicar del 1 al 12 con while (usando un contador)
        int contador = 1;
        double acumuladorSuma = 0; // 3. Acumulador para la suma de todos los resultados

        while (contador <= 12)
        {
            double resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");
            
            // Acumular el resultado
            acumuladorSuma += resultado;
            
            // Incrementar el contador
            contador++;
        }

        // 3. Mostrar la suma de todos los resultados
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Suma total de todos los resultados: {acumuladorSuma}");
        Console.WriteLine("========================================");
        
        Console.Write("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}