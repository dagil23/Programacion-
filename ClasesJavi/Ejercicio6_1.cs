// // A partir del primer ejercicio y teniendo en cuenta la relación entre las clases, crea las clase Empresa.

// // 📌 Nota: El método DatosEmpresa de Empresa devolverá la información de la empresa sin los empleados, mientras que ACadena incluirá los empleados.

// public class Empleado {
//     private static double sueldoBase = 1200.0;

//     private  readonly string dni;
//     private readonly string nombre;
//     private readonly int AnoNacimiento;
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

// class Empresa {
//     private readonly string cif;
//     private readonly string razonSocial;
//     private string direccion;
//     private Empleado[] empleados;

//     public Empresa(
//         in string cif,
//         in string razonSocial,
//         in string direccion,
//         in string dni,
//         in string nombre,
//         in int añoNacimiento
//     ) {
//         this.cif = cif;
//         this.razonSocial = razonSocial;
//         this.direccion = direccion;
//         empleados = new Empleado[1];
//         empleados[0] = new Empleado(dni, nombre, añoNacimiento);
//     }
// }