using System;

class Program
{
    static void Main()
    {
        const double LibrasAKg = 0.453592;

        Console.WriteLine("=== CONVERSOR DE UNIDADES ===");
        
        Console.Write("Ingrese el peso en libras (lb): ");
        if (double.TryParse(Console.ReadLine(), out double libras))
        {
            Console.Write("Ingrese la temperatura en grados Fahrenheit (°F): ");
            if (double.TryParse(Console.ReadLine(), out double fahrenheit))
            {
                double kilogramos = libras * LibrasAKg;
                double celsius = (fahrenheit - 32) * 5.0 / 9.0;

                Console.WriteLine("\n--- RESULTADOS ---");
                Console.WriteLine($"Peso ingresado: {libras} lb equivalen a {kilogramos:F2} kg");
                Console.WriteLine($"Temperatura ingresada: {fahrenheit} °F equivalen a {celsius:F2} °C");
            }
            else
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido para la temperatura.");
            }
        }
        else
        {
            Console.WriteLine("Error: Ingrese un valor numérico válido para el peso.");
        }
    }
}