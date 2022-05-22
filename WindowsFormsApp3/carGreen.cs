using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    [Serializable]
    internal class carGreen : CarRace
    {
    
        public carGreen() : base()
        {
            haveContent = false;
            _brand = "Ford";
            _id = 8;
            _kmh = 195;
            _release_year = 2013;
           
        }

    }
}
