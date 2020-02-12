namespace OrderManager.Data
{
    interface IDataSerializer<T>
    {
        void Serialize(string path, T data);

        T Deserialize(string path);   
    }
}
