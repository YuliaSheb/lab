using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
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
                var date = string.Join(" ", num[i,1], num[i,2]);
                Console.WriteLine(DateTime.ParseExact(date, "HH:mm", CultureInfo.InvariantCulture));//?? при выводе выскакивает исключение
                people.Terpenie = Convert.ToInt32(num[i, 3]);
                list.Add(new People() { Name = people.Name,date = people. , Terpenie = people.Terpenie });
            }
        }
    }
}
    

