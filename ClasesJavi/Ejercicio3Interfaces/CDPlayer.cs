    // El reproductor de CD implementa la interfaz IMedia con la funcionalidad:

    // MessageToDisplay: Propiedad que devuelve un mensaje para el Display del DABRadioCD con el estado del reproductor. Devolviendo NO DISC si no hay un disco en su interior. Además, en este caso el resto de opciones de reproducción deberían devolver el mismo mensaje, no teniendo efecto.
    // Play: Que reproducirá el disco desde la pista 1, si el reproductor está parado o desde la pista correspondiente si está pausado. Devolviendo en MessageToDisplay el estado, la información del CD y la pista que está sonando ...
    // PLAYING... Album: Thriller Artist: Michael Jackson Track 1 - Wanna Be Startin' Somethin

    // Stop: Parará la reproducción. Devolviendo MessageToDisplay...
    // STOPPED... Album: Thriller Artist: Michael Jackson
    // Pause: Pausará la reproducción si está sonando y la reanudará si está pausada. Si pasa a pausado, MessageToDisplay devolverá…
    // PAUSED... Album: Thriller Artist: Michael Jackson. Track 1 - Wanna Be Startin' Somethin
    // Next/Previous: Si esta sonando, buscará la anterior o siguiente pista a reproducir de forma cíclica. Esto es, si llega al final irá al principio y viceversa. Además, si está pausado empezará a reproducir la nueva pista.

class CDPlayer : IMedia
{
    //Propiedades
    private ushort track;
    private Disc? disco;
    private MediaState state;
    private string messageToDisplay;

    //Getters & Setters
    public ushort Track
    {
        get
        {
            return track;
        }
        set
        {
            track = value;
        }
    }
    public Disc? Disco
    {
        get => disco;
        set => disco = value;
    }

    public MediaState State
    {
        get => state;
        set => state = value;
    }

    public string MessageToDisplay
    {
        get
        {
            if (Disco == null)
            {
                return "NO DISC";
            }

            return messageToDisplay;
        }
    }

    public string Name => "CDPlayer";

    //Constructores
    public CDPlayer()
    {
        Disco = null;
        State = MediaState.Stopped;
        messageToDisplay = "";
    }

    public void InsertMedia(Disc media)
    {
        Disco = media;
        Track = 0;
    }

    public bool extractMedia()
    {
        if (Disco == null)
        {
            return false;
        }

        Disco = null;
        return true;
    }

    public void Next()
    {
        
            //Avanzar a la canción anterior.
            if (IsDiskInserted())
            {
                int cantidadCanciones = Disco.Songs.Length;
                //Por que todos los metodos empiezan en playing de la interfaz empiezan en playing?

                int nextTrack = Track + 1;

                if (nextTrack > cantidadCanciones-1)
                {
                    Track = 0;
                } else {
                    Track = (ushort)nextTrack;
                }

                Play();
            }
        
    }

    public void Pause()
    {
        if (IsDiskInserted())
        {
            if (State == MediaState.Playing)
            {
                State = MediaState.Paused;
            }
            else if (State == MediaState.Paused)
            {
                State = MediaState.Playing;
            }

            messageToDisplay = $"PAUSED... {Disco?.ToString()} - {Disco?.NombreCancion(Track)}";
        }
    }

    public void Play()
    {
        if (IsDiskInserted())
        {
            if (state == MediaState.Stopped)
            {
                //Reproducir desde la pista 1
                Track = 0;
            }

            //Devolviendo en MessageToDisplay el estado, la información del CD y la pista que está sonando
            //PLAYING... Album: Thriller Artist: Michael Jackson Track 1 - Wanna Be Startin' Somethin
            State = MediaState.Playing;
            messageToDisplay = $"PLAYING... {Disco?.ToString()} - {Disco?.NombreCancion(Track)}";
        }

    }

    public void Previous()
    {
            //Avanzar a la canción anterior.
            if (IsDiskInserted())
            {
                int cantidadCanciones = Disco.Songs.Length;

                int nextTrack = Track - 1;

                if (nextTrack < 0)
                {
                    Track = (ushort)(cantidadCanciones-1);
                } else {
                    Track = (ushort)nextTrack;
                }

                Play();
            }
    }

    public void Stop()
    {
        if (IsDiskInserted())
        {
            State = MediaState.Stopped;

            //STOPPED... Album: Thriller Artist: Michael Jackson
            messageToDisplay = $"STOPPED... {Disco?.ToString()}";
        }
    }

    private bool IsDiskInserted()
    {
        return Disco != null;
    }
}