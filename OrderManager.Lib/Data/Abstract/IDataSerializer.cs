namespace OrderManager.Lib.Data.Abstract
{
    public interface IDataSerializer<T>
    {
        void Serialize(string path, T data);

        T Deserialize(string path);   
    }
}
