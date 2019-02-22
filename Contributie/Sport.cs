using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contributie
{
    class Sport
    {
        private string name;
        private double extraAmount;//

        public Sport(string name, double extraAmount)
        {
            this.name = name;
            this.extraAmount = extraAmount;
        }

        public override string ToString()
        {
            return $"Name:{name}, Price:{extraAmount}";
        }

        public string Name
        {
            get { return name; }
        }

        public double ExtraAmount
        {
            get { return extraAmount; }
            set { extraAmount = value; }
        }
    }
}
