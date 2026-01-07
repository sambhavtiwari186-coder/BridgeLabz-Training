using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenario_based.VehicleMangementSystem
{
    class Car : Vehicle
    {
        public Car(int id, string brand, string model, double rentPerDay)
            : base(id, brand, model, rentPerDay)
        {
        }

        public override double CalculateRent(int days)
        {
            return (days * rentPerDay) + 1000; // Insurance charge
        }
    }

}
