﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class whiteTrack : BigCars
    {

        public whiteTrack() : base()
        {
            haveContent = true;
            Emergency = false;
            _brand = "Mercedes";
            _id = 3;
            _kmh = 165;
            _release_year = 2013;
        }

        int newcontent;

        Random rand1 = new Random();
        Random rand2 = new Random();


        public override string Content()
        {
            newcontent = rand1.Next(1, 4);
            switch (newcontent)
            {
                case 1:
                   return "Food";
                   
                case 2:
                    return "Furniture";
                    
                case 3:
                    return "Animals";
                    
                case 4:
                    return  "Coca-Cola";
                  
            }
            return null;
        }
        public void trackWeight()
        {
            double newWeight = rand2.Next(3000, 5000);
            weight = newWeight;
            if (weight > 4000)
            {
                speed = 4;
            }
            else
                speed = 5;
        }

    }
}
