class Program
{
    static void Main(string[] args)
    {
        // Constante: nunca cambia
        const int ANIO_ACTUAL = 2026;

        // Pregunta 1: nombre (string = texto)
        Console.Write("¿Cómo te llamas? ");
        string nombre = Console.ReadLine();

        // Pregunta 2: edad (int = número entero)
        Console.Write("¿Cuántos años tienes? ");
        int edad = int.Parse(Console.ReadLine());

        // Pregunta 3: estatura (double = número con decimales)
        Console.Write("¿Cuánto mides en metros? (ejemplo: 1.75) ");
        double estatura = double.Parse(Console.ReadLine());

        // Cálculo del año de nacimiento
        int anioNacimiento = ANIO_ACTUAL - edad;

        // Mostrar todo con interpolación
        Console.WriteLine($"Hola {nombre}, tienes {edad} años y mides {estatura} metros.");
        Console.WriteLine($"Naciste aproximadamente en el año {anioNacimiento}.");
    }
}