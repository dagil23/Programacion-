using System.Text;

public class Euro
{
    private double valor;

    public Euro(double valor){
        Valor = valor;
    }
    public double Valor{
        get=> valor;
        set=> valor = value;
    }
    public override string ToString()
    {
        return $"{Valor}€";
    }

    //Operadores binarios aritméticos:
    //Suma
    public static Euro operator +(Euro e1, Euro e2) {
        return new Euro(e1.valor + e2.valor);
    }

    public static Euro operator +(Euro e1, Pesetas p1) {
        return new Euro(e1.valor + (p1.Valor/166.386));
    }

    //Resta
    public static Euro operator -(Euro e1, Euro e2) {
        return new Euro(e1.valor - e2.valor);
    }

    public static Euro operator -(Euro e1, Pesetas p1) {
        return new Euro(e1.valor - (p1.Valor/166.386));
    }

    //Operadores binarios comparacion

    //Redefiniciones necesarias primero
    public override int GetHashCode()
    {
        return $"{valor:F2}".GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        Euro euro = obj as Euro;
        return base.Equals(valor == euro.valor);
    }

    public static bool operator ==(Euro e1, Euro e2) => e1.Equals(e2);
    public static bool operator !=(Euro e1, Euro e2) => !e1.Equals(e2);

    //Operadores ++ y --
    //e++
    public static Euro operator ++(Euro e) => new Euro(e.Valor + 1.0);
    //e--
    public static Euro operator --(Euro e) => new Euro(e.Valor - 1.0);

    //Casting implicito
    public static implicit operator double(Euro e) => Convert.ToDouble(e.Valor);
    public static implicit operator Pesetas(Euro e) => new Pesetas(e.valor*166.386);
}
public class Pesetas{
    private double valor;
    
    public Pesetas(double valor){
        Valor = valor;
    }
    public double Valor{
        get=> valor;
        set=> valor = value;
    }
     public override string ToString()
    {
        return $"{Valor}ptas.";
    }
    //Operadores binarios aritméticos:
    //Suma
    public static Pesetas operator +(Pesetas e1, Pesetas e2) {
        return new Pesetas(e1.valor + e2.valor);
    }

    public static Pesetas operator +(Pesetas p1, Euro e1) {
        return new Pesetas((e1.Valor*166.386) + p1.Valor);
    }

    //Resta
        public static Pesetas operator -(Pesetas p1, Pesetas p2) {
        return new Pesetas(p1.valor - p2.valor);
    }

    public static Pesetas operator -(Pesetas p1, Euro e1) {
        Pesetas p2 = e1;
        return new Pesetas(p1.valor - p2.valor);
    }

    //Operadores binarios comparacion

    //Redefiniciones necesarias primero
    public override int GetHashCode()
    {
        return $"{valor:F2}".GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        Pesetas pesetas = obj as Pesetas;
        return base.Equals(valor == pesetas.valor);
    }

    public static bool operator ==(Pesetas p1, Pesetas p2) => p1.Equals(p2);
    public static bool operator !=(Pesetas p1, Pesetas p2) => !p1.Equals(p2);

    //Operadores ++ y --
    //e++
    public static Pesetas operator ++(Pesetas p) => new Pesetas(p.Valor + 1.0);
    //e--
    public static Pesetas operator --(Pesetas p) => new Pesetas(p.Valor - 1.0);
    
    //Casting implicito
    public static implicit operator double(Pesetas p) => Convert.ToDouble(p.Valor);
    public static implicit operator Euro(Pesetas p) => new Euro(p.valor/166.386);
}


// public class Program
// {
//     static void Main(){
//         Euro e1 = new Euro(1.67);
//         Euro e2 = new Euro(3.0);
//         Euro e3 = e1 + e2;
//         Euro e4 = e2 - e1;
//         Pesetas p1 = new Pesetas(1.67);
//         Euro e5 = e1 + p1;
//         Pesetas p2 = p1 + p1;
//         Pesetas p3 = p1 + e1;
//         double d1 = e1;
//         Pesetas pesetas = e1;
//     }
// }