using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class South : Location
    {
        public override void CreateOffices()
        {
            Offices = new List<Office>()
            {
                new OfficeSouth1(),
                new OfficeSouth2(),
                new OfficeSouth3()
            };
        }
    }
}
