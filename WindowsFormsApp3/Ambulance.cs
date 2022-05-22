using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Ambulance : BigCars
    {
        int savelife;
        public Ambulance() : base()
        {
            haveContent = false;
            _brand = "Chevrolet";
            _id = 1;
            _kmh = 150;
            _release_year = 1999;
            weight = 3500;
        }
        Random rand1 = new Random();
        public bool savelives()
        {
            savelife = rand1.Next(1, 2);
            switch (savelife)
            {
                case 1:
                   Emergency = true;
                    break;
                case 2:
                    Emergency = false;
                    break;
            }
            return Emergency;
        }

        public override string Content()
        {
            return "Medical equipment";

        }

        public override void makeNoise()
        {
            
        }



    }
}
