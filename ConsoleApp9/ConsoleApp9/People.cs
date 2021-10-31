using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class People
    {
        public string Name { get; set; }
        public DateTime date = new DateTime();
        public int Terpenie { get; set; }
        public People()
        {
            Name = "";
            Terpenie = 0;
        }
    }
    /*
        public class Person
    {
        public string? Name { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public int Terpenie { get; set; }
        public Boolean IsCutted { get; set; }
    }
    */
}
