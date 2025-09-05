using ImmutableObjectDesignPattern;

class Program
{
    static void Main()
    {
        CountryData cd = new CountryData("INDIA", 121000000000);
        Console.WriteLine($"Name: {cd.Name} Population: {cd.Population}" );
        //cd.Name = "America";
    }
}