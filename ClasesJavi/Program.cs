
// Crear una lista enlazada de una clase personalizada que represente, por ejemplo, empleados. La clase Empleado podría tener propiedades como nombre, salario, etc.
// Implementar funciones para agregar, eliminar y buscar empleados en la lista enlazada.
// Escribir código para recorrer la lista enlazada e imprimir los detalles de cada empleado.
// Experimentar con diferentes métodos proporcionados por la clase LinkedList<T>, como AddFirst, RemoveLast, Find, etc

using System.Collections;
using System.ComponentModel;

public class Nodo<T> : IDisposable
//Me creo una clase Nodo, donde mis propiedades son las siguientes:
// Dato = al tipo de dato que va tener lo que le pase a mi nodo
// Nodo = Un objeto de tipo nodo para que pueda referenciar a otro o que este me pueda referenciar a mi
{
    public Nodo<T>? Siguiente { get; set;}
    private T Dato;

    public Nodo(T dato){
        Siguiente = null;
        Dato = dato;
    }
    public void Dispose()
    {
       Siguiente = null;
       if (Dato is IDisposable d)
       {
         d.Dispose();
       }

    }
}

public class MiListaSimlementeEnlazada<T> : IEnumerable<T> where T : IComparable{

    public Nodo<T>? Primero { get; private set;}
    public Nodo<T>? Ultimo  { get; private set;}
    public int Longitud {get; private set;}

    public bool Vacia => Longitud == 0;

    public MiListaSimlementeEnlazada(IEnumerable dato){
        Primero = null;
        Ultimo = null;
        Longitud = 0;
    }
   

    public void AYadirCuandoEsteVacia(T dato){

        Nodo<T> nuevo = new Nodo<T>(dato);
        Primero = nuevo;
        Ultimo = nuevo;
        Longitud ++;
    }

    public void AyadirAlPrincipioDeLaLista(T dato){
        Nodo<T> nuevo = new Nodo<T>(dato);
        Primero = nuevo;
        nuevo.Siguiente = Primero;
        Longitud ++;

    }

    public void AyadirAlFinalDeLaLista(T dato){

        Nodo<T> nuevo = new Nodo<T>(dato);
        Ultimo = nuevo;
        Ultimo.Siguiente = nuevo;
        if (Vacia)
        {
            Primero = nuevo;
        }
        Longitud ++;

    }

    public class ListaVaciaExpetion : Exception{
        public ListaVaciaExpetion(string message):base( message){}
    }

    public void AyadirEnCualquierPosicion(T dato, Nodo<T> nodo){

        Nodo<T> nuevo = new Nodo<T>(dato);
        if (Vacia)
        {
            throw new ListaVaciaExpetion("La lista no puede estar vacia");
        }
        nuevo.Siguiente = nodo.Siguiente;
        nodo.Siguiente= nuevo;
        if (Ultimo == nodo) Ultimo = nuevo;
        Longitud ++;

    }

   
}


public class Program
{
    static void Main(string[] args){

        MiListaSimlementeEnlazada<int> miLista = new MiListaSimlementeEnlazada<int>();
        miLista.AyadirAlPrincipioDeLaLista(2);
        miLista.AyadirAlPrincipioDeLaLista(3);
        miLista.AyadirAlPrincipioDeLaLista(4);
        miLista.AyadirAlPrincipioDeLaLista(5);

        foreach(var numero in miLista){

        }


    }
}
