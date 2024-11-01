using HomeOutlays.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeOutlays.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly MyAppDbContext _context;

        protected DbSet<T> table = null;

        public Repository(MyAppDbContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(Guid id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(T obj)
        {
            table.Remove(obj);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
