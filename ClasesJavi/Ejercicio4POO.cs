// Crea un proyecto con los TAD necesarios para que el siguiente código perteneciente a la Main, pueda ser ejecutado sin problemas:
// Compas compas = new Compas();
// Circulo circulo = compas.DibujaCirculo(3.5f);
// Rotulador rotulador = Estuche.GetRotuladores()
//                       [
//                           new Random().Next(0, Estuche.NUMERO_ROTULADORES)
//                       ];
// rotulador.Rotula(circulo.Perimetro());
// Pincel pincel = new Pincel();
// pincel.SetColor(Color.Verde);
// pincel.Pinta(circulo.Area());   
// 💡 Pistas:
// El circulo tendrá un atributo radio.
// El rotulador tendrá un atributo color de tipo enumerado y solo rotula perímetros.
// Habrá una clase estática Estuche con un solo método también estático que devolverá un array de rotuladores con colores creados de forma aleatoria.
// El pincel también tiene un atributo color y solo pinta áreas.
// La salida por pantalla del programa podría ser algo como lo siguiente:
// Dibujado un círculo de radio 3,5 
// Rotulado el perímetro de 21,99 cm de color Azul.
// Pintada el area de  38,48 cm de color Verde.

// Creo las clases independientes que son Circulo, compas y pincel

class Compas {
    public Circulo DibujaCirculo(float radio) {
        Console.WriteLine($"Dibujado un circulo de radio {radio} cm");
        return new Circulo(radio);
    }
}

class Circulo {
    private float radio;

    public Circulo(in float radio) {
        this.radio = radio;
    }

    public float Perimetro() {
        return (float)Math.PI * radio * 2;
    }

    public float Area() {
        return (float)Math.PI*radio*radio;
    }
}

class Estuche {
    public static int NUMERO_ROTULADORES = 200;
    private static Rotulador[] rotuladores = new Rotulador[NUMERO_ROTULADORES];
    private static bool isFirstTime = true;
    public static Rotulador[] GetRotuladores() {
        if (isFirstTime) {
            for(int i = 0; i < NUMERO_ROTULADORES; i++) {
                rotuladores[i] = new Rotulador((Colores)new Random().Next(0,4));
            }
            isFirstTime = false;
        }

        return rotuladores;
    }
}

class Rotulador {
    private Colores color;

    public Rotulador(Colores color) {
        this.color = color;
    }

    public void Rotula(float perimetro) {
        Console.WriteLine($"Rotulado el perimetro de {perimetro} cm de color {color}");
    }
}

class Pincel {
    private Colores color;

    public Pincel() {

    }

    public void SetColor(Colores color) {
        this.color = color;
    }

    public void Pinta(float area) {
        Console.WriteLine($"Pintada el area de {area} cm de color {color}");
    }
}

public enum Colores
{
    Azul,
    Verde,
    Rojo,
    Marron
};