﻿using System;
using System.Runtime.Serialization;

namespace OrderManager.Lib.Model
{
    [DataContract]
    public enum HeatingApplianceType
    {
        None,
        BackeryOven,
        Brazier,
        Campfire
    }

    [DataContract]
    public enum HeatingApplianceStatus
    {       
        Cold,
        Heating,
        HeatUp        
    }

    [DataContract]
    public class Cooker 
    {
        [DataMember]
        public TimeSpan warmUpTime;
        [DataMember]
        public TimeSpan coolingTime;
        [DataMember]
        public HeatingApplianceType HeatingApplianceType { get; set; }
        [IgnoreDataMember]
        public DateTime StartTime { get; set; }
        [IgnoreDataMember]
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

        public Cooker()
        {
        }

        public Cooker(TimeSpan warmUpTime, TimeSpan coolingTime, HeatingApplianceType heatingApplianceType)
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