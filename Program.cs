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
    static void PrintEvenOdd(int limit, string choice)
    {
        if (limit >= 1)
        {
            if (choice == "Genap" || choice == "genap")
            {
                for (int i = 1; i <= limit; i++)
                {
                    if (i % 2 == 0)
                    {
                        if (i == limit || i == limit - 1)
                        {
                            Console.Write(i);
                        }
                        else
                            Console.Write(i + ",");
                    }

                }
            }
            else if (choice == "Ganjil" || choice == "ganjil")
            {
                for (int i = 1; i <= limit; i++)
                {
                    if (i % 2 != 0)
                    {
                        if (i == limit || i == limit - 1)
                        {
                            Console.Write(i);
                        }
                        else
                            Console.Write(i + ",");
                    }
                }
            }
            else
            {
                Console.WriteLine("Input pilihan tidak valid!");
            }
        }
        else
        {
            Console.WriteLine("Input limit tidak valid!");
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

        do
        {
            Menu();
            Console.Write("Pilihan : ");
            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    try
                    {
                        Console.Write("Masukkan bilangan yang ingin dicek: ");
                        int angka = Convert.ToInt32(Console.ReadLine());
                        CheckEvenOrOdd(angka);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Input tidak valid!");
                    }
                    break;
                case 2:
                    try
                    {
                        Console.Write("Pilih Ganjil/Genap: ");
                        string choice = Console.ReadLine();


                        Console.Write("Masukkan Limit: ");
                        int limit = Convert.ToInt32(Console.ReadLine());

                        PrintEvenOdd(limit, choice);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Input tidak valid!");
                    }
                    break;
                case 3:
                    Console.WriteLine("Exit");
                    break;
            }
        } while (menu != 3);

    }
}
