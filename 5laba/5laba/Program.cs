using System;
namespace laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sw = 0;
            while (sw != 5)
            {
                Console.WriteLine("1 - Programmmer\n2 - Economist\n3 - Lawyer\n4 - Doctor\n5 - Exit");
                try
                {
                    sw = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                }
                switch (sw)
                {
                    case 1:
                        Programmer programmer = new Programmer("BSUIR", "KSIS", "Minsk",  "Yulia", "Shebeko", 18);
                        Console.WriteLine(programmer);
                        break;
                    case 2:
                        Economist economist = new Economist("BSU", "Economy", "Minsk", "Yana", "Shebeko", 17);
                        Console.WriteLine(economist);
                        break;
                    case 3:
                        Lawyer lawyer = new Lawyer("BSU", "International right", "Minsk", "Anastasia", "Shurova", 18);
                        Console.WriteLine(lawyer);
                        break;
                    case 4:
                        Doctor doctor = new Doctor("GSMU", "Pediatrics", "Molodechno", "Anastasia", "Savenok", 18);
                        Console.WriteLine(doctor);
                        break;
                    case 5:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
