using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parik
{
    class Info
    {
        public string Name { get; set; }
        public int Time { get; set; }
        public int Time_m { get; set; }
        public int Terpenie { get; set; }
        public Info(string name, int time,int time_m, int terpenie)
        {
            Name = name;
            Time = time;
            Time_m = time_m;
            Terpenie = terpenie;
        }
    }
}
