// // Crea un proyecto con los TAD necesarios para que el siguiente código perteneciente a la Main, pueda ser ejecutado sin problemas:
// // Compas compas = new Compas();
// // Circulo circulo = compas.DibujaCirculo(3.5f);
// // Rotulador rotulador = Estuche.GetRotuladores()
// //                       [
// //                           new Random().Next(0, Estuche.NUMERO_ROTULADORES)
// //                       ];
// // rotulador.Rotula(circulo.Perimetro());
// // Pincel pincel = new Pincel();
// // pincel.SetColor(Color.Verde);
// // pincel.Pinta(circulo.Area());   
// // 💡 Pistas:
// // El circulo tendrá un atributo radio.
// // El rotulador tendrá un atributo color de tipo enumerado y solo rotula perímetros.
// // Habrá una clase estática Estuche con un solo método también estático que devolverá un array de rotuladores con colores creados de forma aleatoria.
// // El pincel también tiene un atributo color y solo pinta áreas.
// // La salida por pantalla del programa podría ser algo como lo siguiente:
// // Dibujado un círculo de radio 3,5 
// // Rotulado el perímetro de 21,99 cm de color Azul.
// // Pintada el area de  38,48 cm de color Verde.

// // Creo las clases independientes que son Circulo, compas y pincel



// class Compas{


//     public Circulo DibujaCirculo(double radio ){
//         return new Circulo(radio);
//     }
// }
//  public static class Estuche{
    
//   public static Rotulador[] GetRotuladores(){


//   }
// }
// class Rotulador{

//     private Color color;
//    public const int NUMERO_ROTULADORES = 10;
//     public void Rotula(){


//     }



// }
//  class Circulo
// {
    
//     private double radio;


//    public Circulo(double radio){
//     this.radio = radio;
//    }
//     public double GetRadio(){
//         return radio;
//     }
//     public  double Perimetro(double radio){
//         return radio * radio * Math.PI;
// }
    

//  class Pincel{
//      private Color color;

//      public Color SetColor(Color color ){
//            return  color;
//      }
// }

// public enum Colores{
//     Rojo,
//     Amarillo,
//     Verde,
//     Azul,
//     Negro,
//     Blanco

// }
// }