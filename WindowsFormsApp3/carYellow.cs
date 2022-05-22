using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class carYellow : CarRace
    {
        public carYellow() :base()
        {
          haveContent = false;
         _brand= "Hyundai";
         _id=4;
         _kmh=185;
         _release_year = 2010;
          
        }
    }
}

