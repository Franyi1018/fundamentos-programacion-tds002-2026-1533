using System;

class AdivinaNumero
{
    static void Main(string[] args)
    {
        int numeroSecreto = Random.Shared.Next(1, 101);
        int intento = 0;
        int contadorIntentos = 0;

        Console.WriteLine("=== PROGRAMA 2: ADIVINA EL NÚMERO ===");
        Console.WriteLine("He pensado en un número secreto entre 1 y 100. ¡Intenta adivinarlo!\n");

        while (intento != numeroSecreto)
        {
            Console.Write("Ingrese su suposición: ");
            if (int.TryParse(Console.ReadLine(), out intento))
            {
                contadorIntentos++;

                if (intento < numeroSecreto)
                {
                    Console.WriteLine("El número secreto es MAYOR.\n");
                }
                else if (intento > numeroSecreto)
                {
                    Console.WriteLine("El número secreto es MENOR.\n");
                }
                else
                {
                    Console.WriteLine($"\n¡Felicidades! Has adivinado el número secreto ({numeroSecreto}).");
                    Console.WriteLine($"Total de intentos realizados: {contadorIntentos}");
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese un número entero válido.\n");
            }
        }
    }
}