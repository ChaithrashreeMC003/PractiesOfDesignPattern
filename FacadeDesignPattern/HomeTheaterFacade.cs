public class HomeTheaterFacade
{
    private DVDPlayer dvd;
    private Projector projector;
    private SoundSystem sound;

    public HomeTheaterFacade(DVDPlayer dvd, Projector projector, SoundSystem sound)
    {
        this.dvd = dvd;
        this.projector = projector;
        this.sound = sound;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("\n--- Get ready to watch a movie ---");
        projector.On();
        sound.On();
        sound.SetVolume(10);
        dvd.On();
        dvd.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("\n--- Shutting movie theater down ---");
        dvd.Off();
        sound.Off();
        projector.Off();
    }
}
