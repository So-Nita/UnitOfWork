using Microsoft.EntityFrameworkCore;
using ProductStock.EntityConfiguration;

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
         
        public TE? GetById(string id)
        {
            return _context.Set<TE>().Find(id);
        }

        
        public void Add(TE entity)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(TE entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TE entity)
        {
            throw new NotImplementedException();
        }

        public Task<TE> DeleteAsync(TE entity)
        {
            throw new NotImplementedException();
        }

       

        public async Task<TE> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(TE entity)
        {
            throw new NotImplementedException();
        }

        public Task<TE> UpdateAsync(TE entity)
        {
            throw new NotImplementedException();
        }


        /*public async Task<IQueryable<TE?>> GetAllAsync()
        {
            return  _context.Set<TE>().AsQueryable();
        }*/
        public async Task<IEnumerable<TE?>> GetAllAsync()
        {
            return await _context.Set<TE>().ToListAsync();
        }

    }

}
