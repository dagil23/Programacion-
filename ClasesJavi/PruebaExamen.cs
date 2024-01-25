class PruebaExamen{
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

    private int[] CrearArray(int tamano){
        
        int [] array = new int [tamano];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = GenerarNumero();
        }
        return array;
    }

    private int GenerarNumero(){
        Random random = new Random();
        return random.Next(0,99);
    }

    private int SumarElementosArray(int [] array){
        int sumaNumeros = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sumaNumeros += array[i];
        }
        return sumaNumeros;
    }

    private void MostrarAparicionNumeros(int [] array){
            for (int i = 0; i <100; i++)
            {
                int numeroVeces = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if(array[j]== i)
                    {
                        numeroVeces++;
                    }
                }
            Console.WriteLine($"El numero {i} aparece {numeroVeces} veces");
            }
    }

    private void MostrarNumeroConMasyMenosApariciones(int[] array) {
            int [] arrayApariciones = new int [100];

            for(int i = 0; i < 100; i++) {
                arrayApariciones[i] = 0;
            }

            for (int i = 0; i <100; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if(array[j]== i)
                    {
                        arrayApariciones[i] += 1;
                    }
                }
            }

            int mayorApariciones = arrayApariciones[0];
            int indice = 0;
            for (int i = 0; i < arrayApariciones.Length; i++)
            {
                if(arrayApariciones[i] > mayorApariciones){
                    mayorApariciones = arrayApariciones[i];
                    indice = i;
                }
            }

            Console.WriteLine("El numero que mas se repite es " + indice + " con apariciones: " + mayorApariciones);

            int menorApariciones = arrayApariciones[0];
            int indice2 = 0;
            for (int i = 0; i < arrayApariciones.Length; i++)
            {
                if(arrayApariciones[i] < menorApariciones){
                    menorApariciones = arrayApariciones[i];
                    indice2 = i;
                }
            }

            Console.WriteLine("El numero que menos se repite es " + indice2 + " con apariciones: " + menorApariciones);
    }
   
    public void EjecutarExamen(){
        int tamano = 100000;
        int[] array = CrearArray(tamano);
       int suma = SumarElementosArray(array);
        MostrarAparicionNumeros(array);
        MostrarNumeroConMasyMenosApariciones(array);
    }
}

