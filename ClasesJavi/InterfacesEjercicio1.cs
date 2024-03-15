// A partir del siguiente UML crea las clases e Interfaces necesarias para implementar un editor de figuras geométricas. Crea además, un programa principal que te permita probarlo correctamente.
public interface IFigura
{

    void Dibuja();
    float Area();
    float Perimetro();

}

public class Circulo : IFigura
{

    private float radio;

    public Circulo(float radio){
        this.radio = radio;
    }
    public void Dibuja()
    {
        Console.WriteLine("Dibujando un circulo de mierda");
    }
    public float Area()
    {
        return (float)Math.PI*radio*radio;
    }
    public float Perimetro()
    {
        return 2*(float)Math.PI*radio;
    }
}
public class Rectangulo : IFigura
{

    private float @base;
    private float altura;

    public Rectangulo(float @base, float altura){

        this.@base = @base;
        this.altura = altura;
    }
    public void Dibuja()
    {
        Console.WriteLine("Dibujando un rectangulo de mierda");
    }
    public float Area()
    {
        return @base * altura;
    }
    public float Perimetro()
    {
        return altura*2 + @base*2;
    }
}
public class Cuadrado : IFigura
{
    private float lado;

    public Cuadrado(float lado){
        this.lado = lado;
    }

    public void Dibuja()
    {
        Console.WriteLine("Dibujando un cuadrado");
    }
    public float Area()
    {
        return lado * lado;
    }
    public float Perimetro()
    {
        return lado * 4;
    }
}


// public class Program
// {
//     static void Main()
//     {

//         //Solucion Dani
//         Circulo figura1 = new Circulo(3);
//         Cuadrado figura2 = new Cuadrado(4);
//         Rectangulo figura3 = new Rectangulo(70,7);

//        Console.WriteLine(figura1.Area());
//        Console.WriteLine(figura1.Perimetro());
//        figura1.Dibuja();

       
//        Console.WriteLine(figura2.Area());
//        Console.WriteLine(figura2.Perimetro());
//        figura2.Dibuja();

//         Console.WriteLine(figura3.Area());
//        Console.WriteLine(figura3.Perimetro());
//        figura3.Dibuja();

//         //Solucion interfaces
//        IFigura[] figuras = new IFigura[]{
//             new Circulo(3),
//             new Cuadrado(4),
//             new Rectangulo(70, 7),
//             new Circulo(5), 
//             new Cuadrado(7), 
//             new Rectangulo(1,1)
//         };

//        foreach (IFigura figura in figuras) {
//             figura.Dibuja();
//             Console.WriteLine(figura.Area());
//             Console.WriteLine(figura.Perimetro());
//        }
//     }
// }