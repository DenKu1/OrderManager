using System.Runtime.Serialization.Json;
using System.IO;

namespace OrderManager.Data
{
    class MyJsonSerializer<T> : IDataSerializer<T>
    {
        public T Deserialize(string path)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(T));

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                return (T)jsonFormatter.ReadObject(fs);
            }
        }

        public void Serialize(string path, T data)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(T));

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, data);
            }
        }
    }
}
