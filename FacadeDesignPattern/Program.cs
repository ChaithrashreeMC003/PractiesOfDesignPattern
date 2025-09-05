class Program
{
    static void Main(string[] args)
    {
        // Subsystems
        DVDPlayer dvd = new DVDPlayer();
        Projector projector = new Projector();
        SoundSystem sound = new SoundSystem();

        // Facade
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(dvd, projector, sound);

        // Client uses only the Facade (simple interface)
        homeTheater.WatchMovie("Inception");
        homeTheater.EndMovie();

        Console.ReadLine();
    }
}
