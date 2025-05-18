using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7311FactoryDesign
{
    public class GunFactory
    {
        public IGun GetGun(string gunModel)
        {
            if (gunModel == "AR")
            {
                return new AR();
            }
            else if (gunModel == "Shotgun")
            {
                return new Shotgun();
            }
            else
            {
                return null;
            }
        }
    }
}
