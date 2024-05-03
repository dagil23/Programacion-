// Crea un tipo delegado denominado Infinitivo para métodos que no reciban, ni devuelvan nada. Define ahora los métodos Ser, Correr, Ver, Pensar, Comer los cuales mostrarán por consola los infinitivos en inglés de dichos verbos.

// Crea un programa principal donde se instancie un objeto del delegado definido y …

// Le asociemos con el operador += los métodos Ser, Correr y Ver y realicemos una llamada al delegado, para que se llamen los tres métodos de forma consecutiva.
// Desasocia ahora con el operador -= los métodos Ser y Ver y asocia Pensar y Comer y vuelva a hacer una llamada.
class Delegados_Ejercicicio1
{
    public delegate void Infinitivo();
    public static void Ser() { Console.WriteLine("To be"); }
    public static void Correr() { Console.WriteLine("Run"); }
    public static void Ver() { Console.WriteLine("See"); }
    public static void Pensar() { Console.WriteLine("Think"); }
    public static void Comer() { Console.WriteLine("Eat"); }




    // static void Main(string[] args)
    // {
        
    //     Infinitivo verbos = Ser;
    //     verbos += Correr; verbos += Ver;
    //     verbos();
    //     verbos -= Ser; 
    //     verbos -= Ver; 
    //     verbos += Pensar;
    //      verbos += Comer;
    //     verbos();
           
    // }
}