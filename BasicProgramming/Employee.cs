namespace BasicProgramming;

//<T> Placeholder
public class Employee<TId>
{
    public TId Id { get; private set; } //prop
    public string FullName { get; set; }
    private float salary;

    public string Job { get; set; }

    //Polymorphism melalui Constructor Overloading
    public Employee(TId id)
    {
        Id = id;
    }

    public float Salary
    {
        get
        {
            return salary;
        }
        set
        {
            // if (value < 0)
            // {
            //     value = 0;
            // }
            // else //bisa pakai logika
            salary = value; //value default
        }
    }
    public virtual void Introduction()
    {
        Console.WriteLine("=========");
        Console.WriteLine("ID : " + Id);
        Console.WriteLine("NAME : " + FullName);
        Console.WriteLine("SALARY : " + Salary);
        Console.WriteLine("JOB : " + Job);
    }

    public float CalculateTax()
    {
        float tax = 2.5f;
        return salary * tax;
    }
}
