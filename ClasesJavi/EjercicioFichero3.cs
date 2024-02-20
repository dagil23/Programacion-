// // Vamos a crear algunos comandos similares a los del S.O., que nos ayuden a entender mejor el funcionamiento de las clases DirectoryInfo, FileInfo y sus homólogas de utilidad. Para ello deberemos crear distintos programas, de forma que cada uno haga una de las siguientes funciones. El nombre de cada proyecto será el nombre del comando y todos irán en una solución llamada ejercicio3:

// // Comando listaCarpeta: Se encargará de mostrar el contenido del directorio actual si no se le indica ruta, o del directorio que se indique en la ruta. Sino existe el directorio, se capturará la excepción mostrando un mensaje de error.
// // Puedes usar la funcionalidad de las enumeraciones excluyentes para conocer el tipo de elemento:
// // Comando creaDirectorio: Se le pasa una ruta y te crea un directorio y tendrás que controlar si se indica más de una entrada o capturar las excepciones de ruta inválida.

// // Comando eliminaDirectorio: Se le pasa una ruta y te elimina un directorio, tendrás que controlar si se indica más de una entrada o capturar las excepciones de ruta inválida.

// // Comando eliminaFichero: Se le pasa una ruta y elimina un fichero y tendrás que controlar si se indica más de una entrada o capturar las excepciones de ruta inválida.

// // Comando copiaFicheros: Se le pasa dos rutas:

// // La primera de un directorio válido.
// // la segunda de un directorio que no tiene porque existir.
// // El comando se encargará de copiar todos los ficheros que hay en la primera ruta a la segunda, creando la carpeta si fuera necesario. Además, deberás controlar las posibles excepciones.
// // Este comando podrá, además, ejecutarse con la opción de añadir un filtro a la copia (solo se copiarán los archivos que cumplan el filtro, eso lo podemos hacer con la sobrecarga del método EnumerateFile).
// // Ejemplo del comando para copiar los ficheros que contengan en su nombre windows, desde la carpeta logs a la carpeta copia:

// // copiaFicheros c:\logs c:\copia *windows*
// // 📌 Nota: La ejecución y el paso de información al programa se realizará a través de la línea de comandos.
// // La explicación está en el primer ejercicio del tema anterior de excepciones.



// using System.ComponentModel.Design;
// using Microsoft.VisualBasic;

// public class Program
// {
//     static void Main(string[] args)
//     {
//         string opcion = args[0];
//         if (args.Length > 0)
//         {
           
//         switch (opcion)
//         {
//             case "1" :
//             listaCarpeta();
//             break;
//             case "2":
//             creaDirectorio();
//             break;
//             default:
//             Menu();
//             break;
            
//         }
//         }
//     }
// public static void Menu(){
//     Console.WriteLine("1.Para mostras la informacion de las capetas");
//     Console.WriteLine("2.Para crear un directorio con la ruta prporcionada");
//     Console.WriteLine("3....");
//     Console.WriteLine("4....");
//     Console.WriteLine("5....");
// }
// // Puedes usar la funcionalidad de las enumeraciones excluyentes para conocer el tipo de elemento:
// // Comando creaDirectorio: Se le pasa una ruta y te crea un directorio y tendrás que controlar si se indica más de una entrada o capturar las excepciones de ruta inválida.
// public static void creaDirectorio(){

//     try
//     {    Console.WriteLine("Indique una ruta: ");
//          string ruta = Console.ReadLine();
//          Console.WriteLine("Creando la ruta en el siguiente directorio: ");
//          Directory.CreateDirectory(ruta);
//     }
//     catch (System.Exception)
//     {
        
//         Console.WriteLine("NOOO");
//     }
// }
//     public static void listaCarpeta()
//     {
//         try
//         {

//             Console.WriteLine("Indique una ruta para mostrar la informacion: ");
//             string ruta = Console.ReadLine();
//             if (string.IsNullOrWhiteSpace(ruta))
//             {
//                 ruta = Directory.GetCurrentDirectory();
//                 Console.WriteLine("La informacion del directorio actual es: ");
//                 Console.WriteLine(Path.GetDirectoryName(ruta));
//             }
//             DirectoryInfo infoDirectorio = new DirectoryInfo(ruta);
//             string[] informacionDirectorios = Directory.GetDirectories(ruta);
//             Console.WriteLine("La informacion de los directorios es: ");
//             foreach (string directorios in informacionDirectorios)
//             {
//                 Console.WriteLine(Path.GetDirectoryName(ruta));
//             }
//         }
//         catch (System.Exception)
//         {

//             Console.WriteLine("No");
//         }

//     }
//     public static void ObtenerInfromacionDirectorioActual(string ruta)
//     {
//         if (string.IsNullOrWhiteSpace(ruta))
//         {   
//             ruta = Directory.GetCurrentDirectory();
//            Console.WriteLine(Path.GetDirectoryName(ruta));
//         }
//     }
// }
// //     string [] informacionFicheros = Directory.GetFiles(ruta);
// //     Console.WriteLine("La informacion de los ficheros es:");
// //    foreach (string fichero in informacionFicheros)
// //    {
// //     Console.WriteLine(Path.GetFileName(fichero));

// //    }