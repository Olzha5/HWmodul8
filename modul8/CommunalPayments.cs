using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8
{
    public class CommunalPayments
    {
        public double HeatingRate { get; set; }
        public double WaterRate { get; set; }
        public double GasRate { get; set; }
        public double RepairRate { get; set; }

        public double Calculate(double area, int residents, bool isWinter, bool isLaborVeteran, bool isWarVeteran)
        {
            double heatingTotal = HeatingRate * area * (isWinter ? 1.5 : 1.0);
            double waterTotal = WaterRate * residents;
            double gasTotal = GasRate * residents;
            double repairTotal = RepairRate * area;

            double discount = 0;
            if (isLaborVeteran) discount += heatingTotal * 0.3;
            if (isWarVeteran) discount += heatingTotal * 0.5;

            double total = heatingTotal + waterTotal + gasTotal + repairTotal - discount;
            return total;
        }
    }
}
