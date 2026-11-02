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
            Console.WriteLine("    EVALUACIÓN 03 - PROGRAMAS SECUENCIALES");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Nómina (Salario, AFP, SFS y Neto)");
            Console.WriteLine("2. Factura (Subtotal, ITBIS y Total alineados)");
            Console.WriteLine("3. Geometría (Círculo y Triángulo Rectángulo)");
            Console.WriteLine("4. Salir");
            Console.Write("\nSeleccione una opción (1-4): ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        EjecutarNomina();
                        break;
                    case 2:
                        EjecutarFactura();
                        break;
                    case 3:
                        EjecutarGeometria();
                        break;
                    case 4:
                        Console.WriteLine("\n¡Saliendo del programa. Éxito con tu tarea!");
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

        } while (opcion != 4);
    }

    // --- PROGRAMA 1: NÓMINA ---
    static void EjecutarNomina()
    {
        Console.Clear();
        Console.WriteLine("--- 1. CÁLCULO DE NÓMINA ---");
        
        const double PorcentajeAfp = 0.0287; // 2.87%
        const double PorcentajeSfs = 0.0304; // 3.04%

        Console.Write("Ingrese el nombre del empleado: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Ingrese las horas trabajadas: ");
        double.TryParse(Console.ReadLine(), out double horasTrabajadas);

        Console.Write("Ingrese el pago por hora: ");
        double.TryParse(Console.ReadLine(), out double pagoHora);

        double salarioBruto = horasTrabajadas * pagoHora;
        double descuentoAfp = salarioBruto * PorcentajeAfp;
        double descuentoSfs = salarioBruto * PorcentajeSfs;
        double salarioNeto = salarioBruto - (descuentoAfp + descuentoSfs);

        Console.WriteLine("\n================ RESULTADO NÓMINA ================");
        Console.WriteLine($"Empleado: {nombre.ToUpper()}");
        Console.WriteLine($"Salario Bruto: {salarioBruto:N2}");
        Console.WriteLine($"Descuento AFP (2.87%): {descuentoAfp:N2}");
        Console.WriteLine($"Descuento SFS (3.04%): {descuentoSfs:N2}");
        Console.WriteLine($"Salario Neto: {salarioNeto:N2}");
        Console.WriteLine("==================================================");
        Console.Write("\nPresione una tecla para volver al menú...");
        Console.ReadKey();
    }

    // --- PROGRAMA 2: FACTURA ---
    static void EjecutarFactura()
    {
        Console.Clear();
        Console.WriteLine("--- 2. FACTURA DE PRODUCTO ---");

        const double ItbisConstante = 0.18; // 18%

        Console.Write("Ingrese el nombre del producto: ");
        string producto = Console.ReadLine() ?? "Producto";

        Console.Write("Ingrese la cantidad: ");
        double.TryParse(Console.ReadLine(), out double cantidad);

        Console.Write("Ingrese el precio unitario: ");
        double.TryParse(Console.ReadLine(), out double precioUnitario);

        double subtotal = cantidad * precioUnitario;
        double itbis = subtotal * ItbisConstante;
        double total = subtotal + itbis;

        Console.WriteLine("\n================ FACTURA COMERCIAL ================");
        Console.WriteLine(string.Format("{0,-15} {1,10} {2,10}", "PRODUCTO", "CANT.", "TOTAL"));
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine(string.Format("{0,-15} {1,10:N2} {2,10:N2}", producto, cantidad, subtotal));
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine(string.Format("{0,-25} {1,10:N2}", "Subtotal:", subtotal));
        Console.WriteLine(string.Format("{0,-25} {1,10:N2}", "ITBIS (18%):", itbis));
        Console.WriteLine(string.Format("{0,-25} {1,10:N2}", "TOTAL A PAGAR:", total));
        Console.WriteLine("==================================================");
        Console.Write("\nPresione una tecla para volver al menú...");
        Console.ReadKey();
    }

    // --- PROGRAMA 3: GEOMETRÍA ---
    static void EjecutarGeometria()
    {
        Console.Clear();
        Console.WriteLine("--- 3. CÁLCULOS GEOMÉTRICOS ---");

        Console.Write("Ingrese el radio del círculo: ");
        double.TryParse(Console.ReadLine(), out double radio);

        Console.Write("Ingrese el cateto A del triángulo rectángulo: ");
        double.TryParse(Console.ReadLine(), out double catetoA);

        Console.Write("Ingrese el cateto B del triángulo rectángulo: ");
        double.TryParse(Console.ReadLine(), out double catetoB);

        // Fórmulas geométricas usando Math
        double areaCirculo = Math.PI * Math.Pow(radio, 2);
        double circunferenciaCirculo = 2 * Math.PI * radio;
        double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

        Console.WriteLine("\n============== RESULTADOS GEOMETRÍA ==============");
        Console.WriteLine($"Área del círculo: {areaCirculo:F2}");
        Console.WriteLine($"Circunferencia del círculo: {circunferenciaCirculo:F2}");
        Console.WriteLine($"Hipotenusa del triángulo: {hipotenusa:F2}");
        Console.WriteLine("==================================================");
        Console.Write("\nPresione una tecla para volver al menú...");
        Console.ReadKey();
    }
}