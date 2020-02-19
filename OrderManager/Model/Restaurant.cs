using System;
using OrderManager.Data;

namespace OrderManager.Model
{
    class Restaurant
    {
        Dish[] dishes;

        Cook[] cooks;

        HeatingAppliance[] heatingAppliances;

        private readonly IDataSerializer<Dish> dishSerializer;
        private readonly IDataSerializer<Cook> cookSerializer;
        private readonly IDataSerializer<HeatingAppliance> heatAppSerializer;


        public Kitchen Kitchen { get; }

        public Restaurant(string path, IDataSerializer<Dish> dishSerializer, IDataSerializer<Cook> cookhSerializer,)
        {
            DeserializeObjects(out Dish[] dishes, out Cook[] cooks, out HeatingAppliance[] heatingAppliances, path);

            Kitchen = new Kitchen(cooks, dishes, heatingAppliances);
        }

        public void SerializeObjects(string path)
        {
            var dishSerializer2 = new MyJsonSerializer<Dish[]>();
            dishSerializer2.Serialize(path + @"/dishes.json", dishes);

            var cookSerializer2 = new MyJsonSerializer<Cook[]>();
            cookSerializer2.Serialize(path + @"/cooks.json", cooks);

            var heatingApplianceSerializer2 = new MyJsonSerializer<HeatingAppliance[]>();
            heatingApplianceSerializer2.Serialize(path + @"/heatingAppliances.json", heatingAppliances);
        }

        public void DeserializeObjects(out Dish[] dishes, out Cook[] cooks, out HeatingAppliance[] heatingAppliances, string path)
        {
            var dishSerializer = new MyJsonSerializer<Dish[]>();
            dishes = dishSerializer.Deserialize(path + @"/dishes.json");

            var cookSerializer = new MyJsonSerializer<Cook[]>();
            cooks = cookSerializer.Deserialize(path + @"/cooks.json");

            var heatingApplianceSerializer = new MyJsonSerializer<HeatingAppliance[]>();
            heatingAppliances = heatingApplianceSerializer.Deserialize(path + @"/heatingAppliances.json");
        }

    }
}
