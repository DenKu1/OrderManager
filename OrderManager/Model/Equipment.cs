using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Model
{
    enum EquipmentType
    {
        None,
        BackeryOven,
        Brazier,
        Campfire
    }

    class Equipment 
    {
        private readonly TimeSpan warmUpTime;

        private readonly TimeSpan coolingTime;

        public EquipmentType EquipmentType { get; }

        public bool IsHeatUp => StartTime.Add(coolingTime) >= Clock.Current;

        public DateTime StartTime { get; private set; }        

        public Equipment(TimeSpan warmUpTime, TimeSpan coolingTime, EquipmentType equipmentType)
        {
            if (warmUpTime <= TimeSpan.Zero || coolingTime <= TimeSpan.Zero)
                throw new Exception("Time span must be above zero!");

            if (equipmentType == EquipmentType.None)
                throw new Exception("Equipment type must be not None!");

            this.warmUpTime = warmUpTime;
            this.coolingTime = coolingTime;

            EquipmentType = equipmentType;
        }
       
        private TimeSpan TurnOn()
        {
            TimeSpan whenBeReadyToCook = IsHeatUp ? TimeSpan.Zero : warmUpTime;

            StartTime = Clock.Current;

            return whenBeReadyToCook;
        }

        public TimeSpan CookDish(Dish dish)
        {
            if (dish is null)
                throw new NullReferenceException();

            if (dish.EquipmentType != EquipmentType)
                throw new Exception("Equipment can`t cook this dish!");

            return TurnOn();
        }

    }
}
