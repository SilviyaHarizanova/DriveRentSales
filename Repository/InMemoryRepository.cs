using DriveRentSales.Models.Entities;

namespace DriveRentSales.Repository
{
    public class InMemoryRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly List<T> _items = new List<T>();
        public Task<IEnumerable<T>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<T>>(_items);
        }
        public Task<T> GetByIdAsync(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(item);
        }
        public Task AddAsync(T entity)
        {
            if (entity.Id == 0)
            {
                int nextId = _items.Count > 0 ? _items.Max(x => x.Id) +1 : 1;
                entity.Id = nextId;
            }
            _items.Add(entity);
            return Task.CompletedTask;
        }
        public Task UpdateAsync(T entity)
        {
            var existing = _items.FirstOrDefault(x => x.Id == entity.Id);
            if (existing != null)
            {
                _items.Remove(existing);
                _items.Add(entity);
            }
            return Task.CompletedTask;
        }
        public Task DeleteAsync(int id)
        {
            var existing = _items.FirstOrDefault(x => x.Id == id);
            if (existing != null)
            {
                _items.Remove(existing);
            }
            return Task.CompletedTask;
        }
    }
}
