
public interface ICumplePredicado<T>
{
    public bool Predicado(T o1, T o2);

}
public interface IObtenTemperatura
{
    public float ObtenTemperatura(TemperaturasXProvincia provincia);
}
public class TemperaturasXProvincia
{
    public string Provincia { get; }
    public float TemperaturaMaxima { get; }
    public float TemperaturaMinima { get; }

    public TemperaturasXProvincia(string provincia,
                float temperaturaMaxima,
                float temperaturaMinima)
    {
        Provincia = provincia;
        TemperaturaMaxima = temperaturaMaxima;
        TemperaturaMinima = temperaturaMinima;
    }
}
public class ObtenMaxima : IObtenTemperatura
{
    public float ObtenTemperatura(TemperaturasXProvincia provincia)
    {
        return provincia.TemperaturaMaxima;
    }
}

public class ObtenMinima : IObtenTemperatura
{
    public float ObtenTemperatura(TemperaturasXProvincia provincia)
    {
        return provincia.TemperaturaMinima;
    }
}

public class MayorQue : ICumplePredicado<float>
{
    public bool Predicado(float o1, float o2)
    {
        return o1 > o2;
    }
}

public class MenorQue : ICumplePredicado<float>
{
    public bool Predicado(float o1, float o2)
    {
        return o1 < o2;
    }
}
public class IgualQue : ICumplePredicado<float>
{
    public bool Predicado(float o1, float o2)
    {
        return o1 == o2;
    }
}

// public class Program
// {
//     static void Main()
//     {
//         //Generamos las provincias ==> proporcionando cuántas queremos y el nombre de cada una de ellas.
//         //Una vez le damos la cantidad de provincias que queremos y el nombre de cada provincia, genera
//         //aleatoriamente valores para las temperaturas máximas y mínimas de cada provincia.
//         TemperaturasXProvincia[] provincias = RecogeTemperaturasPorProvincia();

//         // 1- Muestre las provincias cuya máxima sea mayor a la media de las máximas.
//         Console.WriteLine();
//         Console.WriteLine("las provincias cuya máxima sea mayor a la media de las máximas");

//         IObtenTemperatura estrategiaMaxima = new ObtenMaxima();
//         float mediaDeLasMaximas = MediaTemperaturas(provincias, estrategiaMaxima);
//         MuestraProvincias(
//             provincias,
//             estrategiaMaxima,
//             new MayorQue(),
//             mediaDeLasMaximas  
//         );

//         // Muestre las provincias cuya mínima sea menor a la media de las mínimas.
//         Console.WriteLine();
//         Console.WriteLine("las provincias cuya mínima sea menor a la media de las mínimas");
//         IObtenTemperatura estrategiaMinima = new ObtenMinima();
//         float mediaDeLasMinimas = MediaTemperaturas(provincias, estrategiaMinima);
//         MuestraProvincias(
//             provincias,
//             estrategiaMinima,
//             new MenorQue(),
//             mediaDeLasMinimas
//         );
        
//         // Muestre las provincias cuya mínima sea igual a la media de las mínimas.
//         Console.WriteLine();
//         Console.WriteLine("las provincias cuya mínima sea igual a la media de las mínimas");
//         IObtenTemperatura estrategiaMinima2 = new ObtenMinima();
//         float mediaDeLasMinimas2 = MediaTemperaturas(provincias, estrategiaMinima2);
//         MuestraProvincias(provincias,estrategiaMinima2,new IgualQue(),mediaDeLasMinimas2 );
//     }
    
//     public static void MuestraProvincias(
//         TemperaturasXProvincia[] temperaturasXProvincias,
//         IObtenTemperatura estrategia,
//         ICumplePredicado<float> cumplePredicado,
//         float temperatura
//     )
//     {
//         //Para cada una de las ciudades
//         foreach(TemperaturasXProvincia provincia in temperaturasXProvincias) {
//             //Obtenemos su temperatura máxima o mínima (en función de la estrategia) y la comparamos (cumplePredicado ===> MayorQue/MenorQue/IgualQue) con la temperatura que nos hayan pasado.
//             if (cumplePredicado.Predicado(estrategia.ObtenTemperatura(provincia), temperatura) == true) {
//                 //Imprimimos la ciudad que haya dado "true" en la comparación.
//                 Console.WriteLine($"Esta ciudad lo cumple: {provincia.Provincia}");
//             }
//         }
//     }

//     //Este método calcula la media de las temperaturas máximas o la media de las temperaturas mínimas.
//     //El decidir si escoge las máximas o las mínimas está en función de la estrategia que nos pasen (ObtenMaxima u ObtenMínima).
//     public static float  MediaTemperaturas(
//         TemperaturasXProvincia[] temperaturasXProvincias,
//         IObtenTemperatura estrategia
//     )
//     {
//         //Variable donde vamos a ir sumando las temperaturas máximas o mínimas de las distintas ciudades.
//         float suma = 0;

//         //Nos recorremos las ciudades, con el fin de poder acceder a su temperatura máxima o mínima (en función de la estrategia).
//         foreach(TemperaturasXProvincia provincia in temperaturasXProvincias) {
//             //Obtenemos la temperatura máxima o mínima (en función de la estrategia) y la vamos sumando.
//             suma += estrategia.ObtenTemperatura(provincia);
//         }

//         //Una vez tenemos la suma de las máximas o las mínimas (en función de la estrategia), dividmos por el número
//         //de ciudades, para obtener la media de las máximas o las mínimas (en función de la estrategia).
//         return suma / temperaturasXProvincias.Length;
//     }

//     public static TemperaturasXProvincia[] RecogeTemperaturasPorProvincia()
//         {
//             Console.Write("De cuantas provincias quieres recoger la temperatura: ");
//             var temperaturasPorProvincia =
//                 new TemperaturasXProvincia[int.Parse(Console.ReadLine())];
//             Random seed = new Random();
//             for (int i = 0; i < temperaturasPorProvincia.Length; i++)
//             {
//                 Console.Write($"Introduce la provincia nº{i + 1}:  ");
//                 string provincia = Console.ReadLine();
//                 float temperaturaMaxima = seed.Next(17, 25);
//                 float temperaturaMinima = seed.Next(-5, 17);
//                 Console.Write("\n\n");
//                 temperaturasPorProvincia[i] = new TemperaturasXProvincia(
//                                                     provincia,
//                                                     temperaturaMaxima,
//                                                     temperaturaMinima);
//             }
//             return temperaturasPorProvincia;
//         }
// }
        
