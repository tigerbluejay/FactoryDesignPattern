using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class North : Location
    {
        public override void CreateOffices()
        {
            Offices = new List<Office>()
            {
                new OfficeNorth1(),
                new OfficeNorth2(),
                new OfficeNorth3()
            };
        }
    }
}
