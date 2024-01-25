// Crea una clase Humano con los campos, como mínimo: nombre, edad, peso, sexo, inteligencia, fuerza, destreza y energía.
// Los métodos MostrarInformación, SetNombre, SetEdad,...y los constructores que creas necesarios.
class Humano{
    string nombre;
    int edad;
    int peso;
    Sexo sexo;
    string inteligencia;
   TipoFuerza fuerza;
    string destreza;
    string energia;
    public enum Sexo{
        Masculino,
        Femenino
    }
    public enum TipoFuerza{
        SuperFuerte,
        Debilucho,
        Mamadisimo,
        Desnutrido
    }

    public Humano(in string nombre, in int edad, in int peso, in string destreza, in string energia )
    {
        this.nombre = nombre;
        this.edad = edad;
        this.peso = peso;
        this.destreza = destreza;
        this.energia = energia;
    }
    public void SetNombre(string value){
        nombre = value;
    }
    public void SetEdad(int value){
        edad = value;
    }
    public void MostrarInformacionHumano(Humano value){
        Console.WriteLine($" {value.nombre} tiene una edad de {value.edad} y un peso de {value.peso}");
        Console.WriteLine($"Su tipo de fuerza es {value.fuerza} su mayor destreza es {value.destreza} y tiene una energia de {value.energia}");
    }
}