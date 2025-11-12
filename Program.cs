namespace DockerTehtava;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hei, mikä on nimesi?");
        string? nimi = Console.ReadLine();
        Console.WriteLine($"Hei {nimi}, tervetuloa Dockerin maailmaan!");
    }
}
