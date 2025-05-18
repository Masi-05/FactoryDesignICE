using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7311FactoryDesign
{
    public class Shotgun : IGun
    {
        public void Shoot()
        {
            Console.WriteLine("Pump Action Shotgun");
        }
    }
}
