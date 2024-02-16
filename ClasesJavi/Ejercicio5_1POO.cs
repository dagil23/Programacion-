// // A partir del siguiente texto:
// // "Una cadena de muebles a nivel nacional tiene tiendas ubicadas por toda la geografía española.
// // Cada una de estas tiendas de muebles almacena información sobre: sofás, sillas y mesas. De todos ellos es común, como mínimo, color(enumeración), peso, dimensiones (estructura), fabricante y precio. En cambio los sofás incluye información de la tela con el que está tapizado y si es abatible o no, las sillas la longitud del respaldo y las mesas el tipo de madera que está hecho."

// // Crea una clase Mueble que contenga los campos, constructores y métodos necesarios para recoger la información de un mueble y devolver mediante un método ACadena esa información. Importante que al recoger los valores de color pertenezcan a la enumeración.

// // 📌 Nota: Debes de fijarte que el ejercicio pide que hagas solo la clase Mueble, con las características comunes a todos los muebles, el resto de texto se usará en ejercicios posteriores.

// using System.Drawing;

// public class Mueble
// {

//     private Color color;
//     private double peso;
//     private int dimensionX;
//     private int dimensionY;
//     private int dimensionZ;
//     private string fabricante;
//     private double precio;

//     public Mueble(in Color color, in double peso, in int dimensionX, in int dimensionY, in int dimensionZ, in string fabricantes, in double precio)
//     {

//         SetColor(color);
//         SetPeso(peso);
//         SetDimensiones(dimensionX, dimensionY, dimensionZ);
//         SetPrecio(precio);
//         SetFabricantes(fabricantes);

//     }
//     public void SetColor(Color color)
//     {
//         this.color = color;
//     }
//     public void SetPeso(double value)
//     {
//         peso = value;
//     }
//     public void SetDimensiones(int dimensionX, int dimensionY, int dimensionZ)
//     {
//         this.dimensionZ = dimensionZ;
//         this.dimensionX = dimensionX;
//         this.dimensionY = dimensionY;
//     }
//     public void SetPrecio(double value)
//     {
//        precio = value;
//     }
//     public void SetFabricantes(string value)
//     {
//         fabricante = value;
//     }
//     public double Getpeso()
//     {
//         return peso;
//     }

//     public double getPrecio()
//     {
//         return precio;
//     }
//     public string getFabricantes()
//     {
//         return fabricante;
//     }
//     public Color getColor(){
//         return color;
//     }

//     public (int dimensionZ, int dimensionX, int dimensionY)GetDimenciones(){
//         return (dimensionZ,dimensionX,dimensionY);
//     }
    
//     public string  Acadena()
//     {
//         return "El mueble: tiene un peso de : " + Getpeso() + " es de color  " + getColor() + " con un precio de " + getPrecio() + " con unas dimensiones de " + GetDimenciones() + " y su fabricante es " + getFabricantes();
//     }

// }
// public enum Color
// {
//     Azul,
//     Verde,
//     Rojo,
//     Marron
// };