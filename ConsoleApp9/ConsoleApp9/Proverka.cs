using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Proverka:Reader
    {
        public Queue<People> queue = new Queue<People>();
        public  Proverka()
        {
            foreach (People l in list)
            {
                Console.WriteLine(list);
                queue.Enqueue(new People() { Name = people.Name, Time = people.Time, Time_m = people.Time_m, Terpenie = people.Terpenie });
            }
            foreach (People q in queue)
            {
                people.Time_m += 20;
                if (people.Time_m>60)
                {
                    people.Time_m -= 60;
                    people.Time++;
                }
                Console.WriteLine(people.Time + "." + people.Time_m);
            }
        }
    }
}
