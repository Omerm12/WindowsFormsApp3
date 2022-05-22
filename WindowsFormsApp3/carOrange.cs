using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class carOrange : Vehicle
    {
        public carOrange() : base()
        {
            haveContent = false;
            _brand = "Lamborghini";
            _id = 7;
            _kmh = 265;
            _release_year = 2019;
            
        }
    }
}
