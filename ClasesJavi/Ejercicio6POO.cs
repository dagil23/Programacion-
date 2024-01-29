// A partir del primer ejercicio y teniendo en cuenta la relación entre las clases, crea las clase Empresa.

// 📌 Nota: El método DatosEmpresa de Empresa devolverá la información de la empresa sin los empleados, mientras que ACadena incluirá los empleados.

public class Empresa{
    private readonly string  cif;
    private readonly string razonSocial;
    private string direccion;
    private Empleado empleado;

    public Empresa( string cif, string razonSocial, string direccion, Empleado empleado){

        this.cif = cif;
        this.razonSocial = razonSocial;
        this.direccion = direccion;
        this.empleado = empleado;

    }

    public Empresa(in Empresa empresa){

    }

    private  string SetNombreGerente(string value){
        gere
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
        Console.WriteLine($"La empresa {cif}");
        Console.WriteLine($"{razonSocial} con direccion en {direccion}");
    }
}
