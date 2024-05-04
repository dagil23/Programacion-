// public class Cola<T>
// {
//     public LinkedList<T> miLinkedList = new LinkedList<T>();
    
//     public Cola() {
//     }

//     public void Encolar(T dato){

//         //Meto datos por la derecha(final) y salen por la izquierda(inicio)

//         miLinkedList.AddLast(dato);
//     }

//     public T Desencolar(){
//         T dato = miLinkedList.First();
//         miLinkedList.RemoveFirst();

//         return dato;
//     }

//     public Cola<T> invertir() {
//         Cola<T> colaAux = new Cola<T>();

//         LinkedList<T> linkedListAux = new LinkedList<T>(miLinkedList);
        
//         while(linkedListAux.Count > 0) {
//             colaAux.Encolar(linkedListAux.Last());
//             linkedListAux.RemoveLast();
//         }

//         return colaAux;
//     }

//     public override string ToString()
//     {
//         string resultado = "";

//         LinkedList<T> linkedListAux = new LinkedList<T>(miLinkedList);
//         while(linkedListAux.Count > 0) {
//             resultado = resultado + linkedListAux.First() + " ";
//             linkedListAux.RemoveFirst();
//         }

//         return resultado;
//     }
// }


// public class Program
// {
//     static void Main(){
//         Cola<int> cola = new Cola<int>();
//         cola.Encolar(1);
//         cola.Encolar(2);
//         cola.Encolar(7654);
//         cola.Encolar(5);

//        Cola<int> otraCola = cola.invertir();
//        Console.WriteLine(otraCola.ToString());
//     }
// }