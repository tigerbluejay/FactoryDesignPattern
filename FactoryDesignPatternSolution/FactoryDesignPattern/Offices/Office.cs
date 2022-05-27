using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    abstract class Office
    {
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
