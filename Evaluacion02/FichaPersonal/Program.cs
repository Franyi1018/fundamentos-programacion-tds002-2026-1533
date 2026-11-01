class Program
{
    static void Main(string[] args)
    {
        // Constante: el año en que estamos
        const int anioActual = 2026;

        // Pedimos los datos al usuario
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();

        Console.Write("¿Cuántos años tienes? ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("¿Cuánto mides en metros? (ejemplo: 1.75) ");
        double estatura = double.Parse(Console.ReadLine());

        Console.Write("¿Trabajas? (escribe true o false) ");
        bool trabaja = bool.Parse(Console.ReadLine());

        // Calculamos el año en que cumplirá 30 años
        int anioCumple30 = anioActual + (30 - edad);

        // Mostramos la ficha con interpolación
        Console.WriteLine();
        Console.WriteLine("===== FICHA PERSONAL =====");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura} metros");
        Console.WriteLine($"Trabaja: {trabaja}");
        Console.WriteLine($"Cumplirá 30 años en el año {anioCumple30}");
    }
}