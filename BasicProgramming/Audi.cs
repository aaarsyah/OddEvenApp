namespace BasicProgramming;

public class Audi : Car, IMachine
{
    public override void OpenDoor()
    {
        Console.WriteLine("Audi Door Opened");
    }

    public override void OpenWindow()
    {
        Console.WriteLine("Audi Window Opened");
    }

    public void Move()
    {
        Console.WriteLine("Audi is Moving");
    }

    public void Break()
    {
        Console.WriteLine("Audi is Breaking");
    }

    // public void Break()
    // {
    //     throw new NotImplementedException();
    // }

    // public void Move()
    // {
    //     throw new NotImplementedException();
    // }

    // public override void OpenDoor()
    // {
    //     throw new NotImplementedException();
    // }

    // public override void OpenWindow()
    // {
    //     throw new NotImplementedException();
    // }
}