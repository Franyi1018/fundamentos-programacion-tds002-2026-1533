using System;

class PromedioValidado
{
    static void Main(string[] args)
    {
        double sumaNotas = 0;
        int contadorNotas = 0;
        double notaMayor = double.MinValue;
        double notaMenor = double.MaxValue;
        double nota = 0;

        Console.WriteLine("=== PROGRAMA 3: PROMEDIO VALIDADO ===");
        Console.WriteLine("Ingrese notas válidas (0-100). Escriba -1 para finalizar y calcular.\n");

        do
        {
            Console.Write("Ingrese una nota (-1 para terminar): ");
            if (double.TryParse(Console.ReadLine(), out nota))
            {
                if (nota == -1)
                {
                    break;
                }

                if (nota >= 0 && nota <= 100)
                {
                    sumaNotas += nota;
                    contadorNotas++;

                    if (nota > notaMayor)
                    {
                        notaMayor = nota;
                    }
                    if (nota < notaMenor)
                    {
                        notaMenor = nota;
                    }
                }
                else
                {
                    Console.WriteLine("Error: La nota debe estar en el rango de 0 a 100.");
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido.");
            }

        } while (true);

        Console.WriteLine("\n================ RESULTADOS FINALES ================");
        if (contadorNotas > 0)
        {
            double promedio = sumaNotas / contadorNotas;
            Console.WriteLine($"Cantidad de notas ingresadas: {contadorNotas}");
            Console.WriteLine($"Promedio general: {promedio:N2}");
            Console.WriteLine($"Nota más alta: {notaMayor:N2}");
            Console.WriteLine($"Nota más baja: {notaMenor:N2}");
        }
        else
        {
            Console.WriteLine("No se ingresaron notas válidas para calcular el promedio.");
        }
        Console.WriteLine("====================================================");
    }
}