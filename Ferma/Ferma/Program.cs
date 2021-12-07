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
            Chiken = 2,
            Duck = 2,
            Cow = 4,
            Dog = 3,
            Horse = 5,   
        }
        private static readonly int Endurence = 5;
        static void Opred(int value_people, int value_chiken,int  value_duck, int value_cow, int value_dog, int value_horse)
        {
            People people = new People((int)Tenants.People);
            People[] p = new People[value_people];
            Console.WriteLine(people);
            Chikens chikens = new Chikens((int)Tenants.Chiken);
            Chikens[] ch = new Chikens[value_chiken];
            Console.WriteLine(chikens);
            Ducks ducks = new Ducks((int)Tenants.Duck);
            Ducks[] du = new Ducks[value_duck];
            Console.WriteLine(ducks);
            Cows cows = new Cows((int)Tenants.Cow);
            Cows[] c = new Cows[value_cow];
            Console.WriteLine(cows);
            Dogs dogs = new Dogs((int)Tenants.Dog);
            Dogs[] d = new Dogs[value_dog];
            Console.WriteLine(dogs);
            Horses horses = new Horses((int)Tenants.Horse, Endurence);
            Horses[] h = new Horses[value_horse];
            Console.WriteLine(horses);
        }
        static List<Farm_tenant> Init(int value_people, int value_chiken, int value_duck, int value_cow, int value_dog, int value_horse)
        {
            int k;
            List<Farm_tenant> tenants = new List<Farm_tenant>();
            for (k = 0; k < value_people; k++)
            {
                tenants.Add(new People((int)Tenants.People));
            }
            for (k = 0; k < value_chiken; k++)
            {
                tenants.Add(new Chikens((int)Tenants.Chiken));
            }
            for (k = 0; k < value_duck; k++)
            {
                tenants.Add(new Ducks((int)Tenants.Duck));
            }
            for (k = 0; k < value_cow; k++)
            {
                tenants.Add(new Cows((int)Tenants.Cow));
            }
            for (k = 0; k < value_dog; k++)
            {
                tenants.Add(new Dogs((int)Tenants.Dog));
            }
            for (k = 0; k < value_horse; k++)
            {
                tenants.Add(new Horses((int)Tenants.Horse));
            }
            return tenants;
        }
        static int Calc(List<Farm_tenant> tenants)
        {
            var sum = tenants.Sum(t=>t.Food);
            int n = 1;
            while (Endurence < sum)
            {
                sum -= Endurence;
                n++;
            }
            Console.WriteLine("Чтобы привезти еду для всех, необходимо " + n + " лошадей");
                var sum_people = tenants.Where(t => typeof(People).IsInstanceOfType(t)).Sum(t => t.Food);
            int z = 1;
            while (Endurence < sum_people)
            {
                sum_people -= Endurence;
                z++;
            }
            Console.WriteLine("Чтобы привезти еду для людей, необходимо " + z + " лошадей");
            var sum_horses = tenants.Where(t => typeof(Horses).IsInstanceOfType(t)).Sum(t => t.Food);
            int p = 1;
            while (Endurence < sum_horses)
            {
                sum_horses -= Endurence;
                p++;
            }
            Console.WriteLine("Чтобы привезти еду для лошадей, необходимо " + p + " лошадей");
            var sum_birds = tenants.Where(t =>( typeof(Chikens).IsInstanceOfType(t) || typeof(Ducks).IsInstanceOfType(t))).Sum(t => t.Food);
            int b = 1;
            while (Endurence < sum_birds)
            {
                sum_birds -= Endurence;
                b++;
            }
            Console.WriteLine("Чтобы привезти еду для пернатых, необходимо " + b + " лошадей");
            return n;
        }
        static void Price(int value_chicken, int value_duck, int value_cow)
        {
            Ducks duck = new Ducks();
            duck.Put(value_duck);
            Console.WriteLine("Доход от уток за декабрь составляет " + duck.Value + " рублей.");
            Chikens chik = new Chikens();
            chik.Put(value_chicken);
            Console.WriteLine("Доход от куриц за декабрь  составляет " + chik.Value + " рублей.");
            Cows cow = new Cows();
            cow.Put(value_cow);
            Console.WriteLine("Доход от коров за декабрь составляет " + cow.Value + " рублей.");
        }
        static void Main(string[] args)
        {
            int value_people = 30, value_chiken = 15, value_duck = 7, value_cow = 10, value_dog = 5, value_horse = 25;
            Opred(value_people, value_chiken , value_duck , value_cow , value_dog, value_horse );
            var tenants = Init(value_people, value_horse, value_cow, value_duck, value_chiken, value_dog);
            Calc(tenants);
            Price(value_chiken, value_duck, value_cow);
            Console.ReadKey();
        }
    }
}
