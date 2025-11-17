using BasicProgramming;

public class Manager<TId> : Employee<TId>
{
    public int Allowance { get; set; }

    public Manager(TId id) : base(id) //override
    {

    }

    public override void Introduction()
    {
        base.Introduction(); //base menjalankan method/behaviour dari parent class
        Console.WriteLine("ALLOWANCE : " + Allowance);
    }
}