// // Declara una clase abstracta Legislador que herede de la clase Persona, que usamos en ejercicios anteriores, con un campo povinciaQueRepresenta tipo string, y si quieres otros atributos que creas necesarios.

// // Como puedes ver en el diagrama, la clase Legislador hereda de la clase Persona que no es abstracta, lo cual significa que puede haber instancias de Persona pero no de Legislador.

// // Declara un método abstracto GetCamaraEnQueTrabaja (devolverá un string indicando la cámara a la que pertenece), ToString (devolverá un string con los datos a mostrar de la clase incluida la provincia que representa).

// // Crea las siguientes clases que heredarán de Legislador e implementarán los métodos necesarios:

// // Diputado
// // Senador
// // Crea un array de tres legisladores de distintos tipos, usa polimorfismo de datos y muestra por pantalla la cámara en que trabajan y otros datos que creas necesarios.

// using System.Runtime.CompilerServices;

class Persona{
    private  string nombre;
    private  string dni;
    private int edad;

    public Persona(in string nombre, in string dni, int edad){
        this.dni = dni;
        this.edad = edad;
        this.nombre = nombre;
    }

    public int Edad{

        get => edad;
        set{
            edad = value;
        }
        
    }
    public string  Nombre{
        get => nombre;
        set{
            nombre = value;
        }
    }
    public string Dni{
        get => dni;
        set{
            dni = value;
        }
    }


    public virtual  string ToString(){
        return $"Nombre {Nombre} \n" +
        $"Dni {Dni} \n"+
        $"Edad {Edad}";
    }

    
}

abstract class Legislador : Persona{

    private string provinciaQueRepresenta;



    public Legislador( string nombre,
      string dni, 
     int edad,
     string provinciaQueRepresenta):base(nombre,dni,edad){

            
            ProvinciaQueRepresenta = provinciaQueRepresenta;
            Edad = edad;
            Nombre = nombre;
    }

    public string ProvinciaQueRepresenta{
        get => provinciaQueRepresenta;

        set { provinciaQueRepresenta = value;}
       
    }

    public  abstract string  GetCamaraEnQueTrabaja();

    public override string ToString()
    {
        return base.ToString() + $"Provinvia que representa {ProvinciaQueRepresenta}";
    }


}

// public class Diputado : Legislador{

//     public Diputado(in string nombre,
//      in string dni, 
//      int edad,
//      string provinciaQueRepresenta):base(nombre,dni,edad,provinciaQueRepresenta){

            
//     }

//     public override string GetCamaraEnQueTrabaja(){
//         return "La camara de los Diputados";
//     }
// }

// public class Senador : Legislador{


//   public Senador(in string nombre,
//      in string dni, 
//      int edad,
//      string provinciaQueRepresenta):base(nombre,dni,edad,provinciaQueRepresenta){

                
//     }
//     public override string GetCamaraEnQueTrabaja(){
//         return "La camara de los Senadores";
//     }

// }