using System;
using OrderManager.Lib.Data.Abstract;

namespace OrderManager.Lib.Model
{
    class Restaurant
    {
        Dish[] dishes;

        Cook[] cooks;

        HeatingAppliance[] heatingAppliances;

        public Kitchen Kitchen { get; }

        public Restaurant(IDataSerializer<Dish[]> dishSerializer, IDataSerializer<Cook[]> cookSerializer,
            IDataSerializer<HeatingAppliance[]> heatingAppSerializer, string path)
        {
            DeserializeObjects(dishSerializer, cookSerializer, heatingAppSerializer, out Dish[] dishes, out Cook[] cooks, out HeatingAppliance[] heatingAppliances, path);

            Kitchen = new Kitchen(cooks, dishes, heatingAppliances);
        }

        public void SerializeObjects(IDataSerializer<Dish[]> dishSerializer, IDataSerializer<Cook[]> cookSerializer,
            IDataSerializer<HeatingAppliance[]> heatingAppSerializer, string path)
        {
            dishSerializer.Serialize(path + @"/dishes.json", dishes);

            cookSerializer.Serialize(path + @"/cooks.json", cooks);

            heatingAppSerializer.Serialize(path + @"/heatingAppliances.json", heatingAppliances);
        }

        public void DeserializeObjects(IDataSerializer<Dish[]> dishSerializer, IDataSerializer<Cook[]> cookSerializer,
            IDataSerializer<HeatingAppliance[]> heatingAppSerializer, out Dish[] dishes, out Cook[] cooks, 
            out HeatingAppliance[] heatingAppliances, string path)
        {
            dishes = dishSerializer.Deserialize(path + @"/dishes.json");
            
            cooks = cookSerializer.Deserialize(path + @"/cooks.json");

            heatingAppliances = heatingAppSerializer.Deserialize(path + @"/heatingAppliances.json");
        }

    }
}
