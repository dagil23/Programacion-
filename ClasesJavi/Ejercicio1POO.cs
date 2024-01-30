// // A partir del siguiente diagrama de clases, crea la clase necesaria que permita reflejar los elementos que ves representados en él, y la aplicación para probarla. Las categorías de los trabajadores pueden ser:
// // Subalterno = 10, Administrativo = 20, JefeDepartamento = 40, Gerente = 60.
// // 📌 Nota: El salario del empleado se calculará a partir de la categoría de trabajo que desempeñe, las categorías tienen asociadas el incremento en porcentaje que se tiene que hacer al salario base, que será una constante con el valor de 1200.
// public class Empleado {
//     private static double sueldoBase = 1200.0;

//     private string dni;
//     private string nombre;
//     private int AnoNacimiento;
//     private Categoria categoria;

//     public Empleado(in string dni, in string nombre, in int AnoNacimiento){
//         this.dni = dni;
//         this.nombre = nombre;
//         this.AnoNacimiento = AnoNacimiento;
//     }
//     public Empleado (in Empleado empleado){
//         this.dni = empleado.dni;
//         this.nombre = empleado.nombre;
//         this.AnoNacimiento = empleado.AnoNacimiento;
//         this.categoria = empleado.categoria;
//     }

//     public string GetNombre(){
//         return nombre;
//     }
    
//     public int GetAnoNacimiento(){
//         return AnoNacimiento;
//     }

//     public string GetDni(){
//         return dni;
//     }

//     public void SetCategoria(in Categoria categoria){
//         this.categoria = categoria;
//     }

//     public double Salario(){
//         return categoria switch
//         {
//             Categoria.Subalterno => Empleado.sueldoBase + (Empleado.sueldoBase * (((double)Categoria.Subalterno))/100.0),
//             Categoria.Administrativo => Empleado.sueldoBase + (Empleado.sueldoBase * (((double)Categoria.Administrativo))/100.0),
//             Categoria.JefeDepartamento => Empleado.sueldoBase + (Empleado.sueldoBase * (((double)Categoria.JefeDepartamento))/100.0),
//             Categoria.Gerente => Empleado.sueldoBase + (Empleado.sueldoBase * (((double)Categoria.Gerente))/100.0),
//             _ => Empleado.sueldoBase,
//         };
//     }


//     public string Acadena(){
//         return "$El empleado " + nombre + " con dni : " + dni + " tiene un salario " + Salario() + " y su categoria es: " + categoria;
     
//     }

// }

// public enum Categoria{
//     Subalterno = 10, 
//     Administrativo = 20, 
//     JefeDepartamento = 40,
//     Gerente = 60

// }