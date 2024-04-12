// Partiendo del ejercicio anterior, crea una clase Persona que tenga solo dos propiedades: Nombre y Edad.

// Comprueba si funcionan los métodos Mayor y Menor con ella, ¿qué ocurre?. Ahora haz que la clase derive de IComparable<Persona> y de ICloneable y que invalide el ToString().

// Crea un programa que te permita saber, de dos objetos Persona distintos, cual es el mayor. Clona una persona y prueba los clones con el método estático Menor.

public class Persona : IComparable, ICloneable
{
    private string Nombre { get; }

    private int Edad { get; }

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public int CompareTo(object? obj)
    {

        Persona personaAComparar = obj as Persona ?? throw new ArgumentException("El objeto a comparar no es una Persona.", "obj");
        return Edad > personaAComparar.Edad ? 1 : 0;
    }

    public object Clone()
    {
        return new Persona(Nombre, Edad);
    }
}

// public static class Program
// {
//     static void Main(){
//         Persona persona1 = new Persona("Pepe",22);
//         Persona persona2 = new Persona("Juan",33);
//         Comparador<Persona>.Mayor(persona1,persona2);
//         Persona elClonado = (Persona)persona1.Clone();
//         bool result = Comparador<Persona>.Menor(persona1,elClonado);
//         if (result)
//         {
//             Console.WriteLine("Es menor");
//         }else
//         {
//             Console.WriteLine("No es menor");

//         }
//     }
// }
