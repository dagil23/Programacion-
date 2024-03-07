
// Tendremos una clase Estudios que implementará los interfaces IEstudios e IVisualiza. La interfaz IEstudios deberá asegurar que las clases que deriven de ella, implementen un método que muestre por pantalla la edad mínima para empezar esos estudios.
// Al implementar la interfaz IVisualiza (del ejemplo 1), en el método se mostrará por pantalla la información relativa a los estudios en curso.
// La clase Estudios no podrá ser instanciada y derivarán de ella las clases Superior, Medio y Elemental: los estudios superiores, medios y elementales, tendrán como edades de acceso mínimas 18, 16 y 12 años respectivamente.

// Para todos los estudios, nos interesará ver en pantalla su nombre y duración.
// Para los estudios superiores, nos interesará el lugar donde se realizan.
// Para los Medios nos interesa ver por pantalla el nombre de un estudio superior
// al que den acceso.
// Crea al menos un objeto de cada una de las clases y comprueba su funcionamiento. Comprueba si las clases derivadas de Estudios son a su vez derivadas de IEstudios y IVisualiza.

interface IEstudios
{
    void EdadMinimaParaEstudiar();
}
interface IVisualiza
{
    void Visualiza();
}

abstract class Estudios : IEstudios, IVisualiza
{
    private string Nombre { get; set; }
    private TimeSpan DuracionEstudios { get; set; }

    public Estudios(string nombre, TimeSpan duracionEstudios)
    {

        Nombre = nombre;
        DuracionEstudios = duracionEstudios;
    }


    public void Visualiza()
    {
        Console.WriteLine($"Nombre {Nombre}\n",
                            $"Duracion de los estudios {DuracionEstudios}");
    }
    public void EdadMinimaParaEstudiar()
    {

    }

    public class Superior : Estudios
    {
        private string Ubicacion { get; set; }
        public Superior(string ubicacion,
        string nombre,
         TimeSpan duracionEstudios) : base(nombre, duracionEstudios)
        {
            Ubicacion = ubicacion;
            Nombre = nombre;
            DuracionEstudios = duracionEstudios;
        }

    }
    public class Medio : Estudios
    {

        private Superior estudio;
        public Medio(Superior estudio,
      string nombre,
       TimeSpan duracionEstudios) : base(nombre, duracionEstudios)
        {
            this.estudio = estudio;
            Nombre = nombre;
            DuracionEstudios = duracionEstudios;
        }

        public void MostrarEstudioSuperior(Superior estudio){
            Console.WriteLine($"El estudios superior al que le han dado acceso es {estudio}");
        }


    }
}
class Program
{
    static void Main()
    {

    }
}