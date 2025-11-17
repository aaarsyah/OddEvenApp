namespace BasicProgramming;

//harus diimplementasikan abstact class 
public abstract class Car
{
    public int MaxGear { get; set; }
    public int TopSpeed { get; set; }
    public bool IsManual { get; set; } //false = automatic

    public abstract void OpenDoor();
    public abstract void OpenWindow();

    public void StartEngine()
    {
        Console.WriteLine("Engine Started");
    }

}