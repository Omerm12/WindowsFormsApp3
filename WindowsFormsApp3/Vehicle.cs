using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    [Serializable]
    class Vehicle :VehicleGame
    {
        protected bool haveContent;
        public string _brand;
        public int _id;
        public double _kmh;
        public int _release_year;
        public int speed;

        Random rand = new Random();
        Random carPosition = new Random();

        public virtual void makeNoise() { }
        public virtual string Content() { return null; }
    }

}
