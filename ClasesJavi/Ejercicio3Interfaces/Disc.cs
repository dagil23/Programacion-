public class Disc{
    //Propiedades
    private string[] songs;
    private string artist;
    private string album;

    //Getters & Setters
    public string[] Songs {
        get => songs;
        private set => songs = value;
    }

    public string Artist {
        get => artist;
        private set => artist = value;
    }

    public string Album {
        get => album;
        private set => album = value;
    }

    public int NumTracks {
        get => Songs.Length;
    }

    //Constructor
    public Disc(string artist, string album, string[] songs) {
        Artist = artist;
        Album = album;
        Songs = songs;
    }

    public override string ToString()
    {
        return $"{Artist} - {Album}";
    }

    public string NombreCancion(int index) {
        return Songs[index];
    }
    public string this[int index]{
        get{
            return songs[index];
        }
        set{
            songs[index] = value;
        }
    }
}