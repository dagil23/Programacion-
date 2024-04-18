public interface IMedia :IMessageToDisplay
{
    string Name { get; }
    void Play();
    void Stop();
    void Pause();
    void Next();
    void Previous();
}