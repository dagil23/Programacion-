
//     Partiendo de la siguiente definición de clase parametrizada…

// class A<T, U> 
// {
//    private T clave;
//    private U valor;
//    …
// }
// Define un constructor que reciba los dos atributos como parámetro.
// Crea 2 propiedades que te permitirán devolver los dos atributos.
// Prueba la clase en la Main con una clave de tipo entero y un valor de tipo cadena.
using System.Text.Json;

public class A<T,U>{
    private T clave;
    private U valor;

    public A(T clave, U valor) {
        this.clave = clave;
        this.valor = valor;
    }

    public T Clave{
        get=>clave;
    }
    public U Valor{
        get=>valor;
    }
}



// // class Program
//  {

//     static void Main(){

//         A<int, string> misTipos = new A<int, string>(88,"Hola");
//         A<int[], string> misTipos2 = new A<int[], string>(new int[]{1,2,3}, "Hola");
//         misTipos2.Clave[2] = 1;
//     }
// }