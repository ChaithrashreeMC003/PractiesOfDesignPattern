public class DVDPlayer
{
    public void On() => Console.WriteLine("DVD Player On");
    public void Play(string movie) => Console.WriteLine($"Playing movie: {movie}");
    public void Off() => Console.WriteLine("DVD Player Off");
}
