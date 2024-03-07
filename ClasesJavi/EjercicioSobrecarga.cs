// public static class Taxi
// {
//     const float BAJADA_BANDERA = 1.82F;
//     const float CARRERA_MINIMA = 3.63F;
//     const float COSTE_KM = 0.9F;
//     const float ESPERA_POR_HORA = 18.77F;
//     const short PORCENTAJE_NOCTURNO = 30;


//    private static double _CosteCarrera(
//                     float kilometrosRecorridos, float minutosEspera,
//                     bool nocturno , int porcentajeFestivo, int ocupacionExtra){
                        
//         float costeCarrera = BAJADA_BANDERA + kilometrosRecorridos * COSTE_KM
//                                     + minutosEspera * (ESPERA_POR_HORA / 60);
//         costeCarrera = costeCarrera < CARRERA_MINIMA 
//                                     ? CARRERA_MINIMA 
//                                     : costeCarrera;
//         float incrementoNocturno = nocturno 
//                                     ? costeCarrera / PORCENTAJE_NOCTURNO 
//                                     : 0;
//         float incrementoFestivo = porcentajeFestivo != 0 
//                                     ? costeCarrera * porcentajeFestivo / 100f 
//                                     : 0;
//         costeCarrera += incrementoFestivo >= incrementoNocturno 
//                                     ? incrementoFestivo 
//                                     : incrementoNocturno;
//         costeCarrera += ocupacionExtra;
//         return costeCarrera;
//                     }
//     public static double CosteCarrera(
//                     float kilometrosRecorridos, float minutosEspera,
//                     bool nocturno , int porcentajeFestivo, int ocupacionExtra  )
//     {
//         return _CosteCarrera(kilometrosRecorridos,minutosEspera,nocturno,porcentajeFestivo,ocupacionExtra);
//     }
//       public static double CosteCarrera(
//                     float kilometrosRecorridos, float minutosEspera,
//                     bool nocturno , int porcentajeFestivo )
//     {
//         return _CosteCarrera(kilometrosRecorridos,minutosEspera,nocturno,porcentajeFestivo,0);
//     }
//      public static double CosteCarrera(
//                     float kilometrosRecorridos, float minutosEspera,
//                     bool nocturno )
//     {
//         return _CosteCarrera(kilometrosRecorridos,minutosEspera,nocturno,0,0);
//     }
//      public static double CosteCarrera(
//                     float kilometrosRecorridos, float minutosEspera
//                   )
//     {
//         return _CosteCarrera(kilometrosRecorridos,minutosEspera,false,0,0);
//     }
// }
// class Program
// {
//     static void Main()
//     {
        
//         Console.WriteLine($"Coste carrera lunes mañana -> "
//                           + $"{Taxi.CosteCarrera(20, 5):f2}");
//         Console.WriteLine($"Coste carrera lunes noche -> "
//                           + $"{Taxi.CosteCarrera(20, 5, true):f2}");
//         Console.WriteLine($"Coste carrera lunes con mi mascota Dogo -> "
//                           + $"{Taxi.CosteCarrera(20, 5, false, 0, 1):f2}");
//         Console.WriteLine($"Coste carrera Domingo de Ramos -> "
//                           + $"{Taxi.CosteCarrera(20, 5, false, 40):f2}");
//         Console.WriteLine($"Coste carrera Domingo noche -> "
//                           + $"{Taxi.CosteCarrera(20, 5, true, 20):f2}");
//         Console.WriteLine($"Coste carrera Domingo de Ramos noche con Dogo y Minina -> "
//                           + $"{Taxi.CosteCarrera(20, 5, true, 40, 2):f2}");
//     }
// }