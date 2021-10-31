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
        public List<DateTime> dates = new List<DateTime>();
        public  Proverka()
        {
            TimeSpan ts = new TimeSpan(00, 40, 00);
            DateTime date1 = new DateTime(00,00);
            DateTime date_finish = new DateTime();
            date1.ToString("HH:mm");
            foreach (People l in list)
            {
                Console.WriteLine(list);
                date1 = date;
                date_finish = date + ts;
                TimeSpan interval = date_finish - date1;
                do
                {
                    queue.Enqueue(new People() { Name = people.Name, date = people.date, Terpenie = people.Terpenie });
                    dates.Add(date_finish);
                    foreach (DateTime i in dates)
                    {
                        Console.WriteLine(i);
                    }
                }
                while (interval > ts);
            }
        }
    }
}
