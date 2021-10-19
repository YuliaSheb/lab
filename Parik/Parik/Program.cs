using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в парикмахерскую!");
            int N, time=0, time_m=0, k, terpenie;
            Console.WriteLine("Количество клиентов:");
            N = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            Queue<Info> queue = new Queue<Info>();
            for (int i = 0; i < N; i++)
            {
                int n = i + 1;
                Console.WriteLine(n + " клиент:");
                Console.WriteLine("Представтесь:");
                string name = Console.ReadLine();
                k=rnd.Next(0,15);
                time += k;
                if (time > 23)
                {
                    time = 23;
                }
                time_m += k;
                while (time_m > 60)
                {
                    time_m -= 60;
                }
                Console.WriteLine("Терпение клиента:");
                terpenie = Convert.ToInt32(Console.ReadLine());
                queue.Enqueue(new Info(name, time, time_m, terpenie) { Name = name, Time = time, Time_m = time_m, Terpenie = terpenie });
            }
            Console.WriteLine("Сейчас в очереди {0} человек(а)", queue.Count);
            foreach (Info p in queue)
            {
                Console.WriteLine("Клиент " + p.Name + " пришел в " + p.Time + "." + p.Time_m + "  Терпение " + p.Terpenie);
            }
            Console.WriteLine("*****************************************************");
            foreach (Info d in queue)
            {
                while (queue.Count > 0)
                {
                    if ((d.Terpenie > queue.Count)||(d.Time+20>d.Time))
                    {
                        Info person = queue.Dequeue();
                        Console.WriteLine("Клиент " + person.Name + "  ушел");
                        Console.WriteLine("*****************************************************");
                    }

                    Console.WriteLine("Сейчас в очереди {0} человек(а)", queue.Count);
                    foreach (Info pp in queue)
                    {
                        Console.WriteLine("Клиент " + pp.Name + " пришел в " + pp.Time + "." + pp.Time_m + "  Терпение " + pp.Terpenie);
                    }
                    Console.WriteLine("*****************************************************");
                }
            }
            Console.WriteLine("Рабочий день окончен");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
