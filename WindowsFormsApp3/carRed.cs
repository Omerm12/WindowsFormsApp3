using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class carRed :CarRace
    {
        public carRed() : base()
        {
            haveContent = false;
            _brand = "Mazda";
            _id = 5;
            _kmh = 195;
            _release_year = 2015;
          
        }
    }
}
