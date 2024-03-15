// Nuestro DABRadioCD implementa el interfaz IMedia con la funcionalidad:
// Para los métodos de IMedia, llamará a los respectivos del dispositivo activo en ese momento.

// MessageToDisplay: Devolverá una cadena con el dispositivo activo, el estado devuelto por el correspondiente método del dispositivo activo y el menú de opciones para manejar nuestro DABRadioCD.
// MODO: CD
// STATE: PLAYING... Album: Thriller Artist: Michael Jackson. Track 1 - Wanna Be Startin' Somethin
// [1]Play [2]Pause [3]Stop [4]Prev [5]Next [6]Switch [7]Insert CD [8]Extract CD, [ESC]Turn off
// Insertar un CD: Devolverá una excepción si ya hay un CD dentro del reproductor. Si no lo hay, pasaremos a modo CD y empezará la reproducción automáticamente.
// Extraer un CD: Retirará el CD del reproductor y pasará a modo DAB.
// Intercambiar modo: Pasará de CD a DAB o viceversa. Teniendo en cuenta que si pasamos a CD este empezará a reproducir donde se quedó.

using System.Data;

public class DABRadioCD : IMedia
{
    //Propiedades
    IMedia ActiveDevice { get; set; }
    private CDPlayer ReproductorCD { get; set; }
    private DABRadio ReproductorRadio { get; set; }
    private Disc CompatDisc { get; set; }
    public string MessageToDisplay { get; set; }

    //Constructores
    public DABRadioCD()
    {
        ActiveDevice = ReproductorRadio;
        ReproductorCD = new CDPlayer();
        ReproductorRadio = new DABRadio();
        MessageToDisplay = "[1]Play\n[2]Pause\n[3]Stop\n[4]Prev\n[5]Next\n[6]Switch\n[7]Insert CD\n[8]Extract CD\n[ESC]Turn off";

    }

    //Metodos de la Interfaz IMedia
    public void Next()
    {
        ActiveDevice.Next();
    }

    public void Pause()
    {
        ActiveDevice.Pause();

    }

    public void Play()
    {
        ActiveDevice.Play();

    }

    public void Previous()
    {
        ActiveDevice.Previous();

    }

    public void Stop()
    {
        ActiveDevice.Stop();

    }

    public void InsertCD(Disc media)
    {
        if (CompatDisc != null)
        {
            throw new Exception("Ya hay un dico Insertado");
        }
        CompatDisc = media;
    }

    //Metodos de mi clase
    public void ExtractMedia()
    {
        if (CompatDisc != null)
        {
            ActiveDevice = ReproductorRadio;
        }
    }

    public void SwitchMode()
    {
        //  Intercambiar modo: Pasará de CD a DAB o viceversa. Teniendo en cuenta que si pasamos a CD este empezará a reproducir donde se quedó.
        if (ActiveDevice == ReproductorCD)
        {
            ActiveDevice = ReproductorRadio;
            MessageToDisplay = $"Modo {ReproductorRadio.ToString()}";
        }
        else if (ActiveDevice == ReproductorRadio)
        {
            ActiveDevice = ReproductorCD;
            ReproductorCD.Play();
            MessageToDisplay = $"Modo {ReproductorCD.ToString()}";

        }
    }
}