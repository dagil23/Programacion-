// A partir del siguiente texto:
// "Una cadena de muebles a nivel nacional tiene tiendas ubicadas por toda la geografía española.
// Cada una de estas tiendas de muebles almacena información sobre: sofás, sillas y mesas. De todos ellos es común, como mínimo, color(enumeración), peso, dimensiones (estructura), fabricante y precio. En cambio los sofás incluye información de la tela con el que está tapizado y si es abatible o no, las sillas la longitud del respaldo y las mesas el tipo de madera que está hecho."

// Crea una clase Mueble que contenga los campos, constructores y métodos necesarios para recoger la información de un mueble y devolver mediante un método ACadena esa información. Importante que al recoger los valores de color pertenezcan a la enumeración.

// 📌 Nota: Debes de fijarte que el ejercicio pide que hagas solo la clase Mueble, con las características comunes a todos los muebles, el resto de texto se usará en ejercicios posteriores.

using System.Drawing;

public class Mueble
{

    private Color color;
    private double peso;
    private int dimensionX;
    private int dimensionY;
    private int dimensionZ;
    private string fabricante;
    private double precio;

    public Mueble(in Color color, in double peso, in int dimensionX, in int dimensionY, in int dimensionZ, in string fabricantes, in double precio){

        this.color = color;
        this.peso = peso;
        this.dimensionX = dimensionX;
        this.dimensionZ = dimensionZ;
        this.dimensionY = dimensionY;
        this.precio = precio;
        this.fabricante = fabricantes;

    }
    public double Getpeso(){
        return peso;
    }
   
    private (int dimensionX,int dimensionY,int dimensionZ)SetDimensiones(int dimensionX,int dimensionY,int dimensionZ)
    {
        return (dimensionX,dimensionY,dimensionZ);
    }
    
    public double getPrecio(){
        return precio;
    }
    public string getFabricantes(){
        return fabricante;
    }

    public string Acadena(){
        return "El mueble: "+" tiene un peso de: " + peso + "con un color de " + color +" con un precio de " + precio + " con unas dimensiones de " + SetDimensiones(dimensionX,dimensionX,dimensionZ) + " y su fabricante es " + fabricante;
    }

}
public enum Color
{
    Azul,
    Verde,
    Rojo,
    Marron
};