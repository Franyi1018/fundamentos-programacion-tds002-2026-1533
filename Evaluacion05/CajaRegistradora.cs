using System;

class CajaRegistradora
{
    static void Main(string[] args)
    {
        const double ItbisConstante = 0.18; // 18%
        double subtotal = 0;
        int cantidadProductos = 0;
        double precio;

        Console.WriteLine("=== PROGRAMA 1: CAJA REGISTRADORA ===");
        Console.WriteLine("Ingrese los precios de los productos. Digite 0 para terminar.\n");

        do
        {
            Console.Write("Ingrese el precio del producto: ");
            if (double.TryParse(Console.ReadLine(), out precio))
            {
                if (precio > 0)
                {
                    subtotal += precio;
                    cantidadProductos++;
                }
                else if (precio < 0)
                {
                    Console.WriteLine("Error: El precio no puede ser negativo.");
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese un valor numérico válido.");
            }

        } while (precio != 0);

        double itbis = subtotal * ItbisConstante;
        double total = subtotal + itbis;

        Console.WriteLine("\n================ RESUMEN DE COMPRA ================");
        Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
        Console.WriteLine($"Subtotal: {subtotal:N2}");
        Console.WriteLine($"ITBIS (18%): {itbis:N2}");
        Console.WriteLine($"TOTAL A PAGAR: {total:N2}");
        Console.WriteLine("===================================================");
    }
}