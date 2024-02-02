// // Debes definir un tipo valor que represente un Naipe de la baraja Española de 48 cartas. El tipo estará compuesto por dos miembros: un valor y un palo, este último sera de tipo enumerado con los siguientes valores posibles: Oros, Copas, Bastos, Espada.
// // Crea un método en la clase principal que utilizando el tipo Naipe nos devuelva una baraja con las 48 cartas, usa una matriz Naipe[,] baraja= new Naipe[4,12] e inicialízala suponiendo que cada fila representa un palo.
// // Crea un método que nos mezcle la baraja para que queden sus cartas desordenadas.
// // Crea un programa que muestre el resultado de la utilización de los métodos anteriores.

// // 📌 Nota: Vuelve a repasar los apuntes donde se explica la creación del Tipo Valor y sigue las normas que se explican para este tipo.
// public enum Palo{
//     Oro,
//     Copas,
//     Basto,
//     Espada
// }
// struct Naipe{
//     private int valor;
//     private Palo palo;

//     public Naipe(in int valor, in Palo palo ){
//         this.valor = valor;
//         this.palo = palo;
//     }
//     public string Acadena(){
//         return $"[{valor}{palo}]";
//     }
// }

// public class EjercicioNaipe7_1{
//    private static int tipoDePalo = 4;
//       private static int cantidadCartasPorPalo = 4;
//     static Palo AsignarPalo(int i){
//         if(i == 0){
//             return Palo.Basto;
//         }else if(i==1){
//             return Palo.Oro;
//         }else if(i==2){
//             return Palo.Copas;
//         }
//             return Palo.Espada;
        
        
        
        
        

//     }
//     static Naipe[,] GenerarBaraja(){
     
        
//         Naipe[,] baraja = new Naipe[tipoDePalo,cantidadCartasPorPalo];
//         for (int i = 0; i < tipoDePalo; i++)
//         {
//            Palo palo = AsignarPalo(i);
//            for (int j = 0; j < cantidadCartasPorPalo; j++)
//            {
//             baraja[i,j] = new Naipe(j+1,palo);
//            }
//         }
//         return baraja;
//     }

//     static void BarajarBaraja(Naipe[,] baraja){
//         Random random = new Random();
//         int filasAleatorias = random.Next(0, tipoDePalo-1);
//         int columnaAleatoria = random.Next(0, cantidadCartasPorPalo -1);
//         for (int i = 0; i <tipoDePalo; i++)
//         {
//             for (int j = 1; j < cantidadCartasPorPalo; j++)
//             {
//                 Naipe naipe1 = baraja[i,j];
//                 Naipe naipe2 = baraja[filasAleatorias,columnaAleatoria];
//                 baraja[i,j] = naipe2;
//                 baraja[filasAleatorias,columnaAleatoria] = naipe1;
//             }
//         }
//     }
//           static void MostrarBaraja(Naipe[,] baraja){

         
//             for (int i = 0; i < baraja.GetLength(0); i++)
//             {
//                 for (int j = 0; j < baraja.GetLength(1); j++)
//                 {
//                     Console.Write(baraja[i,j].Acadena());
//                 }
//                 Console.WriteLine();
//             }
//           }
//     static void Separador(){
//         Console.WriteLine("------------------------------------");
//     }
//     static void Main(){
//         Naipe[,] naipe = GenerarBaraja();
//         Console.WriteLine("Baraja sin barajar: ");
//         Separador();
//         MostrarBaraja(naipe);
//         Separador();
//         Console.WriteLine("Baraja barajada: ");
//         BarajarBaraja(naipe);
//         MostrarBaraja(naipe);



        
//     }
// }