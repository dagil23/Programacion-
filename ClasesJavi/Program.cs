// Crea una aplicación con un método estático genérico Mostrar,
// al que le pases una matriz del tipo T y la muestre con una correcta tabulación. 
// Posteriormente, prueba este método con diferentes tipos.

// Posible ejemplo de una llamada con float y otra con string ...

// 3 4 5
// 2,4 4,4 5

// SAL AGUA AZUCAR VINO
// COLA CAFE ZUMO LECHE
// Crea un objeto delegado predefinido genérico de la BCL para el método Mostrar y comprueba su funcionamiento.
public class Ejercicio3_Delegados
{
    public static void Separador(){Console.WriteLine("--------------------------------------------");}
    public static void Mostrar<T>(T[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public static int [,] RellenarMatrizNumeros(int filas, int columnas)
    {
        int [,] matriz = new int[filas,columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = i * columnas + j + 1;
            }
        }
        return matriz;
    }
    public static string[,] RellenarMatrizString(int filas, int columnas){
        string [,] matriz = new string[filas,columnas];
         for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.WriteLine($"Introduce una cadena para la fila {i+1} columna {j+1} :\n");
                matriz[i, j] = Console.ReadLine()??"";
            }
        }
        return matriz;
    }
    public static void Main(string[] args)
    {
        const int filas = 3;
        const int columnas = 3;
        Action<int[,]> MuestraMatrizEnteros = Mostrar;
        int[,] matriz = RellenarMatrizNumeros(filas,columnas);
        Separador();
        MuestraMatrizEnteros(matriz);
        Separador();
        Action<string[,]> MuestraMatrizString = Mostrar;
        string[,] matrizString = RellenarMatrizString(filas,columnas);
        Separador();
        MuestraMatrizString(matrizString);
        Separador();
    


    }
}