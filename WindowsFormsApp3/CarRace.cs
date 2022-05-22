using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    [Serializable]
    class CarRace : Vehicle
    {
       public  CarRace() : base()
        {
            speed = 7;
            haveContent = false;
        }
        public override void makeNoise()
        { 

        }

        public override string Content()
        {
            return "null" ;

        }

    }
}