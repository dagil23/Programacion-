// // 1. Crea una clase llamada deportista:
// //  - Los deportistas tienen un id de deportista, un nombre completo y una fecha de nacimiento
// //  - El id es clave primaria autoincremental
// //  - El nombre es obligatorio
// //  - La fecha de nacimiento es opcional
// //  - No es necesario controlar errores
// //  - Crea los constructores necesarios
// //  - Crea el constructor de copia. La copia tendrá un id de deportista nuevo ya que es clave primaria
// //  - Crea los getters y setters
// //  - Invalida el método ToString() para que nos devuelva una cadena con toda la información del deportista


// public class Deportista
// {
//     private static int cantidad_deportistas_actual = 0;
//     private int id;
//     private DateOnly? fechaNacimiento;
//     private string? nombre;

//     public Deportista(DateOnly fechaNacimento, string nombre)
//     {
//         Id = cantidad_deportistas_actual;
//         FechaNacimiento = fechaNacimento;
//         Nombre = nombre;
        
//     }
//     public Deportista(Deportista deportista)
//     {
//         Id = cantidad_deportistas_actual;
//         FechaNacimiento = deportista.fechaNacimiento;
//         Nombre = deportista.Nombre;
        
//     }

//     public string? Nombre
//     {
//         get => nombre;
//         set => nombre = value;
//     }
//     private int Id
//     {
//         get => id;
//         set
//         {
//             id = value;
//             cantidad_deportistas_actual++;
            
//         }
//     }

//     public DateOnly? FechaNacimiento
//     {
//         get => fechaNacimiento;
//         set => fechaNacimiento = value;

//     }

//     public virtual string ToString()
//     {
//         string información = $"Nombre: {Nombre} FechaNacimiento {FechaNacimiento} Id {Id} \t";
//                             información += "---------------------------------------------\n";
                            
//         return información;
//     }

// }


// // 2. Crea una clase llamada equipo:
// //  - Un equipo tiene un código de equipo, un nombre y desde cero hasta 20 deportistas
// //  - El código del equipo debe tener tres letras en mayúsculas
// //  - El nombre es obligatorio
// //  - Genera errores adecuados si el código no tiene tres letras.
// //  - Las letras del código pueden estar en minúsculas, pero se deben pasar a mayúsculas
// //  - Todo equipo tendrá un mínimo de cero y un máximo de veinte deportistas
// //  - Crea un constructor con el código y el nombre como parámetros
// //  - Crea el constructor de copia
// //  - Crea los getters y setters
// //  - Invalida el métido ToString() que nos devuelve en una cadena toda la información del
// //    equipo más toda la información de sus deportistas
// //  - Crea un método que añada un deportista a un equipo
// //  - Genera errores adecuados si el se intenta añadir un deportista a un equipo que ya tiene 20 deportistas.

// public class CodigoMenorDeTresDigitos : Exception
// {
//     public CodigoMenorDeTresDigitos(string message) : base(message) { }


// }
// public class CantidadDeportistasSuperada : Exception
// {
//     public CantidadDeportistasSuperada(string message) : base(message) { }


// }
// public class Equipo

// {
//     private int cantidad_miembros_actual;
//     private const int CANTIDA_DEPORTISTAS = 20;
//     private string codigoEquipo;
//     private string nombre;
//     private Deportista[] deportistas = new Deportista[CANTIDA_DEPORTISTAS];

//     public Equipo(string codigoEquipo, string nombre)
//     {
//         Nombre = nombre;
//         CodigoEquipo = codigoEquipo;
//         Deportista = new Deportista[CANTIDA_DEPORTISTAS];
//     }
//     public Equipo(Equipo equipo)
//     {
//         Nombre = equipo.nombre;
//         CodigoEquipo = equipo.codigoEquipo;
//         Deportista = new Deportista[CANTIDA_DEPORTISTAS];
//         Deportista = equipo.Deportista;
//     }

//     public string CodigoEquipo
//     {
//         get => codigoEquipo.ToUpper();
//         set
//         {
//             if (value.Length > 3)
//             {
//                 throw new CodigoMenorDeTresDigitos("Haz introducido un codigo mayor a 3");
//             }
//             codigoEquipo = value;
//         }
//     }

//     public string Nombre
//     {
//         get => nombre;
//         set => nombre = value;
//     }

//     public Deportista[] Deportista
//     {
//         get => deportistas;
//         set
//         {
//             for (int i = 0; i < deportistas.Length; i++)
//             {
//                 deportistas[i] = value[i];
//             }
//         }

//     }

//     public override string ToString()
//     {
//         string mensaje = "Informacion del equipo es la siguiente\n" +
//                         $"Nombre {Nombre} Codigo del equipo [{CodigoEquipo}]\n ";

//         for (int i = 0; i < cantidad_miembros_actual; i++)
//         {
//             mensaje += deportistas[i].ToString() + "\t";
//         }
//         return mensaje;
//     }

//     public void AyadirDeportista(Deportista deportista)
//     {

//         if (cantidad_miembros_actual < CANTIDA_DEPORTISTAS)
//         {
//             deportistas[cantidad_miembros_actual] = deportista;
//             cantidad_miembros_actual++;
//         }
//         else
//         {
//             throw new CantidadDeportistasSuperada("Solo pueden ser 20 deportistas, haz superado el límite");
//         }
//     }

// }

// public class Program
// {
//     // / 3. Para probarlo todo:
//     //  - Crea dos equipos.
//     //  - Añade a uno 10 deportistas de manera aleatoria y al segundo 15 deportias de manera aleatoria
//     //  - Saca por pantalla toda la información de los dos equipos
//     // ---------------------------------------------------------------------------- */
//     static void Main()
//     {

//         Equipo madrid = new Equipo("RMA", "Real Madrid");
//         for (int i = 0; i < 10; i++)
//         {

//             madrid.AyadirDeportista(new Deportista(FechaAleatoria(), NombresAleatorios()));
//         }
//         Equipo barcelona = new Equipo ("BCL","Barcelona");
//         for (int i = 0; i < 15; i++)
//         {
//             barcelona.AyadirDeportista(new Deportista(FechaAleatoria(),NombresAleatorios()));
//         }

//        Console.WriteLine(madrid.ToString());
//        Console.WriteLine(barcelona.ToString());
        
//     }

//     private static string NombresAleatorios()
//     {
//         string[] nombre = { "Pepe", "Juan", "Marco", "Alex", "Simon", "Jose", "Miguel", "Daniel", "Manuel", "Barbara" };
//         Random random = new Random();
//         return nombre[random.Next(nombre.Length)];

//     }
//     private static DateOnly FechaAleatoria()
//     {Random random = new Random();
//     int anoMinimo = 1990;
//     int anoMaximo = 2050;
//     int anoAleatorio = random.Next(anoMinimo, anoMaximo + 1);

//     // Obtener un mes aleatorio dentro del rango de 1 a 12
//     int mesAleatorio = random.Next(1, 13);

//     // Obtener el último día del mes para el año y mes aleatorios
//     int ultimoDiaDelMes = DateTime.DaysInMonth(anoAleatorio, mesAleatorio);

//     // Obtener un día aleatorio dentro del rango del mes
//     int diaAleatorio = random.Next(1, ultimoDiaDelMes + 1);
      

//         return new DateOnly(anoAleatorio,mesAleatorio,diaAleatorio);
//     }
// }
