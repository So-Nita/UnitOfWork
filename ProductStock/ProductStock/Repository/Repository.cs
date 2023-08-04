using Microsoft.EntityFrameworkCore;
using ProductStock.EntityConfiguration;
using ProductStock.Interface;

namespace ProductStock.Repository
{
    public class Repository<TE, TK> : IRepository<TE, TK> where TE : class
    {
        private readonly ProductStockContext _context;
        public Repository(ProductStockContext context) 
        {
            _context = context; 
        }
        public IQueryable<TE> GetQueryable()
        {
            return _context.Set<TE>().AsQueryable();
        }

        public IEnumerable<TE> GetAll()
        {
            return _context.Set<TE>().AsEnumerable();
        }
        public TE? GetById(string id)
        {
            return _context.Set<TE>().Find(id);
        }

        
        public void Add(TE entity)
        {
            _context.Set<TE>().Add(entity); 
        }

        public void Update(TE entity)
        {
            _context.Set<TE>().Update(entity);
        }

        public void Delete(TE entity)
        {
            _context.Set<TE>().Remove(entity);
        }

        public async Task<TE?> GetByIdAsync(string id)
        {
            return await Task.Run(() => GetById(id));
        }
        public async Task<IEnumerable<TE?>> GetAllAsync()
        {
            return await Task.Run(() => GetAll());
        }
        public async Task AddAsync(TE entity)
        {
            await Task.Run(() => Add(entity));
        }
        public async Task UpdateAsync(TE entity)
        {
            await Task.Run(() => Update(entity));
        }

        public async Task DeleteAsync(TE entity)
        {
            await Task.Run(() => Delete(entity));
        }

    }

}
