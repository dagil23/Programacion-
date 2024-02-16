// Crear una clase llamada TablaEnteros que no permita que se creen objetos a partir de ella. Esta clase almacenará una tabla de enteros de una dimensión y que será un atributo protegido, el tamaño debe ser especificado mediante su constructor.
// La clase debe obligar a que cualquier clase que herede de ella y no quiera ser una clase abstracta, implemente un método llamado GuardarNumerosenTabla.

// Además, TablaEnteros dispondrá de dos métodos:

// DevuelveTabla, método redefinible, que servirá para devolver la cadena con el contenido completo de la tabla.
// SumaPropia que se encargará de comprobar si existen más números positivos o negativos en la tabla y devolverá la suma de aquellos de los que hay mayor cantidad.
// Crear a partir de esta clase dos nuevas clases llamadas:

// TablaImpares: que solo guardará números impares en el atributo del padre.
// TablaPares: que solo guardará números pares, el el atributo del padre.
// Ambas, lo harán mediante el método GuardarNumerosEnTabla, antes mencionado, que seleccionará los números apropiados (pares o impares) a guardar a partir de número generados aleatoriamente.

// En el programa principal, crea instancias de cada una de estas clases, dales valores y muestra las tablas y la suma propia de ambos objetos por pantalla.


using System.Reflection;

public abstract class TablaEnteros{
    protected int [] tablaEnteros;
    
    public TablaEnteros (in int tamano){
    
        tablaEnteros = new int [tamano];

    }

    public abstract void GuardarNumerosEnTabla(in int [] array);
    public virtual string DevuelveTabla(){

        return string.Join(",",tablaEnteros);
    }
    

    public int SumaPropia(){

        int positivos= 0;
        int negativos= 0;

        for (int i = 0; i < tablaEnteros.Length; i++)
        {
            if (tablaEnteros[i]>= 0)
            {
                positivos++;
            }else{
                negativos++;
            }
        }

        int suma = 0;

        if (positivos >= negativos)
        {
            for (int i = 0; i < tablaEnteros.Length; i++)
            {
                suma+= tablaEnteros[i];
            }
        }else
        {
            for (int i = 0; i < tablaEnteros.Length; i++)
         {
            if (tablaEnteros[i]<0)
            {
                suma += tablaEnteros[i];
            }
         }
        }
         
        return suma;
    }

    
}


public class TablaPares : TablaEnteros{

    private int cantidadElementos = 0;
    public TablaPares (in int tamano):base(tamano){

    }

    public  override void GuardarNumerosEnTabla(in int [] array)
    {
        for (int i = 0; i < array.Length && cantidadElementos < tablaEnteros.Length; i++)
        {
            if (array[i]%2==0)
            {
                tablaEnteros[cantidadElementos] = array[i];
                cantidadElementos++;
            }
        }
    }
}

public class TablaImpares : TablaEnteros{

    private int  cantidadElementos = 0;
    public TablaImpares (in int tamano):base(tamano){

    }

    public override void GuardarNumerosEnTabla(in int [] array)
    {
        for (int i = 0; i < array.Length && cantidadElementos < tablaEnteros.Length; i++)
        {
            if (array[i]%2!=0)
            {
                tablaEnteros[cantidadElementos] = array[i];
                cantidadElementos ++;
            }
        }
    }

}

public class EjercicioHerencia6{
    static void Main(){
        Random aleatorio = new Random();
        int tamano = 1000;
        TablaPares tablaNumerosPares = new TablaPares(10);
        TablaImpares tablaNumerosImpares = new TablaImpares(10);
        int [] arrayEnteros = new int [tamano];

        for (int i = 0; i < arrayEnteros.Length; i++)
        {
            arrayEnteros[i] = aleatorio.Next(-10,10);
        }
        tablaNumerosImpares.GuardarNumerosEnTabla(arrayEnteros);
        tablaNumerosPares.GuardarNumerosEnTabla(arrayEnteros);
        Console.WriteLine("Numeros pares: " + tablaNumerosPares.DevuelveTabla());
        Console.WriteLine("Numeros Impares: " + tablaNumerosImpares.DevuelveTabla());
        Console.WriteLine("Suma total de las tabla Impares " + tablaNumerosImpares.SumaPropia());
        Console.WriteLine("Suma total de las tabla Pares " +  tablaNumerosPares.SumaPropia());
       



        
    }
}
