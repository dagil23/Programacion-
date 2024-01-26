using System;

namespace Ej02_Pantallaspantallas
{
    /* Crea un programa que permita guardar información sobre las características gráficas de un equipo informático. 
     * La información relevante es:
     * Número de pulgadas (short)
     * Controlador gráfico (string)
     * Número de colores (short)
     * Pixeles eje x (int)
     * Pixeles eje y (int)
     * Debe ser posible cambiar el número de colores, la resolución de la pantalla y el controlador en cualquier momento, 
     * así como consultar toda la información concerniente a las características gráficas. Crea alguna instancia de pantalla 
     * y prueba el funcionamiento.
     * Nota: todos los campos serán privados, y deberemos crear solo los métodos y accesores o modificadores necesarios para 
     * poder hacer funcional la aplicación.*/
    class Pantalla
    {
        private readonly short numeroPulgadas;
        private string controladorGrafico;
        private int numeroColores;
        private int pixelsX;
        private int pixelsY;

        public int GetPixelsX()
        {
            return pixelsX;
        }

        public void SetPixelsX(int value)
        {
            if(value <= 0)
            {
                throw new ArgumentOutOfRangeException("Los pixeles del eje X tienen que ser mayor que 0");
            }
            pixelsX = value;
        }

        public int GetPixelsY()
        {
            return pixelsY;
        }

        public void SetPixelsY(int value)
        {
            pixelsY = value;
        }

        public int GetNumeroColores()
        {
            return numeroColores;
        }

        public void SetNumeroColores(int value)
        {
            numeroColores = value;
        }

        public string GetControladorGrafico()
        {
            return controladorGrafico;
        }

        public void SetControladorGrafico(string value)
        {
            controladorGrafico = value;
        }

        public short GetNumeroPulgadas()
        {
            return numeroPulgadas;
        }

        public Pantalla(string controlador, short pulgadas, int colores, int pixelsX, int pixelsY)
        {
            SetControladorGrafico(controlador);
            controladorGrafico = controlador;
            numeroPulgadas = pulgadas;
            SetNumeroColores(colores);
            SetPixelsX(pixelsX);
            SetPixelsY(pixelsY);
        }
    }

    class Ej02_Pantallaspantallas
    {
        static void ModificaDatos(Pantalla p)
        {
            Console.Write("\nIntroduzca nombre de controlador: ");
            p.SetControladorGrafico(Console.ReadLine());
            Console.Write("Introduzca número de colores: ");
            p.SetNumeroColores(short.Parse(Console.ReadLine()));
            Console.Write("Introduzca número de píxels eje X: ");
            p.SetPixelsX(int.Parse(Console.ReadLine()));
            Console.Write("Introduzca número de píxels eje Y: ");
            p.SetPixelsY(int.Parse(Console.ReadLine()));
        }

        static void MuestraDatos(Pantalla p)
        {
            Console.WriteLine("\nNombre de controlador: " + p.GetControladorGrafico());
            Console.WriteLine("Número de pulgadas: " + p.GetNumeroPulgadas());
            Console.WriteLine("Número de colores: " + p.GetNumeroColores());
            Console.WriteLine("Número de píxels Eje X: " + p.GetPixelsX());
            Console.WriteLine("Número de píxels Eje Y: " + p.GetPixelsY());
        }

        static void Main()
        {
            Console.WriteLine("Ej02 - Consulta y modificación de parámetros de pantallas gráficas\n\n");

            bool modificarDatos;
            Pantalla pantalla = new Pantalla("ZRX350", 17, 124000, -1, 720);
            do
            {
                MuestraDatos(pantalla);
                Console.Write("\n¿Desea modificar los parámetros? (S/N): ");
                modificarDatos = Console.ReadKey().Key == ConsoleKey.S;
                Console.WriteLine("");
                if (modificarDatos)
                    ModificaDatos(pantalla);
            } while (modificarDatos);
        }
    }
}
