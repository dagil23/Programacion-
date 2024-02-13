// class Ficheros_2
// {

//     //Individual names
//     static string root = "C:\\";
//     static string carpetaNombres = "nombres";
//     static string carpetaJuan = "juan";
//     static string carpetaPepe = "pepe";
//     static string carpetaDatos = "datos";
//     static string ficheroDocumento = "documento.txt";

//     //Routes
//     static string rutaCarpetaNombres = Path.Combine(root, carpetaNombres);
//     static string rutaCarpetaJuan = Path.Combine(root, carpetaNombres, carpetaJuan);
//     static string rutaCarpetaPepe = Path.Combine(root, carpetaNombres, carpetaPepe);
//     static string rutaCarpetaDatos = Path.Combine(root, carpetaNombres, carpetaJuan, carpetaDatos);
//     static string rutaFicheroDocumento = Path.Combine(root, carpetaNombres, carpetaJuan, ficheroDocumento);

//     static void Main()
//     {

//         ConsoleKeyInfo key;

//         do
//         {
//             Console.WriteLine("¿Qué opción quieres elegir?");
//             key = Console.ReadKey();

//             if (key.Key == ConsoleKey.NumPad0)
//             {
//                 CreaArbolDeDirectorios();
//             }
//             else if (key.Key == ConsoleKey.NumPad1)
//             {
//                 string rutaABorrar = getRutaABorrar();
//                 EliminaDirectorio(rutaABorrar);
//             }
//             else if (key.Key == ConsoleKey.NumPad2)
//             {
//                 string ficheroABorrar = getRutaFicheroABorrar();
//                 EliminaFichero(ficheroABorrar);
//             }
//             else if (key.Key == ConsoleKey.NumPad3)
//             {
//                 string rutaAMostrar = getRutaAMostrar();
//                 MuestraInformacion(rutaAMostrar);
//             }
//             else if (key.Key == ConsoleKey.NumPad5)
//             {
//                 string ficheroAMostrarAtributos = getFicheroAMostrarAtributos();
//                 MuestraInformacion(ficheroAMostrarAtributos);
//             }
//             else
//             {
//                 Console.WriteLine("Opción introducido no reconocida. Introduzca una opción reconocida, por favor");
//             }

//         } while (key.Key != ConsoleKey.Escape);
//     }

//     private static string getRutaABorrar()
//     {
//         Console.WriteLine("¿Qué directorio quieres borrar?");
//         Console.WriteLine($"0- {rutaCarpetaNombres}");
//         Console.WriteLine($"1- {rutaCarpetaJuan}");
//         Console.WriteLine($"2- {rutaCarpetaPepe}");
//         Console.WriteLine($"3- {rutaCarpetaDatos}");

//         ConsoleKeyInfo newOption = Console.ReadKey();

//         string ruta = "";
//         if (newOption.Key == ConsoleKey.NumPad0)
//         {
//             ruta = rutaCarpetaNombres;
//         }
//         else if (newOption.Key == ConsoleKey.NumPad1)
//         {
//             ruta = rutaCarpetaJuan;
//         }
//         else if (newOption.Key == ConsoleKey.NumPad2)
//         {
//             ruta = rutaCarpetaPepe;
//         }
//         else if (newOption.Key == ConsoleKey.NumPad3)
//         {
//             ruta = rutaCarpetaDatos;
//         }
//         else
//         {
//             Console.WriteLine("Has metido una opción no contemplada, te devuelvo al menú principal");
//         }

//         return ruta;
//     }

//     private static string getRutaFicheroABorrar()
//     {
//         Console.WriteLine("¿Qué fichero quieres borrar?");
//         Console.WriteLine($"0- {rutaFicheroDocumento}");
//         Console.WriteLine("1- Introducir nombre del fichero a borrar");

//         ConsoleKeyInfo newOption = Console.ReadKey();

//         string ficheroABorrar = "";
//         if (newOption.Key == ConsoleKey.NumPad0)
//         {
//             ficheroABorrar = rutaFicheroDocumento;
//         }
//         else if (newOption.Key == ConsoleKey.NumPad1)
//         {
//             Console.WriteLine("Introduceme el nombre del fichero a borrar");
//             ficheroABorrar = Console.ReadLine() ?? "";
//         }
//         else
//         {
//             Console.WriteLine("Has metido una opción no contemplada, te devuelvo al menú principal");
//         }

//         return ficheroABorrar;
//     }

//     private static string getRutaAMostrar()
//     {
//         Console.WriteLine("¿Qué directorio quieres mostrar?");
//         Console.WriteLine($"0- {rutaCarpetaNombres}");
//         Console.WriteLine($"1- {rutaCarpetaJuan}");
//         Console.WriteLine($"2- {rutaCarpetaPepe}");
//         Console.WriteLine($"3- {rutaCarpetaDatos}");

//         ConsoleKeyInfo newOption = Console.ReadKey();

//         string rutaAMostrar = "";
//         if (newOption.Key == ConsoleKey.NumPad0)
//         {
//             rutaAMostrar = rutaCarpetaNombres;
//         }
//         else if (newOption.Key == ConsoleKey.NumPad1)
//         {
//             rutaAMostrar = rutaCarpetaJuan;
//         }
//         else if (newOption.Key == ConsoleKey.NumPad2)
//         {
//             rutaAMostrar = rutaCarpetaPepe;
//         }
//         else if (newOption.Key == ConsoleKey.NumPad3)
//         {
//             rutaAMostrar = rutaCarpetaDatos;
//         }
//         else
//         {
//             Console.WriteLine("Has metido una opción no contemplada, te devuelvo al menú principal");
//         }

//         return rutaAMostrar;
//     }

//     private static string getFicheroAMostrarAtributos()
//     {
//         Console.WriteLine("¿De cuál fichero quieres ver sus atributos?");
//         Console.WriteLine($"0- {rutaFicheroDocumento}");
//         Console.WriteLine("1- Introducir nombre del fichero");

//         ConsoleKeyInfo newOption = Console.ReadKey();

//         string ficheroAMostrarAtributos = "";
//         if (newOption.Key == ConsoleKey.NumPad0)
//         {
//             ficheroAMostrarAtributos = rutaFicheroDocumento;
//         }
//         else if (newOption.Key == ConsoleKey.NumPad1)
//         {
//             Console.WriteLine("Introduceme el nombre del fichero");
//             ficheroAMostrarAtributos = Console.ReadLine() ?? "";
//         }
//         else
//         {
//             Console.WriteLine("Has metido una opción no contemplada, te devuelvo al menú principal");
//         }

//         return ficheroAMostrarAtributos;
//     }

//     private static void CreaArbolDeDirectorios()
//     {
//         //C:\\
//         //nombres
//         //pepe
//         //datos
//         //documento.txt
//         //juan
//     }

//     private static void EliminaDirectorio(string directorio)
//     {

//     }

//     private static void EliminaFichero(string fichero)
//     {

//     }

//     private static void MuestraInformacion(string ruta)
//     {

//     }

//     private static void MuestraAtributos(string fichero)
//     {

//     }
// }
