// El sintonizador de DAB implementa el interfaz IMedia con la funcionalidad, empezará parada.

// MessageToDisplay: Propiedad que devuelve un mensaje para el Display del DABRadioCD con el estado de la radio.

// Play: Que sintonizará la primera frecuencia de la banda de FM (MIN_FREQUENCY) si estaba apagada (OFF) o continuará con el streaming almacenado en el buffer si estaba pausada. Devolviendo MessageToDisplay…
// HEARING... FM – 87,5 MHz

// Stop: Parará el streamig. Devolviendo MessageToDisplay… RADIO OFF

// Pause: Pausará la reproducción si está sonando la radio y la reanudará si está pausada. Si pasa a pausado se almacenará todo el streaming en un buffer para poder reanudar la emisión donde se quedó y MessageToDisplay devolverá…
// PAUSED - BUFFERING... FM – 87,5 MHz

// Next/Previous: Si esta sonando moverá el dial a la anterior o siguiente frecuencia, con saltos de 0,5 MHz cada vez que se pulse. Si llega al final de la banda (MAX_FREQUENCY) irá al principio de la misma y viceversa. Además, si está pausada empezará a reproducir desde la nueva frecuencia.

public class DABRadio : IMedia
{

    private const float SEEK_STEEP = 0.5F;
    private const float MAX_FREQUENCY = 108F;
    private const float MIN_FRECUENCY = 87.5F;
    public string MessageToDisplay{get;set;}
    private float Frecuency;

    private MediaState State{get;set;}

    public DABRadio(){
        Frecuency = MIN_FRECUENCY;
        State = MediaState.Stopped;
        MessageToDisplay = "Modo Radio";
    }

    public void Next()
    {
        Frecuency += SEEK_STEEP;
        
        if (Frecuency >= MAX_FREQUENCY) {
                Frecuency = MIN_FRECUENCY;
        }

        if (State == MediaState.Stopped || State == MediaState.Paused) {
            Play();
        }
    }

    public void Pause()
    {
      if (State == MediaState.Playing)
      {
        State = MediaState.Paused;
        MessageToDisplay = $"PAUSED - BUFFERING... FM - {Frecuency} MHz";
      }else if(State == MediaState.Paused)
      {
        Play();
      }
     
    }

    public void Play()
    {
        if (State == MediaState.Stopped  )
        {
            Frecuency = MIN_FRECUENCY;
        } 
        State = MediaState.Playing;
        MessageToDisplay = $"HEARING... FM-{Frecuency}Mhz";
        

    }

    public void Previous()
    {
        Frecuency -= SEEK_STEEP;
        
        if (Frecuency >= MIN_FRECUENCY) {
                Frecuency = MAX_FREQUENCY;
        }

        if (State == MediaState.Stopped || State == MediaState.Paused) {
            Play();
        } 
    }

    public void Stop()
    {
       State = MediaState.Stopped;
       MessageToDisplay = "RADIO OFF";
    }
}