// // Debes definir un tipo valor que represente un Naipe de la baraja Española de 48 cartas. El tipo estará compuesto por dos miembros: un valor y un palo, este último sera de tipo enumerado con los siguientes valores posibles: Oros, Copas, Bastos, Espada.
// // Crea un método en la clase principal que utilizando el tipo Naipe nos devuelva una baraja con las 48 cartas, usa una matriz Naipe[,] baraja= new Naipe[4,12] e inicialízala suponiendo que cada fila representa un palo.
// // Crea un método que nos mezcle la baraja para que queden sus cartas desordenadas.
// // Crea un programa que muestre el resultado de la utilización de los métodos anteriores.

// // 📌 Nota: Vuelve a repasar los apuntes donde se explica la creación del Tipo Valor y sigue las normas que se explican para este tipo.

// enum Palo {
//     Oro,
//     Copa,
//     Basto,
//     Espada
// }

// struct Naipe {
//     public readonly int valor;
//     public readonly Palo palo;

//     public Naipe(in int valor, in Palo palo)
//     {
//         this.valor = valor;
//         this.palo = palo;
//     }
//     public string ATexto() 
//     { 
//         return $"[{valor}-{palo}]"; 
//     }
// }

// class ProgramaNaipes
// {
//     private static int tiposDePalo = 4;
//     private static int cantidadCartasPorPalo = 12;

//     static void Main()
//     {
//         //Generamos la baraja.
//         Naipe[,] baraja = generarBaraja();

//         //Imprimimos la baraja generada.
//         Console.WriteLine("------------------");
//         Console.WriteLine("------------------");
//         Console.WriteLine("------------------");
//         Console.WriteLine("La baraja inicial es: ");
//         Console.WriteLine("------------------");
//         Console.WriteLine("------------------");
//         Console.WriteLine("------------------");
//         ImprimirBaraja(baraja);

//         //Barajamos la baraja.
//         barajar(baraja);

//         //Imprimimos la baraja barajada.
//         Console.WriteLine("------------------");
//         Console.WriteLine("------------------");
//         Console.WriteLine("------------------");
//         Console.WriteLine("La baraja barajada es: ");
//         Console.WriteLine("------------------");
//         Console.WriteLine("------------------");
//         Console.WriteLine("------------------");
        
//         ImprimirBaraja(baraja);
//     }

//     static Naipe[,] generarBaraja()
//     {

//         Naipe[,] baraja = new Naipe[tiposDePalo, cantidadCartasPorPalo];

//         for(int i = 0; i < tiposDePalo; i++) {
//             Palo palo = obtenerPalo(i);

//             for(int j = 0; j < cantidadCartasPorPalo; j++) {
//                 baraja[i,j] = new Naipe(j+1, palo);
//             }
//         }

//         return baraja;
//     }

//     private static Palo obtenerPalo(int i) {
//         if (i == 0) {
//             return Palo.Oro;
//         } else if (i == 1) {
//             return Palo.Copa;
//         } else if (i == 2) {
//             return Palo.Basto;
//         }
                
//         return Palo.Espada;
//     }

//     static void barajar(Naipe[,] baraja) {
//         Random random = new Random();

//         for(int i = 0; i < tiposDePalo; i++) {
//             for(int j = 0; j < cantidadCartasPorPalo; j++) {
//                 Naipe naipe1 = baraja[i,j];
//                 int filaAleatoria = random.Next(0, tiposDePalo-1);
//                 int columnaAleatoria = random.Next(0, cantidadCartasPorPalo-1);
//                 Naipe naipe2 = baraja[filaAleatoria, columnaAleatoria];
                
//                 baraja[i,j] = naipe2;
//                 baraja[filaAleatoria, columnaAleatoria] = naipe1;
//             }
//         }
//     }

//     static void ImprimirBaraja(Naipe[,] naipes) {
//         for(int i = 0; i < tiposDePalo; i++) {
//             for(int j = 0; j < cantidadCartasPorPalo; j++) {
//                 Console.Write(naipes[i,j].ATexto() + ", ");
//             }
//             Console.WriteLine();
//         }
//     }
// }