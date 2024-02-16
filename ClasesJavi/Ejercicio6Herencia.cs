// // Crear una clase llamada TablaEnteros que no permita que se creen objetos a partir de ella. Esta clase almacenará una tabla de enteros de una dimensión y que será un atributo protegido, el tamaño debe ser especificado mediante su constructor.
// // La clase debe obligar a que cualquier clase que herede de ella y no quiera ser una clase abstracta, implemente un método llamado GuardarNumerosenTabla.

// // Además, TablaEnteros dispondrá de dos métodos:

// // DevuelveTabla, método redefinible, que servirá para devolver la cadena con el contenido completo de la tabla.
// // SumaPropia que se encargará de comprobar si existen más números positivos o negativos en la tabla y devolverá la suma de aquellos de los que hay mayor cantidad.
// // Crear a partir de esta clase dos nuevas clases llamadas:

// // TablaImpares: que solo guardará números impares en el atributo del padre.
// // TablaPares: que solo guardará números pares, el el atributo del padre.
// // Ambas, lo harán mediante el método GuardarNumerosEnTabla, antes mencionado, que seleccionará los números apropiados (pares o impares) a guardar a partir de número generados aleatoriamente.

// // En el programa principal, crea instancias de cada una de estas clases, dales valores y muestra las tablas y la suma propia de ambos objetos por pantalla.

// abstract class TablaEnteros{


//     protected int [] arrayEnteros;

//     public TablaEnteros(in int tamano){

//         arrayEnteros = new int[tamano];
//     }
//     abstract public void GuardarNumerosEnTabla(in int [] array);
//     public virtual string DevuelveTabla(){

//         return string.Join(",",arrayEnteros);
//     }
//     public int SumaPropia(){
//         int cantidadPositivos = 0;
//         int cantidadNegativos = 0;
//         for (int i = 0; i < arrayEnteros.Length; i++)
//         {
//             if (arrayEnteros[i] >= 0)
//             {
//                 cantidadPositivos ++;
//             }else{
//                 cantidadNegativos ++;
//             }

//         }
//         int suma = 0;
//         if (cantidadPositivos >= cantidadNegativos)
//         {
//             //Hacer suma de los numeros positivos;
//             for (int i = 0; i < arrayEnteros.Length; i++)
//             {
//                 if (arrayEnteros[i] >= 0)
//                 {
//                     suma += arrayEnteros[i];
//                 }
//             }
//         }
//         else
//         {
//             //Hacer la suma de los numeros negativos;
//             for (int i = 0; i < arrayEnteros.Length; i++)
//             {
//                 if (arrayEnteros[i] < 0)
//                 {
//                     suma += arrayEnteros[i];
//                 }
//             }
        
//         } 
//         return suma;
//     }

// }
// class TablaImpares:TablaEnteros{
//     private int cantidadElementos = 0;
//     public TablaImpares(in int tamano):base(tamano){

//     }

//     public override void GuardarNumerosEnTabla(in int [] array){

//         for (int i = 0; i < array.Length && cantidadElementos < arrayEnteros.Length; i++) {
//             if (array[i]%2!=0)
//             {
//                 arrayEnteros[cantidadElementos] = array[i];
//                 cantidadElementos++;
//             }
//         }
//     }
    

// }
// class TablaPares :TablaEnteros{
//     private int cantidadElementos = 0;
//     public TablaPares(in int tamano):base(tamano){
        
//     }

//     public override void GuardarNumerosEnTabla(in int [] array){

//         for (int i = 0; i < array.Length && cantidadElementos < arrayEnteros.Length; i++) {
//             if (array[i]%2==0)
//             {
//                 arrayEnteros[cantidadElementos] = array[i];
//                 cantidadElementos++;
//             }
//         }
//     }

// }

// public class ProgramEjercicio6{
//     static void Main(){
//         int tamano = 10;
//         TablaPares tablapar = new TablaPares (tamano);
//         TablaImpares tablaImpares = new TablaImpares (tamano);

//         Random random = new Random ();
//         int [] arrayEnteros = new int [tamano];
//         for (int i = 0; i < arrayEnteros.Length; i++)
//         {
//             arrayEnteros[i] = random.Next(-10, 10);
//         }

//         tablapar.GuardarNumerosEnTabla(arrayEnteros);
//         tablaImpares.GuardarNumerosEnTabla(arrayEnteros);
//         Console.WriteLine(tablaImpares.DevuelveTabla());
//         Console.WriteLine($"Suma: {tablaImpares.SumaPropia()}");
//         Console.WriteLine(tablapar.DevuelveTabla());
//         Console.WriteLine($"Suma: {tablapar.SumaPropia()}");

     


//     }
// }

