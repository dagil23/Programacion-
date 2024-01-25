// Crea un programa que permita guardar información sobre las características gráficas de un equipo informático. La información relevante es:

// Número de pulgadas (short)
// Controlador gráfico (string)
// Número de colores (short)
// Pixeles eje x (int)
// Pixeles eje y (int)
// Debe ser posible cambiar el número de colores, la resolución de la pantalla y el controlador en cualquier momento, así como consultar toda la información concerniente a las características gráficas. Crea alguna instancia de pantalla y prueba el funcionamiento.

// 📌 Nota: todos los campos serán privados, y deberemos crear solo los métodos y accesores o modificadores necesarios para poder hacer funcional la aplicación.
class Pantalla
{
    private short numero_pulgadas;
    private string Controlador_grafico;
    private int Numero_colores;
    private int Pixeles_x;
    private int Pixeles_y;

    public short GetNumeroPulgadas()
    {
        return numero_pulgadas;

    }
    public void SetControladorGrafico(string value)
    {
        Controlador_grafico = value;
    }

    public void SetNumeroColores(int value)
    {
        Numero_colores = value;
    }
    public void SetPixelsX(int value)
    {
        Pixeles_x = value;
    }
    public void SetPixelsY(int value)
    {
        Pixeles_y = value;
    }
    public int SetPixelsX()
    {
        return Pixeles_x;
    }
    public string Acadena(){
        return "El numero de pulgadas es" + numero_pulgadas + "tiene un controlador grafico " + Controlador_grafico + "Y un numero de colores " + Numero_colores + " y unos pixeles de " + Pixeles_x +"x "+ Pixeles_y + "y";
        
    }
    public Pantalla(in short numero_pulgadas, in string Controlador_grafico, in short Numero_colores, in int Pixeles_x, in int Pixeles_y)
    {
       this.numero_pulgadas = numero_pulgadas;
       this.Controlador_grafico = Controlador_grafico;
       this.Numero_colores = Numero_colores;
       this.Pixeles_x = Pixeles_x;
       this.Pixeles_y = Pixeles_y;

    }

}