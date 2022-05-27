using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    abstract class Location
    {
        public Location()
        {
            this.CreateOffices();
        }
        public List<Office> Offices { get; protected set; }
        public abstract void CreateOffices();

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
