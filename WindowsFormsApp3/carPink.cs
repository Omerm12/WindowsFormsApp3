using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class carPink : CarRace
    {
       
        public carPink() : base()
        {
           
            haveContent = false;
            _brand = "BMW";
            _id = 6;
            _kmh = 250;
            _release_year = 2020;
            
        }

        //public override string Content() { return "null"; }
    }
   

}
