using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konzolniPrimeri
{
    class PropertyPrimer
    {
        public PropertyPrimer(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
