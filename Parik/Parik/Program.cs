using System;
using System.IO;
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
            Queue<string> queue = new Queue<string>();
            /* List<string> list = new List<string>();
             string[] lines = File.ReadAllLines("queue.txt");
             foreach (string s in lines)
             {
                 list.Add(s);
             }
             foreach (string i in list)
             {
                 Console.WriteLine(i);
             }
             Console.ReadLine();*/
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
            Console.WriteLine("Клиенты:");
            Console.WriteLine("Имя:  Часы:   Минуты: Терпение:");
            int rows = num.GetUpperBound(0) + 1;
           int columns = num.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{num[i, j]} \t");
                }
                queue.Enqueue(num[i,0]);
                Console.WriteLine();
            }
            int k = 1;
            int time = 0;
            int time_m = 0;
            for (int i = 0; i < rows; i++)
            {
                int terpenie = Convert.ToInt32(num[i, 3]);
                int time1 = Convert.ToInt32(num[i , 1]);
                int time1_m = Convert.ToInt32(num[i , 2]);
                int time_r = time1 - time;
                if (time_r < 0)
                {
                    time_r = time - time1;
                }
                int time_m_r = time1_m - time_m;
                if (time_m_r<0)
                {
                    time_m_r = time_m - time1_m;
                }
                if ((time_r == 0) && (time_m_r == 0))
                {
                    time1_m += 20;
                    if (time1_m >= 60)
                    {
                        time1_m -= 60;
                        time1++;
                    }
                    if (k > terpenie)
                    {
                        Console.WriteLine("Клиент " + num[i, 0] + " не дождался своей очереди и ушел");
                        string queueElemen = queue.Dequeue();
                        k--;
                    }
                    else
                    {
                        Console.WriteLine("Клиент " + num[i, 0] + " ушел в " + time1 + "." + time1_m);
                        string queueEleme = queue.Dequeue();
                        k--;
                    }
                }
                else if ((time_r>0)||(time_m_r>20))
                { 
                        time1_m += 20;
                        if (time1_m >= 60)
                        {

                            time1_m -= 60;
                            time1++;
                        }
                        if (k > terpenie)
                        {
                            Console.WriteLine("Клиент " + num[i, 0] + " не дождался своей очереди и ушел");
                            string queueElem = queue.Dequeue();
                            k--;
                        }
                        else
                        {
                            Console.WriteLine("Клиент " + num[i, 0] + " ушел в " + time1 + "." + time1_m);
                            string queueEle = queue.Dequeue();
                            k--;
                        }
                }
                else if ((time_r==0)&&(time_m_r<20))
                {
                    time1_m += time_m_r;
                    if (time1_m >= 60)
                    {

                        time1_m -= 60;
                        time1++;
                    }
                    time1_m += 20;
                    if (time1_m >= 60)
                    {

                        time1_m -= 60;
                        time1++;
                    }
                    if (k > terpenie)
                    {
                        Console.WriteLine("Клиент " + num[i , 0] + " не дождался своей очереди и ушел");
                        string queueElements = queue.Dequeue();
                        k--;
                    }
                    else
                    {
                        Console.WriteLine("Клиент " + num[i , 0] + " ушел в " + time1 + "." + time1_m);
                        string queueElement = queue.Dequeue();
                        k--;
                    }
                }
                Console.WriteLine("Остались:");
                foreach (string n in queue)
                {
                    Console.WriteLine(n);
                }
                k++;
                time = time1;
                time_m = time1_m;
            }

            Console.ReadLine();
        }
    }
}
