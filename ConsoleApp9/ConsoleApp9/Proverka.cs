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
    /*
        public class Proverka
    {
		private List<Person> cut_queue = new List<Person>();
		private List<Person> processed = new List<Person> ();
		private TimeSpan Time_to_cut = new TimeSpan(00, 40, 00);
		/// <summary>
		/// Check queue and returns its current size
		/// </summary>
		/// <param name="current_moment"></param>
		/// <returns></returns>
		private int CheckQueueSize(DateTime current_moment) {
		    foreach(var p in cut_queue) {
				if (p.End_date < current_moment) {
					// Mark that person is cutted and add to list of processed persons
					p.IsCutted = true;
					processed.Add(p);
					// Remove person who is processed from queue 
					cut_queue.Remove(p);
				}
			}
			return cut_queue.Count;
		}
		
        public Proverka(List<Person> list) {
			TimeSpan time_to_cut = new TimeSpan(00, 40, 00);
			foreach (Person l in list)
			{
				// If person do not like to wait
				if (CheckQueueSize(l.Start_date) > l.Terpenie)
				{
					l.IsCutted = false;
				}
				// If person will wait
				else
				{
					if (cut_queue.Count > 0)
					{
						var End_date_to_last = cut_queue.Last().End_date;
						if (End_date_to_last > l.Start_date)
						{
							l.End_date = End_date_to_last + Time_to_cut;
						} else
                        {
							l.End_date = l.Start_date + Time_to_cut;
						}
					}
					else
					{
						l.End_date = l.Start_date + Time_to_cut;
					}
					cut_queue.Add(l);
				}
			}
		}
    }
    */
}
