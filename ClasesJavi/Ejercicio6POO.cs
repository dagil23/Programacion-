// A partir del primer ejercicio y teniendo en cuenta la relación entre las clases, crea las clase Empresa.

// 📌 Nota: El método DatosEmpresa de Empresa devolverá la información de la empresa sin los empleados, mientras que ACadena incluirá los empleados.

public class Empresa{
    private readonly string  cif;
    private readonly string razonSocial;
    private string direccion;

    public Empresa(in string cif,in string razonSocial,in string direccion){

        this.cif = cif;
        this.razonSocial = razonSocial;
        this.direccion = direccion;

    }

    public Empresa(in Empresa empresa){

    }

    private  string SetNombreGerente(string gerente){
        return gerente;
    }

    public string GetrazonSocial(string razonSocial){
        return razonSocial;
    }

    public string GetDireccion(string direccion){
        return direccion;
    }

    public string GetCif(string Cif){
        return Cif;
    }

    public void AñadeGerente(in string dni, in string nombre, in int AnoNacimiento){
        
    }

    public void SetDireccion(in string direccion){
        
    }

    public void DatosEmpresa(){
        Console.WriteLine($"La empresa {cif}");
        Console.WriteLine($"{razonSocial} con direccion en {direccion}");
    }
}