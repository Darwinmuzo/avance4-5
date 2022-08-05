using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1
{
    public class Carroceria
    {
        public bool HabitaculoReforzado { get; set; }
        public string Material { get; set; }
        public string TipoCarroceria { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
