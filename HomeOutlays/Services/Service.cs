using HomeOutlays.Repositories;

namespace HomeOutlays.Services
{
    public class Service<T> : IService<T> where T : class
    {
        protected IRepository<T> _repository { get; set; }

        public Service(IRepository<T> repository)
        {
            this._repository = repository;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual T? GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public virtual void Add(T obj)
        {
            _repository.Insert(obj);
            _repository.Save();
        }

        public virtual void Update(T obj)
        {
            _repository.Update(obj);
            _repository.Save();
        }

        public virtual void Delete(T obj)
        {
            _repository.Delete(obj);
            _repository.Save();
        }
    }
}
