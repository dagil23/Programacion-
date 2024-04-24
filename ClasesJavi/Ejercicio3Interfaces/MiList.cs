

//  
// ----------------------------------------------------------------------------
/*
Este es un ejercicio de examen que no intenta ser un ejemplo de ejercicio en la vida real

Crea una pila genérica guardando los objetos de la pila en una lista (la implementación de los arrays en las BCL)

Implementa las siguientes operaciones:
- Apilar: apila un elemento en la pila
- Desapilar: nos devuelve la cabeza de la pila y desapila dicho elemento. Genera un error si la pila está vacía
- Borrar: borra todos los elementos de la pila
- ConsultarCabeza: nos devuelve la cabeza de la pila sin desapilar dicho elemento. Genera un error si la pila está vacía
- Vacia: devuelve verdadero si la pila está vacía y falso en otro caso

Invalida ToString para que nos devuelva una cadena con todos los elementos de la pila separados por coma o la cadena "Pila vacía" si la pila está vacía

Crea un tipo (clase) para concretar las excepciones de la pila

Puedes usar el siguiente Main para probar tu pila o crear el tuyo propio
*/

// ----------------------------------------------------------------------------
//  Código de apoyo
// ----------------------------------------------------------------------------
// no es exhaustivo

public class MiPila<T> {
    private List<T> lista;

    // public MiPila(List<T> lista) {
    //     this.lista = lista;
    // }

    public void Apilar(T elemento) => lista.Add(elemento);

    public T Desapilar() {
        //Conseguimos el elemento primero, ya que lista.RemoveAt nos devuelve void en lugar de T.
        //Si RemoveAt nos hubiera devuelto T, nos hubiera sobrado con esa línea sólamente; pero, no devuelve T
        //por eso nos ha tocado hacer estos 3 pasos.
        T elemento = lista[lista.Count-1];

        //Lo borramos de la lista.
        lista.RemoveAt(lista.Count-1);

        //Y lo devolvemos.
        return elemento;
    }

    public void Borrar() {
        lista.Clear();
    }

    public T ConsultarCabeza() {
        if (lista.Count == 0) {
            throw new NoHayElementosEnLaPilaException("No hay elementos en la pila");
        }

        return lista[lista.Count-1];
    }

    public bool Vacia() => lista.Count == 0;

    public override string ToString()
    {
        if (Vacia()) {
            return "La pila está vacía";
        }

        string myString = "";

        for(int i = 0; i < lista.Count; i++) {
            if (i == lista.Count - 1) {
                myString += lista[i]?.ToString();
            } else {
                myString += lista[i]?.ToString() + ", ";
            }
        }

        return myString;
    }
}

public class NoHayElementosEnLaPilaException: Exception {
    public NoHayElementosEnLaPilaException(string message) : base(message) {}
}

public class Program
{
 
   
     public static void ImprimePila(MiPila<string> pila) => Console.WriteLine("Pila: " + pila);

    static  void Main(string[] args){

         var pila = new MiPila<string>();

        if (!pila.Vacia()) Console.WriteLine("Error. La pila debería estar vacía");
        ImprimePila(pila);
        pila.Apilar("Ana");
        if (pila.Vacia()) Console.WriteLine("Error. La pila no debería estar vacía");
        pila.Apilar("Carlos");
        pila.Apilar("Andrea");
        ImprimePila(pila);

        Console.Write("Desapilando de la pila los elementos: ");
        while (!pila.Vacia())
            Console.Write(pila.Desapilar() + " ");
        Console.WriteLine();
        ImprimePila(pila);

        Console.WriteLine(pila.ConsultarCabeza()); // Debe generar un error
    }

}