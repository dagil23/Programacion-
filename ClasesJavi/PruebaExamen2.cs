public class PruebaExamen2
{
    //      Guarda 100.000 números aleagorios en un array. Cada número estará comprendido entre 0 y 99.
    // 2. Calcula la suma de todos los elementos del array:
    //    La suma de todos los elementos es: 4931723
    // 3. En una segunda pasada al array indica cuántas veces aparece cada número en el array:
    //    El número 0 aparece 962 veces
    //    El número 1 aparece 973 veces
    //    El número 2 aparece 1006 veces
    //    ...
    //    El número 99 aparece 975 veces
    // 4. Indica cuál es el ńumero que más veces aparece y el que menos de la siguiente manera:
    //    El número que más ha aparecido es el: 76 con 1086 apariciones
    //    El número que menos ha aparecido es el: 53 con 933 apariciones
    // Organiza todo el código con métodos
    // */


    private int[] CrearArray(int tamano)
    {

        int[] array = new int[tamano];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = GenerarNumero();
        }
        return array;
    }

    private int GenerarNumero()
    {
        Random random = new Random();
        return random.Next(0, 99);
    }

    private int SumarElementosArray(int[] array)
    {


        int sumaElementos = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sumaElementos += array[i];
        }

        return sumaElementos;

    }

    private void MostrarAparicionElementos(int[] array)
    {

        for (int i = 0; i < 99; i++)
        {
            int numeroVeces = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == i)
                {
                    numeroVeces++;
                }
            }
            Console.WriteLine($"El numero {i} aparece {numeroVeces} veces");
        }
    }

    private void MostrarElementoConMayorAparicion(int [] array){
        
        int [] mostrarApariciones = new int [100];
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < array.Length ; j++)
            {
                if(array[j] == i){
                    mostrarApariciones[i] = i +1;
                }
            }
        }
    }
   public void EjecutarExamen2()
    {
        int tamano = 100000;
        int[] array = CrearArray(tamano);
        SumarElementosArray(array);
        MostrarAparicionElementos(array);


    }
}