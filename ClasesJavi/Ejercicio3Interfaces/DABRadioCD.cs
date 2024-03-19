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
    IMedia? ActiveDevice { get; set; }
    private CDPlayer ReproductorCD { get; set; }
    private DABRadio ReproductorRadio { get; set; }
    private Disc? CompatDisc { get; set; }
    private bool isRadioActive = true;
    public bool IsRadioActive {
        get {
            return isRadioActive;
        } 
        set {
            isRadioActive = value;
            
            if (isRadioActive) {
                MessageToDisplay = "MODO: Radio\n";
                MessageToDisplay += $"STATE: {ReproductorRadio.MessageToDisplay}\n";
            } else {
                MessageToDisplay = "MODO: CD\n";
                MessageToDisplay += $"STATE: {ReproductorCD.MessageToDisplay}\n";
            }
            
            MessageToDisplay += "[1]Play [2]Pause [3]Stop [4]Prev [5]Next [6]Switch [7]Insert CD [8]Extract CD, [ESC]Turn off";
        }
    }

    public string MessageToDisplay { get; set; }

    //Constructores
    public DABRadioCD()
    {
        ReproductorCD = new CDPlayer();
        ReproductorRadio = new DABRadio();
        ActiveDevice = ReproductorRadio;
        MessageToDisplay = "";
        updateMediaState();
    }

    private void updateMediaState() {
        if (ActiveDevice == ReproductorRadio) {
            IsRadioActive = true;
        } else {
            IsRadioActive = false;
        }
    }

    //Metodos de la Interfaz IMedia
    public void Next()
    {
        ActiveDevice?.Next();
        updateMediaState();
    }

    public void Pause()
    {
        ActiveDevice?.Pause();
        updateMediaState();
    }

    public void Play()
    {
        ActiveDevice?.Play();
        updateMediaState();
    }

    public void Previous()
    {
        ActiveDevice?.Previous();
        updateMediaState();
    }

    public void Stop()
    {
        ActiveDevice?.Stop();
        updateMediaState();
    }

    public void InsertCD(Disc media)
    {
        if (CompatDisc != null)
        {
            throw new Exception("Ya hay un dico Insertado");
        }
        ActiveDevice = ReproductorCD;
        CompatDisc = media;
        ReproductorCD.InsertMedia(CompatDisc);
        ActiveDevice.Play();
        updateMediaState();
    }

    //Metodos de mi clase
    public void ExtractMedia()
    {
        CompatDisc = null;
        ActiveDevice = ReproductorRadio;
        ReproductorCD.extractMedia();
        updateMediaState();
    }

    public void SwitchMode()
    {
        //  Intercambiar modo: Pasará de CD a DAB o viceversa. Teniendo en cuenta que si pasamos a CD este empezará a reproducir donde se quedó.
        if (ActiveDevice == ReproductorCD)
        {
            ActiveDevice = ReproductorRadio;
        }
        else if (ActiveDevice == ReproductorRadio)
        {
            ActiveDevice = ReproductorCD;
        }

        ActiveDevice?.Play();
        updateMediaState();
    }
}