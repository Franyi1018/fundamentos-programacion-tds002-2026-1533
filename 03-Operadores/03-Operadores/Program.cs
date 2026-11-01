class Program
{
    static void Main(string[] args)
    {
        // Pedimos los dos números enteros
        Console.Write("Escribe el primer número entero (x): ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Escribe el segundo número entero (y): ");
        int y = int.Parse(Console.ReadLine());

        // Operaciones
        int suma = x + y;
        int resta = x - y;
        int producto = x * y;
        double divisionReal = (double)x / y;   // (double) hace que la división dé decimales
        int divisionEntera = x / y;            // entre enteros, solo queda la parte entera
        int residuo = x % y;                   // lo que sobra al dividir
        bool esPar = x % 2 == 0;               // true si x es par

        // Mostramos los resultados con interpolación
        Console.WriteLine();
        Console.WriteLine($"Suma: {x} + {y} = {suma}");
        Console.WriteLine($"Resta: {x} - {y} = {resta}");
        Console.WriteLine($"Producto: {x} * {y} = {producto}");
        Console.WriteLine($"División real: {x} / {y} = {divisionReal:F2}");
        Console.WriteLine($"División entera: {x} / {y} = {divisionEntera}");
        Console.WriteLine($"Residuo: {x} % {y} = {residuo}");
        Console.WriteLine($"¿{x} es par? {esPar}");
    }
}

/*
PRUEBA DE ESCRITORIO (x = 10, y = 3)

Línea de código                          | Cálculo       | Resultado
-----------------------------------------|---------------|----------
int x = ...                              | entrada       | x = 10
int y = ...                              | entrada       | y = 3
int suma = x + y;                        | 10 + 3        | 13
int resta = x - y;                       | 10 - 3        | 7
int producto = x * y;                    | 10 * 3        | 30
double divisionReal = (double)x / y;     | 10.0 / 3      | 3.3333... (se muestra 3.33)
int divisionEntera = x / y;              | 10 / 3        | 3
int residuo = x % y;                     | 10 % 3        | 1
bool esPar = x % 2 == 0;                 | 10 % 2 == 0   | true

Salida en pantalla:
Suma: 10 + 3 = 13
Resta: 10 - 3 = 7
Producto: 10 * 3 = 30
División real: 10 / 3 = 3.33
División entera: 10 / 3 = 3
Residuo: 10 % 3 = 1
¿10 es par? True
*/