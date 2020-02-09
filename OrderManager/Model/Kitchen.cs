using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace OrderManager.Model
{
    class Kitchen
    {
        private readonly Cook[] cooks;
        private readonly HeatingAppliance[] heatingAppliances;

        public Dish[] Dishes { get; }

        public Kitchen(Cook[] cooks, Dish[] dishes, HeatingAppliance[] heatingAppliances)
        {
            if (cooks is null || dishes is null || heatingAppliances is null)
                throw new NullReferenceException();

            if (cooks.Length < 1)
                throw new Exception("Must be at least 1 cook!");

            if (dishes.Length < 1)
                throw new Exception("Must be at least 1 dish!");

            this.cooks = cooks;           
            this.heatingAppliances = heatingAppliances;

            Dishes = dishes;
        }

        public string MakeOrder(Dish dish)
        {
            if (dish is null)
                return "Order can`t contain no dishes!";
          
            HeatingAppliance heatingAppliance =
                dish.HeatingApplianceType == HeatingApplianceType.None
                ? null
                : (FindHeatingAppliance(dish.HeatingApplianceType)
                ?? throw new Exception("There is no appliance to cook this!"));

            Cook cook = FindFreeCook() ?? FindLeastBusyCook();

            cook.AddDishToCook(dish, heatingAppliance);

            return cook.FinishTime.ToString();
        }

        private Cook FindFreeCook()
        {
            return cooks.Where(x => x.IsFree).OrderByDescending(x => x.SkillCoefficient).FirstOrDefault();
        }

        private Cook FindLeastBusyCook()
        {
            return cooks.OrderBy(x => x.FinishTime).ThenByDescending(x => x.SkillCoefficient).First();
        }

        private HeatingAppliance FindHeatingAppliance(HeatingApplianceType heatingApplianceType)
        {
            return heatingAppliances.Where(x => x.HeatingApplianceType == heatingApplianceType).FirstOrDefault();
        }
    }
}
