using System.Reflection;

namespace BasicProgramming;

class Program
{
    //method main
    static void Main(string[] args)
    {
        Employee<int> ahmad = new Employee<int>(2001); //object
        var imam = new Employee<string>("X3001"); //object
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

        numbers.Add(6);
        numbers.Add(7);

        foreach (var i in numbers)
        {
            Console.WriteLine("Number: " + i);
        }

        List<Employee<int>> employee = new List<Employee<int>>();

        //tipe datanya harus sama dengan generic di deklarasi list
        employee.Add(new Employee<int>(2001)
        {
            FullName = "Susilo Bambang",
            Salary = 4700000f,
            Job = "Teknisi"
        });

        employee.Add(new Employee<int>(2002)
        {
            FullName = "Budi Santoso",
            Salary = 4500000f,
            Job = "Staff HRD"
        });

        // employee.Add(new Employee<int>(2003, "Theo", "Gamedev", 20f));

        foreach (var i in employee)
        {
            i.Introduction();
        }


        //isi data
        // ahmad.Id = 101;
        ahmad.FullName = "Ahmad Sulaiman";
        ahmad.Salary = 5000000f;
        // ahmad.salary = 5000000f;
        ahmad.Job = "Staff IT";

        // imam.Id = 102;
        imam.FullName = "Imam Suprayogi";
        imam.Salary = 6000000f;
        // imam.salary = 6000000f;
        imam.Job = "Manager IT";

        //memanggil method introduction
        imam.Introduction();
        ahmad.Introduction();

        imam.CalculateTax();
        ahmad.CalculateTax();

        var joko = new Manager<int>(30001);
        // joko.Id = 103;
        joko.FullName = "Joko Susilo";
        joko.Salary = 8000000f;
        joko.Introduction();
        joko.Job = "Technical Manager";
        joko.Allowance = 2000000;

        var a8 = new Audi();
        a8.TopSpeed = 280;
        a8.MaxGear = 7;
        a8.IsManual = false;

        //abstract
        Console.WriteLine("=================");
        a8.OpenDoor();
        a8.OpenWindow();
        a8.Move();
        a8.Break();

        //interfacex
        var lambo = new Lamborgini();
        Console.WriteLine("=================");
        lambo.OpenDoor();
        lambo.OpenWindow();
        lambo.Move();
        lambo.Break();


    }
}