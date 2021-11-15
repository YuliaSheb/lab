using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 5, 4, 8, 6, 15 };
            int sum = 0, en;
            People people = new People(array[0]);
            Console.WriteLine(people);
            Chikens chikens = new Chikens(array[1]);
            Console.WriteLine(chikens);
            Ducks ducks = new Ducks(array[2]);
            Console.WriteLine(ducks);
            Cows cows = new Cows(array[3]);
            Console.WriteLine(cows);
            Dogs dogs = new Dogs(array[4]);
            Console.WriteLine(dogs);
            Console.WriteLine("Введите выносливость лошади (сколько кг может везти):");
            en = Convert.ToInt32(Console.ReadLine());
            Horses horses = new Horses(array[5],en);
            Console.WriteLine(horses);
            for (int i=0; i< array.Length; i++)
            {
                sum += array[i];
            }
            int k=1;
            while (en < sum)
            {
                sum -= en;
                k++;
            }
            Console.WriteLine("Чтобы привезти еду необходимо "+k+" лошадей");
            Console.ReadKey();
        }
    }
}
