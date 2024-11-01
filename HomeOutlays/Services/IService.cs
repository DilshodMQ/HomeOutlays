namespace HomeOutlays.Services
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T? GetById(Guid id);
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
