using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
    public class Rueda
    {
        public int Diametro { get; set; }
        public string Llanta { get; set; }
        public string Neumatico { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
