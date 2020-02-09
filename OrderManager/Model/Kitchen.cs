using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace OrderManager.Model
{
    class Kitchen
    {
        private readonly Cook[] cooks;
        private readonly Equipment[] equipment;

        public Dish[] Dishes { get; }

        public Kitchen(Cook[] cooks, Dish[] dishes, Equipment[] equipment)
        {
            if (cooks is null || dishes is null || equipment is null)
                throw new NullReferenceException();

            if (cooks.Length < 1)
                throw new Exception("Must be at least 1 cook!");

            if (dishes.Length < 1)
                throw new Exception("Must be at least 1 dish!");

            this.cooks = cooks;           
            this.equipment = equipment;

            Dishes = dishes;
        }

        public string MakeOrder(Dish dish)
        {
            if (dish is null)
                return "Order can`t contain no dishes!";
          
            Equipment equipment =
                dish.EquipmentType == EquipmentType.None
                ? null
                : (FindEquipment(dish.EquipmentType)
                ?? throw new Exception("There is no equipment to cook this!"));

            Cook cook = FindFreeCook() ?? FindLeastBusyCook();

            cook.AddDishToCook(dish, equipment);

            return cook.FinishTime.ToString();
        }

        private Cook FindFreeCook()
        {
            return cooks.Where(x => x.IsFree).OrderBy(x => x.SkillCoefficient).FirstOrDefault();
        }

        private Cook FindLeastBusyCook()
        {
            return cooks.OrderBy(x => x.FinishTime).ThenBy(x => x.SkillCoefficient).First();
        }

        private Equipment FindEquipment(EquipmentType equipmentType)
        {
            return equipment.Where(x => x.EquipmentType == equipmentType).FirstOrDefault();
        }
    }
}
