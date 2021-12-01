using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Project
{
      class Car:Vehicle
    {
        public int doorsNumber;
        public string carModel;
        public string carColor;
        public int carHorsePower;

        public Car(int doorsNumber, string carModel, string carColor, int carHorsePower, string type, string chiptuning) : base( type, chiptuning)
        {
            this.doorsNumber = doorsNumber;
            this.carModel = carModel;
            this.carColor = carColor;
            this.carHorsePower = carHorsePower;
            
        }
        


        public void CarInfo()
        {
            VeichleInfo();
            Console.WriteLine(this.doorsNumber + " " + this.carModel + " " +this.carColor + " " + this.carHorsePower );
        }
        public void doorsLocking()
        {
            Console.WriteLine("Doors are locking...");

        }
    }
}
