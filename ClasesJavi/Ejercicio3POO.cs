// Crea una clase Humano con los campos, como mínimo: nombre, edad, peso, sexo, inteligencia, fuerza, destreza y energía.
// Los métodos MostrarInformación, SetNombre, SetEdad,...y los constructores que creas necesarios.
using System.Dynamic;

class Humano
{
    private string nombre;
    private int edad;
    private int peso;
    Sexo sexo;
    private string inteligencia;
    private TipoFuerza fuerza;
    private string destreza;
    private string energia;
    public enum Sexo
    {
        Masculino,
        Femenino
    }
    public enum TipoFuerza
    {
        SuperFuerte,
        Debilucho,
        Mamadisimo,
        Desnutrido
    }
    public enum Energia{
        Bueno,
        Malo,
        Intermedio,
        
    }

    public Humano(in string nombre, in int edad, in int peso, in string destreza)
    {
        SetNombre(nombre);
        SetEdad(edad);
        SetPeso(peso);
       SetDestreza(destreza);
    }
    private void SetNombre(string value)
    {
        nombre = value;
    }
    private void SetEdad(int value)
    {
        edad = value;
    }
    private void SetPeso(int value)
    {
        peso = value;

    }
    private void SetDestreza(string value){
        destreza = value;

    }
    public void MostrarInformacionHumano(Humano value)
    {
        Console.WriteLine($" {value.nombre} tiene una edad de {value.edad} y un peso de {value.peso}");
        Console.WriteLine($"Su tipo de fuerza es {value.fuerza} su mayor destreza es {value.destreza} y tiene una energia de {value.energia}");
    }
}