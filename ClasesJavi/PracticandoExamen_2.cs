// 1. Crea una clase llamada deportista:
//  - Los deportistas tienen un id de deportista, un nombre completo y una fecha de nacimiento
//  - El id es clave primaria autoincremental
//  - El nombre es obligatorio
//  - La fecha de nacimiento es opcional
//  - No es necesario controlar errores
//  - Crea los constructores necesarios
//  - Crea el constructor de copia. La copia tendrá un id de deportista nuevo ya que es clave primaria
//  - Crea los getters y setters
//  - Invalida el método ToString() para que nos devuelva una cadena con toda la información del deportista

public class Deportista
{
    private int cantidadDeportistas = 0;
    private int id;
    private string nombre;
    private DateOnly? fechaNacimiento;

    public Deportista(string nombre, DateOnly? feechaNacimiento)
    {
        Id = cantidadDeportistas;
        Nombre = nombre;
        FechaNacimiento = fechaNacimiento;

    }
    public Deportista(Deportista deportista)
    {
        Id = deportista.cantidadDeportistas;
        Nombre = deportista.nombre;
        FechaNacimiento = deportista.fechaNacimiento;

    }

    public int Id
    {
        get => id;
        set
        {
            id = value;
            cantidadDeportistas++;
        }
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public DateOnly? FechaNacimiento
    {
        get => fechaNacimiento;
        set => fechaNacimiento = value;

    }

    public override string ToString()
    {
        string mensaje = "Informacion del Deportitas: \n" +
                            $"Nombre: {Nombre}\n" +
                            $"Fecha Nacimiento: {FechaNacimiento}\n" +
                            $"Id: [{Id}]";
        return mensaje;
    }


}


// 2. Crea una clase llamada equipo:
//  - Un equipo tiene un código de equipo, un nombre y desde cero hasta 20 deportistas
//  - El código del equipo debe tener tres letras en mayúsculas
//  - El nombre es obligatorio
//  - Genera errores adecuados si el código no tiene tres letras.
//  - Las letras del código pueden estar en minúsculas, pero se deben pasar a mayúsculas
//  - Todo equipo tendrá un mínimo de cero y un máximo de veinte deportistas
//  - Crea un constructor con el código y el nombre como parámetros
//  - Crea el constructor de copia
//  - Crea los getters y setters
//  - Invalida el métido ToString() que nos devuelve en una cadena toda la información del
//    equipo más toda la información de sus deportistas
//  - Crea un método que añada un deportista a un equipo
//  - Genera errores adecuados si el se intenta añadir un deportista a un equipo que ya tiene 20 deportistas.


public class CodigoMayorA3Letras : Exception
{
    public CodigoMayorA3Letras(string message) : base(message) { }

}
public class LimiteDeDeportistas : Exception
{
    public LimiteDeDeportistas(string message) : base(message) { }


}
public class Equipo
{
    private static int cantidad_miembros_actual = 0;
    private const int CANTIDA_DEPORTISTAS = 20;
    private string codigo;
    private string nombre;
    private Deportista[] deportistas = new Deportista[CANTIDA_DEPORTISTAS];

    public Equipo(string codigo, string nombre)
    {
        Nombre = nombre;
        Codigo = codigo;
        Deportistas = new Deportista[CANTIDA_DEPORTISTAS];



    }
    public string Codigo
    {
        get => codigo.ToUpper();
        set
        {
            if (value.Length > 3)
            {
                throw new CodigoMayorA3Letras("Haz introducido un codigo mayor a 3 letras");
            }
        }
    }
    public Deportista[] Deportistas
    {
        get => deportistas;
        set
        {
            for (int i = 0; i < deportistas.Length; i++)
            {
                deportistas[i] = value[i];
            }
        }
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public void AgregarDeportista(Deportista deportista)
    {
        if (cantidad_miembros_actual < CANTIDA_DEPORTISTAS)
        {
            deportistas[cantidad_miembros_actual] = deportista;
            cantidad_miembros_actual++;

        }
        else
        {
            throw new LimiteDeDeportistas("Haz superado el limite de deportistas que son 20");
        }
    
    }

    public override string ToString()
    {
        string mensaje = "Informacion del equipo: \n" +
                        $"Nombre: {Nombre} -- Codigo:{Codigo}";

        for (int i = 0; i < deportistas.Length; i++)
        {
            mensaje += deportistas[i].ToString() + "\n";
        }
        return mensaje;
    }
}


// / 3. Para probarlo todo:
//  - Crea dos equipos.
//  - Añade a uno 10 deportistas de manera aleatoria y al segundo 15 deportias de manera aleatoria
//  - Saca por pantalla toda la información de los dos equipos
// ---------------------------------------------------------------------------- */

public class Program
{
    static void Main()
    {
        Equipo madrid = new Equipo("RMA", "Real Madrid");
        Equipo barcelona = new Equipo("BCA", "Barcelona");

        for (int i = 0; i < 10; i++)
        {
            madrid.AgregarDeportista(new Deportista(generarNombreAleatorios(), fechaAleatorioa()));
        }
        for (int i = 0; i < 15; i++)
        {
            barcelona.AgregarDeportista(new Deportista(generarNombreAleatorios(), fechaAleatorioa()));

        }
        Console.WriteLine(madrid.ToString());
        Console.WriteLine(barcelona.ToString());


    }

    public static string generarNombreAleatorios()
    {
        Random random = new Random();
        string[] nombres = new string[] { "Maria", "Carmen", "Pedro", "Miguel", "Juan", "Daniel", "Pedro", "Jose", "Emilio" };
        return nombres[random.Next(nombres.Length)];
    }
    public static DateOnly fechaAleatorioa()
    {
        return new DateOnly(2002, 12, 6);
    }
}
