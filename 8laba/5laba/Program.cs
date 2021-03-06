using System;
namespace laba5
{
    class Program
    {
        delegate int Operation(int x, int y, int z, int d);
        delegate void MessageHandler(string message);
        static void ShowMessage(string mes, MessageHandler handler)
        {
            handler(mes);
        }
        delegate void Message();
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning, choose who you would like to view information about!");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening, choose who you would like to view information about!");
        }
        static void Main(string[] args)
        {
            Message mes;
            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning; 
            }
            else
            {
                mes = GoodEvening;
            }
            mes();
            Operation operation = (x, y, z, d) => x + y + z + d;
            Console.WriteLine($"Number of students in these specialties - {operation(2300, 1700, 381, 4000)}");
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
                        Programmer programmer1 = new Programmer("BSUIR", "KSIS", "Minsk", "Catherine", "Kalinina", 17);
                        programmer1.CloneCreated += (x) => Console.WriteLine("Logged creating new clone of programmer {0}", (x as Human).Name);
                        programmer1.CloneCreated += delegate (object clone)
                        {
                            Console.WriteLine("Condemn creating clones of real people");
                            Console.WriteLine("Press any button to express regret");
                            Console.ReadKey();
                            Console.Write("Ok, clone as human:");
                            (clone as Human).OutInfo();
                        };
                        Console.WriteLine("Number of laboratory works in semester 2 - 22");
                        Console.WriteLine("Average lead time:");
                        programmer.Lab(22);
                        if (programmer.Time == 1)
                        {
                            Console.WriteLine(programmer.Time+ " hour");
                        }
                        else if (programmer.Time <= 23 && programmer.Time == 1)
                        {
                            Console.WriteLine(programmer.Time + " hours");
                        }
                        else if (programmer.Time >= 24)
                        {
                            int d,h;
                            h = programmer.Time % 24;
                            d = programmer.Time / 24;
                            if (d>1 && h==0)
                            {
                                Console.WriteLine(d + " days");
                            }
                            else if (d == 1 && h == 0)
                            {
                                Console.WriteLine(d + " day");
                            }
                            else if (d == 1 && h == 1)
                            {
                                Console.WriteLine(d + " day " + h + " hour");
                            }
                            else if (d == 1 && h > 1)
                            {
                                Console.WriteLine(d + " day " + h + " hours");
                            }
                            else if (d > 1 && h == 1)
                            {
                                Console.WriteLine(d + " days " + h + " hour");
                            }
                            else if (d > 1 && h > 1)
                            {
                                Console.WriteLine(d + " days " + h + " hours");
                            }
                        }
                        {
                            ShowMessage("Good luck!", delegate (string mes)
                            {
                                Console.WriteLine(mes);
                            });
                        }
                        programmer.CompareTo();
                        break;
                    case 2:
                        Economist economist = new Economist("BSU", "Economy", "Minsk", "Yana", "Shebeko", 17);
                        Console.WriteLine(economist);
                        Console.WriteLine("Number of laboratory works in semester 2 - 27");
                        Console.WriteLine("Average lead time:");
                        economist.Lab(27);
                        if (economist.Time == 1)
                        {
                            Console.WriteLine(economist.Time + " hour");
                        }
                        else if (economist.Time <= 23 && economist.Time == 1)
                        {
                            Console.WriteLine(economist.Time + " hours");
                        }
                        else if (economist.Time >= 24)
                        {
                            int d, h;
                            h = economist.Time % 24;
                            d = economist.Time / 24;
                            if (d > 1 && h == 0)
                            {
                                Console.WriteLine(d + " days");
                            }
                            else if (d == 1 && h == 0)
                            {
                                Console.WriteLine(d + " day");
                            }
                            else if (d == 1 && h == 1)
                            {
                                Console.WriteLine(d + " day " + h + " hour");
                            }
                            else if (d == 1 && h > 1)
                            {
                                Console.WriteLine(d + " day " + h + " hours");
                            }
                            else if (d > 1 && h == 1)
                            {
                                Console.WriteLine(d + " days " + h + " hour");
                            }
                            else if (d > 1 && h > 1)
                            {
                                Console.WriteLine(d + " days " + h + " hours");
                            }
                        }
                        {
                            ShowMessage("Good luck!", delegate (string mes)
                            {
                                Console.WriteLine(mes);
                            });
                        }
                        economist.CompareTo();
                        break;
                    case 3:
                        Lawyer lawyer = new Lawyer("BSU", "International right", "Minsk", "Anastasia", "Shurova", 18);
                        Console.WriteLine(lawyer);
                        Console.WriteLine("Number of laboratory works in semester 2 - 17");
                        Console.WriteLine("Average lead time:");
                        lawyer.Lab(17);
                        if (lawyer.Time == 1)
                        {
                            Console.WriteLine(lawyer.Time + " hour");
                        }
                        else if (lawyer.Time <= 23 && lawyer.Time == 1)
                        {
                            Console.WriteLine(lawyer.Time + " hours");
                        }
                        else if (lawyer.Time >= 24)
                        {
                            int d, h;
                            h = lawyer.Time % 24;
                            d = lawyer.Time / 24;
                            if (d > 1 && h == 0)
                            {
                                Console.WriteLine(d + " days");
                            }
                            else if (d == 1 && h == 0)
                            {
                                Console.WriteLine(d + " day");
                            }
                            else if (d == 1 && h == 1)
                            {
                                Console.WriteLine(d + " day " + h + " hour");
                            }
                            else if (d == 1 && h > 1)
                            {
                                Console.WriteLine(d + " day " + h + " hours");
                            }
                            else if (d > 1 && h == 1)
                            {
                                Console.WriteLine(d + " days " + h + " hour");
                            }
                            else if (d > 1 && h > 1)
                            {
                                Console.WriteLine(d + " days " + h + " hours");
                            }
                        }
                        Console.WriteLine("Good luck!");
                        lawyer.CompareTo();
                        break;
                    case 4:
                        Doctor doctor = new Doctor("GSMU", "Pediatrics", "Molodechno", "Anastasia", "Savenok", 18);
                        Console.WriteLine(doctor);
                        Console.WriteLine("Number of laboratory works in semester 2 - 13");
                        Console.WriteLine("Average lead time:");
                        doctor.Lab(13);
                        if (doctor.Time == 1)
                        {
                            Console.WriteLine(doctor.Time + " hour");
                        }
                        else if (doctor.Time <= 23 && doctor.Time == 1)
                        {
                            Console.WriteLine(doctor.Time + " hours");
                        }
                        else if (doctor.Time >= 24)
                        {
                            int d, h;
                            h = doctor.Time % 24;
                            d = doctor.Time / 24;
                            if (d > 1 && h == 0)
                            {
                                Console.WriteLine(d + " days");
                            }
                            else if (d == 1 && h == 0)
                            {
                                Console.WriteLine(d + " day");
                            }
                            else if (d == 1 && h == 1)
                            {
                                Console.WriteLine(d + " day " + h + " hour");
                            }
                            else if (d == 1 && h > 1)
                            {
                                Console.WriteLine(d + " day " + h + " hours");
                            }
                            else if (d > 1 && h == 1)
                            {
                                Console.WriteLine(d + " days " + h + " hour");
                            }
                            else if (d > 1 && h > 1)
                            {
                                Console.WriteLine(d + " days " + h + " hours");
                            }
                        }
                        Console.WriteLine("Good luck!");
                        doctor.CompareTo();
                        break;
                    case 5:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}