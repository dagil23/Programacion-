// Crea una clase Automovil con los datos básicos de los automóviles (marca, modelo, cilindrada, año de fabricación,
//  etc) y los métodos necesarios para poder usarla con comodidad.

public class Automovil{
    public string Marca {get;set;}
    public string Modelo {get;set;} 
    public string Cilindrada {get;set;}
    public string Color {get;set;}    
    public DateOnly AnyoFabricacion {get;set;}

    public Automovil(
        string marca,
        string modelo,
        string cilindrada,
        string color,
        DateOnly anyoFabricacion )
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
            AnyoFabricacion = anyoFabricacion;
            Color = color;
        }

    public override string ToString()
    {
        return $"{Marca},{Modelo},{Cilindrada},{Color},{AnyoFabricacion.ToString()}";

    }
}
// Crea una clase Program con una serie de métodos que nos permitan trabajar con una lista genérica de automóviles.

// Necesitaremos un Método AñadeAutomovil que a partir de una lista y un automóvil, añadirá este a la lista.

// EliminaAutomovil que eliminará el automóvil con el índice i que se haya pasado como argumento.

// Crea un método AutomovilesPorAñoFabricacion, que te permita encontrar en la lista los coches con una determinada fecha de fabricación y que retorne una nueva lista con esos datos.

// Otro método AutomovilesPorAñoFabricacionYColor que devuelva una sublista con los coches de la 
// lista que sean de un determinado color y una fecha pasados ambos como parámetros.

// Método que permita mostrar el contenido de la lista.


public class Program
{

    public static void AyadeAutomovil(Automovil auto, List<Automovil> lista) => lista.Add(auto);

    public static void EliminaAutomovil(int indice, List<Automovil> lista) => lista.RemoveAt(indice);

    public static List<Automovil> AutomovilesPorAñoFabricacion(List<Automovil> lista, DateOnly anyoFabricacion) => lista.FindAll(x => x.AnyoFabricacion.Year == anyoFabricacion.Year);

    public static List<Automovil>  AutomovilesPorAnyoFabricacionYColor(List<Automovil> lista, string color, DateOnly fecha){
        return AutomovilesPorAñoFabricacion(lista,fecha).FindAll(x => x.Color == color);
       //return lista.FindAll(x => x.Color == color && x.AnyoFabricacion.Year == fecha.Year);
    }

    public static void MuestraLista(List<Automovil> lista) => Console.WriteLine(string.Join(", \n", lista.Select(x => x.ToString())));


    
//    static void Main(){
    
//         List<Automovil> list = new List<Automovil>();
//         AyadeAutomovil(new Automovil("TFor","Fiesta","2554","Azul",new DateOnly(2002,4,15)),list);
//         AyadeAutomovil(new Automovil("sdsd","Fiesta","2554","Rojo",new DateOnly(2002,4,15)),list);
//         AyadeAutomovil(new Automovil("TFosdsdr","Fiesta","2554","Rojo",new DateOnly(2004,4,15)),list);
//         AyadeAutomovil(new Automovil("TsdsdFor","Fiesta","2554","Rojo",new DateOnly(2003,4,15)),list);

//         List<Automovil> listaAux = AutomovilesPorAnyoFabricacionYColor(list, "Rojo", new DateOnly(2002, 5, 20));
//         MuestraLista(listaAux);
        

    
//    }
   
}