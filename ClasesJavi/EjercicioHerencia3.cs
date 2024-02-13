// Para dar nuestros primeros pasos con el polimorfismo de datos del principio de sustitución de Liskov, vamos a recordar el cálculo de factorial y de número primo.
// Vamos a necesitar una clase padre ElNoCalculador con un atributo protected short numero, que será la base del calculo posterior, también tendrá dos métodos virtuales Factorial y Primo devolverán un double y un booleano respectivamente (en esta clase no se realizarán los cálculos, los métodos devolverán 0 y false). Además, crearemos una clase hija ElCalculador que sí implementa estos métodos de forma correcta a partir del numero del padre.
// Para probar el funcionamiento del polimorfismo nos crearemos un objeto de la manera: ElNoCalculador obj = new ElCalculador(num);
// y llamaremos a los métodos Primo y Factorial.

// ✋ Reflexiona las siguiente preguntas:

// ¿A qué métodos se llama, a los de la clase padre o a los de la clase hija?
// Crea en la clase hija un método MostrarResultado y llámalo con el objeto. ¿Qué ocurre?
// y si comentas el método Primo de la hija. ¿Qué ocurre?



using System.Runtime.InteropServices;

class ElNoCalculador
{

    protected short numero;

    public ElNoCalculador(short numero)
    {
        this.numero = numero;
    }

    public virtual int Factorial()
    {
        int n = 0;
        return n;



    }

    public virtual  bool EsPrimo()
    {
     return false;
    }
}

class ElCalculador : ElNoCalculador
{
    public ElCalculador(short numero) : base(numero)
    {
        this.numero = numero;
    }

    public override int Factorial(){

        int factorial = 1;
        for (int i = factorial; i < numero; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

    public override bool EsPrimo()
    {
        
        if (numero <=2)
        {
            return false;
        }
        for (int i = 2; i < numero; i++)
        {
            if (numero%i==0)
            {
                return false;
            }
        }
        return true;
    }

         public void MostrarResultado(){

            Console.WriteLine(EsPrimo());
            Console.WriteLine(Factorial());
         }
}
    




// public class Ejercicio3
// {
//     static void Main()
//     {
//         ElCalculador obj = new ElCalculador(8);
//         obj.Factorial();
//         obj.EsPrimo();
//         obj.MostrarResultado();
        
//     }
// }