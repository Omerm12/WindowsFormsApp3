using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class player : Vehicle
    {
       public player() : base()
        {
            haveContent = false;
            _brand = "Tesla";
            _id = 10;
            _kmh = 350;
            _release_year = 2018;
            speed = 12;
        }
    }
}
