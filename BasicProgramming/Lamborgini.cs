namespace BasicProgramming;

public class Lamborgini : Car, IMachine
{
    public override void OpenDoor()
    {
        Console.WriteLine("Pintu Lamborgini Terbuka");
    }

    public override void OpenWindow()
    {
        Console.WriteLine("Jendela Lamborgini Terbuka");
    }

    public void Move()
    {
        Console.WriteLine("Lamborgini is Moving");
    }

    public void Break()
    {
        Console.WriteLine("Lamborgini is Breaking");
    }
}