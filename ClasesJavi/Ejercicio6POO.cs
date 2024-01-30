// A partir del primer ejercicio y teniendo en cuenta la relación entre las clases, crea las clase Empresa.

// 📌 Nota: El método DatosEmpresa de Empresa devolverá la información de la empresa sin los empleados, mientras que ACadena incluirá los empleados.

public class Empresa{
    private readonly string  cif;
    private readonly string razonSocial;
    private string direccion;
    public Empleado[] empleado;

    public Empresa( string cif, string razonSocial, string direccion, Empleado empleado){

        this.cif = cif;
        this.razonSocial = razonSocial;
        this.direccion = direccion;
       

    }

    public Empresa(in Empresa empresa){

    }
  
    public string GetRazonSocial(){
        return razonSocial;
    }

    public string GetDireccion(){
        return direccion;
    }

    public string GetCif(){
        return cif;
    }

    public void AñadeGerente(in string dni, in string nombre, in int AnoNacimiento){
        
    }

    public void SetDireccion(string value){
        direccion = value;
    }

    public void DatosEmpresa(){
        Console.WriteLine($"La empresa {GetCif()}");
  
    }
}

public class Empleado {
    private static double sueldoBase = 1200.0;

    private string dni;
    private string nombre;
    private int AnoNacimiento;
    private Categoria categoria;

    public Empleado(in string dni, in string nombre, in int AnoNacimiento){
        this.dni = dni;
        this.nombre = nombre;
        this.AnoNacimiento = AnoNacimiento;
    }
    public Empleado (in Empleado empleado){
        this.dni = empleado.dni;
        this.nombre = empleado.nombre;
        this.AnoNacimiento = empleado.AnoNacimiento;
        this.categoria = empleado.categoria;
    }

    public string GetNombre(){
        return nombre;
    }
    
    public int GetAnoNacimiento(){
        return AnoNacimiento;
    }

    public string GetDni(){
        return dni;
    }

    public void SetCategoria( Categoria categoria){
        this.categoria = categoria;
    }

     public Categoria GetCategoria(){
        return categoria;
     }
    public double Salario(){
        return categoria switch
        {
            Categoria.Subalterno => Empleado.sueldoBase + (Empleado.sueldoBase * (((double)Categoria.Subalterno))/100.0),
            Categoria.Administrativo => Empleado.sueldoBase + (Empleado.sueldoBase * (((double)Categoria.Administrativo))/100.0),
            Categoria.JefeDepartamento => Empleado.sueldoBase + (Empleado.sueldoBase * (((double)Categoria.JefeDepartamento))/100.0),
            Categoria.Gerente => Empleado.sueldoBase + (Empleado.sueldoBase * (((double)Categoria.Gerente))/100.0),
            _ => Empleado.sueldoBase,
        };
    }


    public string Acadena(){
        return "$El empleado " + GetNombre() +" con dni : " + GetDni() + " tiene un salario " + Salario() + " y su categoria es: " + GetCategoria();
     
    }

}

public enum Categoria{
    Subalterno = 10, 
    Administrativo = 20, 
    JefeDepartamento = 40,
    Gerente = 60

}