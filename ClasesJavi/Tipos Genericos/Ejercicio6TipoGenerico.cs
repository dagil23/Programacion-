
// Definiremos un indizador público para la clase y así poder acceder y modificar el elemento correspondiente en el array.
// Prueba la clase creada con el siguiente programa:


//La parametrización se declara con <> (con bocadillos)
//La parametrización se puede declarar a varios niveles (clase, métodos, etc)
//Cuanto más global sea el nivel, en más sitios se podrá aplicar el tipo parametrizado. (cuando digo aplicar, 
//me refiero a utilizar el T sin los bocadillos <>)
public class Lista<T>{

    private T[] miArrayParametrizado;
    
    public Lista(){
        miArrayParametrizado =  new T[0];

    }

    public void Add(T datoParametrizado){
        //Redimensionamos primero el array con el tamaño que ya tenia mas 1
        Array.Resize(ref miArrayParametrizado, miArrayParametrizado.Length + 1);
        //Luego le asiganamos el dato que nos hayan pasado a esa posicion
        //Recordando siempre la longitud del array para no tener un error con los tamaños del mismo
        miArrayParametrizado[miArrayParametrizado.Length -1] = datoParametrizado;
    }

    public T this[int indice]{
        get{

            return miArrayParametrizado[indice];
        }
        set{
            if (indice < miArrayParametrizado.Length)
            {
                
            miArrayParametrizado[indice] = value;
                
            }
        }
    }
}
// public class Program{
//     static void Main(){
//         Lista<string> lista=new Lista<string>();
//            lista.Add("5");
//            Console.WriteLine(lista[0]);  
//            lista.Add("8");
//            Console.WriteLine(lista[1]);
//            lista[1]="         ";
//            Console.WriteLine(lista[1]);
//            //Prueba la lista con string
//     }
// }