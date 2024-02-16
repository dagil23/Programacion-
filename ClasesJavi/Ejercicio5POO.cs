// // A partir del siguiente texto:
// // "Una cadena de muebles a nivel nacional tiene tiendas ubicadas por toda la geografía española.
// // Cada una de estas tiendas de muebles almacena información sobre: sofás, sillas y mesas. De todos ellos es común, como mínimo, color(enumeración), peso, dimensiones (estructura), fabricante y precio. En cambio los sofás incluye información de la tela con el que está tapizado y si es abatible o no, las sillas la longitud del respaldo y las mesas el tipo de madera que está hecho."

// // Crea una clase Mueble que contenga los campos, constructores y métodos necesarios para recoger la información de un mueble y devolver mediante un método ACadena esa información. Importante que al recoger los valores de color pertenezcan a la enumeración.

// // 📌 Nota: Debes de fijarte que el ejercicio pide que hagas solo la clase Mueble, con las características comunes a todos los muebles, el resto de texto se usará en ejercicios posteriores.

// class Mueble {
//     private Color color;
//     private double peso;
//     private double dimensionX;
//     private double dimensionY;
//     private double dimensionZ;

//     private string fabricante;
//     private double precio;

//     public Mueble(
//         Color color, 
//         double peso,
//         double dimensionX,
//         double dimensionY,
//         double dimensionZ,
//         string fabricante,
//         double precio
//     ) {
//         this.color = color;
//         this.peso = peso;
//         this.dimensionX = dimensionX;
//         this.dimensionY = dimensionY;
//         this.dimensionZ = dimensionZ;
//         this.fabricante = fabricante;
//         this.precio = precio;
//     }

//     public Color getColor() {
//         return color;
//     }

//     public double getPeso() {
//         return peso;
//     }

//     public double getDimensionX() {
//         return dimensionX;
//     }

//     public double getDimensionY() {
//         return dimensionY;
//     }

//     public double getDimensionZ() {
//         return dimensionZ;
//     }

//     public string getFabricante() {
//         return fabricante;
//     }

//     public double getPrecio() {
//         return precio;
//     }

//     virtual public string ACadena() {
//         return "El mueble tiene las siguientes propiedades:" +
//         " Color: " + color +
//         " Peso: " + peso +
//         " Dimension X: " + dimensionX +
//         " Dimension Y: " + dimensionY +
//         " Dimension Z: " + dimensionZ +
//         " Fabricante: " + fabricante +
//         " Precio: " + precio;
//     }
// }

// class Sofa: Mueble {
//     private string nombre_tela;
//     private bool esAbatible;

//     public Sofa(
//         string nombre_tela,
//         bool esAbatible,
//         Color color, 
//         double peso,
//         double dimensionX,
//         double dimensionY,
//         double dimensionZ,
//         string fabricante,
//         double precio
//     ): base(color, peso, dimensionX, dimensionY, dimensionZ, fabricante, precio) {
//         this.nombre_tela = nombre_tela;
//         this.esAbatible = esAbatible;
//     }

//     override public string ACadena() {
//         return base.ACadena() +
//          " Nombre tela: " + nombre_tela +
//          " Es abatible: " + esAbatible;
//     }
// }

// class Silla: Mueble {
//     private double longitud_respaldo;

//     public Silla(
//         double longitud_respaldo,
//         Color color, 
//         double peso,
//         double dimensionX,
//         double dimensionY,
//         double dimensionZ,
//         string fabricante,
//         double precio
//     ): base(color, peso, dimensionX, dimensionY, dimensionZ, fabricante, precio) {
//         this.longitud_respaldo = longitud_respaldo;
//     }

//     override public string ACadena() {
//         return base.ACadena() +
//          " Longitud respaldo: " + longitud_respaldo;
//     }
// }

// class Mesa: Mueble {
//     private string tipo_madera;

//     public Mesa(
//         string tipo_madera,
//         Color color, 
//         double peso,
//         double dimensionX,
//         double dimensionY,
//         double dimensionZ,
//         string fabricante,
//         double precio
//     ): base(color, peso, dimensionX, dimensionY, dimensionZ, fabricante, precio) {
//         this.tipo_madera = tipo_madera;
//     }

//     override public string ACadena() {
//         return base.ACadena() +
//          " Tipo madera: " + tipo_madera;
//     }
// }

// enum Color {
//     Rojo,
//     Azul,
//     Marron
// }

