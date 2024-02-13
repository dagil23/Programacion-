using System;

class Program
{
    static void Main(string[] args)
    {
        // // Verificar si se proporcionaron argumentos
        // if (args.Length > 0)
        // {
        //     Console.WriteLine("Argumentos proporcionados:");
        //     // Iterar a través de los argumentos y mostrarlos
        //     foreach (string arg in args)
        //     {
        //         Console.WriteLine(arg);
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("No se proporcionaron argumentos.");
        // }


        try
        {
            double numero = Double.Parse(args[0]);
            Console.WriteLine($"El logaritmo es: {CalcularLogaritmo(numero)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error en el formato del número.");
            Console.WriteLine("Hemos capturado la excepcion FormatException");

        }
        catch (OverflowException)
        {
            Console.WriteLine("Desbordamiento al convertir el número.");
            Console.WriteLine("Hemos capturado la excepcion OverflowException");

        } catch (IndexOutOfRangeException) {
            Console.WriteLine("Indice fuera del rango.");
            Console.WriteLine("Hemos capturado la excepcion IndexOutOfRangeException");
        }
    }

    private static double CalcularLogaritmo(double numero) {
        return Math.Log10(numero);
    }
}