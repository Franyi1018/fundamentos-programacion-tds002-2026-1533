class Program
{
    static void Main(string[] args)
    {
        // Tasa del día: cuántos dólares vale 1 peso (valor de ejemplo, cámbialo por la tasa real)
        const double TASA_USD = 0.0165;

        // Pedimos el monto en pesos
        Console.Write("¿Cuántos pesos quieres convertir? ");
        double montoPesos = double.Parse(Console.ReadLine());

        // Convertimos multiplicando por la tasa
        double montoDolares = montoPesos * TASA_USD;

        // F2 muestra solo 2 decimales
        Console.WriteLine($"{montoPesos} pesos equivalen a {montoDolares:F2} dólares.");
    }
}