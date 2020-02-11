using System;

namespace OrderManager.Model
{
    public enum HeatingApplianceType
    {
        None,
        BackeryOven,
        Brazier,
        Campfire
    }

    public enum HeatingApplianceStatus
    {       
        Cold,
        Heating,
        HeatUp        
    }

    public class HeatingAppliance 
    {
        private readonly TimeSpan warmUpTime;

        private readonly TimeSpan coolingTime;

        public HeatingApplianceType HeatingApplianceType { get; }

        public DateTime StartTime { get; private set; }

        public HeatingApplianceStatus Status
        {
            get
            {
                try
                {
                    return Clock.Current < StartTime.Add(-warmUpTime) || Clock.Current > StartTime.Add(coolingTime)
                        ? HeatingApplianceStatus.Cold
                        : Clock.Current < StartTime
                        ? HeatingApplianceStatus.Heating
                        : HeatingApplianceStatus.HeatUp;
                }
                catch (ArgumentOutOfRangeException)
                {
                    return Clock.Current > StartTime.Add(coolingTime)
                        ? HeatingApplianceStatus.Cold
                        : Clock.Current < StartTime
                        ? HeatingApplianceStatus.Heating
                        : HeatingApplianceStatus.HeatUp;

                }
            }

        }       

        public HeatingAppliance(TimeSpan warmUpTime, TimeSpan coolingTime, HeatingApplianceType heatingApplianceType)
        {
            if (warmUpTime <= TimeSpan.Zero || coolingTime <= TimeSpan.Zero)
                throw new Exception("Time span must be above zero!");

            if (heatingApplianceType == HeatingApplianceType.None)
                throw new Exception("Heating appliance type must be not None!");

            this.warmUpTime = warmUpTime;
            this.coolingTime = coolingTime;

            HeatingApplianceType = heatingApplianceType;
        }
       
        private TimeSpan TurnOn()
        {
            TimeSpan whenBeReadyToCook =
                Status == HeatingApplianceStatus.Cold
                ? warmUpTime
                : Status == HeatingApplianceStatus.Heating
                ? StartTime - Clock.Current
                : TimeSpan.Zero;

            StartTime = Status == HeatingApplianceStatus.Cold
                ? Clock.Current.Add(warmUpTime)
                : Status == HeatingApplianceStatus.Heating
                ? StartTime
                : Clock.Current; 

            return whenBeReadyToCook;
        }

        public TimeSpan CookDish(Dish dish)
        {
            if (dish is null)
                throw new NullReferenceException();

            if (dish.HeatingApplianceType != HeatingApplianceType)
                throw new Exception("Heating appliance can`t cook this dish!");

            return TurnOn();
        }

    }
}
