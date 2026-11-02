using System;
using System.Collections.Generic;

class Program
{
    // Listas globales para simular el almacenamiento de la tienda/sistema
    static List<string> productos = new List<string>() { "Laptop", "Auriculares", "Teclado" };
    static List<double> precios = new List<double>() { 45000.00, 2500.00, 1800.00 };

    static void Main(string[] args)
    {
        int opcion = -1;

        do
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("     SISTEMA DE GESTIÓN Y TIENDA - GRUPO");
            Console.WriteLine("==================================================");
            Console.WriteLine("1. Ver catálogo de productos");
            Console.WriteLine("2. Calcular total de compra (Con método y parámetros)");
            Console.WriteLine("3. Agregar nuevo producto (Con método y return)");
            Console.WriteLine("4. Aplicar descuento especial (Con método y return)");
            Console.WriteLine("0. Salir del sistema");
            Console.Write("\nSeleccione una opción (0-4): ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        MostrarCatalogo();
                        break;
                    case 2:
                        ProcesarCompraInteractiva();
                        break;
                    case 3:
                        EjecutarAgregarProducto();
                        break;
                    case 4:
                        EjecutarCalculoDescuento();
                        break;
                    case 0:
                        Console.WriteLine("\n¡Gracias por utilizar el sistema grupal! Saliendo...");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida. Presione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nEntrada no válida. Ingrese un número entero. Presione una tecla...");
                Console.ReadKey();
            }

        } while (opcion != 0);
    }

    // --- OPCIÓN 1: MOSTRAR CATÁLOGO (Usa ciclo for y formato) ---
    static void MostrarCatalogo()
    {
        Console.Clear();
        Console.WriteLine("================ CATÁLOGO DE PRODUCTOS ================");
        Console.WriteLine(string.Format("{0,-5} {1,-20} {2,15}", "ID", "PRODUCTO", "PRECIO (DOP)"));
        Console.WriteLine("-------------------------------------------------------");

        for (int i = 0; i < productos.Count; i++)
        {
            Console.WriteLine(string.Format("{0,-5} {1,-20} {2,15:N2}", (i + 1), productos[i], precios[i]));
        }

        Console.WriteLine("=======================================================");
        Console.Write("\nPresione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }

    // --- OPCIÓN 2: COMPRA (Método 1 con parámetros - Requisito rúbrica) ---
    static void ProcesarCompraInteractiva()
    {
        Console.Clear();
        Console.WriteLine("--- PROCESAR COMPRA DE PRODUCTO ---");
        MostrarCatalogoSimple();

        Console.Write("\nSeleccione el número del producto que desea comprar: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= productos.Count)
        {
            Console.Write("Ingrese la cantidad que desea llevar: ");
            if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
            {
                // Llamada al método con parámetros
                double totalPagar = CalcularSubtotalConImpuesto(precios[index - 1], cantidad);

                Console.WriteLine("\n================ FACTURA DE COMPRA ================");
                Console.WriteLine($"Producto: {productos[index - 1]}");
                Console.WriteLine($"Cantidad: {cantidad}");
                Console.WriteLine($"Total con ITBIS (18%): {totalPagar:N2} DOP");
                Console.WriteLine("===================================================");
            }
            else
            {
                Console.WriteLine("Error: Cantidad no válida.");
            }
        }
        else
        {
            Console.WriteLine("Error: Producto no válido.");
        }

        Console.Write("\nPresione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }

    // Método con parámetros (Requisito de la rúbrica)
    static double CalcularSubtotalConImpuesto(double precioUnitario, int cantidad)
    {
        const double itbis = 0.18;
        double subtotal = precioUnitario * cantidad;
        double totalConImpuesto = subtotal + (subtotal * itbis);
        return totalConImpuesto;
    }

    // --- OPCIÓN 3: AGREGAR PRODUCTO (Método 2 con return - Requisito rúbrica) ---
    static void EjecutarAgregarProducto()
    {
        Console.Clear();
        Console.WriteLine("--- AGREGAR NUEVO PRODUCTO AL INVENTARIO ---");

        Console.Write("Ingrese el nombre del nuevo producto: ");
        string nuevoNombre = Console.ReadLine() ?? "";

        Console.Write("Ingrese el precio del producto: ");
        if (double.TryParse(Console.ReadLine(), out double nuevoPrecio) && nuevoPrecio > 0)
        {
            bool agregado = RegistrarNuevoProducto(nuevoNombre, nuevoPrecio);
            if (agregado)
            {
                Console.WriteLine("\n¡Producto agregado exitosamente al inventario!");
            }
        }
        else
        {
            Console.WriteLine("Error: Precio no válido.");
        }

        Console.Write("\nPresione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }

    // Método con return (Requisito de la rúbrica)
    static bool RegistrarNuevoProducto(string nombre, double precio)
    {
        if (!string.IsNullOrWhiteSpace(nombre))
        {
            productos.Add(nombre);
            precios.Add(precio);
            return true;
        }
        return false;
    }

    // --- OPCIÓN 4: DESCUENTO (Método 3 con return y parámetros - Requisito rúbrica) ---
    static void EjecutarCalculoDescuento()
    {
        Console.Clear();
        Console.WriteLine("--- CÁLCULO DE DESCUENTO ESPECIAL ---");
        Console.Write("Ingrese el precio original del artículo: ");

        if (double.TryParse(Console.ReadLine(), out double precioOriginal) && precioOriginal > 0)
        {
            Console.Write("Ingrese el porcentaje de descuento (ej. 10 para 10%): ");
            if (double.TryParse(Console.ReadLine(), out double porcentaje) && porcentaje >= 0 && porcentaje <= 100)
            {
                double precioFinal = AplicarDescuento(precioOriginal, porcentaje);
                Console.WriteLine($"\nPrecio original: {precioOriginal:N2} DOP");
                Console.WriteLine($"Descuento aplicado: {porcentaje}%");
                Console.WriteLine($"Precio con descuento: {precioFinal:N2} DOP");
            }
            else
            {
                Console.WriteLine("Error: Porcentaje no válido.");
            }
        }
        else
        {
            Console.WriteLine("Error: Precio no válido.");
        }

        Console.Write("\nPresione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }

    // Método con return y parámetros (Requisito de la rúbrica)
    static double AplicarDescuento(double precio, double porcentajeDescuento)
    {
        double montoDescuento = precio * (porcentajeDescuento / 100.0);
        return precio - montoDescuento;
    }

    // Método auxiliar para listar rápido
    static void MostrarCatalogoSimple()
    {
        for (int i = 0; i < productos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {productos[i]} - {precios[i]:N2} DOP");
        }
    }
}