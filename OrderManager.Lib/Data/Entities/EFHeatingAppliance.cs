using System;
using OrderManager.Lib.Model;

namespace OrderManager.Lib.Data.Entities
{
    public class EFHeatingAppliance
    {
        public int Id { get; set; }

        public TimeSpan WarmUpTime { get; set; }

        public TimeSpan CoolingTime { get; set; }

        public HeatingApplianceType HeatingApplianceType { get; set; }
    }
}
