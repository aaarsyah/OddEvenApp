namespace OddEvenApp;

class Program
{
    /*
     * Menampilkan Menu
     */
    static void Menu()
    {

        Console.WriteLine();
        Console.WriteLine("============================================");
        Console.WriteLine("               MENU GANJIL GENAP");
        Console.WriteLine("============================================");
        Console.WriteLine("1. Cek Ganjil Genap");
        Console.WriteLine("2. Print Ganjil/Genap (dengan limit)");
        Console.WriteLine("3. Exit");
    }


    /*
     * ex: PrintEvenOdd(5, "Genap"') ;
     * output 1, 3, 5
     * x: PrintEvenOdd(5, "Ganjil");
     * output 2, 4
     * @PARAM Limit: Batas akhir. minimal 1, tidak boleh O atau negatif.
     * @PARAM choice: Pilihan, hanya boleh "Even" atau "Odd". Selain itu invalid
     */

    static bool IsNotBelowThanOne(int limit)
    {
        return limit < 1;
    }

    static bool IsChoiceNotEvenOrOdd(string choice)
    {
        return choice != "Genap" && choice != "genap" && choice != "Ganjil" && choice != "ganjil";
    }
    static void PrintEvenOdd(int limit, string choice)
    {
        if (IsNotBelowThanOne(limit))
        {
            Console.WriteLine("Input limit tidak valid!");
            return;
        }

        if (IsChoiceNotEvenOrOdd(choice))
        {
            Console.WriteLine("Input pilihan tidak valid!");
            return;
        }

        int modularResult = 1;
        if (choice == "Genap" || choice == "genap")
        {
            modularResult = 0;
        }

        Console.Write($"Print Bilangan 1 - {limit}: ");
        for (int i = 1; i <= limit; i++)
        {
            if (i % 2 != modularResult)
            {
                continue;
            }

            if (i == limit || i == limit - 1)
            {
                Console.Write(i);
            }
            else
            {
                Console.Write(i + ",");
            }
        }
    }



    /*
     * ex: EvenOddCheck(5);
     * output "Even"
     * @PARAM input: Angka yang akan dicek. minimal 1, tidak boleh O atau negatif.
     * @RETURN "Genap" jika input genap, "Ganil". jika input ganjil, selain itu Invalid Input!! jika input tidak sesuai pada @PARAM input
     */
    static string CheckEvenOrOdd(int input)
    {
        if (input < 1)
        {
            Console.WriteLine("Invalid Input!!");
        }
        else if (input % 2 == 0)
        {
            Console.WriteLine("Bilangan genap");
        }
        else if (input % 2 != 0)
        {
            Console.WriteLine("Bilangan ganjil");
        }

        return "Invalid";
    }

    static void Main(string[] args)
    {
        int menu;

        while (true)
        {
            Menu();
            Console.Write("Pilihan : ");
            menu = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (menu)
                {
                    case 1:
                        Console.Write("Masukkan bilangan yang ingin dicek: ");
                        int angka = Convert.ToInt32(Console.ReadLine());
                        CheckEvenOrOdd(angka);

                        break;
                    case 2:
                        Console.Write("Pilih Ganjil/Genap: ");
                        string choice = Console.ReadLine();


                        Console.Write("Masukkan Limit: ");
                        int limit = Convert.ToInt32(Console.ReadLine());

                        PrintEvenOdd(limit, choice);
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        return;
                }
            }
            catch
            {
                Console.WriteLine("INVALID!!");
            }
        }
    }
}
