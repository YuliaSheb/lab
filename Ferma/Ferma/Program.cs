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
            Endurence = 5      
        }
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
            Horses horses = new Horses((int)Tenants.Horse, (int)Tenants.Endurence);
            Horses[] h = new Horses[value_horse];
            Console.WriteLine(horses);
        }
        static int Calc(int value_people, int value_chiken, int value_duck, int value_cow, int value_dog, int value_horse)
        {
            int sum = 0;
            sum = value_people*(int)Tenants.People + value_chiken*(int)Tenants.Chiken + value_duck * (int)Tenants.Duck + value_cow * (int)Tenants.Cow + value_dog * (int)Tenants.Dog + value_horse * (int)Tenants.Horse;
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
            int value_people = 30, value_chiken = 15, value_duck = 7, value_cow = 10, value_dog = 5, value_horse = 25;
            Opred(value_people, value_chiken , value_duck , value_cow , value_dog, value_horse );
            Calc(value_people, value_chiken, value_duck, value_cow, value_dog, value_horse);
            Console.ReadKey();
        }
    }
}
