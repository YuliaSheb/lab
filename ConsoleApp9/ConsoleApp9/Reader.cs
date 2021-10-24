using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Reader:People
    {
        public People people = new People();
        public List<People> list = new List<People>();
        public Reader()
        {
            
            string[] lines = File.ReadAllLines("queue.txt");
            string[,] num = new string[lines.Length, lines[0].Split(' ').Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(' ');
                for (int j = 0; j < temp.Length; j++)
                {
                    num[i, j] = temp[j];
                }
            }
            for (int i = 0; i < lines.Length; i++)
            {
                people.Name = num[i, 0];
                people.Time = Convert.ToInt32(num[i, 1]);
                people.Time_m = Convert.ToInt32(num[i, 2]);
                people.Terpenie = Convert.ToInt32(num[i, 3]);
                list.Add(new People() { Name = people.Name, Time = people.Time, Time_m = people.Time_m, Terpenie = people.Terpenie });
            }
        }
    }
}
    

