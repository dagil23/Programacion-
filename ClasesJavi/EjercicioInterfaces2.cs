
// // Tendremos una clase Estudios que implementará los interfaces IEstudios e IVisualiza. La interfaz IEstudios deberá asegurar que las clases que deriven de ella, implementen un método que muestre por pantalla la edad mínima para empezar esos estudios.
// // Al implementar la interfaz IVisualiza (del ejemplo 1), en el método se mostrará por pantalla la información relativa a los estudios en curso.
// // La clase Estudios no podrá ser instanciada y derivarán de ella las clases Superior, Medio y Elemental: los estudios superiores, medios y elementales, tendrán como edades de acceso mínimas 18, 16 y 12 años respectivamente.

// // Para todos los estudios, nos interesará ver en pantalla su nombre y duración.
// // Para los estudios superiores, nos interesará el lugar donde se realizan.
// // Para los Medios nos interesa ver por pantalla el nombre de un estudio superior
// // al que den acceso.
// // Crea al menos un objeto de cada una de las clases y comprueba su funcionamiento. Comprueba si las clases derivadas de Estudios son a su vez derivadas de IEstudios y IVisualiza.

// interface IEstudios
// {

//     void EdadMinimaParaEstudiar();
// }
// interface IVisualiza
// {
//     void Visualiza();
// }

// abstract class Estudios : IEstudios, IVisualiza
// {


//     private string NombreCurso { get; set; }
//     private int Duracion { get; set; }

//     public Estudios(string nombreCurso, int duracion)
//     {


//         NombreCurso = nombreCurso;
//         Duracion = duracion;
//     }

//     public abstract void EdadMinimaParaEstudiar();

//     public void Visualiza()
//     {

//         Console.WriteLine($"Nombre del curso {NombreCurso}\n",
//                         $"Duracion del curso: {Duracion}");
//     }
// }

//     class Superior : Estudios
//     {
//         private string Ubicacion{get;set;}

//         public Superior(string nombreCurso,int duracion,string ubicacion):base(nombreCurso,duracion){
//             Ubicacion = ubicacion;
            
//         }
//     public override void EdadMinimaParaEstudiar(){ 

//         Console.WriteLine("La edad minima para estudiar es 18 años");
//      }
        

//     }
//     class Medio : Estudios
//     {
//         private Superior estudioSuperior;
//         public Medio(string nombreCurso,
//          int duracion,
//          Superior estudioSuperior):base(nombreCurso,duracion){
//             this.estudioSuperior = estudioSuperior;

//         }

//        public override void EdadMinimaParaEstudiar(){ 

//         Console.WriteLine("La edad minima para estudiar es 16 años");
//      }


//         public void AccesosSuperior(){
            
//             Console.WriteLine("Estos estudios dan acceso : \n");
//             estudioSuperior.Visualiza();
//         }
      
//     }
//     class Elemental : Estudios
//     {
//         public Elemental(string nombreCurso, int duracion):base(nombreCurso,duracion){}
//          public override void EdadMinimaParaEstudiar(){ 

//         Console.WriteLine("La edad minima para estudiar es 12 años");
//      }
//     }
//     class Program
//     {
//         static void Main()
//         {
//             IEstudios[] estudios = new IEstudios[]{
//                 new Superior("DAW",3,"Alicante-Doctor-Balmis"),
//                 new Elemental("Musica",4),
//                 new Medio("ADE",6,new Superior("DAW",4,"Alicante"))
//             };

        
          
//           //IEstudios -- IVisualiza
//           //Estudios
//           // Superior -- Medio -- Elemental

//         }
//     }