// public class Ejercicio2Ficheros
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
//             Console.WriteLine("0 - CrearArbolDirectorios");
//             Console.WriteLine("1 - Eliminar directorio");
//             Console.WriteLine("2 - Eliminar Fichero");
//             Console.WriteLine("3 - Mostrar información");
//             Console.WriteLine("4 - Mostrar atributos");
//             key = Console.ReadKey();
//             Console.WriteLine();

//             if (key.Key == ConsoleKey.D0)
//             {
//                 CreaArbolDeDirectorios();
//             }
//             else if (key.Key == ConsoleKey.D1)
//             {
//                 string rutaABorrar = getRutaABorrar();
//                 EliminaDirectorio(rutaABorrar);
//             }
//             else if (key.Key == ConsoleKey.D2)
//             {
//                 string ficheroABorrar = getRutaFicheroABorrar();
//                 EliminaFichero(ficheroABorrar);
//             }
//             else if (key.Key == ConsoleKey.D3)
//             {
//                 string rutaAMostrar = getRutaAMostrar();
//                 MuestraInformacion(rutaAMostrar);
//             }
//             else if (key.Key == ConsoleKey.D4)
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
//         if (newOption.Key == ConsoleKey.D0)
//         {
//             ruta = rutaCarpetaNombres;
//         }
//         else if (newOption.Key == ConsoleKey.D1)
//         {
//             ruta = rutaCarpetaJuan;
//         }
//         else if (newOption.Key == ConsoleKey.D2)
//         {
//             ruta = rutaCarpetaPepe;
//         }
//         else if (newOption.Key == ConsoleKey.D3)
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
//         if (newOption.Key == ConsoleKey.D0)
//         {
//             ficheroABorrar = rutaFicheroDocumento;
//         }
//         else if (newOption.Key == ConsoleKey.D1)
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
//         if (newOption.Key == ConsoleKey.D0)
//         {
//             rutaAMostrar = rutaCarpetaNombres;
//         }
//         else if (newOption.Key == ConsoleKey.D1)
//         {
//             rutaAMostrar = rutaCarpetaJuan;
//         }
//         else if (newOption.Key == ConsoleKey.D2)
//         {
//             rutaAMostrar = rutaCarpetaPepe;
//         }
//         else if (newOption.Key == ConsoleKey.D3)
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
//         if (newOption.Key == ConsoleKey.D0)
//         {
//             ficheroAMostrarAtributos = rutaFicheroDocumento;
//         }
//         else if (newOption.Key == ConsoleKey.D1)
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
//         string[] rutasCarpetas = {
//             rutaCarpetaNombres,
//             rutaCarpetaJuan,
//             rutaCarpetaPepe,
//             rutaCarpetaDatos,
//         };

//         string[] rutasFicheros = {
//             rutaFicheroDocumento
//         };

//         Directory.CreateDirectory(rutaCarpetaNombres);
//         Directory.CreateDirectory(rutaCarpetaNombres);

//         foreach (string ruta in rutasCarpetas)
//         {
//             if (doesPathExist(ruta, false))
//             {
//                 Console.WriteLine($"La carpeta {ruta} existe.");
//             }
//             else
//             {
//                 Console.WriteLine($"La carpeta {ruta} no existe. Lo creamos,");
//                 crearCarpeta(ruta);
//             }
//         }

//         foreach (string ruta in rutasFicheros)
//         {
//             if (doesPathExist(ruta, true))
//             {
//                 Console.WriteLine($"El fichero {ruta} existe.");
//             }
//             else
//             {
//                 Console.WriteLine($"El fichero {ruta} no existe. Lo creamos,");
//                 crearFichero(ruta);
//             }
//         }
//     }

//     private static bool doesPathExist(string path, bool isFile)
//     {
//         if (isFile)
//         {
//             return File.Exists(path);
//         }

//         return Directory.Exists(path);
//     }

//     private static void crearFichero(string ruta)
//     {
//         using StreamWriter escritor = new StreamWriter(ruta);
//         // Escribir datos en el archivo
//         escritor.WriteLine("");
//     }

//     private static void crearCarpeta(string ruta)
//     {
//         Directory.CreateDirectory(ruta);
//     }

//     private static void EliminaDirectorio(string directorio)
//     {
//         if (Directory.Exists(directorio))
//         {
//             Directory.Delete(directorio, true);
//             Console.WriteLine($"El directorio {directorio} ha sido eliminado con exito.");
//         }
//         else
//         {
//             Console.WriteLine("El directorio no existe...");
//         }
//     }

//     private static void EliminaFichero(string fichero)
//     {
//         if (File.Exists(fichero))
//         {
//             File.Delete(fichero);
//             Console.WriteLine($"El archivo {fichero} ha sido eliminado con éxito.");
//         }
//         else
//         {
//             Console.WriteLine("El fichero indicado no existe");
//         }
//     }

//     private static void MuestraInformacion(string ruta)
//     {
//         if (Directory.Exists(ruta) == true)
//         {
//             DirectoryInfo infoDirectorio = new DirectoryInfo(ruta);
//             Console.WriteLine("\nInformacion del directorio ...");
//             Console.WriteLine(ObtenInformacionSistemaDeFicheros(infoDirectorio) + "\n");
//         }
//         else
//         {
//             Console.WriteLine("EL directorio no existe...\n");
//         }
//     }

//     static string ObtenInformacionSistemaDeFicheros(FileSystemInfo fsi)
//     {
//         string infoFS = "";

//         infoFS += "\tRuta absoluta: " + fsi.FullName;
//         infoFS += "\n\tFecha creacion: " + fsi.CreationTime;
//         infoFS += "\n\tFecha ultimo acceso: " + fsi.LastAccessTime;
//         infoFS += "\n\tFecha ultimo modificacion: " + fsi.LastWriteTime;

//         infoFS += "\n\tAtributos:";
//         if ((fsi.Attributes & FileAttributes.Normal) == FileAttributes.Normal)
//             infoFS += " Normal";
//         if ((fsi.Attributes & FileAttributes.Compressed) == FileAttributes.Compressed)
//             infoFS += " Comprimido";
//         if ((fsi.Attributes & FileAttributes.Encrypted) == FileAttributes.Encrypted)
//             infoFS += " Encriptado";
//         if ((fsi.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
//             infoFS += " Oculto";
//         if ((fsi.Attributes & FileAttributes.System) == FileAttributes.System)
//             infoFS += " Sistema";
//         if ((fsi.Attributes & FileAttributes.Temporary) == FileAttributes.Temporary)
//             infoFS += " Temporal";

//         return infoFS;
//     }

//     private static void MuestraAtributos(string fichero)
//     {
//         if (File.Exists(fichero) == true)
//         {
//             FileInfo infoFichero = new FileInfo(fichero);
//             string info = ObtenInformacionSistemaDeFicheros(infoFichero);
//             if (infoFichero.IsReadOnly)
//                 info += " Solo_Lectura";
//             Console.WriteLine("\nInformacion del archivo ...");
//             Console.WriteLine(info + "\n");
//         }
//         else
//         {
//             Console.WriteLine("EL fichero no existe...\n");
//         }
//     }
// }
