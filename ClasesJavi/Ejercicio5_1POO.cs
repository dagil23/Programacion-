// // A partir del siguiente texto:
// // "Una cadena de muebles a nivel nacional tiene tiendas ubicadas por toda la geografía española.
// // Cada una de estas tiendas de muebles almacena información sobre: sofás, sillas y mesas. De todos ellos es común, como mínimo, color(enumeración), peso, dimensiones (estructura), fabricante y precio. En cambio los sofás incluye información de la tela con el que está tapizado y si es abatible o no, las sillas la longitud del respaldo y las mesas el tipo de madera que está hecho."

// // Crea una clase Mueble que contenga los campos, constructores y métodos necesarios para recoger la información de un mueble y devolver mediante un método ACadena esa información. Importante que al recoger los valores de color pertenezcan a la enumeración.

// // 📌 Nota: Debes de fijarte que el ejercicio pide que hagas solo la clase Mueble, con las características comunes a todos los muebles, el resto de texto se usará en ejercicios posteriores.

// using System.Drawing;
// class myExection : Exception{
//     public myExection(string message):base(message){

//     }
// }
// class Mueble
// {

//     private Colores color;
//     private int peso;
//     private int dimension_y;
//     private int dimension_x;
//     private int dimension_z;
//     private int precio;

//     public Mueble(int peso,
//                     int dimension_x,
//                     int dimension_y,
//                     int dimension_z,
//                     int precio,
//                     string fabricante)
//                     // Colores color)
//     {
//         Peso = peso;
//         Dimension_x = dimension_x;
//         Dimension_y = dimension_y;
//         Dimension_z = dimension_z;
//         Precio = precio;
//         Fabricante = fabricante;
//         // Color= color;
        
//     }

//     public Colores Color
//     {
//         get => color;
//         set
//         {
//             if (Enum.IsDefined(typeof(Colores), value))
//             {
                
//                 color = value;
//             }else{
//                 throw new myExection("El color debe pertenecer a la enumeracion");
//             }
//         }
//     }
//     public int Peso
//     {
//         get => peso;
//         set
//         {
//             peso = value;
//         }
//     }

//     public int Dimension_y
//     {
//         get => dimension_y;
//         set
//         {
//             dimension_y = value;
//         }
//     }

//     public int Dimension_x
//     {
//         get => dimension_x;
//         set
//         {
//             dimension_x = value;
//         }
//     }
//     public int Dimension_z
//     {
//         get => dimension_z;
//         set
//         {
//             dimension_z = value;
//         }
//     }

//     public int Precio{
//         get => precio;
//         set{
//             precio = value;
//         }
//     }

//     public string Fabricante { get; set; }

//     public string MostrarIformacion(){
//         return $"Precio {Precio:C}\n "+
//                 $"Dimensiones (Y) {Dimension_y}(X) {Dimension_x}(Z) {Dimension_z} \n "+
//                 $"Peso: {Peso:G}KG\n "+
//                 $"Fabricante: {Fabricante}";
//     }
    
// public enum Colores
// {
//     Rojo,
//     Verde,
//     Amarrillo,
//     Ngero,
//     Azul
// }
// }


// public class Program{
//     static void Main(){

//         Mueble mueble1 = new Mueble(20,5,6,7,99,"IKEA");
//         Console.WriteLine(mueble1.MostrarIformacion());

//         try
//         {
//             Mueble mueble2 = new Mueble (20,33,33,33,25,"IKEA");
//             Console.WriteLine("Introduce el color del mueble");
//             string color = Console.ReadLine();
//             mueble2.Color = (Colores)Enum.Parse(typeof(Colores),color, true);
            
//         }
//         catch (System.Exception)
//         {
            
//             throw;
//         }
//     }
// }