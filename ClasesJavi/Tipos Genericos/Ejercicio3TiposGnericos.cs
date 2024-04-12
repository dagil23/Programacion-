// Crea una clase estática genérica llamada Comparador<T> que posea a su vez dos métodos de utilidad estáticos llamados Mayor y Menor. Ambos recibirán dos parámetros del tipo genérico, y devolverán true o false en el caso de que el primer parámetro sea mayor que el segundo y viceversa, ¿qué problemas has encontrado?.

// La mejor forma de solucionarlo, es obligando a que el parámetro genérico implemente la interface IComparable<T>.

// Crea una clase programa que te permita probar estos métodos, mandándo diferentes elementos int, string, float, etc.

public static class Comparador<T> where T: IComparable
{
    public static bool Mayor(T valor1, T valor2){
        int result = valor1.CompareTo(valor2);
        return result > 0;
    }

    public static bool Menor(T valor1, T valor2){
        int result = valor1.CompareTo(valor2);
        return result < 0;
    }
}

// public class Program {
//     static void Main() {

//         DABRadio radio1 = new DABRadio();
//         DABRadio radio2 = new DABRadio();
//         radio1.Next();
//         radio1.Next();


//         bool result = Comparador<DABRadio>.Mayor(radio1, radio2);

//         if (result) {
//             Console.WriteLine("Es mayor");
//         } else {
//             Console.WriteLine("Es menor");
//         }
//     }
// }