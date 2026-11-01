class Program
{
    static void Main(string[] args)
    {
        // Pedimos un número con decimales
        Console.Write("Escribe un número con decimales (ejemplo: 7.85): ");
        double numero = double.Parse(Console.ReadLine());

        // Casting explícito: nosotros pedimos convertir double a int (se pierden los decimales)
        int parteEntera = (int)numero;

        Console.WriteLine($"Número original: {numero}");
        Console.WriteLine($"Parte entera (casting explícito): {parteEntera}");

        // Casting implícito: C# convierte int a double solo, sin que lo pidamos
        double enteroComoDouble = parteEntera;

        // F1 muestra 1 decimal para que se note que ahora es double
        Console.WriteLine($"Ese entero como double (casting implícito): {enteroComoDouble:F1}");
    }
}