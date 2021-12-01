using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Project
{
    class Vehicle
    {
        string type;
        string chiptunung;

        public Vehicle(string type, string chiptuning) 
        {
            this.type = type;
            this.chiptunung = chiptuning;
        
        }
        public void VeichleInfo()
        {
            Console.WriteLine(this.type+" " +this.chiptunung);
        }
    }

}
