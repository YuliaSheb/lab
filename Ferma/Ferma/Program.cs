using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferma
{
    class Program
    {
        enum Tenants
        {
            People = 3, 
            Chiken = 5,
            Duck = 4,
            Cow = 8,
            Dog = 6,
            Horse = 10,
            Endurence = 5      
        }
        static void Opred()
        {
            People people = new People((int)Tenants.People);
            Console.WriteLine(people);
            Chikens chikens = new Chikens((int)Tenants.Chiken);
            Console.WriteLine(chikens);
            Ducks ducks = new Ducks((int)Tenants.Duck);
            Console.WriteLine(ducks);
            Cows cows = new Cows((int)Tenants.Cow);
            Console.WriteLine(cows);
            Dogs dogs = new Dogs((int)Tenants.Dog);
            Console.WriteLine(dogs);
            Horses horses = new Horses((int)Tenants.Horse, (int)Tenants.Endurence);
            Console.WriteLine(horses);
        }
        static int Calc()
        {
            int sum = 0;
            sum = (int)Tenants.People + (int)Tenants.Chiken + (int)Tenants.Duck + (int)Tenants.Cow + (int)Tenants.Dog + (int)Tenants.Horse;
            int k = 1;
            while ((int)Tenants.Endurence < sum)
            {
                sum -= (int)Tenants.Endurence;
                k++;
            }
            Console.WriteLine("Чтобы привезти еду необходимо " + k + " лошадей");
            return k;
        }
        static void Main(string[] args)
        {
            Opred();
            Calc();
            Console.ReadKey();
        }
    }
}
