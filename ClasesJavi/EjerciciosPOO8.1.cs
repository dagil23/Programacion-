// // Utilizando el tipo valor Punto definido en los apuntes, vamos a crear otro tipo valor Estrella formado por un punto, el caracter * y un color aleatorio de la enumeración ConsoleColor.

// // En el programa principal seguiremos los siguientes pasos:

// // Deberemos introducir por teclado la cantidad de estrellas a dibujar.
// // Además almacenaremos los datos en una tabla definida de la siguiente manera Estrella[] estrellas = new Estrella[NumEstrellas];
// // Generaremos la posición del Punto y el Color de cada estrella de forma aleatoria.
// // Borraremos la pantalla con el método Clear() de la clase Console.
// // Dibujaremos todo el array de estrellas en cada una de las coordenadas introducidas y con el color generado aleatorio.
// // 📌 Nota: para posicionar la estrella en la pantalla usaremos el método de la clase Console void SetCursorPosition(int letf, int top); que situará el cursor en una coordenada dentro de las 24 filas y 80 columnas que puede tener una consola con origen en la esquina superior izquierda (para generar los puntos, utilizaremos en Next de la clase Random con el rango entre 24 y 80). Para pintar el color utilizaremos la propiedad, de la clase Console, ForegroundColor.


// struct Punto2D
// {
//     public readonly int X;
//     public readonly int Y;

//     public Punto2D(in int x, in int y)
//     {
//         Y = y; //Filaas
//         X = x; //Columnas
//     }
//     public string ATexto()
//     {
//         return $"({X:G2} - {Y:G2})";
//     }
// }

// struct Estrella{
//  public  Punto2D punto;
//    public  char asterisco = '*';

//   public ConsoleColor color;

//     public Estrella(Punto2D punto, ConsoleColor color){
//         this.punto= punto;
//         this.color = color;
    
//     }

// }

// class EjercicioPOO8_1{
//         static void Main(){

//             Console.WriteLine("INTRODUCE LA CANTIDAD DE ESTRELLAS A DIBUJAR: ");
//             int cantidadEstrellas = int.Parse(Console.ReadLine()??"0");
//             Estrella[] estrellas = new Estrella [cantidadEstrellas];
//         //Aqui estoy creado las estrellas
//             for (int i = 0; i < cantidadEstrellas; i++)
//             {
//                 Random random = new Random();
//                 Punto2D puntoAletorio = new Punto2D(random.Next(0,Console.BufferHeight),random.Next(0,Console.BufferHeight));
//                 estrellas[i] = new Estrella(puntoAletorio,(ConsoleColor)random.Next(0,15));
//             }
//         //Aqui estamos imprimiendo las estrellas por consola 
//         for (int i = 0; i < cantidadEstrellas; i++)
//         {
//             // Console.ForegroundColor = estrellas[i].color;
//             Console.SetCursorPosition(estrellas[i].puntoX,)
//         }
//         }



// }