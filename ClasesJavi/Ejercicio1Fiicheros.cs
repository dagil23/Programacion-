// // Como se explica en el tema, para trabajar con las cadenas que representan las rutas de un sistema de archivos, podemos usar la clase de utilidad Path . Esta clase tiene varios métodos, algunos se nombran en el tema pero otros no. Crea un programa para probar, al menos, los método que se relacionan a continuación. Indica al lado de cada método y con comentarios la salida después de la ejecución.

// // string GetExtension(string ruta)
// // string GetFileName(string ruta)
// // string GetFileNameWithoutExtension(string ruta)
// // string GetDirectoryName(string ruta)
// // string GetPathRoot(string ruta)
// // string ChangeExtension(string ruta, string nuevaExtensión) 
// // string GetFullPath(string rutaRelativa) 
// // string Combine(string ruta1, string ruta2)
// // Nota: Busca en la documentación de Microsoft información y ejemplos sobre los mismos.

// public class Ficheros{
//     static void Main(args[]){
//         // string GetExtension(string ruta)
//         string extension = Path.GetExtension("C:\\Users\\dgil5\\OneDrive\\Escritorio\\Programacion.GIT\\Programacion-\\ClasesJavi\\holaguapo.txt");
//         Console.WriteLine($"Se ha ejecutado el método GetExtension, y hemos obtenido: {extension}");

//         // string GetFileName(string ruta)
//         string filename = Path.GetFileName("C:\\Users\\dgil5\\OneDrive\\Escritorio\\Programacion.GIT\\Programacion-\\ClasesJavi\\holaguapo.txt");
//         Console.WriteLine($"Se ha ejecutado el método GetFileName, y hemos obtenido: {filename}");

//         // string GetFileNameWithoutExtension(string ruta)
//         string filenameWithoutExtension = Path.GetFileNameWithoutExtension("C:\\Users\\dgil5\\OneDrive\\Escritorio\\Programacion.GIT\\Programacion-\\ClasesJavi\\holaguapo.txt");
//         Console.WriteLine($"Se ha ejecutado el método GetFileNameWithoutExtension, y hemos obtenido: {filenameWithoutExtension}");

//         // string GetDirectoryName(string ruta)
//         string directoryName = Path.GetDirectoryName("C:\\Users\\dgil5\\OneDrive\\Escritorio\\Programacion.GIT\\Programacion-\\ClasesJavi\\holaguapo.txt");
//         Console.WriteLine($"Se ha ejecutado el método GetDirectoryName, y hemos obtenido: {directoryName}");

//         // string GetPathRoot(string ruta)
//         string pathRoot = Path.GetPathRoot("C:\\Users\\dgil5\\OneDrive\\Escritorio\\Programacion.GIT\\Programacion-\\ClasesJavi\\holaguapo.txt");
//         Console.WriteLine($"Se ha ejecutado el método GetPathRoot, y hemos obtenido: {pathRoot}");

//         // string ChangeExtension(string ruta, string nuevaExtensión) 
//         string changeExtension = Path.ChangeExtension("C:\\Users\\dgil5\\OneDrive\\Escritorio\\Programacion.GIT\\Programacion-\\ClasesJavi\\holaguapo.txt", ".pdf");
//         Console.WriteLine($"Se ha ejecutado el método ChangeExtension, y hemos obtenido: {changeExtension}");

//         // string GetFullPath(string rutaRelativa) //Este método es dependiente de donde te encuentras
//         // Lo que decía ChatGPT: 
//         /*
//         En este ejemplo, Path.GetFullPath toma una ruta relativa (Archivo.txt) y devuelve la ruta completa. Ten en cuenta que la ruta completa dependerá del directorio de trabajo actual cuando se ejecute el programa.
//         Este código supone que hay un archivo llamado "Archivo.txt" en el mismo directorio que el programa. Asegúrate de adaptarlo según tus necesidades y la estructura de tu proyecto
//         */
//         string fullPath = Path.GetFullPath("holaguapo.txt");
//         Console.WriteLine($"Se ha ejecutado el método GetFullPath, y hemos obtenido: {fullPath}");
//         // string Combine(string ruta1, string ruta2)
//         /*
//         En este ejemplo, Path.Combine se utiliza para combinar las partes de la ruta (directorioBase, subdirectorio, archivo) en una sola ruta completa (rutaCompleta). La función se encarga de manejar las barras diagonales y otros detalles específicos del sistema operativo para construir una ruta válida.

// Ten en cuenta que Path.Combine no verifica si la ruta resultante existe o no; simplemente combina las partes de la manera adecuada. Si necesitas verificar la existencia de la ruta, deberías utilizar otras funciones, como Directory.Exists o File.Exists.
//         */
//         string combine = Path.Combine("C:\\Users\\dgil5\\OneDrive\\Escritorio\\Programacion.GIT\\Programacion-\\ClasesJavi\\holaguapo.txt", "C:\\Users\\dgil5\\OneDrive\\Escritorio\\Programacion.GIT\\Programacion-\\ClasesJavi\\holaguapo2.txt");
//         Console.WriteLine($"Se ha ejecutado el método Combine, y hemos obtenido: {combine}");
        
//     }
// }